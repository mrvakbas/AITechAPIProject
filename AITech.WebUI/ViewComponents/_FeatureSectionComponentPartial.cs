using AITech.WebUI.Services.ChooseServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents
{
    public class _FeatureSectionComponentPartial(IChooseService _chooseService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _chooseService.GetAllAsync();    
            return View(value);
        }
    }
}
