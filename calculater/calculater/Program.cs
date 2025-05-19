using System;

class Calculater
{
    static void Main()
    {
        Console.WriteLine("Простой калькулятор");
        Console.WriteLine("-------------------");

        double number1 = ReadDouble("Введите первое число: ");

        double number2 = ReadDouble("Введите второе число: ");

        // Выбор операции
        Console.WriteLine("Выберите операцию:");
        Console.WriteLine(" +  - сложение");
        Console.WriteLine(" -  - вычитание");
        Console.WriteLine(" *  - умножение");
        Console.WriteLine(" /  - деление");
        Console.WriteLine(" %  - остаток от деления");
        Console.WriteLine(" ++ - инкремент (увеличение первого числа на 1)");
        Console.WriteLine(" -- - декремент (уменьшение первого числа на 1)");
        Console.Write("Введите операцию: ");
        string operation = Console.ReadLine();

        double result;
        bool validOperation = true;

        switch (operation)
        {
            case "+":
                result = number1 + number2;
                Console.WriteLine($"{number1} + {number2} = {result}");
                break;

            case "-":
                result = number1 - number2;
                Console.WriteLine($"{number1} - {number2} = {result}");
                break;

            case "*":
                result = number1 * number2;
                Console.WriteLine($"{number1} * {number2} = {result}");
                break;

            case "/":
                if (number2 == 0)
                {
                    Console.WriteLine("Ошибка: деление на ноль невозможно.");
                }
                else
                {
                    result = number1 / number2;
                    Console.WriteLine($"{number1} / {number2} = {result}");
                }
                break;

            case "%":
                if (number2 == 0)
                {
                    Console.WriteLine("Ошибка: деление на ноль невозможно.");
                }
                else
                {
                    result = number1 % number2;
                    Console.WriteLine($"Остаток от деления {number1} % {number2} = {result}");
                }
                break;

            case "++":
                result = number1 + 1;
                Console.WriteLine($"Инкремент: {number1}++ = {result}");
                break;

            case "--":
                result = number1 - 1;
                Console.WriteLine($"Декремент: {number1}-- = {result}");
                break;

            default:
                Console.WriteLine("Ошибка: неизвестная операция.");
                validOperation = false;
                break;
        }

       
    }

    static double ReadDouble(string prompt)
    {
        double value;
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            if (double.TryParse(input, out value))
                return value;
            else
                Console.WriteLine("Ошибка: введите корректное число.");
        }
    }
}
