using System;

public class task4
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Упражнение 4: Умножение с проверкой ввода ---");

        while (true)
        {
            Console.WriteLine("Введите два числа от 0 до 10.");

            
            Console.Write("Введите первое число: ");
            string input1 = Console.ReadLine();
            int num1;

            
            if (!int.TryParse(input1, out num1))
            {
                Console.WriteLine("Неверный ввод для первого числа. Введите целое число.");
                Console.WriteLine("Повторите ввод обоих чисел.");
                continue; 
            }

            
            Console.Write("Введите второе число: ");
            string input2 = Console.ReadLine();
            int num2;

            
            if (!int.TryParse(input2, out num2))
            {
                Console.WriteLine("Неверный ввод для второго числа. Введите целое число.");
                Console.WriteLine("Повторите ввод обоих чисел.");
                continue; 
            }

            
            if (num1 >= 0 && num1 <= 10 && num2 >= 0 && num2 <= 10)
            {
                
                int result = num1 * num2;
                Console.WriteLine($"Результат умножения: {num1} * {num2} = {result}");
                break; 
            }
            else
            {
                
                Console.WriteLine("Введенные числа недопустимы. Оба числа должны быть от 0 до 10.");
                Console.WriteLine("Повторите ввод обоих чисел.");
                
            }
            Console.WriteLine(); 
        } 

        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("Программа завершена. Нажмите Enter для выхода...");
        Console.ReadLine();
    }
}
