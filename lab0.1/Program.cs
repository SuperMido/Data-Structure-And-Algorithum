using System;

namespace lap1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter your {0} number: ", i+1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int j=0;j<5;j++)
            {
                sum += arr[j];
            }
            
            int minArr=arr[0];
            for (int n=1;n<5;n++)
            {
                if (minArr > arr[n])
                {
                    minArr = arr[n];
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nSum of 5 input: {0}", sum);
            Console.WriteLine("Min number is: {0}", minArr);
            Console.ResetColor();
            Console.WriteLine("\nPress anykey to exit!");
            Console.ReadLine();
        }
    }
}