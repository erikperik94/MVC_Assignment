using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MVC_Assignment1.Models;

namespace MVC_Assignment1.Controllers
{
    public class GameController : Controller
    {
        private int _guessingNumber;


        public IActionResult GuessingGame()
        {
            ViewBag.Title = "The Guessing Game";
            Random number = new Random();
            _guessingNumber = number.Next(1, 101);
            HttpContext.Session.SetInt32("Game", _guessingNumber);
            return View();
        }

        [HttpPost]
        public IActionResult GuessingGame(Game createCheck)
        {
            bool gameResult = false;
            Game gameObj = new Game();

            if (ModelState.IsValid)
            {
                ViewBag.Title = "The Guessing Game";
                string resultMsg = gameObj.CheckTheGuess(createCheck, out gameResult, (int)HttpContext.Session.GetInt32("Game"));

                if (gameResult)
                {
                    ViewBag.resultMessage = resultMsg;
                    return View();
                }
                else
                {
                ViewBag.resultMessage = resultMsg;
                return View();                    
                }
            }
        return View(createCheck);
        }
    }
}
