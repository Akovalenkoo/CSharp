using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> contacts = new Dictionary<string, string>();

        while (true)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Додати новий контакт");
            Console.WriteLine("2. Видалити контакт");
            Console.WriteLine("3. Знайти контакт за ім'ям");
            Console.WriteLine("4. Вивести всі контакти");
            Console.WriteLine("5. Завершити програму");
            Console.ReadLine();

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Введіть ім'я контакту: ");
                    string name = Console.ReadLine();
                    Console.Write("Введіть номер телефону: ");
                    string phoneNumber = Console.ReadLine();

                    if (!contacts.ContainsKey(name))
                    {
                        contacts[name] = phoneNumber;
                        Console.WriteLine("Контакт додано до словника.");
                    }
                    else
                    {
                        Console.WriteLine("Контакт з таким іменем вже існує.");
                    }
                    break;

                case 2:
                    Console.Write("Введіть ім'я контакту для видалення: ");
                    string nameToRemove = Console.ReadLine();

                    if (contacts.ContainsKey(nameToRemove))
                    {
                        contacts.Remove(nameToRemove);
                        Console.WriteLine("Контакт видалено.");
                    }
                    else
                    {
                        Console.WriteLine("Контакт не знайдено.");
                    }
                    break;

                case 3:
                    Console.Write("Введіть ім'я контакту для пошуку: ");
                    string nameToFind = Console.ReadLine();

                    if (contacts.ContainsKey(nameToFind))
                    {
                        Console.WriteLine($"Номер телефону для контакту {nameToFind}: {contacts[nameToFind]}");
                    }
                    else
                    {
                        Console.WriteLine("Контакт не знайдено.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Список усіх контактів:");
                    foreach (var contact in contacts)
                    {
                        Console.WriteLine($"Ім'я: {contact.Key}, Номер телефону: {contact.Value}");
                    }
                    break;

                case 5:
                    Console.WriteLine("Програма завершила роботу.");
                    return;

                default:
                    Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                    break;
            }
        }
    }
}

