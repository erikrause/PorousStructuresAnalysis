# import the necessary packages
#from keras.applications import ResNet50
from keras.preprocessing.image import img_to_array
#from keras.applications import imagenet_utils
from PIL import Image
import numpy as np
import flask
import io

import tensorflow as tf
import keras.backend as K
from modules.models import base_models
from keras.models import load_model
from keras.utils.vis_utils import plot_model
import postprocessing

import base64

# initialize our Flask application and the Keras model
app = flask.Flask(__name__)
generator = None
z_dim = None

graph = tf.get_default_graph()
session = K.get_session()
generator_is_loaded = False

def load_generator():

    global generator
    global z_dim

    generator = load_model("cwgan_generator.h5", custom_objects={ "Generator" : base_models.Generator} )
    #generator = load_model(file, custom_objects={ "Generator" : base_models.Generator} )
    z_dim = 200
    global generator_is_loaded 
    generator_is_loaded = True
    
    #generator._make_predict_function()      # Fixing model loading bug for ResNet50. Solution from https://github.com/keras-team/keras/issues/612

def generate_noise(seed,
                   z_dim,
                   batch_size=1):
    np.random.seed(seed)
    noise = np.random.normal(0, 1, (batch_size, z_dim))

    return noise

def porosity_format(porosity_request):
    """ Форматирует пористость под вход нейронной сети """
    porosity_request = (porosity_request * 2 - 1) * -1
    porosity_request = np.asarray([porosity_request])

    return porosity_request

def predict(seed:int, porosity_request:float):
    
    noise = generate_noise(seed, z_dim)
    porosity_request = porosity_format(porosity_request)
    global graph
    global session
    
    try:
        with session.as_default():
            with graph.as_default():
                image = generator.predict([noise, porosity_request])
    except BaseException as e:
        print(e.args)
    
    image = postprocessing.binarize(image[0,:,:,:,0]).astype(np.uint8)

    image = (image*255).astype(np.uint8)

    return image

@app.route("/predict/slice", methods=["POST"])
def predict_slice():

    seed = flask.request.json["seed"]
    porosity_request = flask.request.json["Porosity"]
    slice_index = flask.request.json["slice"]

    prediction = predict(seed, porosity_request)[slice_index,:,:]
    slice_image = Image.fromarray(prediction)
    bytes = io.BytesIO()
    slice_image.save(bytes, 'PNG')
    bytes.seek(0)

    response = flask.send_file(bytes, attachment_filename="slice #{:d}.png".format(slice_index), as_attachment=True)

    return response

@app.route("/predict/amaretto", methods=["POST"])
def predict_amaretto():

    seed = int(flask.request.json["seed"])
    porosity_request = flask.request.json["Porosity"]

    prediction = predict(seed, porosity_request)
    amaretto_image = postprocessing.convert_to_amaretto(prediction)
    amaretto_bytes = io.BytesIO(amaretto_image.tobytes())
    amaretto_bytes.seek(0)

    response = flask.send_file(amaretto_bytes, attachment_filename="3D image.amaretto", as_attachment=True)

    return response

@app.route("/predict/raw", methods=["POST"])
def predict_raw():

    seed = flask.request.json["Seed"]
    porosity_request = flask.request.json["Porosity"]

    prediction = predict(seed, porosity_request)
    raw_image = postprocessing.convert_to_raw(prediction)
    #raw_bytes = io.BytesIO(raw_image.tobytes())
    #raw_bytes.seek(0)

    x = prediction.shape[0]
    y = prediction.shape[1]
    z = prediction.shape[2]
    porosity = np.mean(prediction) / 255

    b1 = raw_image.tobytes()
    b2 =  base64.b64encode(b1) 
    data = { "VoxelArray" : b2.decode('ascii'),
             "DimX" : x,
             "DimY" : y,
             "DimZ" : z,
             "Porosity" : porosity
        }
    js = flask.json.dumps(data)
    #response = flask.send_file(raw_bytes, attachment_filename="3D image.raw", as_attachment=True)

    return flask.Response(js, status=200, mimetype='application/json')

@app.route("/init_generator", methods=["POST"])
def init_generator():

    generator_model = base64.b64decode(flask.request.json["GeneratorModel"])
    file = io.BytesIO(generator_model)
    #load_generator(file)

    #print("waiting")
    #prob = input()
    #print("OK")

    return flask.Response(status=200)

if __name__ == "__main__":
    print(("* Loading Keras model and Flask starting server..."
        "please wait until server has fully started"))
    load_generator()
    app.run(host="0.0.0.0")
