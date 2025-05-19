using System;

public class TaggingTasks
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        if (n < 1 || n > 92) 
        {
            Console.WriteLine("Ошибка: Количество задач должно быть от 1 до 92 (ограничение типа long).");
            return;
        }

        long totalTime = 2;
        long t1 = 1;
        long t2 = 1;

        for (int i = 3; i <= n; i++)
        {
            long t = t1 + t2;
            totalTime += t;
            t2 = t1;
            t1 = t;
        }

        Console.WriteLine(totalTime);
    }
}

