using AITech.WebUI.Services.TestimonialServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents
{
    public class _TestimonialSectionComponentPartial(ITestimonialService _testimonialService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _testimonialService.GetAllAsync();
            return View(value);
        }
    }
}
