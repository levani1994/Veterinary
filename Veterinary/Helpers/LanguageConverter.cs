using System;
using System.Text;

namespace Veterinary.Helpers
{
    public static  class LanguageConverter
    {
        public static string ConvertToEnglish(string text)
        {
            string[] charset = new string[33] { "a", "b", "g", "d", "e", "v", "z", "T", "i", "k", "l", "m", "n", "o", "p", "J", "r", "s", "t", "u", "f", "q", "R", "y", "S", "C", "c", "Z", "w", "W", "x", "j", "h" };
            var latinString = string.Empty;

            byte[] unicodeBytes = Encoding.Unicode.GetBytes(text);
            for (int p = 0; p < unicodeBytes.Length / 2; p++)
            {
                if (unicodeBytes[p * 2] > 207 && unicodeBytes[p * 2] < 241)
                    latinString += charset[unicodeBytes[p * 2] - 208];
                else
                    latinString += Convert.ToChar(unicodeBytes[p * 2]).ToString();
            }

            return latinString;
        }
    }
}