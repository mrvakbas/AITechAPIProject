using AITech.WebUI.Services.SocialServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents
{
    public class _SocialSectionComponentPartial(ISocialService _socialService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _socialService.GetAllAsync();
            return View(value);
        }
    }
}
