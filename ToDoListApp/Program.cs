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
                // Pievienot jaunu darāmo lietu
                Console.WriteLine("ludzu ievadiet darāmo lietu:");
                string todoTask = Console.ReadLine();
                list.AddNewTodo(todoTask);
                // Es gribu dzēst visas daramas lietas
                // izvadīt visas darāmās lietas uz ekrāna
                list.ShowAllTodos();
            }
        }
    }
}
