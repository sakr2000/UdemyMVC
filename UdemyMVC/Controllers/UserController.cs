using Microsoft.AspNetCore.Mvc;

namespace UdemyMVC.Controllers
{
	public class UserController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
