using System;

namespace Complexidades
{
    public class TempoLogaritmo
    {
        public int Logaritmo(int[] numerosint, int key)
        {
            int minNum = 0;
            int maxNum = numerosint.Length - 1;

            while (minNum <= maxNum)
            {
                int mid = (minNum + maxNum) / 2;
                if (key == numerosint[mid])
                {
                    return ++mid;
                }
                else if (key < numerosint[mid])
                {
                    maxNum = mid - 1;
                }
                else
                {
                    minNum = mid + 1;
                }
            }

            return -1;

        }
    }
}
