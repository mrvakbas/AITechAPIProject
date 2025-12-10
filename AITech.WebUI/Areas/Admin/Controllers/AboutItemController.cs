using AITech.WebUI.DTOs.AboutItemDtos;
using AITech.WebUI.Services.AboutItemServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutItemController(IAboutItemService _aboutItemService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var abouts = await _aboutItemService.GetAllAsync();
            return View(abouts);
        }

        public IActionResult CreateAboutItem()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAboutItem(CreateAboutItemDto aboutDto)
        {
            await _aboutItemService.CreateAsync(aboutDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateAboutItem(int id)
        {
            var about = await _aboutItemService.GetByIdAsync(id);
            return View(about);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAboutItem(UpdateAboutItemDto aboutDto)
        {
            await _aboutItemService.UpdateAsync(aboutDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteAboutItem(int id)
        {
            await _aboutItemService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
