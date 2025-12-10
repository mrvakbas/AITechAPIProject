using AITech.WebUI.Services.AboutServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents
{
    public class _AboutSectionComponentPartial(IAboutService _aboutService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _aboutService.GetAllAsync();
            return View(value);  
        }
    }
}
