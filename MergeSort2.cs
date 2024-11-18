using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the elements of the array separated by spaces:");
        string input = Console.ReadLine()!;

        int[] array = Array.ConvertAll(input.Split(' '), int.Parse);

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
        int i = left;     
        int j = mid + 1;   
        int k = 0;        

        int[] temp = new int[right - left + 1]; 

        while (i <= mid && j <= right)
        {
            if (array[i] <= array[j])
                temp[k++] = array[i++];
            else
                temp[k++] = array[j++];
        }

        while (i <= mid)
            temp[k++] = array[i++];

        while (j <= right)
            temp[k++] = array[j++];

        for (k = 0; k < temp.Length; k++)
            array[left + k] = temp[k];
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
