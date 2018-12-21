using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class ReverseANumber
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("enter a four digit number");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num!=0)
            {
                int r = num % 10;
                sum = sum * 10 + r;
                num = num / 10;
            }
            Console.WriteLine("reverse of given number is {0} ",sum);

            Console.ReadLine();
        }
    }
}
