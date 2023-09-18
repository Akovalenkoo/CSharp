using System;

class Program
{
    static void Main()
    {
        string[] surnames = new string[]
        {
            "Сидоренко",
            "Петров",
            "Андрущенко",
            "Коваленко"
        };

        Array.Sort(surnames);

        foreach (string name in surnames)
        {
            Console.WriteLine(name);
        }
        Console.ReadKey();
    }
}

