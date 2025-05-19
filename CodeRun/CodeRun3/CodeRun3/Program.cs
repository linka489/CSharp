using System;
using System.Linq;

public class BiggerThanNeighbors
{
    public static void Main(string[] args)
    {
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int count = 0;

        for (int i = 1; i < numbers.Length - 1; i++)
        {
            if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}
