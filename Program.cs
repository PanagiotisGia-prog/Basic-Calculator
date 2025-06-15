using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double sum = 0;
            Console.WriteLine("Basic Calculator.");
            bool calculation = true;
            while (calculation)
            {
                while (true) {
                    //Asking the user to give the first number
                    Console.WriteLine("Give the first number: ");
                    string? firstNumber = Console.ReadLine();
                    if (double.TryParse(firstNumber, out num1))
                    {
                        break;
                    } else
                    {
                        Console.WriteLine("Invalid input! Please give a number.");
                    }
                }

                while (true)
                {
                    //Asking the user to give the second number
                    Console.WriteLine("Give the second number:");
                    string? secondNumber = Console.ReadLine();
                    if (double.TryParse(secondNumber, out num2))
                    {
                        break;
                    } else
                    {
                        Console.WriteLine("Invalid input! Please give a number.");
                    }
                }

                string? op;
                while(true) 
                {
                    //Asking the user to give a specific operator
                    Console.WriteLine("Now choose an operator. Please type '+, -, *, /'");
                    op = Console.ReadLine();
                    if (op == "+" || op == "-" || op == "*" || op == "/")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Please type only one of those operators '+, -, *, /'");
                    }
                }

                switch (op)
                {
                    //Checking which operator the user gave
                    case "+":
                        sum = num1 + num2;
                        Console.WriteLine($"Result: {sum}");
                        break;

                    case "-":
                        sum = num1 - num2;
                        Console.WriteLine($"Result: {sum}");
                        break;

                    case "*":
                        sum = num1 * num2;
                        Console.WriteLine($"Result: {sum}");
                        break;

                    case "/":
                        if (num2 == 0)
                        {
                            Console.WriteLine("You can't divide by 0");
                        }
                        else
                        {
                            sum = num1 / num2;
                            Console.WriteLine($"Result: {sum}");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid input! Please type only one of these operators '+, -, *, /'");
                        break;
                }

                //Asking ther user for a new calculation or ending the program
                Console.WriteLine("Wanna make a new calculation? type Y/N");
                string? repeat = Console.ReadLine()?.ToLower().Trim();
                if(repeat != "y" && repeat != "yes")
                {
                    calculation = false;
                }
            }
        }
    }
}
