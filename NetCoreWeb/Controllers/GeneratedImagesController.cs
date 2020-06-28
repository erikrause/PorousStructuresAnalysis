using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreWeb.Models;
using RockAnalysis;

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
            return View();
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
                //ControlVariables controlVariables = new ControlVariables(0, false, 0, 0, false, 0, null, 0, false, 0, 0, null, 0, 0.5, 0, 0);
                ControlVariablesModel controlVariablesModel = 
                    new ControlVariablesModel(0, false, 0, 0, 0, false, 0, 0, 0, null, 0, generateImageRequest.Porosity, generateImageRequest.Seed);

                GenerationImagesClient generationImagesClient = new GenerationImagesClient(new System.Net.Http.HttpClient());
                GeneratedImageGetModel generatedImage =  await generationImagesClient.PostAsync(1, controlVariablesModel);

                var stl_file = generatedImage.P

                return RedirectToAction(nameof(Index));
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