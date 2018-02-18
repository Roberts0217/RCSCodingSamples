using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int Skaitlis = 1; Skaitlis <= 1000000; Skaitlis++)
            {
                if (Skaitlis % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (Skaitlis % 5 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (Skaitlis % 3 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(Skaitlis);
                }

                

            }

        }
    }
}
