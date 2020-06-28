import stl
import matplotlib.pyplot as plt
from mpl_toolkits.mplot3d.art3d import Poly3DCollection

from skimage import measure
import numpy as np

def compute_mesh(voxel_array, threshold, gradient_direction='descent', isPores=False):
  """Compute mesh with marching cubes
  
  Args:

  isPores : отобразить поры
  """

  #voxel_array = binarization(voxel_array)
  #if isPores:
  #  voxel_array = reverse(voxel_array)
  
  voxel_array = np.pad(voxel_array, 1, mode='constant', constant_values=0)

  verts, faces, normals, values = measure.marching_cubes_lewiner(voxel_array, threshold, gradient_direction=gradient_direction)

  cube = stl.mesh.Mesh(np.zeros(faces.shape[0], dtype=stl.mesh.Mesh.dtype))
  for i, f in enumerate(faces):
    for j in range(3):
      cube.vectors[i][j] = verts[f[j],:]

  cube.save("prob.stl")
  return cube

def plot_polygons(polygons, normals, alpha=0.70, face_color=[0.45, 0.45, 0.75], figsize=(20,20), plot_edges=True, shading=True, path=""):
    """Plot polygons with matplotlib
    ONLY FOR CUBES! (TODO: edit autoscale)

    Args:
      Alpha : прозрачность
    """

    fig = plt.figure(figsize=figsize)
    ax = fig.add_subplot(111, projection='3d')

    # Fancy indexing: `verts[faces]` to generate a collection of triangles
    mesh = Poly3DCollection(polygons, alpha=alpha)
   
    if shading:
      mesh.set_facecolor(calc_shading(polygons, normals, color=face_color))
    else:
      mesh.set_facecolor(face_color)

    if plot_edges:
      #mesh.set_edgecolor('k')
      mesh.set_edgecolor([0.45-0.2, 0.45-0.2, 0.75-0.35, alpha])

    ax.add_collection3d(mesh)
    
    # Auto scale to the mesh size
    scale = polygons.flatten()
    ax.auto_scale_xyz(scale, scale, scale)

    #plt.tight_layout()    # ?
    if len(path) > 0:
      plt.savefig(path)
    else:
      plt.show() 

from matplotlib.colors import LightSource

def calc_shading(faces, normals, color=[255.0/255.0, 54.0/255.0, 57/255.0], alpha=1):
  ls = LightSource(azdeg=225.0, altdeg=45.0)

  # First change - normals are per vertex, so I made it per face.
  #normalsarray = np.array([np.array((np.sum(normals[face[:], 0]//3), np.sum(normals[face[:], 1]//3), np.sum(normals[face[:], 2]//3))/np.sqrt(np.sum(normals[face[:], 0]//3)**2 + np.sum(normals[face[:], 1]//3)**2 + np.sum(normals[face[:], 2]//3)**2)) for face in faces])

  # Next this is more asthetic, but it prevents the shadows of the image being too dark. (linear interpolation to correct)
  min = np.min(ls.shade_normals(normals, fraction=1.0)) # min shade value
  max = np.max(ls.shade_normals(normals, fraction=1.0)) # max shade value
  diff = max-min
  newMin = 0.3
  newMax = 0.95
  newdiff = newMax-newMin

  # Using a constant color, put in desired RGB values here.
  colourRGB = np.asarray(color)

  # The correct shading for shadows are now applied. Use the face normals and light orientation to generate a shading value and apply to the RGB colors for each face.
  rgbNew = np.array([colourRGB*(newMin + newdiff*((shade-min)/diff)) for shade in ls.shade_normals(normals, fraction=1.0)])
  #rgbNew[:,3] = alpha

  # Apply color to face
  #new_mesh = Poly3DCollection(mesh.vectors)
  #new_mesh.set_facecolor(rgbNew)

  return rgbNew

def binarization(voxel_array):
  
  return np.where(voxel_array>0.5, 1, 0)

def reverse(voxel_array):
  new_array = np.zeros(voxel_array.shape, dtype=np.uint8)

  for i in range(0,voxel_array.shape[0]):
    for j in range(0, voxel_array.shape[1]):
      for k in range(0, voxel_array.shape[2]):
        if voxel_array[i,j,k] == 0:
          new_array[i,j,k] = 1
        if voxel_array[i,j,k] == 1:
          new_array[i,j,k] = 0

  return new_array