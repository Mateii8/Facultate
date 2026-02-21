using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorStiintific
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Istoric istoric = new Istoric();
            OperatiiBaza op = new OperatiiBaza(istoric);
            FunctiiTrigonometrice trig = new FunctiiTrigonometrice(istoric);
            LogaritmiExponentiale log = new LogaritmiExponentiale(istoric);
            Conversii conv = new Conversii(istoric);

            bool ruleaza = true;

            while (ruleaza)
            {
                Console.WriteLine("\n===== CALCULATOR STIINTIFIC =====");
                Console.WriteLine("1. Operatii de baza (+, -, *, /, ^, %, sqrt)");
                Console.WriteLine("2. Functii trigonometrice (sin, cos, tan)");
                Console.WriteLine("3. Logaritmi si exponentiale (log, ln, exp)");
                Console.WriteLine("4. Conversii numerice (decimal, binar, hex)");
                Console.WriteLine("5. Afiseaza Istoric");
                Console.WriteLine("6. Goleste Istoric");
                Console.WriteLine("7. Iesire");
                Console.Write("Alege o optiune (1-7): ");
                string optiune = Console.ReadLine();

                Console.WriteLine();

                try
                {
                    switch (optiune)
                    {

                        case "1":
                            Console.Write("a = ");
                            double a = double.Parse(Console.ReadLine());

                            double b = 0;
                            Console.Write("Operator (+, -, *, /, ^, %, sqrt): ");
                            string oper = Console.ReadLine();

                            if (oper != "sqrt")
                            {
                                Console.Write("b = ");
                                b = double.Parse(Console.ReadLine());
                            }

                            double rezultatBaza = 0;

                            switch (oper)
                            {
                                case "+":
                                    rezultatBaza = op.Adunare((int)a, (int)b);
                                    break;
                                case "-":
                                    rezultatBaza = op.Scadere((int)a, (int)b);
                                    break;
                                case "*":
                                    rezultatBaza = op.Inmultire((int)a, (int)b);
                                    break;
                                case "/":
                                    rezultatBaza = op.impartire(a, b);
                                    break;
                                case "^":
                                    rezultatBaza = op.Putere(a, b);
                                    break;
                                case "%":
                                    rezultatBaza = op.Modulo(a, b);
                                    break;
                                case "sqrt":
                                    rezultatBaza = op.Radical(a);
                                    break;
                                default:
                                    Console.WriteLine("Operator invalid!");
                                    continue;
                            }

                            Console.WriteLine($"Rezultat: {rezultatBaza}");
                            break;


                        case "2":
                            Console.Write("Valoare (radiani): ");
                            double x = double.Parse(Console.ReadLine());

                            Console.Write("Functie (sin, cos, tan): ");
                            string f = Console.ReadLine().ToLower();

                            double rezultatTrig = 0;

                            switch (f)
                            {
                                case "sin":
                                    rezultatTrig = trig.Sinus(x);
                                    break;
                                case "cos":
                                    rezultatTrig = trig.Cosinus(x);
                                    break;
                                case "tan":
                                    rezultatTrig = trig.Tangenta(x);
                                    break;
                                default:
                                    Console.WriteLine("Functie trigonometrica invalida!");
                                    continue;
                            }

                            Console.WriteLine($"Rezultat: {rezultatTrig}");
                            break;


                        case "3":
                            Console.Write("Valoare: ");
                            double v = double.Parse(Console.ReadLine());

                            Console.Write("Functie (log, ln, exp): ");
                            string lf = Console.ReadLine().ToLower();

                            double rezultatLog = 0;

                            switch (lf)
                            {
                                case "log":
                                    rezultatLog = log.LogaritmBaza10(v);
                                    break;
                                case "ln":
                                    rezultatLog = log.LogaritmNatural(v);
                                    break;
                                case "exp":
                                    rezultatLog = log.Exponentiala(v);
                                    break;
                                default:
                                    Console.WriteLine("Functie log/exponentiala invalida!");
                                    continue;
                            }

                            Console.WriteLine($"Rezultat: {rezultatLog}");
                            break;


                        case "4":
                            Console.Write("Numar (decimal): ");
                            int n = int.Parse(Console.ReadLine());

                            Console.Write("Conversie in (binar / hex): ");
                            string baza = Console.ReadLine().ToLower();

                            string rezultatConv = "";

                            switch (baza)
                            {
                                case "binar":
                                    rezultatConv = conv.decimalToBinary(n);
                                    break;
                                case "hex":
                                    rezultatConv = conv.decimalToHexadecimal(n);
                                    break;
                                default:
                                    Console.WriteLine("Baza invalida!");
                                    continue;
                            }

                            Console.WriteLine($"Rezultat: {rezultatConv}");
                            break;


                        case "5":
                            istoric.AfiseazaIstoric();
                            break;


                        case "6":
                            istoric.GolesteIstoric();
                            Console.WriteLine("Istoric sters!");
                            break;


                        case "7":
                            ruleaza = false;
                            Console.WriteLine("La revedere!");
                            break;

                        default:
                            Console.WriteLine("Optiune invalida!");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Eroare: {ex.Message}");
                }
            }
        }
    }
}