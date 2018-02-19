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
            bool hasUserWon = false;
            for (int Skaitlis = 1; Skaitlis <= 10000 && !hasUserWon; Skaitlis++)
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
            Console.ReadLine();
        }
    }
}
