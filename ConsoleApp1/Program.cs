using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

       {
         
            // izsaucam sevis izveidoto funkciju
            SayHello();
            // izsaucam otru izveidoto funkciju
            SayHelloToUser();
        }

        static void SayHelloToUser()
        {
            Console.WriteLine("Please enter your name:");
            string usersName;
            usersName = Console.ReadLine();
            Console.WriteLine("Labdien," + usersName + "!");
            Console.ReadLine();


        }

        static void SayHello()
        {
           
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
