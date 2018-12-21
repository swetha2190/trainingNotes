using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class CalculatorRunner
    {
        static void Main(string[] args)
        {


            Calculator c = new Calculator();
            c.menu();
            c.GetDetails();

            c.DisplayResult();
            Console.ReadLine();
        }


    }
}
