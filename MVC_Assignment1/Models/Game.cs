using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Assignment1.Models
{
    public class Game
    {
        public int GuessInput { get; set; }
        public string buttonSub { get; set; }

        private static int _Attempt = 0;
        private static int _AttemptsAtWin = 0;

        public string CheckTheGuess(Game userInput, out bool gameResult, int randomNumber)
        {
            string textResult = "";
            gameResult = false;

            if (userInput.GuessInput > randomNumber)
            {
                _Attempt++;
                gameResult = false;
                textResult = $"{userInput.GuessInput} is to high, guess lower.\nYou guessed {_Attempt} time(s).";
            }
            else if (userInput.GuessInput < randomNumber)
            {
                _Attempt++;
                gameResult = false;
                textResult = $"{userInput.GuessInput} is to low, guess higher.\nYou guessed {_Attempt} times.";
            }
            else if (userInput.GuessInput == randomNumber)
            {
                _Attempt++;
                _AttemptsAtWin = _Attempt;
                _Attempt = 0;
                gameResult = true;
                textResult = $"{userInput.GuessInput} is correct. You won at {_AttemptsAtWin} guesses.";
            }

            return textResult;
        }

    }
}
