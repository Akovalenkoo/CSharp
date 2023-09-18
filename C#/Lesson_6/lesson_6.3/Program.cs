using System;

class Program
{
    static void Main()
    {
        int[] arr = { 2, 4, 6, 8, 10 };
        int givenNumber = 5;

        int product = 1;

        foreach (int element in arr)
        {
            if (element > givenNumber)
            {
                product *= element;
            }
        }
        Console.WriteLine("Добуток елементів більших за " + givenNumber + " дорівнює " + product);
        Console.ReadKey();
    }
}

