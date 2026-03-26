using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment2.Controllers
{
	public class ProjectsController : Controller
	{
		public IActionResult Current()
		{
			ViewData["Title"] = "Current Projects";
			return View();
		}

		public IActionResult Completed()
		{
			ViewData["Title"] = "Completed Projects";
			return View();
		}

		public IActionResult Ideas()
		{
			ViewData["Title"] = "Project Ideas";
			return View();
		}
	}
}
