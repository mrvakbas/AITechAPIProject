using AITech.WebUI.Services.AboutItemServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents
{
    public class _AboutItemComponentPartial(IAboutItemService _aboutItemService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _aboutItemService.GetAllAsync();
            return View(value); 
        }
    }
}
