using System;
using System.Collections.Generic;
using System.IO;
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
            for(int skaititajs = 0; skaititajs < todoEntries.Count; skaititajs++)
            {
                Console.WriteLine((skaititajs + 1) + ". " + todoEntries[skaititajs]);
            }
           
        }
        public void deliteTodo(int indexOfTodo)
        {
            // neļaut mēgināt izvilkt ierakstu no saraksta,
            //kura kārtas numurs neeksistē
            if (indexOfTodo >= this.todoEntries.Count)
            {
                Console.WriteLine("Tāds ieraksts neeksistē");
                return;
            }
            else
            {
                todoEntries.RemoveAt(indexOfTodo);
            }
            
        }
        public void DeldeliteTodo()
        {
            todoEntries.Clear();
        }

        public void SaveToFile()
        {
            //ctrl  +
            for(int i = 0; i < todoEntries.Count; i++)
            {
                // control + .
                // Append (angļu val) - Pievienot, papildināt
                File.AppendAllText(
                                @"C:\Users\Gatis\Documents\To do application saves\todos", todoEntries[i] + "\r\n");
            }
          
        }
        public void LoadFromeFile()
        {
            string[] allLinesFromFile = File.ReadAllLines(@"C:\Users\Gatis\Documents\To do application saves\todos.txt");
                foreach (string listEntry in allLinesFromFile)
            {
                todoEntries.Add(listEntry);
            }
            
        }
    }

}
