using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class Prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            int status = 0;
            for (int i=1;i<=number;i++)
            {

              
                if (number % i == 0)
                    status++;
                
            }
            if (status == 2)
            {
                Console.WriteLine("number is prime ");
            }
            else
                Console.WriteLine("number is not prime number");

            Console.ReadLine();
        }
    }
}
