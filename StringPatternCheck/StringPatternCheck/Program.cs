using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPatternCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            StringProcessor sp = new StringProcessor();
            var pattern = "Th?lakr*";
            var input = "Thilakraj";
            var result=sp.IsPatternMatch(pattern, input);
            Console.WriteLine("Input :" + input);
            Console.WriteLine("Pattern :" + pattern);
            Console.WriteLine("Result :" + result);
            Console.ReadKey();
        }

        private class StringProcessor {
            public bool IsPatternMatch(string pattern, string inputString)
            {
                char[] patternChars = pattern.ToCharArray();
                char[] inputChars = inputString.ToCharArray();

                int currentInputIndex = 0;
                int currentPatternIndex = 0;
               // int lastPatternIndex = 0;
                bool asteriskCheckMode = false;

                while (currentInputIndex <= inputChars.Length -1 && currentPatternIndex <= patternChars.Length -1)
                {
                    if (patternChars[currentPatternIndex] == '?' || patternChars[currentPatternIndex] == inputChars[currentInputIndex])
                    {
                        currentPatternIndex++;
                        currentInputIndex++;
                    }
                    else if (patternChars[currentPatternIndex] == '*')
                    {
                        asteriskCheckMode = true;
                        if (currentPatternIndex == patternChars.Length - 1)
                        {
                            currentInputIndex = inputChars.Length ;
                        }
                        else
                        {
                            currentInputIndex++;
                        }

                        currentPatternIndex++;
                        
                    }
                    else if (asteriskCheckMode == true  && patternChars[currentPatternIndex] == inputChars[currentInputIndex])
                    {
                        currentPatternIndex++;
                        currentInputIndex++;
                    }
                    else if (asteriskCheckMode == true && patternChars[currentPatternIndex] != inputChars[currentInputIndex])
                    {
                        currentInputIndex++;
                    }
                    else if (inputChars[currentInputIndex] != patternChars[currentPatternIndex])
                    {
                        return false;
                    }
                }

                if (currentInputIndex  != inputChars.Length || currentPatternIndex != patternChars.Length)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
