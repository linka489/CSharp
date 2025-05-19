using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите числа через пробел:");
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');

        string result = "";

        for (int i = 0; i < parts.Length; i++)
        {
            int number;
            if (int.TryParse(parts[i], out number))
            {
                if (!result.Contains(parts[i] + " "))
                {
                    result += parts[i] + " ";
                }
            }
        }

        Console.WriteLine("Список без дубликатов:");
        Console.WriteLine(result.Trim());
    }
}