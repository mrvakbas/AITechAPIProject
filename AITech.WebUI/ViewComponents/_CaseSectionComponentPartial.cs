using AITech.WebUI.Services.ProjectServices;
using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents
{
    public class _CaseSectionComponentPartial(IProjectService _projectService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _projectService.GetAllAsync();
            return View(value);
        }
    }
}
