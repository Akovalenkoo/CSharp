using System;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            { 1, -2, 3 },
            { -4, 5, -6 },
            { 7, -8, 9 }
        };

        int positiveCount = 0;
        int negativeCount = 0;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                int element = matrix[row, column];
                if (element > 0)
                {
                    positiveCount++;
                }
                else if (element < 0)
                {
                    negativeCount++;
                }
            }
        }

        Console.WriteLine("Positive count: " + positiveCount);
        Console.WriteLine("Negative count: " + negativeCount);
        Console.ReadKey();
    }
}

