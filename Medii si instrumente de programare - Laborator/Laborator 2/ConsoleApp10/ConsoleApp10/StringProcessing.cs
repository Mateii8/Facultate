using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class StringProcessing
    {
        private string text;
        public StringProcessing(string inputText)
        {
            text = inputText;
        }
        public int countChar()
        {
            return text.Length;
        }
        public int countWords()
        {
      
            return text.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
        public int countPropozitii()
        {
            return text.Count(c => c == '.' || c == '?' || c == '!');
        }
        public int countVocale()
        {
            string vocale = "aeiouAEIOU";
            return text.Count(c => vocale.Contains(c));//linq folosit pt parcurgeri de text,liste, arrays
        }
        public int countConsoane()
        {
            string consoane = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";
            return text.Count(c => consoane.Contains(c));
        }
        public string Majuscule()
        {
            return text.ToUpper();
        }
        public string Minuscule()
        {
            return text.ToLower();
        }
        public string InvPropozitie()
        {
            if (!string.IsNullOrEmpty(text))
            {
                return new string(text.Reverse().ToArray());
            }
            return string.Empty;
        }
    }
}
