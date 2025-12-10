using AITech.WebUI.DTOs.FeatureDtos;
using AITech.WebUI.Services.FeatureServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FeatureController(IFeatureService _featureService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var FAQs = await _featureService.GetAllAsync();
            return View(FAQs);
        }

        public IActionResult CreateFeature()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateFeature(CreateFeatureDto featureDto)
        {
            await _featureService.CreateAsync(featureDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateFeature(int id)
        {
            var FAQ = await _featureService.GetByIdAsync(id);
            return View(FAQ);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateFeature(UpdateFeatureDto featureDto)
        {
            await _featureService.UpdateAsync(featureDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteFeature(int id)
        {
            await _featureService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
