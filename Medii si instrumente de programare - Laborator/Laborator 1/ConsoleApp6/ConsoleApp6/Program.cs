using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anNastere = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(anNastere);
            int x = 100;
            int anCurent = 2025;
            Console.WriteLine(anCurent - anNastere + "ani");
            if (anCurent - anNastere < 18)
                Console.WriteLine("Utilizatorul este minor");
            else
                Console.WriteLine("Utilizatorul este major");
            Console.WriteLine(x - (anCurent - anNastere) + " Acesta va implini varsta de 100 ani "); 
        }
    }
}
