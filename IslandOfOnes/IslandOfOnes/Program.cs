using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IslandOfOnes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] screenPixels = new int[,]{ 
                                     { 1,0,1,1,0,1},
                                     { 1,1,1,0,0,0},
                                     { 0,1,0,0,0,1},
                                     { 0,1,0,0,0,1},
                                   };

            ScreenProcessor sp = new ScreenProcessor();
         int count=   sp.NumberOfOnes(screenPixels);

        }

        public class ScreenProcessor{

            public int NumberOfOnes(int[,] screenPixels)
            {
                int onesCount = 0;
                bool[,] visted = new bool[screenPixels.GetLength(0), screenPixels.GetLength(1)];

                for (int row = 0; row < screenPixels.GetLength(0); row++)
                {
                    for (int col = 0; col < screenPixels.GetLength(1); col++)
                    {
                        if (screenPixels[row, col] == 1 && !visted[row,col])
                        {
                            onesCount++;
                            //visted[row, col] = true;
                            dfsVisted(screenPixels, row, col, visted);
                        }
                    }

                }

                return onesCount;
            }

            private void dfsVisted(int[,] screenPixels, int currentRow, int currentCol, bool[,] visted)
            {
                if (visted[currentRow, currentCol])
                {
                    return;
                }
                visted[currentRow, currentCol] = true;
                    for (int row = -1; row <= 1; row++)
                    {
                        for (int col = -1; col <= 1; col++)
                        {
                            if ((row == 0 && col == 0) ||
                               currentRow + row< 0 || currentRow + row > screenPixels.GetLength(0)-1 ||
                                currentCol + col<0 ||currentCol + col > screenPixels.GetLength(1)-1)
                            {
                                continue;
                            }

                            if (screenPixels[currentRow+row, currentCol+col] == 1)
                            {
                                dfsVisted(screenPixels, currentRow + row, currentCol + col, visted);
                            }
                        }

                    }
                
            } 
        }
    }
}
