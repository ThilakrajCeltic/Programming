using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] input = {
                                {1,2,3,4 },
                                {5,6,7,8 },
                                {9,10,11,12},
                                {13,14,15,16}
                            };

            ArrayMannupulaion am = new ArrayMannupulaion();
            am.Rotate90(input, input.GetUpperBound(0) + 1);
            am.Display(input, input.GetUpperBound(0) + 1);
            Console.ReadKey();
        }

        private class ArrayMannupulaion
        {
            public void Display(int[,] input, int n)
            {
                for (int x = 0; x < n; x++)
                {
                    for (int y = 0; y < n; y++)
                    {
                        Console.Write(" " + input[x, y]);
                    }
                    Console.WriteLine("");
                }
            }

            public void Rotate90(int[,] input, int n)
            {
                for (int x = 0; x < n / 2; x++)
                {
                    for (int y = x; y < n - 1 - x; y++)
                    {
                        int temp = input[x, y];
                        //Right to Left
                        input[x, y] = input[y, n - 1 - x];

                        //bottom to right
                        input[y, n - 1 - x] = input[n - 1 - x, n - 1 - y];

                        //left to bottom
                        input[n - 1 - x, n - 1 - y] = input[n - 1 - y, x];

                        //top to left
                        input[n - 1 - y, x] = temp;
                    }
                }
            }
        }
    }
}
