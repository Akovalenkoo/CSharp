using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            double oper1, oper2, result;
            Operation operation;

            Console.Write("Введіть перший операнд: ");
            oper1 = GetDoubleNumber();
            Console.Write("Введіть другий операнд: ");
            oper2 = GetDoubleNumber();
            Console.Write("Введіть операцію 1 - +, 2 - -, 3 - *, 4 - /: ");
            operation = GetOperation();

            if (IsValidOperation(operation))
            {
                result = DoOperation(oper1, oper2, operation);
                Console.WriteLine("{0} {1} {2} = {3}", oper1, GetOperationSymbol(operation), oper2, result);
            }
            else
            {
                Console.WriteLine("Некоректна операція.");
            }
            Console.ReadKey();
        }

        static Operation GetOperation()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (Enum.TryParse(input, out Operation operation))
                {
                    return operation;
                }
                Console.Write("Введіть коректну операцію (1-4): ");
            }
        }

        static bool IsValidOperation(Operation operation)
        {
            return operation == Operation.Add || operation == Operation.Subtract ||
                   operation == Operation.Multiply || operation == Operation.Divide;
        }

        static double GetDoubleNumber()
        {
            double number;
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Введіть коректне число: ");
            }
            return number;
        }

        static string GetOperationSymbol(Operation operation)
        {
            switch (operation)
            {
                case Operation.Add:
                    return "+";
                case Operation.Subtract:
                    return "-";
                case Operation.Multiply:
                    return "*";
                case Operation.Divide:
                    return "/";
                default:
                    throw new ArgumentException();
            }
            Console.ReadKey();
        }

        static double DoOperation(double oper1, double oper2, Operation operation)
        {
            switch (operation)
            {
                case Operation.Add:
                    return oper1 + oper2;
                case Operation.Subtract:
                    return oper1 - oper2;
                case Operation.Multiply:
                    return oper1 * oper2;
                case Operation.Divide:
                    if (oper2 == 0)
                    {
                        Console.WriteLine("Ділення на нуль недопустиме.");
                        Environment.Exit(1);
                    }
                    return oper1 / oper2;
                default:
                    throw new ArgumentException();
            }
            Console.ReadKey();
        }
    }

    enum Operation
    {
        Add = 1,
        Subtract = 2,
        Multiply = 3,
        Divide = 4
    }
}
