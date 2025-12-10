using AITech.WebUI.DTOs.FAQDtos;
using AITech.WebUI.Services.FAQServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FAQController(IFAQService _fAQService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var FAQs = await _fAQService.GetAllAsync();
            return View(FAQs);
        }

        public IActionResult CreateFAQ()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateFAQ(CreateFAQDto fAQDto)
        {
            await _fAQService.CreateAsync(fAQDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateFAQ(int id)
        {
            var FAQ = await _fAQService.GetByIdAsync(id);
            return View(FAQ);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateFAQ(UpdateFAQDto fAQDto)
        {
            await _fAQService.UpdateAsync(fAQDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteFAQ(int id)
        {
            await _fAQService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
