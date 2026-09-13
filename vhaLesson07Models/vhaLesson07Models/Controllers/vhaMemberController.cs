using Microsoft.AspNetCore.Mvc;
using vhaLesson07Models.Models.DataModels;
using static vhaLesson07Models.Models.DataModels.vhaMember;

namespace vhaLesson07Models.Controllers
{
	public class vhaMemberController : Controller
	{
		// Mock Data
		protected static List<vhaMember> _members = new List<vhaMember>
		{
			 new vhaMember
			{
				vhaMemberId = Guid.NewGuid().ToString(),
				vhaUserName = "anhvh",
				vhaPassword = "123456",
				vhaFullName = "Vũ Hoàng Anh",
				vhaEmail = "hoanganhcuti2202@example.com"
			},
			new vhaMember
			{
				vhaMemberId = Guid.NewGuid().ToString(),
				vhaUserName = "tranthibinh",
				vhaPassword = "123456",
				vhaFullName = "Trần Thị Bình",
				vhaEmail = "tranthibinh@example.com"
			},
			new vhaMember
			{
				vhaMemberId = Guid.NewGuid().ToString(),
				vhaUserName = "daoduylong",
				vhaPassword = "123456",
				vhaFullName = "Đào Duy Long",
				vhaEmail = "daoduylong@example.com"
			},
			new vhaMember
			{
				vhaMemberId = Guid.NewGuid().ToString(),
				vhaUserName = "phamthiduyen",
				vhaPassword = "123456",
				vhaFullName = "Phạm Thị Duyên",
				vhaEmail = "phamthiduyen@example.com"
			},
			new vhaMember
			{
				vhaMemberId = Guid.NewGuid().ToString(),
				vhaUserName = "nguyenminhduc",
				vhaPassword = "123456",
				vhaFullName = "Nguyễn Minh Đức",
				vhaEmail = "nguyenminhduc@example.com"
			}
		};

		public IActionResult Index()
		{
			return View(_members);
		}
		public IActionResult GetMember()
		{
			var member = new vhaMember
			{
				vhaMemberId = Guid.NewGuid().ToString(),
				vhaUserName = "anhvh",
				vhaPassword = "password123",
				vhaFullName = "Vũ Hoàng Anh",
				vhaEmail = "hoanganhcuti2202@gmail.com"
			};
			//ViewBag.Member = member;
			return View(member);
		}

		// Đưa dữ liệu dạng List ra View
		public IActionResult GetMembers()
		{
			// Lấy từ mock data
			ViewBag.Members = _members;
			return View();

		}

		// GET: Create member
		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		// POST: Create member
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(vhaMember member)
		{
			// Bỏ qua lỗi validation đối với trường vhaMemberId không có trên form
			ModelState.Remove("vhaMemberId");
			if (ModelState.IsValid)
			{
				member.vhaMemberId = Guid.NewGuid().ToString();
				_members.Add(member);
				return RedirectToAction(nameof(Index));
			}
			return View(member);
		}
	}
}
