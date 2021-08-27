using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_Assignment1.Models;
using System;

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
        public IActionResult GuessingGame(Game updateView)
        {
            bool gameResult = false;
            Game gameObj = new Game();

            if (ModelState.IsValid)
            {
                ViewBag.Title = "The Guessing Game";
                string resultMsg = gameObj.GuessCheck(updateView, out gameResult, (int)HttpContext.Session.GetInt32("Game"));

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
            return View(updateView);
        }
    }
}
