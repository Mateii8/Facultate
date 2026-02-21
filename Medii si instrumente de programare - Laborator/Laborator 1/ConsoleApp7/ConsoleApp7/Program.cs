using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double C, F, K;
                Console.WriteLine("Alegeti tipul de conversie:");
                Console.WriteLine("1. Celsius -> Fahrenheit");
                Console.WriteLine("2. Fahrenheit -> Celsius");
                Console.WriteLine("3. Celsius -> Kelvin");
                Console.WriteLine("4. Fahrenheit -> Kelvin");
                Console.WriteLine("5. Kelvin -> Fahrenheit");
                int tip = Convert.ToInt32(Console.ReadLine());
                switch (tip)
                {
                    case 1:
                        C = Convert.ToInt32(Console.ReadLine());
                        F = (C * 9 / 5) + 32;
                        Console.WriteLine(" Fahrenheit " + F);
                        break;
                    case 2:
                        F = Convert.ToInt32(Console.ReadLine());
                        C = (F - 32) * 9 / 5;
                        Console.WriteLine(" Celsius " + C);
                        break;
                    case 3:
                        C = Convert.ToInt32(Console.ReadLine());
                        K = C + 273.15;
                        Console.WriteLine(" Kelvin " + K);
                        break;
                    case 4:
                        F = Convert.ToInt32(Console.ReadLine());
                        K = (F - 32) * 5 / 9 + 273.15;
                        Console.WriteLine("Fahrenheit -> Kelvin");
                        break;
                    case 5:
                        K = Convert.ToInt32(Console.ReadLine());
                        F = K - 273;
                        Console.WriteLine("Kelvin -> Fahrenheit");
                        break;
                }
                Console.WriteLine("Doriti sa mai faceti o conversie? (da/nu)");
            } while (Console.ReadLine().ToLower() == "da");
        }
    }
}
