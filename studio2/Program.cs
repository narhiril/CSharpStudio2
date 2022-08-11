using System.IO;
using System.Collections.Generic;

namespace studio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Velvet\Documents\LaunchCode\csharp\class2\studio2\studio2\Readable.txt";
            string str = File.ReadAllText(path);
            List<char> charsInString = new List<char>();
            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            foreach (char c in str.ToUpper())
            {
                if (!charsInString.Contains(c))
                {
                    charsInString.Add(c);
                }
            }

            foreach (char foundChar in charsInString)
            {
                charCounts.Add(foundChar, CountCharacters(foundChar, str));
            }

            foreach (KeyValuePair<char, int> element in charCounts)
            {
                Console.WriteLine($"{element.Key}: {element.Value}");
            }
        }

        internal static int CountCharacters(char character, string searchString)
        {
            int count = 0;
            foreach (char c in searchString.ToUpper())
            {
                if (Equals(character, c))
                {
                    count++;
                }
            }
            return count;
        }
    }
}