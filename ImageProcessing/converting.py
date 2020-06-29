import numpy as np

def convert_to_amaretto(image_array):
    """
    Конвертирует трехмерный numpy-массив в формат .amaretto
    """
    image_vector = np.ravel(image_array)

    image_shape = image_array.shape

    amaretto_shapes = np.array([image_shape[1], image_shape[2]])
    amaretto = np.append(amaretto_shapes, image_vector).astype(np.int16)

    return amaretto

def convert_to_raw(image_array):
    """
    Конвертирует трехмерный numpy-массив в формат .raw (первые 4 числа int 16 - x,y,z,c)
    """
    image_vector = np.ravel(image_array)

    image_shape = image_array.shape
    image_channels = 1

    raw_shapes = np.array([image_shape[1], image_shape[2], image_shape[3], image_shape[4]])
    raw_array = np.append(raw_shapes, image_vector).astype(np.int16)

    return raw_array

def convert_from_raw(image_bytes):

    raw_array = np.frombuffer(image_bytes, dtype=np.uint16)
    x = raw_array[0]
    y = raw_array[1]
    z = raw_array[2]
    channels = raw_array[3]

    image_vector = raw_array[4:]
    image_array = image_vector.reshape((x,y,z,channels))

    return image_array
    #for i in range(0, x):
    #    for j in range(0, y):
    #        for 
