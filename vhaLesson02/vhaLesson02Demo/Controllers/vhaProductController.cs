using Microsoft.AspNetCore.Mvc;
using vhaLesson02Demo.Models;

namespace vhaLesson02Demo.Controllers
{
	public class vhaProductController : Controller
	{
		public IActionResult Index()
		{
			//Đưa dữ liệu ra view
			ViewBag.name = "Hoàng Anh";
			ViewData["address"] = "FitNTU";
			TempData["UNI"] = "Trường Đại Học Nguyễn Trãi";
			return View();
		}
		//Chi tiết sản phẩm
		public IActionResult GetProduct()
		{
			//Mock data
			vhaProduct vhaProduct = new vhaProduct()
			{
				ProductId="P001",
				ProductName="Laptp Dell Vostro",
				YearRelease=2024,
				Price=12000000,
			};

			ViewData["productVD"] = vhaProduct;
			ViewBag.productVB = vhaProduct;
			return View();
		}
	}
}
