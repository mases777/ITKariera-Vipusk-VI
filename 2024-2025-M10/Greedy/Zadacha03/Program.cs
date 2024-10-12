using Microsoft.VisualBasic;
using System;

namespace Zadacha03
{
    internal class Program
    {
        const int N = 8;

        static void Print(int[,] board)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    var symbol = board[i, j] == 1 ? "Q" : ".";
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }

        static bool Place(int[,] board, int row, int col)
        {
            int i, j;
            for (i = 0; i < col; i++)
                if (board[row, i] == 1) return false;
            for (i = row, j = col; i >= 0 && j >= 0; i--, j--)
                if (board[i, j] == 1) return false;
            for (i = row, j = col; j >= 0 && i < N; i++, j--)
                if (board[i, j] == 1) return false;
            return true;
        }

        static bool Solve(int[,] board, int col)
        {
            if (col >= N) return true;
            for (int i = 0; i < N; i++)
            {
                if (Place(board, i, col) == true)
                {
                    board[i, col] = 1;
                    if (Solve(board, col + 1)) return true;
                    board[i, col] = 0;
                }
            }
            return false;
        }
        
        static void Main(string[] args)
        {
            int[,] board = new int[N, N];
            if (!Solve(board, 0))
            {
                Console.WriteLine("Solution Not Found.");
            }
            else
            {
                Print(board);
            }
        }
    }
}
