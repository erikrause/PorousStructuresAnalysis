using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiNetGenerationImageServiceBase;
using ApiNetOpenApi.Models;
using ApiNetOpenApi.Models.Get;
using ApiNetOpenApi.Models.Post;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Routing;
using OpenApiSqlDomain.Entities;

namespace ApiNetOpenApi.Controllers
{
    [Route("api/PGGANs/")]
    [ApiController]
    public class GenerationImagesController : ControllerBase
    {
        readonly IGenerationImageService _generationImageService;
        readonly IMapper _mapper;
        public GenerationImagesController(IGenerationImageService generationImageService)
        {
            _generationImageService = generationImageService;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<GeneratedImagePostModel, GeneratedImage>().ReverseMap();
                cfg.CreateMap<GeneratedImage, GeneratedImageGetModel>().ForMember(x => x.PolygonalModel, opt => opt.Ignore()).ReverseMap();
                cfg.CreateMap<ControlVariables, ControlVariablesModel>().ReverseMap();
            });
            
            
            _mapper = new Mapper(config);
        }
        /// <summary>
        /// Получить все изображения, сгенерированные нейронной сетью
        /// </summary>
        /// <param name="pGGANId"> Идентификатор нейронной сети </param>
        /// <returns> Сгенерированное изображение пористой среды </returns>
        [HttpGet("{pGGANId}/[controller]")]
        public Task<IEnumerable<GeneratedImageGetModel>> Get(int pGGANId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Получить сгенерированное изображение.
        /// </summary>
        /// <param name="pGGANId"> Идентификатор нейронной сети </param>
        /// <param name="id"> Идентификатор изображения </param>
        /// <returns></returns>
        [HttpGet("{pGGANId}/[controller]/{id}")]
        public async Task<GeneratedImageGetModel> Get(int pGGANId, int id)
        {
            GeneratedImage generatedImage = await _generationImageService.Get(id);
            GeneratedImageGetModel generatedImageGetModel = _mapper.Map<GeneratedImageGetModel>(generatedImage);
            generatedImageGetModel.PolygonalModel = new PolygonalModelGetModel
            {
                RockFaces = Convert.ToBase64String(generatedImage.PolygonalModel.RockFaces)
            };

            return generatedImageGetModel;
        }

        /// <summary>
        /// Сгенерировать изображение
        /// </summary>
        /// <param name="pGGANId"> Идентификатор нейронной сети </param>
        /// <param name="controlVariablesModel"> Контрольные значения изображения </param>
        [HttpPost("{pGGANId}/[controller]")]
        public async Task<GeneratedImageGetModel> Post(int pGGANId, [FromBody] ControlVariablesModel controlVariablesModel)
        {
            /*
            ControlVariables controlVariables = new ControlVariables
            {
                NoiseVector = controlVariablesModel.NoiseVector,
                Porosity = controlVariablesModel.Porosity,
                ElementsCount = controlVariablesModel.ElementsCount,
                MinElementSize = controlVariablesModel.MinElementSize,
                MaxElementSize = controlVariablesModel.MaxElementSize,
                AvgElementSize = controlVariablesModel.AvgElementSize,
                Сohesion = controlVariablesModel.Cohesion,
                CavernsVolume = controlVariablesModel.CavernsVolume,
                ChanelsVolume = controlVariablesModel.ChanelsVolume,
                Permeability = controlVariablesModel.Permeability,
                Binarisation = controlVariablesModel.Binarisation,
                DeleteNoize = controlVariablesModel.DeleteNoize,
                Seed = controlVariablesModel.Seed
            };*/
            ControlVariables controlVariables = _mapper.Map<ControlVariables>(controlVariablesModel);
            GeneratedImage generatedImage = await _generationImageService.Generate(pGGANId, controlVariables);


            GeneratedImageGetModel response = _mapper.Map<GeneratedImageGetModel>(generatedImage);
            response.PolygonalModel = new PolygonalModelGetModel
            {
                RockFaces = Convert.ToBase64String(generatedImage.PolygonalModel.RockFaces)
            };
            /*
            var result = new GeneratedImageGetModel
            {
                AvgElementSize = 0,
                CavernsVolume = 0,
                ChanelsVolume = 0,
                ControlVariables = controlVariables,
                CreatedDate = new DateTime()
            };*/

            return response;
        }

        [HttpDelete("{pGGANId}/[controller]/{id}")]
        public void Delete(int pGGANId, int id)
        {
        }
    }
}
