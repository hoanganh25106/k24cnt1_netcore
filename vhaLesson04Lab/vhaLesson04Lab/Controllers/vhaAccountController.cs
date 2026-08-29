using Microsoft.AspNetCore.Mvc;
using vhaLesson04Lab.Models;

namespace vhaLesson04Lab.Controllers
{
	public class vhaAccountController : Controller
	{
		private readonly List<vhaAccount> vhaAccounts = new()
		{
				new vhaAccount
				{
					Id = 1,
					Name = "Nguyễn Văn An",
					Email = "nguyenvanan@gmail.com",
					Phone = "0901234567",
					Avatar = "/images/1.jpg",
					Address = "Hà Nội",
					Bio = "Lập trình viên Web",
					Gender = 1,
					BirthDay = new DateTime(2003, 5, 12)
				},

				new vhaAccount
				{
					Id = 2,
					Name = "Trần Thị Bình",
					Email = "tranthibinh@gmail.com",
					Phone = "0912345678",
					Avatar = "/images/2.jpg",
					Address = "Hải Phòng",
					Bio = "Sinh viên CNTT",
					Gender = 0,
					BirthDay = new DateTime(2004, 8, 25)
				},

				new vhaAccount
				{
					Id = 3,
					Name = "Lê Hoàng Nam",
					Email = "lehoangnam@gmail.com",
					Phone = "0923456789",
					Avatar = "https://i.pravatar.cc/150?img=3",
					Address = "Thái Bình",
					Bio = "Thiết kế Website",
					Gender = 1,
					BirthDay = new DateTime(2002, 3, 18)
				},

				new vhaAccount
				{
					Id = 4,
					Name = "Phạm Ngọc Mai",
					Email = "phamngocmai@gmail.com",
					Phone = "0934567890",
					Avatar = "/images/BanhIChi.jpg",
					Address = "Nam Định",
					Bio = "Yêu thích công nghệ",
					Gender = 0,
					BirthDay = new DateTime(2005, 11, 7)
				},

				new vhaAccount
				{
					Id = 5,
					Name = "Vũ Hoàng Anh",
					Email = "vuhoanganh@gmail.com",
					Phone = "0987654321",
					Avatar = "/images/KeoDeo.jpg",
					Address = "Hà Nội",
					Bio = "Sinh viên Đại học Nguyễn Trãi",
					Gender = 1,
					BirthDay = new DateTime(2006, 10, 25)
				}
		};
		
		public IActionResult vhaIndex()
		{
			ViewBag.vhaAccounts = vhaAccounts;
			return View();
		}
		[Route ("ho-so-cua-toi",Name="vhaProfile")]
		public IActionResult vhaProfile(int? id)
		{
			vhaAccount vhaAccount = new vhaAccount()
			{
				Id = 5,
				Name = "Vũ Hoàng Anh",
				Email = "vuhoanganh@gmail.com",
				Phone = "0987654321",
				Avatar = "/images/KeoDeo.jpg",
				Address = "Hà Nội",
				Bio = "Sinh viên Đại học Nguyễn Trãi",
				Gender = 1,
				BirthDay = new DateTime(2006, 10, 25)
			};
			if (id != null)
				vhaAccount = vhaAccounts.FirstOrDefault(x => x.Id == id);
			ViewBag.vhaAccount = vhaAccount;
			return View();
		}
	}
}
