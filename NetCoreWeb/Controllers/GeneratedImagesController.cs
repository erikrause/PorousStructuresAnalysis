using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreWeb.Models;
using RockAnalysis;
using System.IO;

namespace NetCoreWeb.Controllers
{
    public class GeneratedImagesController : Controller
    {
        // GET: GeneratedImages
        public ActionResult Index()
        {
            return View();
        }

        // GET: GeneratedImages/Details/5
        public async Task<ActionResult> Details(int id)
        {
            GenerationImagesClient generationImagesClient = new GenerationImagesClient(new System.Net.Http.HttpClient());
            GeneratedImageGetModel generatedImageGetModel = await generationImagesClient.GetAsync(1, id);

            return View(generatedImageGetModel);
        }

        // GET: GeneratedImages/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GeneratedImages/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([FromForm]GenerateImageRequest generateImageRequest)
        {
            try
            {
                generateImageRequest.Porosity = generateImageRequest.Porosity / 100;
                //ControlVariables controlVariables = new ControlVariables(0, false, 0, 0, false, 0, null, 0, false, 0, 0, null, 0, 0.5, 0, 0);
                ControlVariablesModel controlVariablesModel = new ControlVariablesModel
                {
                    Seed = generateImageRequest.Seed,
                    Porosity = generateImageRequest.Porosity
                };

                GenerationImagesClient generationImagesClient = new GenerationImagesClient(new System.Net.Http.HttpClient());
                GeneratedImageGetModel generatedImage =  await generationImagesClient.PostAsync(1, controlVariablesModel);
                generatedImage.Porosity = generatedImage.Porosity * 100;

                var stl_file = Convert.FromBase64String(generatedImage.PolygonalModel.RockFaces);

                string currentDirectory = Directory.GetCurrentDirectory();
                string filePath = System.IO.Path.Combine(currentDirectory, "wwwroot", "js", "porous.stl");
                System.IO.File.WriteAllBytes(filePath, stl_file);

                //return RedirectToAction(nameof(Details), generatedImage.Id);
                return RedirectToAction("Details", new { id = generatedImage.Id });
            }
            catch
            {
                return View();
            }
        }

        // GET: GeneratedImages/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GeneratedImages/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GeneratedImages/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GeneratedImages/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}