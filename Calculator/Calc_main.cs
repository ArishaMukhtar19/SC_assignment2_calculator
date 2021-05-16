using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calc_main : Operations
    {
        static void Main(string[] args)
        {
            try
            {
                double num1, num2;
                string num1temp, num2temp;
                bool isDouble;
                while (true)
                {
                    Console.Write("\n\nEnter First Number: ");
                    num1temp = Console.ReadLine();
                    isDouble = double.TryParse(num1temp, out num1);
                    if (isDouble)
                        break;
                    else
                        Console.Write("\n\nFormat Error! Please Give a number/numeric input");

                }
                while (true)
                {
                    Console.Write("\n\nEnter Second Number: ");
                    num2temp = Console.ReadLine();
                    isDouble = double.TryParse(num2temp, out num2);
                    if (isDouble)
                        break;
                    else
                        Console.Write("\n\nFormat Error! Please Give a number/numeric input");

                }
                Operations obj = new Operations();
                obj.Calculate(num1, num2);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("\n\nError! " + e.Message);
                Console.ReadKey();
            }

        }
    }
}
