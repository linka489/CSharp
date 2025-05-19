using System;

class TicTacToe
{
    static char[] board = new char[9];
    static char currentPlayer = 'X';

    static void Main()
    {
        InitializeBoard();

        while (true)
        {
            Console.Clear();
            DisplayBoard();

            Console.WriteLine($"Ход игрока {currentPlayer}. Введите номер ячейки (1-9):");
            int move = GetValidMove();

            board[move - 1] = currentPlayer;

            if (CheckWin(currentPlayer))
            {
                Console.Clear();
                DisplayBoard();
                Console.WriteLine($"Игрок {currentPlayer} выиграл!");
                break;
            }

            if (CheckDraw())
            {
                Console.Clear();
                DisplayBoard();
                Console.WriteLine("Ничья!");
                break;
            }

            SwitchPlayer();
        }
    }

    static void InitializeBoard()
    {
        for (int i = 0; i < board.Length; i++)
        {
            board[i] = (char)('1' + i);
        }
    }

    
    static void DisplayBoard()
    {
        Console.WriteLine();
        Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
        Console.WriteLine();
    }

    static int GetValidMove()
    {
        while (true)
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int move))
            {
                Console.WriteLine("Ошибка: введите число от 1 до 9.");
                continue;
            }

            if (move < 1 || move > 9)
            {
                Console.WriteLine("Ошибка: номер ячейки должен быть от 1 до 9.");
                continue;
            }

            if (board[move - 1] == 'X' || board[move - 1] == 'O')
            {
                Console.WriteLine("Ошибка: эта ячейка уже занята. Выберите другую.");
                continue;
            }

            return move;
        }
    }

    static bool CheckWin(char player)
    {
        int[,] winPositions = new int[,]
        {
            {0,1,2}, {3,4,5}, {6,7,8}, 
            {0,3,6}, {1,4,7}, {2,5,8}, 
            {0,4,8}, {2,4,6}           
        };

        for (int i = 0; i < winPositions.GetLength(0); i++)
        {
            if (board[winPositions[i, 0]] == player &&
                board[winPositions[i, 1]] == player &&
                board[winPositions[i, 2]] == player)
            {
                return true;
            }
        }

        return false;
    }

    
    static bool CheckDraw()
    {
        foreach (char c in board)
        {
            if (c != 'X' && c != 'O')
                return false;
        }
        return true;
    }

    
    static void SwitchPlayer()
    {
        currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
    }
}
