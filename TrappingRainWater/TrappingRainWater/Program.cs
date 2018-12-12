using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrappingRainWater
{
    class Program
    {
        static void Main(string[] args)
        {
            TrapWater tw = new TrapWater();
            int result = tw.CalculateStorage(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 });
            Console.WriteLine(result);
            Console.ReadKey();
        }

        private class TrapWater
        {
            public int CalculateStorage(int[] heights)
            {
                int[] leftMax = new int[heights.Length];
                int[] rightMax = new int[heights.Length];

                leftMax[0] = heights[0];
                rightMax[heights.Length - 1] = heights[heights.Length - 1];

                for (int i = 1; i < heights.Length; i++)
                {
                    leftMax[i] = heights[i] > leftMax[i - 1] ? heights[i] : leftMax[i - 1];
                }

                for (int i = heights.Length - 2; i >= 0; i--)
                {
                    rightMax[i] = heights[i] > rightMax[i + 1] ? heights[i] : rightMax[i + 1];
                }

                int ans = 0;

                for (int i = 1; i < heights.Length; i++)
                {
                    ans += (leftMax[i] < rightMax[i] ? leftMax[i] : rightMax[i]) - heights[i];
                }

                return ans;
            }
        }
    }
}
