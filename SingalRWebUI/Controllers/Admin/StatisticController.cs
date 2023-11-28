using Microsoft.AspNetCore.Mvc;

namespace SingalRWebUI.Controllers.Admin
{
	public class StatisticController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
