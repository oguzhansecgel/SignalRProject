using Microsoft.AspNetCore.Mvc;

namespace SingalRWebUI.Controllers.Admin
{
	public class AdminLayout : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
