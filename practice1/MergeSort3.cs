using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the elements of the array separated by spaces:");
        // string input = Console.ReadLine() ?? string.Empty;
        int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        // int[] array = Array.ConvertAll(input.Split(' '), int.Parse);

        Console.WriteLine("Array before sorting:");
        PrintArray(array);

        MergeSort(array, 0, array.Length - 1);

        Console.WriteLine("Array after sorting:");
        PrintArray(array);
    }

    static void MergeSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            MergeSort(array, left, mid);
            MergeSort(array, mid + 1, right);
            Merge(array, left, mid, right);
        }
    }
    static void Merge(int[] array, int left, int mid, int right)
    {
        int i = left, j = mid + 1;

        while (i <= mid && j <= right)
        {
            if (array[i] <= array[j]) i++;
            
            else {
                int temp = array[j];
                int k = j;

                while (k > i)
                {
                    array[k] = array[k - 1];
                    k--;
                }
                array[i] = temp;

                i++; mid++; j++;
            }
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}