using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsonantsAndVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            GetLetters();
        }

        public static void GetLetters()
        {
            int vowelCount = 0;
            int consCount = 0;
            int i;
            string word;            

            Console.WriteLine("Type any word: ");
            word = Console.ReadLine();

            for (i = 0; i < word.Length; i++)
            {            

                if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
                {
                    vowelCount++;
                }
                else
                {
                    consCount++;
                }
                
            }
            Console.WriteLine("There are " + vowelCount + "vowels in that word and " + consCount + "consonants!");
            Console.ReadKey();
        }
    }

}
