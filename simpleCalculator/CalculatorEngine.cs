using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result;
            switch (argOperation.ToLower())
            {
                case "add":
                case "+":
                    result = argFirstNumber + argSecondNumber;
                    break;
                case "subtract":
                case "-":
                    result = argFirstNumber - argSecondNumber;
                    break;
                case "multiply":
                case "*":
                    result = argSecondNumber * argFirstNumber;
                    break;
                case "division":
                case "/":
                    result = argFirstNumber / argSecondNumber;
                    break;

                default:
                    throw new InvalidOperationException("Specified operation invalid!");
            }
            return result;
        }
    }
}
