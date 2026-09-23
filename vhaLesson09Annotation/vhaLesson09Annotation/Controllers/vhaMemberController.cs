using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using vhaLesson09Annotation.Models.DataModel;
using vhaLesson09Annotation.Models.DataViewModels;

namespace vhaLesson09Annotation.Controllers
{
	public class vhaMemberController : Controller
	{
		private static List<vhaMember> vhaMembers = new List<vhaMember>();

		// GET: vhaMember
		public ActionResult Index()
		{
			return View(vhaMembers);
		}

		// GET: vhaMember/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: vhaMember/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(vhaMemberRegister vhaMember)
		{
			try
			{
				if (!ModelState.IsValid)
				{
					return View(vhaMember);
				}

				vhaMember newMember = new vhaMember
				{
					vhaMemberId = vhaMembers.Count + 1,
					vhaUserName = vhaMember.vhaUserName,
					vhaPassword = vhaMember.vhaPassword,
					vhaEmail = vhaMember.vhaEmail,
					vhaPhoneNumber = vhaMember.vhaPhoneNumber,
					vhaFullName = vhaMember.vhaFullName,
					vhaBirthday = vhaMember.vhaBirthday
				};

				vhaMembers.Add(newMember);

				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View(vhaMember);
			}
		}
	


		// GET: vhaMemberController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: vhaMemberController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: vhaMemberController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: vhaMemberController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}
