using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //paprasīt lietotājam, cik lielu skaitli viņš grib minēt uzģenerēt gadījuma skaitli līdz šai robežai
            Console.WriteLine("Izvelēties skaitli, ko minēt");
            int maxNumber = int.Parse(Console.ReadLine());
            Random diceNumberGenerator;
            diceNumberGenerator = new Random();
            //uzģenerēt gadījuma skaitli līdz šai robežai
            int guess = diceNumberGenerator.Next(1, maxNumber);
            //cikls: kamēr lietotājs neuzmin:
            string 
            while (true)
            {
                if (maxNumber == diceNumberGenerator)
                {
                    break;
                }
               
            }

            //paprasīt lietotājam lai viņš min kāds skaitlis ir izveidots (iegūt ievadi)
            //salīdzināt, vai lietotājs ir uzminējis ja ir, tad izbeigt

        }
    }
}
