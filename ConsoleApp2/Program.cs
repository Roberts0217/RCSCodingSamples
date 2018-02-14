using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalculateCircleArea();
            CountNumbers();
            //ctrl + k + d - lai nolīdzinātu 
        }

        static void CalculateCircleArea()
        {
            //izveidojam mainīgo, kur glabāt radiusu
            double radius;
            //izveidosim mainīgo kur glabat rezultātu
            double result;
            // piešķirsim radiusa mainīgajam vērtību
            radius = GetNumberFromUser ("Lūdzu ievadiet rādiusu");
            // veicam aprēķināsanas operāciju
            result = radius * radius * 3.14;
            // parādam rezultatu lietotajam
            Console.WriteLine("Rezultāts: " + result);
            Console.ReadLine();
        }
        static double GetNumberFromUser(string msg)
        {
            //Izvadam funkcijai iedoto paziņojumu
            Console.WriteLine(msg);
            //nilasam lietotāja ievadi no ekrāna un ierakstam teksta mainīgajā
            string textInput = Console.ReadLine();
            //izveidojam mainīgo, kur glabāt apaļo skaitli
            double parsedNumber;
            //pārveidojam ievadīto tekstu par skaitli un ierakstam mainīgajā
            bool parseWasSuccess = double.TryParse(textInput, out parsedNumber);
            if (parseWasSuccess == false)
            {
                Console.WriteLine("Slikti ievadiits skaitlis" + textInput);
            }
            else
            {
                Console.WriteLine("Burrvīgi ievadīts skaitlis");
                Console.WriteLine("ievadiet skaitli velreiz");
                parsedNumber = GetNumberFromUser(msg);

            }
            return parsedNumber;

        }
        static void CountNumbers()
        {
            //izveidojam mainīgo, kur glabāt lietotāja pirmo skaitli
            double firstNumber;
            //izveidojam mainīgo, kur glabāt lietotāja pirmo skaitli
            double secondNumber;
            double c;
            double number;
            firstNumber = GetNumberFromUser("Lūdzu ievadiet pirmo skaitli");
            secondNumber = GetNumberFromUser("Lūdzu ievadiet otro skaitli");
            c = GetNumberFromUser("Lūdzu ievadiet reizinātāju");
            number = (firstNumber + secondNumber) * c;
            Console.WriteLine("Rezultāts: " + number);
            Console.ReadLine();
        }
      
    }
}
