using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Початковий масив:");
        PrintArray(array);

        Console.Write("Введіть позицію для видалення (індекс від 0 до " + (array.Length - 1) + "): ");
        if (int.TryParse(Console.ReadLine(), out int position))
        {
            if (position >= 0 && position < array.Length)
            {
                array = RemoveElementAtIndex(array, position);

                Console.WriteLine("Масив після видалення:");
                PrintArray(array);
            }
            else
            {
                Console.WriteLine("Неправильна позиція. Введіть індекс в межах масиву.");
            }
        }
        else
        {
            Console.WriteLine("Неправильний формат вводу.");
        }
    }

    static int[] RemoveElementAtIndex(int[] arr, int index)
    {
        int[] newArray = new int[arr.Length - 1];

        for (int i = 0, j = 0; i < arr.Length; i++)
        {
            if (i != index)
            {
                newArray[j] = arr[i];
                j++;
            }
        }

        return newArray;
    }

    static void PrintArray(int[] arr)
    {
        foreach (int element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}

