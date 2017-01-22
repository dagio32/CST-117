using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCU_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Write a C# program that reads strings from a file and outputs the following statistics
             * The first and last word alphabetically
             * The number of words that start with a vowel
             * The longest word
             * The total number of words
             */

            string line = "";

            try
            {
                using (StreamReader streamReader = new StreamReader(@"C:\Users\nickr\OneDrive\Visual Studio 2015\Projects\GCU_StreamReader\GCU_StreamReader\TextFile.txt"))
                {
                    line = streamReader.ReadLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Cannot find the file.");
            }

            string[] parts = line.Split(',');

            //Display the words in order
            Console.WriteLine("The following words were read from the text file:\r\n");
            foreach (var item in parts)
            {
                Console.WriteLine(item);
            }

            //Sort words alphabetically, display first and last words
            Array.Sort(parts);
            Console.WriteLine("\r\nFirst word alphabetically: {0}", parts[0]);
            Console.WriteLine("Last word alphabetically: {0}", parts[parts.Length - 1]);

            //Words that start with vowels
            int totalVowels = 0;
            char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u'};
            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i].IndexOfAny(vowels) == 0)
                {
                    totalVowels++;
                }
            }
            Console.WriteLine("Words that start with vowels: {0}", totalVowels);

            //Find longest word
            int totalCharacters = 0;
            string longestWord = "";
            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i].Length > totalCharacters)
                {
                    totalCharacters = parts[i].Length;
                    longestWord = parts[i];
                }
            }
            Console.WriteLine("Longest word: {0}", longestWord);

            //Display total number of words
            Console.WriteLine("Total number of words: {0}", parts.Length);

            Console.ReadKey();
        }
    }
}
