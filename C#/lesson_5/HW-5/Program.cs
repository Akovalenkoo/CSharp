using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[10];
        Random random = new Random();

        FillArrayWithRandomNumbers(array, random);
        PrintArray(array);

        int randomElement = random.Next(1, 100);
        AddElementToBeginning(array, randomElement);
        PrintArray(array);
    }

    static void FillArrayWithRandomNumbers(int[] arr, Random random)
    {
        for (int i = 0; i < arr.Length; i++)
            arr[i] = random.Next(1, 100);
    }

    static void PrintArray(int[] arr)
    {
        Console.WriteLine("Елементи масиву: " + string.Join(" ", arr));
    }

    static void AddElementToBeginning(int[] arr, int element)
    {
        Array.Resize(ref arr, arr.Length + 1);
        for (int i = arr.Length - 1; i > 0; i--)
            arr[i] = arr[i - 1];
        arr[0] = element;

        Console.ReadKey();
    }
}

