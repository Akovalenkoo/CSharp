using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array1 = { 1, 2, 3 };
        int[] array2 = { 4, 5, 6 };

        int[] combinedArray = CombineArrays(array1, array2);

        Console.WriteLine("Підсумковий масив:");
        foreach (int element in combinedArray)
        {
            Console.Write(element + " ");
        }
    }

    static int[] CombineArrays(int[] arr1, int[] arr2)
    {
        int length = arr1.Length + arr2.Length;
        int[] combinedArray = new int[length];

        for (int i = 0; i < arr1.Length; i++)
        {
            combinedArray[i] = arr1[i];
        }

        for (int i = 0; i < arr2.Length; i++)
        {
            combinedArray[i + arr1.Length] = arr2[i];
        }

        return combinedArray;
    }
}

