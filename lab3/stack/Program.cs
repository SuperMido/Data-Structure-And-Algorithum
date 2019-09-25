using System;
 
namespace DSAlab3Stack
{
    public class Stack
    {
        public static int[] stackArray = new int[20];
        public static int top=-1;
        public static void push(int x)
        {
            if (top == 19)
            {
                Console.WriteLine("Array full");
            }
            else
            {
                top++;
                stackArray[top] = x;
            }
        }

        public static int pop()
        {
            int x;
            if (top < 0)
            {
                x=-1;
            }
            else
            {
                x = stackArray[top];
                top--;
            }
            return x;
        }
 
        public static bool IsFull()
        {
            if (top == Stack.stackArray.Length - 1)      
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsEmpty()
        {
            if (top == -1)                    
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void input()
        {
            int x=-1;
            while (x!=0)
            {
                Console.Write("Input a number: ");
                x = Convert.ToInt32(Console.ReadLine());
                if (x == 0) break;
                Stack.push(x);
            }
        }

        public static void output()
        {
            while (top >=0)
            {
                Console.Write($" {Stack.pop()}");
            }
        }

        public static void change(int n)
        {
            int r;
            while (n!=0)
            {
                r = n%2;
                Stack.push(r);
                n=n/2;
            }
        }
    }

    class Program
    {
       
        public static void Main(string[] args) 
        {
            // Stack.input();
            // Stack.output();
            Console.Write("Input number that you want to convert: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("The number change to: ");
            Stack.change(n);
            Stack.output();
            
            Console.WriteLine();
            Console.Write("Press any key to exit! ");
            Console.ReadKey();
        }
    }
}