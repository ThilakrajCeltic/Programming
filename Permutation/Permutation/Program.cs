using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutation
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string input = "ABC";
            StringProcessor sp = new StringProcessor();
            sp.Permute(input,0, input.Length-1);
            Console.ReadKey();  
        }
        
        private class StringProcessor
        {
            private string Swap(string str, int indexFrom, int indexTo)
            {
                char[] strArry = str.ToCharArray();
                char temp = strArry[indexFrom];
                strArry[indexFrom] = strArry[indexTo];
                strArry[indexTo] = temp;
                return new string(strArry);
            }

            public void Permute(string str, int startIndex, int endIndex)
            {
                if (startIndex == endIndex)
                {
                    Console.WriteLine(str);
                }
                else
                {
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        str = Swap(str, startIndex, i);
                        Permute(str, startIndex + 1, endIndex);
                        str = Swap(str, startIndex, i);
                    }
                }
            }
        }
    }
}
