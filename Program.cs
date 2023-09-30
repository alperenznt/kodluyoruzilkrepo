using System;
public class Example
{
    static void Main(string[] args)
    {
        int[] arr = new int[6] { 22, 27, 16, 2, 18, 6 };
        int n = 6;
        Console.WriteLine("Selection sort");
        Console.Write("Initial array is: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
        int temp, smallest;
        for (int i = 0; i < n - 1; i++)
        {
            smallest = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[smallest])
                {
                    smallest = j;
                }
            }
            temp = arr[smallest];
            arr[smallest] = arr[i];
            arr[i] = temp;
        }
        Console.WriteLine();
        Console.Write("Sorted array is: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}