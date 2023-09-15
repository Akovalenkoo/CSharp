using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 3, 7, 2, 9, -1, 5, 8, 1 };

        Console.WriteLine("Елементи масиву до першого зустріченого -1:");
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == -1)
                break;

            Console.WriteLine(array[i]);
        }
        Console.ReadKey();
    }
}

