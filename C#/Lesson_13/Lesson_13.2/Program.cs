using System;

public static class MathUtility
{
    public static int Додавання(int a, int b)
    {
        return a + b;
    }

    public static int Віднімання(int a, int b)
    {
        return a - b;
    }

    public static int Множення(int a, int b)
    {
        return a * b;
    }

    public static int Ділення(int a, int b)
    {
        if (b == 0)
        {
            throw new ArgumentException("Ділення на нуль неможливе.");
        }
        return a / b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 5;

        try
        {
            int resultAddition = MathUtility.Додавання(a, b);
            int resultSubtraction = MathUtility.Віднімання(a, b);
            int resultMultiplication = MathUtility.Множення(a, b);
            int resultDivision = MathUtility.Ділення(a, b);

            Console.WriteLine($"Додавання: {a} + {b} = {resultAddition}");
            Console.WriteLine($"Віднімання: {a} - {b} = {resultSubtraction}");
            Console.WriteLine($"Множення: {a} * {b} = {resultMultiplication}");
            Console.WriteLine($"Ділення: {a} / {b} = {resultDivision}");
            Console.ReadLine();
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Помилка: {e.Message}");
            Console.ReadLine();
        }
    }
}

