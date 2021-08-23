using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Assignment1.Models;

namespace MVC_Assignment1.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult FeverCheck()
        {
            ViewBag.Title = "Check Temperature";
            return View();
        }

        [HttpPost]
        public IActionResult FeverCheck(Doctor createCheck) //set
        {

            if (ModelState.IsValid)
            {
                ViewBag.resultMessage = Doctor.CheckTemp(createCheck);
                return View();
            }

            return View(createCheck);
        }
    }
}
