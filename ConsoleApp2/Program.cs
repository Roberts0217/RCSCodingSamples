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
            string usersInput = "0";
            while (true)
            {
                //CalculateCircleArea();
                // CountNumbers();
                //ctrl + k + d - lai nolīdzinātu 
                Console.WriteLine("please chose action");
                Console.WriteLine("a - calculate circule area");
                Console.WriteLine("c - count two numbers together");
                usersInput = Console.ReadLine();
                // ja atbilde ir a, tad izsaukt apļa funkciju,
                // ja atbilde ir c, tad isaukt skaitīšanas funkciju
                // visos citos gadijumos parādīt kludas paziņojumu
                if (usersInput == "a")
                {
                    CalculateCircleArea();
                }

                else if (usersInput == "c")
                {
                    CountNumbers();
                }
                else if (usersInput == "d")
                {
                    DoesThisNumberDivide();
                }
                else if (usersInput == "x")

                {
                    break;
                }

                else
                {

                    Console.WriteLine("Sorry, did not understand");
                }
                Console.ReadLine();
            }
        }
            static void DoesThisNumberDivide()
            {
                double dalāmais = GetNumberFromUser("Lūdzu ievadiet dalāmo");
                double dalītājs = GetNumberFromUser("Lūdzu ievadiet dalītāju");
                double modulo = dalāmais % dalītājs;
            // ja moduls == 0 tad skaitļi jadalas
                if (modulo == 0)
                {
                    Console.WriteLine("Šie skaitļi dalas");
                }
                else
                {
                    Console.WriteLine("nedalās");
                }
            }

            static void CalculateCircleArea()
            {
                //izveidojam mainīgo, kur glabāt radiusu
                double radius;
                //izveidosim mainīgo kur glabat rezultātu
                double result;
                // piešķirsim radiusa mainīgajam vērtību
                radius = GetNumberFromUser("Lūdzu ievadiet rādiusu");
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
                //nolasam lietotāja ievadi no ekrāna un ierakstam teksta mainīgajā
                string textInput = Console.ReadLine();
                //izveidojam mainīgo, kur glabāt apaļo skaitli
                double parsedNumber;
                //pārveidojam ievadīto tekstu par skaitli un ierakstam mainīgajā
                bool parseWasSuccess = double.TryParse(textInput, out parsedNumber);
                if (parseWasSuccess == false)
                {
                    Console.WriteLine("Slikti ievadiits skaitlis" + textInput);
                    Console.WriteLine("ievadiet skaitli velreiz");
                    parsedNumber = GetNumberFromUser(msg);
                }
                else
                {
                    Console.WriteLine("Burrvīgi ievadīts skaitlis");

                }
                return parsedNumber;

            }
            //void nozīmē to ka ši funkcija rezultata neatgriež neko vietā kur tā ir izsaukta.
            static void CountNumbers()
            {
                //izveidojam mainīgo, kur glabāt lietotāja pirmo skaitli
                double firstNumber;
                //izveidojam mainīgo, kur glabāt lietotāja pirmo skaitli
                double secondNumber;
                double number;
                firstNumber = GetNumberFromUser("Lūdzu ievadiet pirmo skaitli");
                secondNumber = GetNumberFromUser("Lūdzu ievadiet otro skaitli");
                number = (firstNumber + secondNumber);
                Console.WriteLine("Rezultāts: " + number);
                Console.ReadLine();
            }

        }
    }
