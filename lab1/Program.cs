using System;

namespace lab1
{
    class Program
    {
        public void showMenu()
        {
            Console.WriteLine("<-----Menu----->");
            Console.WriteLine("1. Input array");
            Console.WriteLine("2. Show array ");
            Console.WriteLine("3. Get specific number in array ");
            Console.WriteLine("4. Insert number at position");
            Console.WriteLine("5. Remove array");
            Console.WriteLine("6. Remove number at specific location");
            Console.WriteLine("7. Replace number at position by another number");
            Console.WriteLine("8. Size of array");
            Console.WriteLine("9. Check empty");
            Console.WriteLine("10. Check full");
            Console.WriteLine("11. Exit");
            Console.WriteLine("===================================");
        }

        
        public void Getpos(int[] arr, int pos)
        {
            Console.WriteLine("Your number at {0} position that you have found is: {1}",pos+1, arr[pos]);
        }

        public void InsertNum(int[] arr,int n, int num, int pos)
        {
            if ( n >= 100) Console.WriteLine("Array is full");
            else
            {
                n =n+1;
                for(int i=n; i > pos; i--)
                {
                    arr[i] = arr[i-1];
                }
                arr[pos] = num;
            }
        }

        public void RemoveArray(int[] arr, int n)
        {
            for (int i=0; i<n; i++)
            {
                arr[0] = 0;
            }
            n=0;
        }

        public void RemoveAt(int[] arr,int n, int pos)
        {
            if(pos >n) Console.Write("You selection run out of array");
            else
            {
                if(pos == n-1)
                {
                    arr[n-1]=0;
                    n=n-1;
                }
                else
                {
                    for (int i=pos; i<n;i++)
                    {
                        arr[i]=arr[i+1];
                    }
                    n=n-1;
                }
            }
        }
        

        public void replaceNum(int[] arr, int reNum, int pos)
        {
            arr[pos] = reNum;
        }
        public void Display(int[] arr, int n)
        {
           Console.WriteLine();
            Console.Write("Your array: ");
            for (int i=0; i<n;i++)
            {
                Console.Write(arr[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.showMenu();    

            int[] arr = new int[100];
            int n=0;

            Console.Write("Input number of number in array: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your command: ");
            int pickOption = Convert.ToInt32(Console.ReadLine());
            
            while (pickOption != 11)
            {
                if (pickOption <1 || pickOption >11)
                {
                    Console.WriteLine("Error");
                }else
                {
                    switch(pickOption)
                    {
                        case 1:
                            for (int i=0; i<n; i++)
                            {
                                Console.Write("Input your number {0} that you want insert to array: ", i+1);
                                arr[i] = Convert.ToInt32(Console.ReadLine());
                            }
                            break;

                        case 2:
                            myProgram.Display(arr, n);
                            break;
                        
                        case 3:
                            Console.Write("Input your number location: ");
                            int l = Convert.ToInt32(Console.ReadLine());
                            myProgram.Getpos(arr,l-1);
                            break;

                        case 4:
                            Console.Write("Input your number: ");
                            int insNum = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            Console.Write("Input your insert position: ");
                            int insLoc = Convert.ToInt32(Console.ReadLine());
                            myProgram.InsertNum(arr,n,insNum,insLoc-1);
                            Console.WriteLine();
                            myProgram.Display(arr, n+1);
                            break;
                        case 5:
                            myProgram.RemoveArray(arr,n);
                            Console.Write("Your array has been deleted");
                            break;
                        case 6:
                            Console.Write("Input your position that you want to delete: ");
                            int posDel = Convert.ToInt32(Console.ReadLine());
                            myProgram.RemoveAt(arr,n,posDel-1);
                            Console.WriteLine();
                            Console.Write("Your new array: ");
                            myProgram.Display(arr,n-1);
                            break;
                        case 7:
                            Console.Write("Input your replace number: ");
                            int repNum = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            Console.Write("Input your replace position: ");
                            int repPos = Convert.ToInt32(Console.ReadLine());
                            myProgram.replaceNum(arr,repNum,repPos);

                            break;
                        case 8:
                            Console.Write(" Array size: {0}", n);

                            break;
                        case 9:
                            if (arr.Length == 0) Console.WriteLine("The array is empty");
                            else
                            {
                                Console.WriteLine("The araay is not empty");
                            }
                            break;

                        case 10:
                            if (arr.Length >= 1-0) Console.WriteLine("The array is full");
                            else
                            {
                                Console.WriteLine("The araay is not full");
                            }
                            break;

                        case 11:
                            break;
                        default:
                            break;
                    }
                    if (pickOption == 11) break;
                }
                Console.Write("Enter your command: ");
                pickOption = Convert.ToInt32(Console.ReadLine());    
            }

            Console.WriteLine("Thank you for using our service");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
