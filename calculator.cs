using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class Calculator
    {
        int result, num1, num2;
        String s;

        public void menu()
        {
            Console.WriteLine("1:add\n 2.subtract\n 3.multiply\n 4.divide");
            int ch = Convert.ToInt32(Console.ReadLine());

            if (ch == 1)
                s = "+";
            else if (ch == 2)
                s = "-";
            else if (ch == 3)
                s = "*";
            else if (ch == 4)
                s = "/";
            else
                Console.WriteLine("invalid option");
        }
        public void GetDetails()
        {
            Console.WriteLine("enter num1 num2 ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
         
        }

        private int Calculate(int num1,int num2,String s)
        {
            switch (s)
            {
                case "+":
                    result = num1 + num2; break;
                case "-":
                    result = num1 - num2; break;

                case "*":
                    result = num1 * num2; break;
                case "/":
                    result = num1 / num2; break;
                default:
                    result = 0; break;

            }
            return result;
        }
            public void DisplayResult()
            {
                int c = Calculate(num1,num2, s);
                Console.WriteLine("result is {0}",c);
            }

        }

    }

