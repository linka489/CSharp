using System;

public class task2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Упражнение 2: Банковский вклад (цикл while) ---");

        Console.Write("Введите начальную сумму вклада: ");
        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Введите количество месяцев: ");
        int numberOfMonths = Convert.ToInt32(Console.ReadLine());


        decimal monthlyInterestRate = 0.07m;

        Console.WriteLine($"Начальная сумма: {depositAmount:C}");

       
        int monthCounter = 1; 

        while (monthCounter <= numberOfMonths)
        {
      
            decimal monthlyInterest = depositAmount * monthlyInterestRate;
           
            depositAmount += monthlyInterest;
            Console.WriteLine($"Месяц {monthCounter}: начислено {monthlyInterest:C}, сумма стала {depositAmount:C}");

          
            monthCounter++;
        }

        
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine($"Конечная сумма вклада через {numberOfMonths} месяцев: {depositAmount:C}");
        Console.WriteLine("-------------------------------------------------");

        Console.WriteLine("Нажмите Enter для завершения...");
        Console.ReadLine();
    }
}