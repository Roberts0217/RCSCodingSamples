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
            int guess = diceNumberGenerator.Next(1, maxNumber + 1);
            bool hasUserWon = false;
            //cikls: kamēr lietotājs neuzmin: 
            for (int tryCount = 1; tryCount < 4 && !hasUserWon; tryCount = tryCount + 1)
            {
                Console.WriteLine("Mēginajums #" + tryCount + " Uzminēt skaitli!");
                int lietotajaSkaitlis = int.Parse(Console.ReadLine());

                if (lietotajaSkaitlis == guess)
                {
                    Console.WriteLine("Jūs uzvarējāt!");
                    hasUserWon = true;
                }
                else if (guess > lietotajaSkaitlis)
                {
                    Console.WriteLine("Skaitlis par mazu, minat velreiz!");
                }
                else
                {
                    Console.WriteLine("Skaitlis par lielu, minat velreiz");
                }


            }
            Console.ReadLine();

            //paprasīt lietotājam lai viņš min kāds skaitlis ir izveidots (iegūt ievadi)
            //salīdzināt, vai lietotājs ir uzminējis ja ir, tad izbeigt

        }
    }
}
