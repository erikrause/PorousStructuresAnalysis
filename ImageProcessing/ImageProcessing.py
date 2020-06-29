import numpy as np
import flask
from flask import jsonify
import io

import converting

import base64

app = flask.Flask(__name__)

@app.route("/computeMetadata", methods=["POST"])
def predict_slice():

    image_raw = base64.b64decode(flask.request.json["VoxelArray"])

    image = converting.convert_from_raw(image_raw)
    #stl = marching_cubes.compute_mesh(image[:,:,:,0], 0)
    mean = np.mean(image)
    x = image.shape[0]
    y = image.shape[1]
    z = image.shape[2]
    data = {
        'X' : z,
        'Y' : y,
        'Z' : z,
        'Porosity' : mean
    }
    js = json.dumps(data)

    resp = Response(js, status=200, mimetype='application/json')
    #response = flask.send_file(stl_binary, attachment_filename="volume.stl", as_attachment=True)

    return resp

if __name__ == "__main__":
    print(("* Loading Flask starting server..."
        "please wait until server has fully started"))
    app.run(host="0.0.0.0", port=5002)
