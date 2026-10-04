using Microsoft.AspNetCore.Mvc;

namespace vhaNetCoreLA7.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class CategoryController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
