using AITech.WebUI.DTOs.TestimonialDtos;
using AITech.WebUI.Services.TestimonialServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TestimonialController(ITestimonialService _testimonialService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var testimonials = await _testimonialService.GetAllAsync();
            return View(testimonials);
        }

        public IActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateTestimonial(CreateTestimonialDto testimonialDto)
        {
            await _testimonialService.CreateAsync(testimonialDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateTestimonial(int id)
        {
            var testimonial = await _testimonialService.GetByIdAsync(id);
            return View(testimonial);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialDto testimonialDto)
        {
            await _testimonialService.UpdateAsync(testimonialDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteTestimonial(int id)
        {
            await _testimonialService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
