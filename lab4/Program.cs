using System;
using System.Text;

namespace lab4
{
    public class Queue
    {
        public int max;
        public char[] Q;

        public int f=0;
        public int r =0;

        public Queue(int max, char[] Q)
        {
            this.max = max;
            this.Q = Q;
        }
        public int Enum()
        {
            if((r+1)%max == 0) return max;
            else return ((max-f)+r)%max;
        }

        public bool isFull()
        {
            return Enum() == max;
        }

        public bool isEmpty()
        {
            return f == r;
        }

        public void enQueue(char x)
        {

            Q[r] = x;
            if (Enum() != max)
            {
                r=(r+1)%max;
            }
        }

        public char deQueue()
        {
            char dQ = Q[f];
            f = (f+1)%max;
            return dQ;
        }

        public void Transfer()
        {
            Console.Write("Input s1: ");
            string s1 = Console.ReadLine();
            char[] s2 = new char[250];
            int i=0;
            int j=0;
            while(i<s1.Length)
            {
                while(Enum() < max -1)
                {
                    char c = s1[i];
                    enQueue(c);
                    i =i +1;
                }
                while (Enum() >0)
                {
                    s2[j] = deQueue();
                    j++;
                }
            }
            Console.WriteLine($"Destination string S2: {s2}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input total numbers of Queue: ");
            int num = Convert.ToInt32(Console.ReadLine());
            char[] queueArray = new char[num];
            Queue myQueue = new Queue(num, queueArray);
            int n=1;
            Console.WriteLine("\n Input 'q' to exit!");
            while (n-1 != num)
            {
                Console.Write("\nInput number {0} of Queue: ",n);
                char data = Convert.ToChar(Console.ReadLine());
                if ( data == 'q') break;
                myQueue.enQueue(data);
                n++;
            }

            Console.Write("Your Queue:");
            foreach(char item in myQueue.Q)
            {
            Console.Write(' ' + item.ToString());
            }

            Console.WriteLine();
            Console.WriteLine($"Max: {myQueue.max}");
            Console.Write($"Enum: {myQueue.Enum()}");
            Console.WriteLine();
            Console.WriteLine($"f: {myQueue.f}, r: {myQueue.r}");
            Console.WriteLine();
            Console.WriteLine("IsFUll: "+myQueue.isFull());
            Console.WriteLine("IsEmpty: "+myQueue.isEmpty());
            myQueue.Transfer();
        }
    }
}
