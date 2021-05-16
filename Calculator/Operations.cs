using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Operations
    {
        public void Calculate(double num1, double num2)
        {
            bool isInt;
            string operationTemp;
            int operation=0;
            double result=0;
            while(true)
            {
                Console.Write("\n\nPlease Enter which operation you want to Evaluate\n\n1--Add\n2--Subtract\n3--Multiply\n4--Divide\n\nEnter Choice: ");
                operationTemp = Console.ReadLine();
                isInt = int.TryParse(operationTemp, out operation);                
                if(operation>4 || operation<1)
                    Console.Write("\n\nWrong input! Please provide a correct choice!");
                else if (isInt)
                    break;
                else
                    Console.Write("\n\nWrong input! Please provide a correct choice!");
            }
            switch(operation)
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    result = num1 / num2;
                    break;
            }
            Console.Write("\n\nEvaluated Result is: " + result);

        }
    }
}
