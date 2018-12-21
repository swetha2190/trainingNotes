using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class PrimeInRange
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter two numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            for (int i = num1; i <= num2; i++)
            {
                int status = 0;
                for (int j = 1; j <= i; j++)
                {


                    if (i % j == 0)
                        status++;

                }
                    if (status == 2)

                    {
                        Console.WriteLine(i);
                    }
                
                
            }
            
            Console.ReadLine();
        }
    }
}
