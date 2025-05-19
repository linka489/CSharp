using System;

public class Program
{
    public static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');

        if (input.Length != 3)
        {
            Console.WriteLine("Ошибка: Необходимо ввести три числа.");
            return;
        }

        if (!int.TryParse(input[0], out int a) || !int.TryParse(input[1], out int b) || !int.TryParse(input[2], out int c) || a <= 0 || b <= 0 || c <= 0)
        {
            Console.WriteLine("Ошибка: Неверный формат ввода. Введите три положительных целых числа.");
            return;
        }


        if (a + b > c && a + c > b && b + c > a)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}
