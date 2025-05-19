using System;

public class task1
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Упражнение 1: Банковский вклад (цикл for) ---");

        Console.Write("Введите начальную сумму вклада: ");
        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Введите количество месяцев: ");
        int numberOfMonths = Convert.ToInt32(Console.ReadLine());

        decimal monthlyInterestRate = 0.07m; 

        for (int month = 1; month <= numberOfMonths; month++)
        {
            
            decimal monthlyInterest = depositAmount * monthlyInterestRate;
            depositAmount += monthlyInterest;
            Console.WriteLine($"Месяц {month}: начислено {monthlyInterest:C}, сумма стала {depositAmount:C}");
        }

        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine($"Конечная сумма вклада через {numberOfMonths} месяцев: {depositAmount:C}");
        Console.WriteLine("-------------------------------------------------");

        Console.WriteLine("Нажмите Enter для завершения...");
        Console.ReadLine(); 
    }
}
