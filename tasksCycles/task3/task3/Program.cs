using System;

public class task3
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Упражнение 3: Таблица умножения ---");
        Console.WriteLine(); 

        
        for (int i = 1; i <= 9; i++)
        {
            
            for (int j = 1; j <= 9; j++)
            {
                
                int result = i * j;
                
                Console.Write($"{i,3} * {j,3} = {result,3}   ");
            }
            Console.WriteLine(); 
        }

        Console.WriteLine(); 
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Нажмите Enter для завершения...");
        Console.ReadLine();
    }
}