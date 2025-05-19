using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите числа через пробел:");
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');

        int max = int.MinValue;

        for (int i = 0; i < parts.Length; i++)
        {
            int number;
            if (int.TryParse(parts[i], out number))
            {
                if (number > max)
                {
                    max = number;
                }
            }
        }

        Console.WriteLine("Максимальное число: " + max);
    }
}
