using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    internal class Program
    {

        static void MoveFigureDown(ref bool[,] board, int[] figure1, int[] figure2, int[] figure3, int[] figure4)
        {
            
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
            }

            
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
            
        Reset:
            

            Console.Clear();
            DrawBoard(board, figure1, figure2, figure3, figure4);
            MoveFigureDown(ref board, figure1, figure2, figure3, figure4);
            
            Console.ReadKey();
            goto Reset;


        }
    }
}
