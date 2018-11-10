using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            StringProcessor sp = new StringProcessor();
            string input = "maddam";
            var result=sp.IsPalindrome(input);
            Console.WriteLine("Input :" + input);
            Console.WriteLine("Result :" + result);

            Console.ReadKey(); 
        }

        private class StringProcessor {
            public bool IsPalindrome(string input)
            {
                char[] inputChars = input.ToCharArray();

                int end = inputChars.Length-1;
                int start = 0;
                while (start < end)
                {
                    if (inputChars[start] != inputChars[end])
                    {
                        return false;
                    }
                    else
                    {
                        start++;
                        end--;
                    }
                }

                return true;
            }
        }
    }
}
