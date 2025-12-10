using Microsoft.AspNetCore.Mvc;

namespace AITech.WebUI.Areas.Admin.ViewComponents
{
    public class _AdminLayoutSidebarPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
