using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {

            SelectionSort ss = new SelectionSort();
            int[] input = { 6, 2, 8, 4, 5, 1, 9 };
            ss.Sort(input);
            foreach (int i in input)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }

        private class SelectionSort
        {
            public int[] Sort(int[] input)
            {
                for (int i = 0; i < input.Length-1; i++)
                {
                    int minIndex = i;
                    for (int j = i + 1; j < input.Length; j++)
                    {
                        if (input[j] < input[minIndex])
                        {
                            minIndex =j;
                        }
                    }

                    int temp = input[i];
                    input[i] = input[minIndex];
                    input[minIndex] = temp;
                }
                
                return input;
            }
        }
    }
}
