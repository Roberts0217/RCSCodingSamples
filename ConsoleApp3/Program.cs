using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //izveidojam mainīgo kur glabāt skaitļu ģenerātoru instanci
            Random diceNumberGenerator;
            //ierakstam mainīhajam jaunizveidoto ģenerātoru
            diceNumberGenerator = new Random();
            //paprasam ģenerātoram iedot skaitli starp 1 un 7,
            //ierakstam rezultātu mainīgajā
            int diceValue = diceNumberGenerator.Next(1, 7);
            Console.WriteLine("Tavs kauliņa metiens " + diceValue);
            int secondDiceValue = diceNumberGenerator.Next(0, 101);
            Console.WriteLine("Tavs kauliņa metiens " + secondDiceValue);
            Console.ReadLine();
        }
    }
}
