using System;
using System.Collections.Generic;
using System.Text;

namespace MyCalc123
{
   public class Operations
    {
        public double Multiply(double a, double b)
        {
            double result = 0;
            result = a * b;
            Console.WriteLine($"Умножение: {result}", result);
            return result;
        }

        public double Div(double a, double b)
        {
            double result = 0;
            result = a / b;
            if (b == 0)
            {
                throw new DivideByZeroException("Деление на ноль");
            }           
            Console.WriteLine($"Деление: {result}", result);
            return result;
        }


        public double Plus(double a, double b)
        {
            double result = 0;
            result = a + b;
            Console.WriteLine($"Сумма: {result}", result);
            return result;
        }

        public double Minus(double a, double b)
        {
            double result = 0;
            result = a - b;
            Console.WriteLine($"Разность: {result}", result);
            return result;
        }
    }
}
