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
            // console writeline - ja gribam textu uz ekrana
            Console.WriteLine("Please enter your name and age:");
            //mainigais kur glabā datus  un ta ir vieta kur noglabā
            string usersName;
            // paprasam konsolei ievadit tekstu, saglabājam rezultātu mainīgaja.
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
