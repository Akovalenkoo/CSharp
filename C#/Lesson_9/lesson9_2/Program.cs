using System;

public class User
{
    // Поля, що містять інформацію про користувача
    private string login;
    private string firstName;
    private string lastName;
    private int age;
    private readonly DateTime registrationDate; // Поле для дати заповнення анкети

    // Конструктор класу
    public User(string login, string firstName, string lastName, int age)
    {
        this.login = login;
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.registrationDate = DateTime.Now; // Ініціалізація дати заповнення анкети
    }

    // Метод для виведення інформації про користувача на екран
    public void DisplayUserInfo()
    {
        Console.WriteLine("Інформація про користувача:");
        Console.WriteLine($"Логін: {login}");
        Console.WriteLine($"Ім'я: {firstName}");
        Console.WriteLine($"Прізвище: {lastName}");
        Console.WriteLine($"Вік: {age}");
        Console.WriteLine($"Дата заповнення анкети: {registrationDate}");
        Console.ReadKey();
    }
}

class Program
{
    static void Main()
    {
        // Приклад використання класу User
        User newUser = new User("users", "Sasha", "Kovalenko", 25);

        // Виведення інформації про користувача на екран
        newUser.DisplayUserInfo();
    }
}

