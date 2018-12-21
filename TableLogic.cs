using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class TableLogic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter two numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num2; i++)
            {
                Console.WriteLine(num1+ "* " + i + " =" + (num1* i));
            }
            Console.ReadLine();
        }
    }
}
