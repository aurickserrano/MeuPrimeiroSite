using MeuPrimeiroSite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MeuPrimeiroSite.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            HomeModel home = new HomeModel();
            home.Email = "aurick serrano";
            home.Email = "aurickserrano@hotmail.com";
            return View(home);
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