using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SegmentationServiceBase
{
    public interface ISegmentationService
    {

        Task CreateNetworkModel(string inputScale);   // TODO: добавить атрибуты - размер слоев, размер ядра для каждого конв. слоя, начальные значения нейронов.
        Task SetTrainingParam(int generationNetworkId);  // TODO: добавить атрибуты - количество итераций для каждого слоя, скорость обучения.
        Task SetDataset(int generationNetworkId, SegmentationDataset Dataset);
        Task SetPreproccessingParam();  // TODO: добавить атрибуты - параметры.
        Task SetPostproccessingParam();  // TODO: добавить атрибуты - параметры.


        Task<IEnumerable<SegmentationNetwork>> GetNetworks(User user);
        Task TrainNetwork(int generationNetworkId);
        Task DeleteNetwork(int generationNetworkId);
        Task<IEnumerable<SegmentedImage>> GetGeneratedImages(int generationNetworkId);
    }
}
