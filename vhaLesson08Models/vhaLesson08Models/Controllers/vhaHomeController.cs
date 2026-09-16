using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using vhaLesson08Models.Models;

namespace vhaLesson08Models.Controllers
{
	public class vhaHomeController : Controller
	{
		private readonly ILogger<vhaHomeController> _logger;

		public vhaHomeController(ILogger<vhaHomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult vhaIndex()
		{
			return View();
		}

		public IActionResult vhaPrivacy()
		{
			return View();
		}
		public IActionResult vhaAbout()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
