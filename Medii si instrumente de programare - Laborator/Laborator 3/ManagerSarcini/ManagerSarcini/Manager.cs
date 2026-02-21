using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerSarcini
{
    internal class Manager
    {
       public static List<TaskItem> tasks = new List<TaskItem>();
        static string filePath = "tasks.txt";
        static int nextId = 1;
         public enum Priority
        {
            Low,
            Medium,
            High
        }

        public class TaskItem
        {
            public int Id { get; set; }
            public string Description { get; set; }
            public Priority Priority { get; set; }
            public bool IsCompleted { get; set; }

            public override string ToString()
            {
                string status = IsCompleted ? "[X]" : "[ ]";
                return $"{Id}. {status} {Description} (Prioritate: {Priority})";
            }
        }

        public static void ShowTasks(List<TaskItem> list)
        {
            Console.Clear();
            Console.WriteLine("==== Lista de sarcini ====\n");
            if (!list.Any())
            {
                Console.WriteLine("Nu exista sarcini.");
                return;
            }

            foreach (var task in list)
                Console.WriteLine(task);
        }
         public static void AddTask()
        {
            Console.Clear();
            Console.Write("Descriere: ");
            string desc = Console.ReadLine();

            Console.Write("Prioritate (Low/Medium/High): ");
            string prioInput = Console.ReadLine();
            Priority prio;
            if (!Enum.TryParse(prioInput, true, out prio))
                prio = Priority.Medium;

            var task = new TaskItem
            {
                Id = nextId++,
                Description = desc,
                Priority = prio,
                IsCompleted = false
            };

            tasks.Add(task);
            SaveTasks();

            Console.WriteLine("Sarcina adaugata cu succes!");
        }

       public static void MarkAsCompleted()
        {
            ShowTasks(tasks);
            Console.Write("\nID sarcina de marcat ca finalizata: ");
            int id;
            if (int.TryParse(Console.ReadLine(), out id))
            {
                var task = tasks.FirstOrDefault(t => t.Id == id);
                if (task != null)
                {
                    task.IsCompleted = true;
                    SaveTasks();
                    Console.WriteLine("Sarcina marcata ca finalizata!");
                }
                else Console.WriteLine("ID invalid!");
            }
        }

       public static void EditTask()
        {
            ShowTasks(tasks);
            Console.Write("\nID sarcina de editat: ");
            int id;
            if (int.TryParse(Console.ReadLine(), out id))
            {
                var task = tasks.FirstOrDefault(t => t.Id == id);
                if (task != null)
                {
                    Console.Write("Noua descriere: ");
                    task.Description = Console.ReadLine();

                    Console.Write("Noua prioritate (Low/Medium/High): ");
                    string prioString = Console.ReadLine();
                    try
                    {
                        task.Priority = (Priority)Enum.Parse(typeof(Priority), prioString, true);
                    }
                    catch
                    {
                        Console.WriteLine("Prioritate invalida! Se pastreaza valoarea anterioara.");
                    }

                    SaveTasks();
                    Console.WriteLine("Sarcina editata cu succes!");
                }
                else Console.WriteLine("ID invalid!");
            }
        }

       public static void DeleteTask()
        {
            ShowTasks(tasks);
            Console.Write("\nID sarcină de sters: ");
            int id;
            if (int.TryParse(Console.ReadLine(), out id))
            {
                var task = tasks.FirstOrDefault(t => t.Id == id);
                if (task != null)
                {
                    tasks.Remove(task);
                    SaveTasks();
                    Console.WriteLine("Sarcina stearsa!");
                }
                else Console.WriteLine("ID invalid!");
            }
        }

         public static void FilterTasks()
        {
            Console.Clear();
            Console.WriteLine("1. Dupa prioritate");
            Console.WriteLine("2. Dupa status (finalizata/nefinalizata)");
            Console.Write("Alege o optiune: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Introdu prioritatea (Low/Medium/High): ");
                    string prioInput = Console.ReadLine();
                    Priority prio;
                    if (Enum.TryParse(prioInput, true, out prio))
                    {
                        var filtered = tasks.Where(t => t.Priority == prio).ToList();
                        ShowTasks(filtered);
                    }
                    else Console.WriteLine("Prioritate invalida!");
                    break;

                case "2":
                    Console.Write("Afișeaza doar finalizate? (da/nu): ");
                    bool completed = Console.ReadLine().Trim().ToLower() == "da";
                    var list = tasks.Where(t => t.IsCompleted == completed).ToList();
                    ShowTasks(list);
                    break;

                default:
                    Console.WriteLine("Opțiune invalida!");
                    break;
            }
        }

       public static void SaveTasks()
        {
            using (var writer = new StreamWriter(filePath))
            {
                foreach (var t in tasks)
                    writer.WriteLine($"{t.Id}|{t.Description}|{t.Priority}|{t.IsCompleted}");
            }
        }

       public static void LoadTasks()
        {
            if (!File.Exists(filePath)) return;

            foreach (var line in File.ReadAllLines(filePath))
            {
                var parts = line.Split('|');
                if (parts.Length == 4)
                {
                    tasks.Add(new TaskItem
                    {
                        Id = int.Parse(parts[0]),
                        Description = parts[1],
                        Priority = (Priority)Enum.Parse(typeof(Priority), parts[2]),
                        IsCompleted = bool.Parse(parts[3])
                    });
                }
            }

            if (tasks.Any())
                nextId = tasks.Max(t => t.Id) + 1;
        }
    }
}
