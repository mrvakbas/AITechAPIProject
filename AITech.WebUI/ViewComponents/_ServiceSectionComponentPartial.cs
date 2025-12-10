using AITech.WebUI.Services.FeatureServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents
{
    public class _ServiceSectionComponentPartial(IFeatureService _featureService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _featureService.GetAllAsync();
            return View(value);
        }
    }
}
