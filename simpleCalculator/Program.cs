﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                double firstNumber = inputConverter.ConvertInputToNumber(Console.ReadLine());
                double secondNumber = inputConverter.ConvertInputToNumber(Console.ReadLine());
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                Console.WriteLine(result);
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                //Start logging exception
                Console.WriteLine(ex.Message);
            }
        }
    }
}
