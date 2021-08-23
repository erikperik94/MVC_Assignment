using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Assignment1.Models
{
    public class Doctor
    {
        public int TempInput { get; set; }
        public string TempType { get; set; }

        public static string CheckTemp(Doctor userFormInput)
        {
            string textResult = "";
        
            //Set Fever/Hpoterm values
            int celciusFever = 37;
            int celciusHypoterm = 35;
            int fahrenheitFever = 99;
            int fahrenheitHypoterm = 96;
            int compareTypeFever = 0;
            int compareTypeHypo = 0;

            if (userFormInput.TempType == "C")
            {
                compareTypeFever = celciusFever;
                compareTypeHypo = celciusHypoterm;
            }
            else if (userFormInput.TempType == "F")
            {
                compareTypeFever = fahrenheitFever;
                compareTypeHypo = fahrenheitHypoterm;
            }

            if (userFormInput.TempInput > compareTypeFever)
            {
                textResult = $"{userFormInput.TempInput}°{userFormInput.TempType} body temperature, you have a fever!";
            }
            else if (userFormInput.TempInput < compareTypeHypo)
            {
                textResult = $"{userFormInput.TempInput}°{userFormInput.TempType} body temperature, your have hypotermia!";
            }
            else
            {
                textResult = $"{userFormInput.TempInput}°{userFormInput.TempType} body temperature, you are fine!";
            }

            return textResult;
        }
    }
}
