using System.Diagnostics.Metrics;
using System.Transactions;

namespace Session04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //int.TryParse(Console.ReadLine(), out int number);
            //for (int i = 1; i <= number; i++)
            //{
            //    Console.Write($"{i} ");
            //}
            #endregion

            #region 2- Write a program that allows the user to insert an integer then print a multiplication table up to 12
            //int.TryParse(Console.ReadLine(), out int number);
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write($"{number * i} ");
            //}

            #endregion

            #region 3- Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //int.TryParse(Console.ReadLine(), out int number);
            //for (int i = 1; i < number; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        Console.Write($"{i} ");
            //    }
            //}

            #endregion

            #region 4- Write a program that takes two integers then prints the power.
            //int.TryParse(Console.ReadLine(), out int number01);
            //int.TryParse(Console.ReadLine(), out int number02);

            //Console.WriteLine($"Power : {Math.Pow(number01 , number02)}");
            #endregion

            #region 5- Write a program to enter marks of five subjects and calculate total, average and percentage
            //int[] Marks = new int[5];
            //double SUM = 0;
            //double AVG ;
            //double Percent ;
            //for (int i = 0; i < Marks.Length; )
            //{
            //    Console.WriteLine($"Enter Marks of Sub {i+1} : ");
            //    bool IsParse = int.TryParse(Console.ReadLine(),out Marks[i]);
            //    if (!IsParse)
            //    {
            //        Console.WriteLine($"Enter Valid Mark  of Sub {i+1} : ");
            //    }
            //    else
            //    {
            //        i++;
            //    }

            //}
            //for (int i = 0;i < Marks.Length;i++)
            //{
            //    SUM += Marks[i];
            //}
            //AVG = SUM / Marks.Length;
            //Percent = (SUM / (100 * Marks.Length)) * 100;
            //Console.WriteLine($"Total Sum : {SUM}\nAvarage : {AVG}\nPercent: {Percent} ");
            #endregion

            #region 6- Write a program to allow the user to enter a string and print the REVERSE of it.
            //string Str = Console.ReadLine(); // Mohammed => demmahoM
            //for (int i = Str.Length - 1; i > 0; i--)
            //{
            //    Console.Write(Str[i]); 
            //}                                 
            #endregion

            #region 7- Write a program to allow the user to enter int and print the REVERSED of it.
            //Console.Write("Enter an integer: ");
            //string Str = Console.ReadLine();
            //bool IsParse = int.TryParse(Str, out int result);
            //if (IsParse)
            //{
            //    Console.Write("Reversed integer: ");
            //    for (int i = Str.Length - 1; i >= 0; i--)
            //    {
            //        Console.Write(Str[i]); 
            //    }  
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input! Please enter a valid integer.");
            //}
            #endregion

            #region 8- Write a program in C# Sharp to find prime numbers within a range of numbers.
            //Console.Write("Enter an integer 1 : ");
            //int.TryParse(Console.ReadLine(), out int Num1);
            //Console.Write("Enter an integer 2 : ");
            //int.TryParse(Console.ReadLine(), out int Num2);


            //for (int i = Num1; i <= Num2; i++)
            //{
            //    bool flag = true;

            //    if (i > 1)
            //    {
            //        for (int j = 2; j <= Math.Sqrt(i); j++)
            //        {
            //            if (i % j == 0)
            //            {
            //                flag = false;
            //                break;
            //            }
            //        }
            //        if(flag)
            //        {
            //            Console.Write($"{i} ");
            //        }
            //    }
            //}
            #endregion

            #region 9- . Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //decimal.TryParse(Console.ReadLine(), out decimal Num1);

            //while(Num1 > 1)
            //{
            //    int binary = (int) Num1 % 2;
            //    Console.Write($"{binary} ");
            //    Num1 /= 2;
            //}

            #endregion

            #region 10- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            //Console.Write("X1 : ");
            //int.TryParse(Console.ReadLine(), out int x1);
            //Console.Write("Y1 : ");
            //int.TryParse(Console.ReadLine(), out int y1);
            //Console.Write("X2 : ");
            //int.TryParse(Console.ReadLine(), out int x2);
            //Console.Write("Y2 : ");
            //int.TryParse(Console.ReadLine(), out int y2);
            //Console.Write("X3 : ");
            //int.TryParse(Console.ReadLine(), out int x3);
            //Console.Write("Y3 : ");
            //int.TryParse(Console.ReadLine(), out int y3);

            //int m1 = (y2 - y1) / (x2 - x1);
            //int m2 = (y3 - y2) / (x3 - x2);

            //if(m1 == m2)
            //{
            //    Console.WriteLine("Three point lie on Straight line.");
            //}
            //else
            //{
            //    Console.WriteLine("Three point not lie on Straight line.");
            //}
            #endregion

            #region 11- . Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //Console.Write("Enter n Matrix Size: ");
            //int.TryParse(Console.ReadLine(), out int n);

            //int[,] Matrix = new int[n, n];

            //for (int i = 0; i < n; i++) // Represent Rows.
            //{
            //    for (int j = 0; j < n; j++) // Represent Cols.
            //    {
            //        Console.Write($"Enter Element At {i} {j} : ");
            //        int.TryParse(Console.ReadLine(), out Matrix[i, j]);
            //    }
            //}
            //Console.Clear();

            //Console.Write($"Element At Matrix :\n");
            //for (int i = 0; i < n; i++) // Represent Rows.
            //{
            //    for (int j = 0; j < n; j++) // Represent Cols.
            //    {
            //        Console.Write($"\t{Matrix[i , j]}");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 12- Write a program in C# Sharp to find the sum of all elements of the array.

            //int[] arr = new int[5];
            //int Sum = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Enter element {i + 1} At Array : ");
            //    int.TryParse(Console.ReadLine(), out arr[i] );
            //}

            //for (int i = 0;i < arr.Length;i++)
            //{
            //    Sum += arr[i];
            //}
            //Console.WriteLine($"Total Sum : {Sum}");
            #endregion

            #region 13- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //int[] arr1 = new int[5];
            //int[] arr2 = new int[5];

            //int[] arr3 = new int[10];
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    Console.Write($"Enter element {i + 1} At Array 1 : ");
            //    int.TryParse(Console.ReadLine(), out arr1[i] );
            //}

            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.Write($"Enter element {i + 1} At Array 2 : ");
            //    int.TryParse(Console.ReadLine(), out arr2[i]);
            //}

            //for(int i = 0;i < arr3.Length; i++)
            //{
            //    if(arr1.Length > i)
            //    {
            //        arr3[i] = arr1[i];
            //    }
            //    else
            //    {
            //        arr3[i] = arr2[i - arr1.Length];
            //    }
            //}


            //Array.Sort(arr3);

            //Console.Clear();

            //for (int i = 0; i < arr3.Length; i++)
            //{
            //    Console.WriteLine($"element {i + 1} : {arr3[i]}");
            //}
            #endregion

            #region 14- Write a program in C# Sharp to count the frequency of each element of an array.

            //int[] arr = new int[10];


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Enter element {i + 1} At Array 1 : ");
            //    int.TryParse(Console.ReadLine(), out arr[i]);
            //}
            //int Counter;
            //for (int i = 0;i < arr.Length;i++)
            //{
            //    Counter = 0;
            //    bool Freq = false;
            //    for (int j = 0; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j] && i > j)
            //        {
            //            Freq = true;
            //            break;
            //        }
            //        if (arr[i] == arr[j])
            //        {
            //            Counter++;
            //        }
            //    }
            //    if (!Freq)
            //    {
            //        Console.WriteLine($"Freq {arr[i]} is {Counter}");
            //    }
            //}

            #endregion

            #region 15- Write a program in C# Sharp to find maximum and minimum element in an array
            //int[] arr = new int[5];


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Enter element {i + 1} At Array 1 : ");
            //    int.TryParse(Console.ReadLine(), out arr[i]);
            //}

            //Console.WriteLine($"Maximum At Array : {arr.Max()}");
            //Console.WriteLine($"Minimum At Array : {arr.Min()}");
            #endregion

            #region 16- Write a program in C# Sharp to find the second largest element in an array.
            //int[] arr = new int[5];


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Enter element {i + 1} At Array 1 : ");
            //    int.TryParse(Console.ReadLine(), out arr[i]);
            //}

            //Array.Sort(arr);

            //Console.WriteLine($"The Second largest Number At array : {arr[arr.Length - 2]}");


            #endregion

            #region  17- write a program find the longest distance between Two equal cells. 
            //Console.Write("Enter Size of array : ");
            //int.TryParse(Console.ReadLine(), out int n);

            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Enter element {i + 1} At Array 1 : ");
            //    int.TryParse(Console.ReadLine(), out arr[i]);
            //}
            //int k; // index of the same element

            //int MaxD = 0; // Catch Max 
            //int Dist; // Distance that compare to Max

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    k = 0;

            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            k = j;
            //        }
            //    }

            //    if (k > 0 && k != i)
            //    {
            //        Dist = (k - 1) - i;

            //        if (MaxD < Dist)
            //        {
            //            MaxD = Dist;
            //        }
            //    }
            //    else
            //    {
            //        continue;
            //    }
            //}
            //Console.Clear();
            //Console.WriteLine($"The Longest Distance Is {MaxD}");
            #endregion

            #region 18- Given a list of space separated words, reverse the order of the words.
            //Console.Write("Enter the Words : ");
            //string words = Console.ReadLine();

            //string[] Rev_Words = words.Split(" ");
            //Array.Reverse(Rev_Words);

            //Console.WriteLine(string.Join(" ", Rev_Words));


            #endregion

            #region 19- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.

            //int[,] Matrix1 = new int[3, 3];
            //int[,] Matrix2 = new int[3, 3];

            //for (int i = 0; i < 3; i++) // Represent Rows.
            //{
            //    for (int j = 0; j < 3; j++) // Represent Cols.
            //    {
            //        Console.Write($"Enter Element At {i} {j} in Matrix 1 : ");
            //        int.TryParse(Console.ReadLine(), out Matrix1[i, j]);
            //    }
            //}

            //for (int i = 0; i < 3; i++) // Represent Rows.
            //{
            //    for (int j = 0; j < 3; j++) // Represent Cols.
            //    {
            //        Matrix2[i, j] = Matrix1[i, j];
            //    }
            //}
            //Console.Clear();

            //Console.Write($"Element At Matrix 2 :\n");
            //for (int i = 0; i < 3; i++) // Represent Rows.
            //{
            //    for (int j = 0; j < 3 ; j++) // Represent Cols.
            //    {
            //        Console.Write($"\t{Matrix2[i, j]}");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region 20- Write a Program to Print One Dimensional Array in Reverse Order
            //int[] arr = new int[] { 1, 2, 3 ,4 ,5 };

            //Array.Reverse(arr);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"{arr[i]} ");
            //}

            #endregion
        }
    }
}
