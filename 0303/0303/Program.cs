using System;

namespace _0303
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i >= 0)
            {
                if (((i + 1) * (i+1) -i * i)> 169)
                {
                    break;
                }
                i++;
            }

            int[] arr = new int[i];
            int j = 0;
            for (; j <= i; j++)
            {
                arr[j] = j * j;
            }
            int x, y;
            for(x = 0; x <= i; x++)
            {
                for(y= 0; y <= i; y++)
                {
                    if (arr[y] - arr[x] == 168)
                    {
                        break;
                    }
                }
            }
            int a = arr[i] - 100;
            Console.WriteLine(a);
        }
    }
}
