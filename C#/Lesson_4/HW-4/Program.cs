using System;

class Program
{
    static void Main()
    {
        string correctPassword = "root";
        string enteredPassword;

        do
        {
            Console.Write("Введіть пароль: ");
            enteredPassword = Console.ReadLine();

            if (enteredPassword != correctPassword)
            {
                Console.WriteLine("Неправильний пароль!");
            }

        } while (enteredPassword != correctPassword);

        Console.WriteLine("Ви увійшли в систему!");
        Console.ReadKey();
    }
}
