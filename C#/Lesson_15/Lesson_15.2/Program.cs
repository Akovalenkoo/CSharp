using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Олена", Grade = 95, Course = 1 },
            new Student { Name = "Іван", Grade = 88, Course = 2 },
            new Student { Name = "Марія", Grade = 92, Course = 1 },
            new Student { Name = "Петро", Grade = 85, Course = 2 },
            new Student { Name = "Анна", Grade = 90, Course = 3 },
            new Student { Name = "Максим", Grade = 89, Course = 3 }
        };

        var highScoringStudents = students.Where(student => student.Grade >= 90);
        Console.WriteLine("Фільтрація (студенти з оцінкою 90 і вище):");
        foreach (var student in highScoringStudents)
        {
            Console.WriteLine($"Ім'я: {student.Name}, Оцінка: {student.Grade}");
        }

        var sortedStudents = students.OrderByDescending(student => student.Grade);
        Console.WriteLine("\nСортування (студенти за оцінкою в спадаючому порядку):");
        foreach (var student in sortedStudents)
        {
            Console.WriteLine($"Ім'я: {student.Name}, Оцінка: {student.Grade}");
        }

        var groupedByCourse = students.GroupBy(student => student.Course);
        Console.WriteLine("\nГрупування студентів за курсами:");
        foreach (var group in groupedByCourse)
        {
            Console.WriteLine($"Курс {group.Key}:");
            foreach (var student in group)
            {
                Console.WriteLine($"Ім'я: {student.Name}, Оцінка: {student.Grade}");
            }
        }

        var countByCourse = students.GroupBy(student => student.Course)
                                    .Select(group => new { Course = group.Key, Count = group.Count() });
        Console.WriteLine("\nПідрахунок студентів на кожному курсі:");
        foreach (var item in countByCourse)
        {
            Console.WriteLine($"Курс {item.Course}: {item.Count} студентів");
        }

        var projection = students.Select(student => $"Ім'я: {student.Name}, Оцінка: {student.Grade}");
        Console.WriteLine("\nПроекція (рядки з ім'ям та оцінкою кожного студента):");
        foreach (var item in projection)
        {
            Console.WriteLine(item);
            Console.ReadLine();
        }
    }
}

class Student
{
    public string Name { get; set; }
    public int Grade { get; set; }
    public int Course { get; set; }
}

