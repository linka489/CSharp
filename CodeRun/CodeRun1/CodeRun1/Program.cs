using System;

public class Tasks
{
    public static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');

        if (input.Length != 2)
        {
            Console.WriteLine("Ошибка: Необходимо ввести два числа.");
            return;
        }

        if (!long.TryParse(input[0], out long a) || !long.TryParse(input[1], out long b))
        {
            Console.WriteLine("Ошибка: Неверный формат ввода. Введите целые числа.");
            return;
        }

        Console.WriteLine(a + b);
    }
}
