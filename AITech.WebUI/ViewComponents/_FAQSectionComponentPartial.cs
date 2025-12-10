using AITech.WebUI.Services.FAQServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents
{
    public class _FAQSectionComponentPartial(IFAQService _fAQService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _fAQService.GetAllAsync();
            return View(value);
        }
    }
}
