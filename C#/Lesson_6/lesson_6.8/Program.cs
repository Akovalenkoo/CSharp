using System;

class Program
{
    static int[][] grades = new int[3][]; // Масив масивів для оцінок з трьох предметів

    static void Main()
    {
        InitializeData();

        while (true)
        {
            Console.WriteLine(@"
1. Ввести оцінки з математики
2. Ввести оцінки з історії
3. Ввести оцінки з фізики
4. Обчислити середню оцінку
5. Вийти
Виберіть опцію:");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    EnterGrades(0); // Математика
                    break;
                case "2":
                    EnterGrades(1); // Історія
                    break;
                case "3":
                    EnterGrades(2); // Фізика
                    break;
                case "4":
                    CalculateAndDisplayAverage();
                    break;
                case "5":
                    Console.WriteLine("Вихід з програми");
                    return;
                default:
                    Console.WriteLine("Невірний вибір опції");
                    break;
            }
        }
        Console.ReadKey();
    }

    static void InitializeData()
    {
        grades[0] = new int[5]; // Початковий розмір масиву для математики
        grades[1] = new int[5]; // Початковий розмір масиву для історії
        grades[2] = new int[5]; // Початковий розмір масиву для фізики
    }

    static void EnterGrades(int subjectIndex)
    {
        string[] subjects = { "математики", "історії", "фізики" };
        Console.WriteLine($"Введіть оцінки з {subjects[subjectIndex]}:");

        for (int i = 0; i < grades[subjectIndex].Length; i++)
        {
            Console.Write($"Оцінка {i + 1}: ");
            if (int.TryParse(Console.ReadLine(), out int grade))
            {
                grades[subjectIndex][i] = grade;
            }
            else
            {
                Console.WriteLine("Невірний формат оцінки. Будь ласка, введіть числову оцінку.");
                i--; // Спробувати ще раз для того ж індексу
            }
        }
    }

    static void CalculateAndDisplayAverage()
    {
        string[] subjects = { "математики", "історії", "фізики" };

        for (int i = 0; i < grades.Length; i++)
        {
            double sum = 0;
            int count = 0;

            foreach (int grade in grades[i])
            {
                sum += grade;
                if (grade != 0) // Ігноруємо нульові оцінки
                {
                    count++;
                }
            }

            double average = count > 0 ? sum / count : 0;
            Console.WriteLine($"Середня оцінка з {subjects[i]}: {average:F2}");
        }
    }
}
