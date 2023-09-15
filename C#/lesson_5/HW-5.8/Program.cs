using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[5];

        // Заповнюємо масив числами, введеними користувачем
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Введіть число " + (i + 1) + ": ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                array[i] = number;
            }
            else
            {
                Console.WriteLine("Некоректний ввід. Будь ласка, введіть ціле число.");
                i--; // Повторити введення для цього числа
            }
        }

        if (IsSortedAscending(array))
        {
            Console.WriteLine("Числа впорядковані за зростанням.");
        }
        else if (IsSortedDescending(array))
        {
            Console.WriteLine("Числа впорядковані за спаданням.");
        }
        else
        {
            Console.WriteLine("Числа не впорядковані.");
        }
    }

    static bool IsSortedAscending(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                return false;
            }
        }
        return true;
    }

    static bool IsSortedDescending(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] < arr[i + 1])
            {
                return false;
            }
        }
        return true;
    }
}

