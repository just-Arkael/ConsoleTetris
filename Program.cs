using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    internal class Program
    {

        static void NextFigure(ref int[] figure1, ref int[] figure2, ref int[] figure3, ref int[] figure4, ref byte newFigure, ref Random rand)
        {

            switch (newFigure)
            {

                case 0:
                    figure1[0] = 3;
                    figure1[1] = 0;
                    figure2[0] = 4;
                    figure2[1] = 0;
                    figure3[0] = 5;
                    figure3[1] = 0;
                    figure4[0] = 6;
                    figure4[1] = 0;
                    break;
                case 1:
                    figure1[0] = 4;
                    figure1[1] = 0;
                    figure2[0] = 4;
                    figure2[1] = 1;
                    figure3[0] = 5;
                    figure3[1] = 1;
                    figure4[0] = 6;
                    figure4[1] = 1;
                    break;
                case 2:
                    figure1[0] = 6;
                    figure1[1] = 0;
                    figure2[0] = 4;
                    figure2[1] = 1;
                    figure3[0] = 5;
                    figure3[1] = 1;
                    figure4[0] = 6;
                    figure4[1] = 1;
                    break;
                case 3:
                    figure1[0] = 4;
                    figure1[1] = 0;
                    figure2[0] = 4;
                    figure2[1] = 1;
                    figure3[0] = 5;
                    figure3[1] = 0;
                    figure4[0] = 5;
                    figure4[1] = 1;
                    break;
                case 4:
                    figure1[0] = 5;
                    figure1[1] = 0;
                    figure2[0] = 6;
                    figure2[1] = 0;
                    figure3[0] = 4;
                    figure3[1] = 1;
                    figure4[0] = 5;
                    figure4[1] = 1;
                    break;
                case 5:
                    figure1[0] = 5;
                    figure1[1] = 0;
                    figure2[0] = 4;
                    figure2[1] = 1;
                    figure3[0] = 5;
                    figure3[1] = 1;
                    figure4[0] = 6;
                    figure4[1] = 1;
                    break;
                case 6:
                    figure1[0] = 4;
                    figure1[1] = 0;
                    figure2[0] = 5;
                    figure2[1] = 0;
                    figure3[0] = 5;
                    figure3[1] = 1;
                    figure4[0] = 6;
                    figure4[1] = 1;
                    break;
                case 7:
                    figure1[0] = 5;
                    figure1[1] = 0;
                    figure2[0] = 6;
                    figure2[1] = 0;
                    figure3[0] = 4;
                    figure3[1] = 0;
                    figure4[0] = 5;
                    figure4[1] = 1;
                    break;
                case 8:
                    figure1[0] = 4;
                    figure1[1] = 0;
                    figure2[0] = 5;
                    figure2[1] = 0;
                    figure3[0] = 6;
                    figure3[1] = 0;
                    figure4[0] = 4;
                    figure4[1] = 1;
                    break;
                case 9:
                    figure1[0] = 4;
                    figure1[1] = 0;
                    figure2[0] = 5;
                    figure2[1] = 0;
                    figure3[0] = 6;
                    figure3[1] = 0;
                    figure4[0] = 6;
                    figure4[1] = 1;
                    break;

            }
            newFigure = (byte)rand.Next(9);

        }
        static void MoveFigureLeft(bool[,] board, int[] figure1, int[] figure2, int[] figure3, int[] figure4)
        {
            if (figure1[0] > 0 && board[figure1[0], figure1[1]] == false && figure2[0] > 0 && board[figure2[0], figure2[1]] == false && figure3[0] > 0 && board[figure3[0], figure3[1]] == false && figure4[0] > 0 && board[figure4[0], figure4[1]] == false)
            {
                figure1[0]--;
                figure2[0]--;
                figure3[0]--;
                figure4[0]--;
            }
        }
        static void MoveFigureRight(bool[,] board, int[] figure1, int[] figure2, int[] figure3, int[] figure4)
        {
            if (figure1[0] < 9 && board[figure1[0], figure1[1]] == false && figure2[0] < 9 && board[figure2[0], figure2[1]] == false && figure3[0] < 9 && board[figure3[0], figure3[1]] == false && figure4[0] < 9 && board[figure4[0], figure4[1]] == false)
            {
                figure1[0]++;
                figure2[0]++;
                figure3[0]++;
                figure4[0]++;
            }
        }

        static bool MoveFigureDown(ref bool[,] board, int[] figure1, int[] figure2, int[] figure3, int[] figure4)
        {
            bool result = true;
            if (figure1[1] < 19 && board[figure1[0], figure1[1] + 1] == false && figure2[1] < 19 && board[figure2[0], figure2[1] + 1] == false && figure3[1] < 19 && board[figure3[0], figure3[1] + 1] == false && figure4[1] < 19 && board[figure4[0], figure4[1] + 1] == false)
            {

                figure1[1]++;
                figure2[1]++;
                figure3[1]++;
                figure4[1]++;
                
            }
            else
            {
                board[figure1[0], figure1[1]] = true;
                board[figure2[0], figure2[1]] = true;
                board[figure3[0], figure3[1]] = true;
                board[figure4[0], figure4[1]] = true;
                result = false;
            }

            return result;
        }


        static void DrawBoard(bool[,] board, int[] figure1, int[] figure2, int[] figure3, int[] figure4)
        {

            Console.WriteLine();
            for (byte i = 0; i < 20; i++)
            {
                Console.Write("          ");
                for (byte j = 0; j < 10; j++)
                {
                    if (board[j, i] == true || j == figure1[0] && i == figure1[1] || j == figure2[0] && i == figure2[1] || j == figure3[0] && i == figure3[1] || j == figure4[0] && i == figure4[1])
                    {
                        if (board[j, i] != true)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        Console.Write("[]");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write("..");
                    }
                }
                
                Console.Write("\n");

            }

        }








        static void Main(string[] args)
        {
            bool[,] board = new bool[10, 20];

            Random rand = new Random();
            int[] figure1 = { 5, 0 };
            int[] figure2 = { 4, 1 };
            int[] figure3 = { 5, 1 };
            int[] figure4 = { 6, 1 };
            byte newFigure = (byte)rand.Next(9);


        Reset:
            

            Console.Clear();
            DrawBoard(board, figure1, figure2, figure3, figure4);
            if (MoveFigureDown(ref board, figure1, figure2, figure3, figure4) == false)
            {
                NextFigure(ref figure1, ref figure2, ref figure3, ref figure4, ref newFigure, ref rand);
            }

            switch (Console.ReadKey().Key)
            {

                case ConsoleKey.D:
                    MoveFigureRight(board, figure1, figure2, figure3, figure4);
                    break;
                case ConsoleKey.A:
                    MoveFigureLeft(board, figure1, figure2, figure3, figure4);
                    break;
            }
            goto Reset;


        }
    }
}
