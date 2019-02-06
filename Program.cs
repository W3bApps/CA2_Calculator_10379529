using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string Welcome = "Welcome to DBS Calculator";
            string SelectFunction = "Please select the function you require\n\n" +
                "1:   Addition\n" +
                "2:   Subtraction\n" +
                "3:   Multiplication\n" + 
                "4:   Division\n" +
                "5:   Square\n" +
                "6:   Square Root\n" +
                "7:   Cube\n" +
                "8:   Cube Root\n" +
                "9:   Sine\n" +
                "10:  Cosine\n" +
                "11:  ***EXIT***";
            string SelectNum1_message = "Please choose your first number";
            string SelectNum2_message = "Please choose your second number";

            Calculator1 calculator = new Calculator1();
            int Exit = 0;

            Console.WriteLine(Welcome);

            while (Exit == 0)
            {
                Console.WriteLine(SelectFunction);
                Console.WriteLine();
                string string_in = Console.ReadLine();
                if (calculator.ValidateInput_Function(string_in) < 0)
                {
                    Console.WriteLine("Invalid entry. Please select value between 1 - 11");
                }
                int func = calculator.ValidateInput_Function(string_in);


                if ((func > 0) & (func < 5))
                {
                    double numA = 0;
                    double numB = 0;
                    string num_string1 = calculator.Num_Validater(SelectNum1_message);
                    string num_string2 = calculator.Num_Validater(SelectNum2_message);

                    if (num_string1 != "Invalid entry. Please input numbers only")
                    {
                        numA = double.Parse(num_string1);
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry. Please input numbers only");
                        continue;
                    }

                    if (num_string2 != "Invalid entry. Please input numbers only")
                    {
                        numB = double.Parse(num_string2);
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry. Please input numbers only");
                        continue;
                    }

                    calculator.FuncImplement(func, numA, numB);
                }
                else if ((func > 4) & (func < 11))
                {
                    double numA = 0;
                    string num_string1 = calculator.Num_Validater(SelectNum1_message);

                    if (num_string1 != "Invalid entry. Please input numbers only")
                    {
                        numA = double.Parse(num_string1);
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry. Please input numbers only");
                        continue;
                    }
                    calculator.FuncImplement(func, numA, 0);
                }
                else if (func == 11)
                {
                    calculator.FuncImplement(11, 0, 0);
                }
                else
                {
                    Console.WriteLine("");
                }

                if (func == 11)
                {
                    Console.WriteLine("Thanks for using our app");
                    Exit = 1;  
                }
                
                Console.ReadLine();
            }
        }
    }
}
