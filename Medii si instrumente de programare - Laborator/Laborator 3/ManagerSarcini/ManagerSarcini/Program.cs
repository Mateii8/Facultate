using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerSarcini
{
    class Program
    {
        

        static void Main()
        {

            Manager.LoadTasks();
           
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Afiseaza toate sarcinile");
                Console.WriteLine("2. Adauga sarcina");
                Console.WriteLine("3. Marcheaza sarcina ca finalizata");
                Console.WriteLine("4. Editeaza sarcina");
                Console.WriteLine("5. Sterge sarcina");
                Console.WriteLine("6. Filtreaza sarcini");
                Console.WriteLine("0. Iesire");
                Console.Write("\nAlege o optiune: ");

                switch (Console.ReadLine())
                {
                    case "1": Manager.ShowTasks(Manager.tasks); break;
                    case "2": Manager.AddTask(); break;
                    case "3": Manager.MarkAsCompleted(); break;
                    case "4": Manager.EditTask(); break;
                    case "5": Manager.DeleteTask(); break;
                    case "6": Manager.FilterTasks(); break;
                    case "0":
                        Manager.SaveTasks();
                        return;
                    default:
                        Console.WriteLine("Optiune invalida!");
                        break;
                }

                Console.WriteLine("\nApasa o tasta pentru a continua...");
                Console.ReadKey();
            }
        }
    }
}