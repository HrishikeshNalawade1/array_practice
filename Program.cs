using System;

namespace proj
{
    class Check
    {
        public void comma(int[] a,int[] b,int m,int n)
        {
            for (int i = 0; i < n; i++)
            {
                int j;

                for (j = 0; j < m; j++)
                    if (a[i] == b[j])
                        break;

                if (j == m)
                    Console.Write(a[i] + " ");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };
            int[] arr1 = { 1, 2, 3, 5 };
            int m = arr.Length;
            int n = arr1.Length;

            Check ch = new Check();
            ch.comma(arr, arr1, m, n);
        }
    }
}
