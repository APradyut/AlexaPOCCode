using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using POC.OAuth2Provider.Models;

namespace POC.OAuth2Provider.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet]
		public IActionResult Index([FromQuery]string response_type, [FromQuery]string client_id, [FromQuery]string redirect_uri, [FromQuery]string state)
		{
			ViewBag.ResponseType = response_type;
			ViewBag.ClientId = client_id;
			ViewBag.RedirectUri = redirect_uri;
			ViewBag.ResponseType = response_type;

			return View();
		}
		[HttpPost]
		public ActionResult Index(UserVM user)
		{
			//user.redirect_uri = user.redirect_uri.Substring(0, user.redirect_uri.Length - 1);
			user.redirect_uri += "?code=" + Guid.NewGuid().ToString() +"&state=" + user.state;

			return Redirect(user.redirect_uri);
		}
		public IActionResult About()
		{
			ViewData["Message"] = "Your application description page.";

			return View();
		}

		public IActionResult Contact()
		{
			ViewData["Message"] = "Your contact page.";

			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
