using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class Table
    {

        static void Main(string[] args)
        {
            Console.WriteLine("ENTER A NUMBER ");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=num;i++)
            {
                Console.WriteLine(num +"* "+i+ " ="+(num*i));
            }
            Console.ReadLine();

        }
    }
}
