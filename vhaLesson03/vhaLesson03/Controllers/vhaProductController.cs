using Microsoft.AspNetCore.Mvc;
using vhaLesson03.Models;

namespace vhaLesson03.Controllers
{
	public class vhaProductController : Controller
	{
		// Tạo mock data
		private readonly List<vhaProduct> _products = new()
		{
			new vhaProduct
			{
				vhaProductId = "PROD-001",
				vhaProductName = "CPU Intel Core i9-14900K",
				vhaYearRelease = "2023",
				vhaPrice = 589.99m
			},
			new vhaProduct
			{
				vhaProductId = "PROD-002",
				vhaProductName = "CPU AMD Ryzen 7 7800X3D",
				vhaYearRelease = "2023",
				vhaPrice = 449.00m
			},
			new vhaProduct
			{
				vhaProductId = "PROD-003",
				vhaProductName = "VGA NVIDIA GeForce RTX 4090 24GB",
				vhaYearRelease = "2022",
				vhaPrice = 1599.99m
			},
			new vhaProduct
			{
				vhaProductId = "PROD-004",
				vhaProductName = "VGA ASUS ROG Strix GeForce RTX 4070 Ti Super",
				vhaYearRelease = "2024",
				vhaPrice = 849.50m
			},
			new vhaProduct
			{
				vhaProductId = "PROD-005",
				vhaProductName = "Mainboard ASUS ROG MAXIMUS Z790 HERO",
				vhaYearRelease = "2022",
				vhaPrice = 629.99m
			},
			new vhaProduct
			{
				vhaProductId = "PROD-006",
				vhaProductName = "RAM Corsair Dominator Titanium RGB 64GB DDR5 6000MHz",
				vhaYearRelease = "2023",
				vhaPrice = 314.99m
			},
			new vhaProduct
			{
				vhaProductId = "PROD-007",
				vhaProductName = "SSD Samsung 990 PRO 2TB PCIe 4.0 NVMe",
				vhaYearRelease = "2022",
				vhaPrice = 189.99m
			},
			new vhaProduct
			{
				vhaProductId = "PROD-008",
				vhaProductName = "Nguồn Seasonic Prime TX-1000 1000W Titanium",
				vhaYearRelease = "2021",
				vhaPrice = 299.00m
			},
			new vhaProduct
			{
				vhaProductId = "PROD-009",
				vhaProductName = "Màn hình Dell UltraSharp U2724D 27 inch 2K IPS",
				vhaYearRelease = "2023",
				vhaPrice = 479.00m
			},
			new vhaProduct
			{
				vhaProductId = "PROD-010",
				vhaProductName = "Laptop Apple MacBook Pro 16 inch M3 Max",
				vhaYearRelease = "2023",
				vhaPrice = 3499.00m
			}
		};
		public IActionResult Index()	
		{
			return Json(_products);
		}
		// GET: danh sách sản phẩm
		public IActionResult vhaGetAllProduct()
		{
			ViewData["products"] = _products;
			return View();
		}

		public IActionResult vhaGetListProduct()
		{
			return View(_products);
		}
	}
}
