using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class Vowelwala
    {

        public void Display()
        {
            Console.WriteLine("enter a character ::");
            char ch = Convert.ToChar(Console.ReadLine());

            switch(ch)
            {
                case 'a':
                case 'A':
                    
                case 'e':
                case 'E':
                case 'i':
                case 'I':
                case 'o':
                case 'O':
                case 'u':
                case 'U':
                Console.WriteLine("it is vowel");break;
                default:

                    Console.WriteLine("it is not vowel"); break;



            }
        }
    }

    class VowelRunner
    {
        static void Main(string[] args)
        {
            Vowelwala v = new Vowelwala();
            v.Display();
            Console.ReadLine();
        }
    }
}
