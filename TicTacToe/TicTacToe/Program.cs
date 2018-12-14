using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] data = {
                                { "X","X","X" },
                                { ""," ","X" },
                                { "O","O","O" }
                            };
            
            TicTacToeProcessor tp= new TicTacToeProcessor();
            bool result = tp.ValidWin(data);
        }
    }

    public class TicTacToeProcessor
    {
        public bool ValidWin(string[,] data)
        {
            bool result = false;
            int diagonal = 0, antiDiagonal = 0, times = 0;
            int length = data.GetLength(0);
            int[] rowWin = new int[length];
            int[] colWin = new int[length];

            for (int row = 0; row < length ; row++)
            {
                for (int col = 0; col < length; col++)
                {
                    if (data[row, col] == "X")
                    {
                        times++;
                        rowWin[row]++;
                        colWin[col]++;

                        if (row == col) diagonal++;
                        if (row + col == length) antiDiagonal++;
                    }
                    else if(data[row, col] == "O")
                    {
                        times--;
                        rowWin[row]--;
                        colWin[col]--;

                        if (row == col) diagonal--;
                        if (row + col == length) antiDiagonal--;
                    }
                }
            }

            bool xWins = diagonal == length || antiDiagonal == length
                || IsWin(rowWin, length)
                || IsWin(colWin, length);

            bool yWins = diagonal == -length || antiDiagonal == -length
                || IsWin(rowWin, -length)
                || IsWin(colWin, -length);

            if (xWins && times == 0 || yWins & times == 1)
            {
                return false;
            }

            result = (!xWins || !yWins);

            return result;
        }

        private static bool IsWin( int[] rowWin, int length)
        {
            foreach (int row in rowWin)
            {
                if (row == length)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
