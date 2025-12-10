using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.ViewComponents
{
    public class _WebUIScriptsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
