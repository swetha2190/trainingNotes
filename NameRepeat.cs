using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class NameRepeat
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name");
            String name = Console.ReadLine();

            Console.WriteLine("enter how many times name should repeat");
            int repeat = Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=repeat;i++)
            {
                Console.WriteLine(name+i);

            }
            Console.ReadLine();
        }
    }
}
