using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();
        string text = input.Replace(" ", "").ToLower();

        bool isPalindrome = true;

        for (int i = 0; i < text.Length / 2; i++)
        {
            if (text[i] != text[text.Length - 1 - i])
            {
                isPalindrome = false;
                break;
            }
        }

        if (isPalindrome)
        {
            Console.WriteLine("Это палиндром.");
        }
        else
        {
            Console.WriteLine("Это не палиндром.");
        }
    }
}