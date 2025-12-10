using AITech.WebUI.Services.BannerServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents
{
    public class _HeroSectionComponentPartial(IBannerService _bannerService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _bannerService.GetAllAsync();
            return View(value);
        }
    }
}
