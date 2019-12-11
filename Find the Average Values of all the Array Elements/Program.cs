using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class program
{
    public void sumAverageElements(int[] arr, int size)////In this C# program, we are reading the size of an array using ‘size’ variable. Using for loop we are entering the coefficient values of an array.///
    {

        int sum = 0;
        int average = 0;
        for (int i = 0; i < size; i++)
        {
            sum += arr[i];
        }
        average = sum / size;
        Console.WriteLine("Sum Of Array is : " + sum);
        Console.WriteLine("Average Of Array is : " + average);
        Console.ReadLine();
    }
    public static void Main(string[] args)///The sumAverageElements() function is used to compute the sum of coefficient value. Find the value of ‘average’ variable by dividing the value of ‘sum’ variable by the value of ‘size’ variable. Print the average values of all the array elements.///
    {
        int size;
        Console.WriteLine("Enter the Size :");
        size = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[size];
        Console.WriteLine("Enter the Elements of the Array : ");
        for (int i = 0; i < size; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        int len = a.Length;
        program pg = new program();
        pg.sumAverageElements(a, len);
    }
}
///Output:
///Enter the size: 5
///Enter the Elements of the Array: {4,2,4,5,6}
///Sum of Array: 21
///Average of the Array is : 4