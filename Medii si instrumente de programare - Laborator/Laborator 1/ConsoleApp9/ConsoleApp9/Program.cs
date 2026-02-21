using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        public static bool prim(int x)
        {
            if (x <= 1)
            {
                return false;
            }
            for (int i = 3; i <= x / 2; i++)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(prim(n));
            for (int div = 1; div <= n; div++)
            {
                if (n % div == 0)
                    Console.WriteLine(div + " ");
            }
        }
    }
}
