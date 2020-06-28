import numpy as np
import flask
import io

import converting
import marching_cubes

import base64

app = flask.Flask(__name__)

@app.route("/compute", methods=["POST"])
def predict_slice():

    image_raw = base64.b64decode(flask.request.json["VoxelArray"])

    image = converting.convert_from_raw(image_raw)
    stl = marching_cubes.compute_mesh(image[:,:,:,0], 0)

    prob = b''

    stl.save(prob, "STL")

    stl_stream = io.BytesIO()
    stl.save(stl_stream)

    response = flask.send_file(stl_stream, attachment_filename="volume.stl", as_attachment=True)

    return response

if __name__ == "__main__":
    print(("* Loading Flask starting server..."
        "please wait until server has fully started"))
    app.run(host="0.0.0.0", port=5001)
