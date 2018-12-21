using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class Pattern
    {

        static void Main(string[] args)
        {
          
            for(int i=1;i<=5;i++)
            {
                for(int j=i;j<=5;j++)
                {
                   if(i==1||i==5||i==3)
                    
                    {
                        Console.Write("* ");

                    }
                    else if(j==1||j==3||j==5)
                    {
                        Console.Write("* ");
                    }




                }
                Console.WriteLine("\n");
            }

            Console.ReadLine();

        }
    }
}
