using AITech.WebUI.DTOs.ChooseDtos;
using AITech.WebUI.Services.ChooseServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChooseController(IChooseService _chooseService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var choose = await _chooseService.GetAllAsync();
            return View(choose);
        }

        public IActionResult CreateChoose()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateChoose(CreateChooseDto chooseDto)
        {
            await _chooseService.CreateAsync(chooseDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateChoose(int id)
        {
            var Choose = await _chooseService.GetByIdAsync(id);
            return View(Choose);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateChoose(UpdateChooseDto chooseDto)
        {
            await _chooseService.UpdateAsync(chooseDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteChoose(int id)
        {
            await _chooseService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
