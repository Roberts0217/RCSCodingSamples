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
           
            for (int tryCount = 1; tryCount <= 100; tryCount++)
            {
                if (tryCount % 15 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (tryCount % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (tryCount % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(tryCount);
                Console.ReadLine();

            }

        }
    }
}
