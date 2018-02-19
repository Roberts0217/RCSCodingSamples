using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDoList list = new ToDoList();
            while (true)
            {
                Console.WriteLine("Lūdzu izvēlieties darbību:");
                Console.WriteLine("a - pievienot");
                Console.WriteLine("p - parādīt");
                Console.WriteLine("d - Dzēst");
                Console.WriteLine("g - Dzēst visu sarakstu");
                string userinput = Console.ReadLine();
                switch (userinput)
                {
                    case "a":
                        // Pievienot jaunu darāmo lietu
                        Console.WriteLine("ludzu ievadiet darāmo lietu:");
                        string todoTask = Console.ReadLine();
                        list.AddNewTodo(todoTask);
                        break;
                    case "p":
                        //izvadat visas darāmas lietas uz ekrana
                        list.ShowAllTodos();
                        break;
                    case "d":
                        //dzēst konkrētu darāmo lietu
                        Console.WriteLine("lūdzu ievadi dzēšamo nummuru");
                        list.ShowAllTodos();
                        int index = int.Parse(Console.ReadLine());
                        list.deliteTodo(index -1);
                        break;
                    // pievienot funkciju kas notira visu sarakstu
                    case "g":

                        list.DeldeliteTodo();
                        break;
                    case "s":
                        //Saglabajam saturu failā
                        list.SaveToFile();
                        break;
                    //implementejam ieladi no faila izmantojot funkciju
                    //File.ReadAlllines(path);
                    case "l":
                        list.LoadFromeFile();
                        break;
                }
                // Pievienot jaunu darāmo lietu
                // Es gribu dzēst visas daramas lietas
                // izvadīt visas darāmās lietas uz ekrāna
               
            }
        }
    }
}
