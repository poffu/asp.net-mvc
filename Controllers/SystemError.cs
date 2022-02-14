using Microsoft.AspNetCore.Mvc;

namespace LabeledData.Controllers
{
	public class SystemError : Controller
	{
		public IActionResult Index()
		{
			HttpContext.Session.Clear();
			ViewBag.error = "Server is maintain";
			return View();
		}
	}
}
