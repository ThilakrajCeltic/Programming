using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;

namespace MaxCharOccurrence
{
    class Program
    {
        static void Main(string[] args)
        {
            StringParser sp = new StringParser();
            var input = "Thilakraj";
            var result = sp.GetMaxOccurrenceCharacter(input);
            Console.WriteLine("Input:" + input);
            Console.WriteLine("Max Occurrence Char:" + result.Key);
            Console.WriteLine("Number of occurrence :" + result.Value);
            Console.ReadKey();
        }

        private class StringParser
        {
            public KeyValuePair<char, int> GetMaxOccurrenceCharacter(string input)
            {
                if (string.IsNullOrEmpty(input))
                {
                    throw new ArgumentNullException();
                }

                char[] inputChar = input.ToCharArray();
                Dictionary<char, int> charCounter = new Dictionary<char, int>();
                foreach (char c in inputChar)
                {
                    if (charCounter.ContainsKey(c))
                    {
                        charCounter[c] += 1;
                    }
                    else
                    {
                        charCounter.Add(c, 1);
                    }
                }
                KeyValuePair<char, int> maxOccurence = new KeyValuePair<char, int>();
                foreach (KeyValuePair<char, int> eachDicItem in charCounter)
                {
                    if (eachDicItem.Value > maxOccurence.Value)
                    {
                        maxOccurence = eachDicItem;
                    }
                }

                return maxOccurence;
            }
        }
    }
}
