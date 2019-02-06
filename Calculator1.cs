using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator1
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }

        public Calculator1()
        {

        }

        public Calculator1(double num1, double num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Divide(double num1, double num2)
        {
            return Math.Round(num1 / num2, 2);
        }


        public double Square(double num1)
        {
            return Math.Pow(num1, 2);
        }

        public double Square_Root(double num1)
        {
            return Math.Round(Math.Sqrt(num1), 2);
        }

        public double Cube(double num1)
        {
            return Math.Pow(num1, 3);
        }

        public double Cube_Root(double num1)
        {
            if (num1 > 0)
            {
                return Math.Round(Math.Pow(num1, (1.0 / 3.0)), 2);
            }
            return -Math.Round(Math.Pow(-num1, (1.0 / 3.0)), 2);
        }

        public double Sine(double num1)
        {
            return Math.Round(Math.Sin(num1), 2);
        }

        public double Cosine(double num1)
        {
            return Math.Round(Math.Cos(num1), 2);
        }


        public int ValidateInput_Function(string input)
        {
            if (int.TryParse(input, out int function))
            {
                if ((function > 0) & (function < 12))
                {
                    return function;
                }
                return -1;
            }
            return -1;
        }

        // Confirm if input is "parse-able". If not, returns "Invalid entry" message
        public string Num_Validater(string message)
        {
            Console.WriteLine(message);
            string num = Console.ReadLine();
            if (double.TryParse(num, out double num_double))
            {
                return num;
            }
            return "Invalid entry. Please input numbers only";
        }


        public void FuncImplement(int function, double num1, double num2)
        {
            if (function == 1)
            {
                Console.WriteLine(Add(num1, num2));
            }
            else if (function == 2)
            {
                Console.WriteLine(Subtract(num1, num2));
            }
            else if (function == 3)
            {
                Console.WriteLine(Multiply(num1, num2));
            }
            else if (function == 4)
            {
                Console.WriteLine(Divide(num1, num2));
            }
            else if (function == 5)
            {
                Console.WriteLine(Square(num1));
            }
            else if (function == 6)
            {
                Console.WriteLine(Square_Root(num1));
            }
            else if (function == 7)
            {
                Console.WriteLine(Cube(num1));
            }
            else if (function == 8)
            {
                Console.WriteLine(Cube_Root(num1));
            }
            else if (function == 9)
            {
                Console.WriteLine(Sine(num1));
            }
            else
            {
                Console.WriteLine(Cosine(num1));
            }
            
        }
    }
}
