using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfOnesComplement
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseNumberProcessor bnp = new BaseNumberProcessor();
            int input = 8;
            var result = bnp.NumberOfOnes(input);
            Console.WriteLine("input :" + input);
            Console.WriteLine("result :" + result);
            Console.ReadKey();
        }

        private class BaseNumberProcessor
        {
            public int NumberOfOnes(int input)
            {
                int result = 0;
                while (input != 0)
                {
                    result++;
                    input &= (input - 1);
                }

                return result;
            }
        }
    }
}
