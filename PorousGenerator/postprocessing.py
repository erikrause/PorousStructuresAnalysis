import numpy as np


def binarize(voxel_array):
    """
  new_array = np.zeros(voxel_array.shape)

  for i in range(0,voxel_array.shape[0]):
    for j in range(0, voxel_array.shape[1]):
      for k in range(0, voxel_array.shape[2]):
        if voxel_array[i,j,k] <= 0:
          new_array[i,j,k] = 0
        if voxel_array[i,j,k] > 0:
          new_array[i,j,k] = 1
          """
  
  #return new_array
    return np.where(voxel_array>0.5, 1, 0)

def reverse(voxel_array):
  new_array = np.zeros(voxel_array.shape)

  for i in range(0,voxel_array.shape[0]):
    for j in range(0, voxel_array.shape[1]):
      for k in range(0, voxel_array.shape[2]):
        if voxel_array[i,j,k] == 0:
          new_array[i,j,k] = 1
        if voxel_array[i,j,k] == 1:
          new_array[i,j,k] = 0

  return new_array

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

    raw_shapes = np.array([image_shape[0], image_shape[1], image_shape[2], image_channels])
    raw = np.append(raw_shapes, image_vector).astype(np.int16)

    return raw

