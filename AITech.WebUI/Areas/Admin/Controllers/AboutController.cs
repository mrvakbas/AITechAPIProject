using AITech.WebUI.DTOs.AboutDtos;
using AITech.WebUI.Services.AboutServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController(IAboutService _aboutService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var abouts = await _aboutService.GetAllAsync();
            return View(abouts);
        }

        public IActionResult CreateAbout()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAbout(CreateAboutDto aboutDto)
        {
            await _aboutService.CreateAsync(aboutDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateAbout(int id)
        {
            var About = await _aboutService.GetByIdAsync(id);
            return View(About);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAbout(UpdateAboutDto aboutDto)
        {
            await _aboutService.UpdateAsync(aboutDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteAbout(int id)
        {
            await _aboutService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
