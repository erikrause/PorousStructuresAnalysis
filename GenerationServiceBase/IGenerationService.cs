﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Entities;

namespace GenerationServiceBase
{
    public interface IGenerationService
    {

        Task CreateNetworkModel(string inputScale, int layersCount);   // TODO: добавить атрибуты - размер слоев, размер ядра для каждого конв. слоя, начальные значения нейронов.
        // ИЛИ:
        Task CreateNetworkModel(GenerationNetwork generationNetwork);


        Task SetTrainingParam(int generationNetworkId);  // TODO: добавить атрибуты - количество итераций для каждого слоя, скорость обучения.
        Task SetPreproccessingParam();  // TODO: добавить атрибуты - параметры.
        Task SetPostproccessingParam();  // TODO: добавить атрибуты - параметры.

        Task SetDataset(int generationNetworkId, MicroCT Dataset);

        Task<IEnumerable<GenerationNetwork>> GetNetworks(User user);
        Task TrainNetwork(int generationNetworkId);
        Task DeleteNetwork(int generationNetworkId);
        Task<IEnumerable<GeneratedImage>> GetGeneratedImages(int generationNetworkId);
    }
}
