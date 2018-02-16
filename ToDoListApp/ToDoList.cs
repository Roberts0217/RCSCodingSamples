using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApp
{
    class ToDoList
    {
        //konstruktors kurš tiek izsaukts, kad tiek izveidots objekts
        //konstruktors neko nekad neatgriež un vienmēr saucas tā pat kā klase.
        public ToDoList()
        {
            todoEntries = new List<string>();
        }
        List<string> todoEntries;
        public void AddNewTodo(string task)
        {
            Console.WriteLine("Uzdevums pievienots:" + task);
            todoEntries.Add(task);
        }

        public void ShowAllTodos()
        {
            //izgustam pirmo elementu no sraksta izmantojoy indeksatoru
            //skaititajs = skaititajs + 1; ir tas pats kas skaititajs += 1;
            // IR TAS PATS KAS SKAITITAJS++;
            for(int skaititajs = 0; skaititajs < todoEntries.Count; skaititajs = skaititajs + 1)
            {
                Console.WriteLine("Your todo list enery is" + todoEntries[skaititajs]);
            }
           
        }
    }
}
