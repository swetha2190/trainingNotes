using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class PerfectSquare
    {
        static void Main(string[] args)
        {
            double  num2;
            Console.WriteLine("enter one number");
            int n = Convert.ToInt32(Console.ReadLine());

            num2 = Math.Sqrt(n);


            n = (int)num2;
            if (n == num2)
            {
                Console.WriteLine("number is perfect square");
            }
            else
            {
                Console.WriteLine("number is not perfect square");
            }
            Console.ReadLine();
        }

        
    }
}
