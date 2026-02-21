using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorStiintific
{
    public class Conversii
    {
        private Istoric istoric;
        public Conversii(Istoric istoric)
        {
            this.istoric = istoric;
        }
        public string decimalToBinary(int num)
        {
            string rezultat = Convert.ToString(num, 2);
            istoric.AdaugaOperatie($"Decimal to Binary: {num} -> {rezultat}");
            return rezultat;
        }
        public string decimalToHexadecimal(int num)
        {
            string rezultat = Convert.ToString(num, 16).ToUpper();
            istoric.AdaugaOperatie($"Decimal to Hexadecimal: {num} -> {rezultat}");
            return rezultat;
        }
        public int binaryToDecimal(string num)
        {
            int rezultat = Convert.ToInt32(num, 2);
            istoric.AdaugaOperatie($"Binary to Decimal: {num} -> {rezultat}");
            return rezultat;
        }
        public int hexadecimalToDecimal(string num)
        {
            int rezultat = Convert.ToInt32(num, 16);
            istoric.AdaugaOperatie($"Hexadecimal to Decimal: {num} -> {rezultat}");
            return rezultat;
        }
        public string binaryToHexadecimal(string num)
        {
            int decimalValue = Convert.ToInt32(num, 2);
            string rezultat = Convert.ToString(decimalValue, 16).ToUpper();
            istoric.AdaugaOperatie($"Binary to Hexadecimal: {num} -> {rezultat}");
            return rezultat;
        }
        public string hexadecimalToBinary(string num)
        {
            int decimalValue = Convert.ToInt32(num, 16);
            string rezultat = Convert.ToString(decimalValue, 2);
            istoric.AdaugaOperatie($"Hexadecimal to Binary: {num} -> {rezultat}");
            return rezultat;
        }

    }
}