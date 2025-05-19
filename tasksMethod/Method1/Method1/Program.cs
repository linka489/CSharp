using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите числа через пробел:");
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');
        int sum = 0;

        for (int i = 0; i < parts.Length; i++)
        {
            int number;
            if (int.TryParse(parts[i], out number))
            {
                sum += number;
            }
        }

        Console.WriteLine("Сумма чисел: " + sum);
    }
}
