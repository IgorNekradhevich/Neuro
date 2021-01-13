using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp61
{
    class HolstArray
    {
        public int N { get; private set; }
        public int[,] arr { get; private set; }

        public HolstArray(int len)
        {
            N = len;
            arr = new int[N, N];
            ClearArray();
        }
        public void ClearArray()
        {
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    arr[i, j] = 0;
        }

        public void DrawPixel(int i, int j)
        {

            if (i - 1 >= 0 
                && j - 1 >= 0 
                && i + 1 <= N - 1 
                && j + 1 <= N - 1)
            {
                arr[i - 1, j] = 1;
                arr[i, j - 1] = 1;
                arr[i + 1, j] = 1;
                arr[i, j + 1] = 1;
                arr[i + 1, j - 1] = 1;
                arr[i + 1, j + 1] = 1;
                arr[i - 1, j - 1] = 1;
                arr[i - 1, j + 1] = 1;
                arr[i, j] = 1;
            }
        }
   
    }
}
