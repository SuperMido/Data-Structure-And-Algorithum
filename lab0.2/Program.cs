using System;

namespace lap2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Input n: ");
            n = Convert.ToInt32(Console.ReadLine());
            var watch = System.Diagnostics.Stopwatch.StartNew();
            watch.Start();
            int[] arr = new int[n];
            arr[0]=1;
            arr[1]=1;
            if (n >2)
            {
                for (int i=2;i<n;i++)
                {
                arr[i] = arr[i-1] + arr[i-2];
                }
            }
            Console.WriteLine(String.Join(" ", arr));
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        }
    }
}