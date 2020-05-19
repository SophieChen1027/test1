using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("n:");*/
           
            for (int l = 1; ;l++) {
                int n = Convert.ToInt32(Console.ReadLine());
                if (n == 0) { break; }
                int[] array1 = new int[n];
                int k = 0;
                for (int i = 0; i < n; i++)
                {
                    /*Console.Write("h:");*/
                    int h = Convert.ToInt32(Console.ReadLine());
                    array1[i] = h;
                    k = k + array1[i];
                }
                int x = k / n;
                int y = 0;
                for (int j = 0; j < n; j++)
                {
                    if (array1[j] - x >= 0)
                    {
                        y = y + (array1[j] - x);
                    }
                    else
                    {
                        y = y + (x - array1[j]);
                    }
                }
                Console.WriteLine("Set #" + l);
                Console.WriteLine("The minimum number of moves is " + y/2+".");
            }
        }
    }
}
