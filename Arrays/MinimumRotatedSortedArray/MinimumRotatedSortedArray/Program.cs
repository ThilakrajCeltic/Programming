using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumRotatedSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 6, 7, 8, 9, 1, 2, 3 };
            ArrayManupulation am = new ArrayManupulation();
            int result = am.FindMin(input);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }

    public class ArrayManupulation
    {
        public int FindMin(int[] input)
        {

            if (input.Length == 1)
            {
                return input[0];
            }

            if (input[input.Length - 1] > input[0])
            {
                return input[0];
            }
            else
            {
                int right = input.Length-1;
                int left = 0;
                while (right > left) {
                    int mid = left + (right + left) / 2;

                    if (input[mid] > input[mid + 1])
                    {
                        return input[mid + 1];
                    }
                    else if (input[mid -1] > input[mid])
                    {
                        return input[mid];
                    }

                    if (input[mid] >input[0]  )
                    {
                        left = mid+1;
                    }
                    else
{
                        right= mid-1;
                    }
                }
            }

            return 0;
        }
    }
}
