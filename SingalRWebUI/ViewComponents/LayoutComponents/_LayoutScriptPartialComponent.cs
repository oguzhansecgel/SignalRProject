﻿using Microsoft.AspNetCore.Mvc;

namespace SingalRWebUI.ViewComponents.LayoutComponents
{
	public class _LayoutScriptPartialComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
