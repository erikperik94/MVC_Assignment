using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Assignment1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Home of Eriks Info Page";
            return View();
        }
        public IActionResult About()
        {
            ViewBag.Message = "About Erik";
            return View();        }

        public IActionResult Contact()
        {
            ViewBag.Message = "Eriks Contact info";
            return View();
        }
        public IActionResult Projects()
        {
            ViewBag.Message = "Eriks Projects";
            return View();
        }
    }
}
