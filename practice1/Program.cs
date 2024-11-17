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
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        for (int i = 0; i < n1; i++)
            leftArray[i] = array[left + i];
        for (int i = 0; i < n2; i++)
            rightArray[i] = array[mid + 1 + i];

        int iLeft = 0, iRight = 0, k = left;

        while (iLeft < n1 && iRight < n2)
        {
            if (leftArray[iLeft] <= rightArray[iRight])
            {
                array[k] = leftArray[iLeft];
                iLeft++;
            }
            else
            {
                array[k] = rightArray[iRight];
                iRight++;
            }
            k++;
        }

        while (iLeft < n1)
        {
            array[k] = leftArray[iLeft];
            iLeft++;
            k++;
        }

        while (iRight < n2)
        {
            array[k] = rightArray[iRight];
            iRight++;
            k++;
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
