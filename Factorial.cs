using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class Factorial
    {
        static void Main(string[] args)
        {

            int fact = 1;
            Console.WriteLine("enter a number::");
            int number = Convert.ToInt32(Console.ReadLine());

            for(int i=2;i<=number;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("factorial of given number is {0}",fact);

            Console.ReadLine();
        }
    }
}
