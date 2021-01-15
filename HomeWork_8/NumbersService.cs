using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_8
{
    class NumbersService
    {
        private bool flag = true;

        public int NumbersDivider(string firstNumber, string secondNumber)
        {
            while (flag)
            {
                IsNumberCorrect(firstNumber, secondNumber);
            }
            int.TryParse(firstNumber, out int firstCorrectNumber);
            int.TryParse(secondNumber, out int secondCorrectNumber);

            return firstCorrectNumber / secondCorrectNumber;
        }

        public string IsNumberCorrect(string firstNumber, string secondNumber)
        { 
            if (firstNumber == string.Empty || secondNumber == string.Empty)
            {
                throw new ArgumentNullException("Нужно ввести число");
            }
            else if (int.TryParse(firstNumber, out int correctFirstNumber) && correctFirstNumber == 0)
            {
                throw new ArgumentException("Делить на ноль нельзя");
            }
            else if(int.TryParse(secondNumber, out int correctSecondNumber) && correctSecondNumber == 0)
            {
                throw new ArgumentException("Делить на ноль нельзя");
            }
            else
            {
                flag = false;
                NumbersDivider(firstNumber,secondNumber);
                return "0";
            }
        }
    }
}
