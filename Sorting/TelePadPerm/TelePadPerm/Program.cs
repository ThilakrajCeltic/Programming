using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelePadPerm
{
    class Program
    {
        static void Main(string[] args)
        {
            LeetCodeSoln leet = new LeetCodeSoln();
            var result = leet.GetPerm("23");

            StringProcessor sp = new TelePadPerm.Program.StringProcessor();
            sp.TestStringProcessor();
        }

      

        private class StringProcessor
        {
            Dictionary<int, List<char>> config = new Dictionary<int, List<char>>();

            public StringProcessor()
            {
                config.Add(2, new List<char> { 'A', 'B', 'C' });
                config.Add(3, new List<char> { 'D', 'E', 'F' });
                config.Add(4, new List<char> { 'G', 'H', 'I' });
                config.Add(5, new List<char> { 'J', 'K', 'L' });
            }
            public  List<string> GetStringCombination(int number)
            {
                List<string> result = new List<string>();

                while (number  > 0)
                {
                    if (number % 10 > 1)
                    {
                        result = GetComb(result, config[number % 10].ToArray());
                    }
                    number = number / 10;
                }

                List<string> allPerm = new List<string>();

                foreach (string str in result)
                {
                    Permutation(str, 0, str.Length-1, allPerm);
                }


                return result;
            }

            public List<string> GetComb(List<string> source, char[] charOptions)
            {
                List<string> result = new List<string>();
                for (int  c=0; c< charOptions.Count(); c++)
                {
                    if (source.Count == 0)
                    {
                        result.Add(charOptions[c].ToString());
                    }
                    else
                    {
                        for (int s = 0; s < source.Count; s++)
                        {
                                result.Add(source[s]+  charOptions[c].ToString());
                               // source[s] = source[s] + c;
                           
                        }
                    }
                }

                return result;  
            }

            private string Swap(string str, int indexFrom, int indexTo)
            {
                char[] tempArray = str.ToArray();
                char temp = str[indexFrom];
                tempArray[indexFrom] = tempArray[indexTo];
                tempArray[indexTo] = temp;

                return new string(tempArray);
            }


            private void Permutation(string str, int startIndex, int endIndex, List<string> result)
            {
                if (startIndex == endIndex)
                {
                    result.Add(str);
                }
                else
                {
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        str=Swap(str, startIndex, i );
                        Permutation(str, startIndex+ 1,endIndex, result);
                        str= Swap(str, startIndex, i);
                    }
                }
            
            }
            public  bool TestStringProcessor()
            {
                bool result = false;
                List<string> data = GetStringCombination(222);

                if (data.Contains("ABC") && data.Contains("BCA") && data.Contains("CBA"))
                {
                    result = true;
                }

                return result;
            }
        }
    }
}
