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
            Console.WriteLine("Please enter your name and age:");
            string usersName;
            usersName = Console.ReadLine();
            string age;
            age = Console.ReadLine();
            Console.WriteLine("Labdien," + usersName + "!" + "Tavs vecums ir " + age);
            Console.ReadLine();


        }

        static void SayHello()
        {
           
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
