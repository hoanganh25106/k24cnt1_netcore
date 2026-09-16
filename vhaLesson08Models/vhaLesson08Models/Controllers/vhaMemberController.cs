using Microsoft.AspNetCore.Mvc;
using vhaLesson08Models.Models;

namespace vhaLesson08Models.Controllers
{
	public class vhaMemberController : Controller
	{
		// Mock data - vhaMember
		private static List<vhaMember> _members = new List<vhaMember>()
		{
			new vhaMember
			{
				vhaMemberId = Guid.NewGuid().ToString(),
				vhaUserName = "AnhVh",
				vhaPassword = "Password123!",
				vhaFullName = "Vũ Hoàng Anh",
				vhaEmail = "hoanganhcuti2202@gmail.com"
			},
			new vhaMember
			{
				vhaMemberId = Guid.NewGuid().ToString(),
				vhaUserName = "tranthib",
				vhaPassword = "SecurePass456#",
				vhaFullName = "Trần Thị B",
				vhaEmail = "tranthib@outlook.com"
			},
			new vhaMember
			{
				vhaMemberId = Guid.NewGuid().ToString(),
				vhaUserName = "levanc",
				vhaPassword = "MyPassword789$",
				vhaFullName = "Lê Văn C",
				vhaEmail = "levanc@company.com"
			}
		};

		// GET: Danh sách thành viên
		public IActionResult Index()
		{
			return View(_members);
		}

		[HttpGet]
		public IActionResult vhaCreate()
		{
			var member = new vhaMember();
			return View(member);
		}
		[HttpPost]
		public IActionResult vhaCreate(vhaMember vhaMember)
		{
			vhaMember.vhaMemberId = Guid.NewGuid().ToString();
			_members.Add(vhaMember);

			return RedirectToAction("Index");
			//return View(vhaMember);
		}

		[HttpGet]
		public IActionResult vhaEdit(string id)
		{
			var member = _members.Where(x => x.vhaMemberId.Equals(id)).FirstOrDefault();
			return View(member);
		}

		[HttpPost]
		public IActionResult vhaEdit(string id, vhaMember vhaMember)
		{
			// var member = _members.Where(x => x.vhaMemberId.Equals(id)).FirstOrDefault();
			for (int i = 0; i < _members.Count; i++)
			{
				if (_members[i].vhaMemberId == id)
				{
					_members[i].vhaUserName = vhaMember.vhaUserName;
					_members[i].vhaPassword = vhaMember.vhaPassword;
					_members[i].vhaFullName = vhaMember.vhaFullName;
					_members[i].vhaEmail = vhaMember.vhaEmail;

					return RedirectToAction("Index");
				}

			}
			return View();
		}

		[HttpGet]
		public IActionResult vhaDetails(string id)
		{
			var member = _members.Where(x => x.vhaMemberId.Equals(id)).FirstOrDefault();
			return View(member);
		}

		[HttpGet]
		public IActionResult vhaDelete(string id)
		{
			var member = _members.Where(x => x.vhaMemberId.Equals(id)).FirstOrDefault();
			return View(member);
		}

		[HttpPost]
		public IActionResult vhaDeleted(string id)
		{
			foreach (var item in _members)
			{
				if (item.vhaMemberId.Equals(id))
				{
					_members.Remove(item);
					return RedirectToAction("Index");
				}
			}
			return View("vhaDelete");
		}
	}
}
