using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 4, 7, 13, 2, 3, 9, 5 };
            Bubble b = new Bubble();
            b.Sort(input);
            foreach (int i in input)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }

        private class Bubble
        {
            public int[] Sort(int[] input)
            {
                for (int i = 1; i <= input.Length - 1; i++)
                {
                    for (int j = 0; j <= input.Length - 2; j++)
                    {
                        if (input[j+1] < input[j])
                        {
                            int temp = input[j+1];
                            input[j + 1] = input[j];
                            input[j] = temp;
                        }
                    }
                }

                return input;
            }
        }
    }
}
