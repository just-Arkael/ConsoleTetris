using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    internal class Program
    {

        static void MoveFigureRotate(bool[,] board, ref int[] figure1, ref int[] figure2, ref int[] figure3, ref int[] figure4)
        {
            int[] myfigure1 = figure1;
            int[] myfigure2 = figure2;
            int[] myfigure3 = figure3;
            int[] myfigure4 = figure4;
            int distanceX;
            int distanceY;

            distanceX = myfigure2[0] - myfigure1[0];
            distanceY = myfigure2[1] - myfigure1[1];
            myfigure1[0] = myfigure2[0] + distanceY;
            myfigure1[1] = myfigure2[1] + distanceX;
            distanceX = myfigure2[0] - myfigure3[0];
            distanceY = myfigure2[1] - myfigure3[1];
            myfigure3[0] = myfigure2[0] + distanceY;
            myfigure3[1] = myfigure2[1] + distanceX;
            distanceX = myfigure2[0] - myfigure4[0];
            distanceY = myfigure2[1] - myfigure4[1];
            myfigure4[0] = myfigure2[0] + distanceY;
            myfigure4[1] = myfigure2[1] + distanceX;

            do
            {
                myfigure1[0]--;
                myfigure2[0]--;
                myfigure3[0]--;
                myfigure4[0]--;

            } while (myfigure1[0] >= 9 || myfigure2[0] >= 9 || myfigure3[0] >= 9 || myfigure4[0] >= 9);
            do
            {
                myfigure1[0]++;
                myfigure2[0]++;
                myfigure3[0]++;
                myfigure4[0]++;

            } while (myfigure1[0] <= 0 || myfigure2[0] <= 0 || myfigure3[0] <= 0 || myfigure4[0] <= 0);
            do
            {
                myfigure1[1]--;
                myfigure2[1]--;
                myfigure3[1]--;
                myfigure4[1]--;

            } while (myfigure1[1] >= 19 || myfigure2[1] >= 19 || myfigure3[1] >= 19 || myfigure4[1] >= 19);
            do
            {
                myfigure1[1]++;
                myfigure2[1]++;
                myfigure3[1]++;
                myfigure4[1]++;

            } while (myfigure1[1] <= 0 || myfigure2[1] <= 0 || myfigure3[1] <= 0 || myfigure4[1] <= 0);

            if (board[myfigure1[0], myfigure1[1]] == false && board[myfigure2[0], myfigure2[1]] == false && board[myfigure3[0], myfigure3[1]] == false && board[myfigure4[0], myfigure4[1]] == false)
            {
                figure1 = myfigure1;
                figure2 = myfigure2;
                figure3 = myfigure3;
                figure4 = myfigure4;
            }

        }

        static void NextFigure(ref int[] figure1, ref int[] figure2, ref int[] figure3, ref int[] figure4, ref byte newFigure, ref Random rand, ref int score)
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
            score += 10;

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


        static void DrawBoard(bool[,] board, int[] figure1, int[] figure2, int[] figure3, int[] figure4, int newFigure, int score)
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
                switch (i)
                {
                    case 1:
                        Console.Write("     NEXT:");
                        break;
                    case 2:
                        Console.Write("     --------");
                        break;
                    case 3:
                        switch (newFigure)
                        {
                            case 0:
                                Console.Write("    |....[]..|");
                                break;
                            default:
                                Console.Write("    |........|");
                                break;
                        }
                        break;
                    case 4:
                        switch (newFigure)
                        {
                            case 0:
                            case 5:
                                Console.Write("    |....[]..|");
                                break;
                            case 1:
                                Console.Write("    |[]......|");
                                break;
                            case 2:
                                Console.Write("    |......[]|");
                                break;
                            case 3:
                                Console.Write("    |..[][]..|");
                                break;
                            case 4:
                                Console.Write("    |....[][]|");
                                break;
                            case 6:
                                Console.Write("    |[][]....|");
                                break;
                            case 7:
                                Console.Write("    |..[][][]|");
                                break;
                            case 8:
                            case 9:
                                Console.Write("    |[][][][]|");
                                break;

                        }
                        break;
                    case 5:
                        switch (newFigure)
                        {
                            case 0:
                            case 7:
                                Console.Write("    |....[]..|");
                                break;
                            case 1:
                            case 2:
                                Console.Write("    |[][][][]|");
                                break;
                            case 3:
                            case 4:
                            case 6:
                                Console.Write("    |..[][]..|");
                                break;
                            case 5:
                                Console.Write("    |..[][][]|");
                                break;
                            case 8:
                                Console.Write("    |[]......|");
                                break;
                            case 9:
                                Console.Write("    |......[]|");
                                break;

                        }
                        break;
                    case 6:
                        switch (newFigure)
                        {
                            case 0:
                                Console.Write("    |....[]..|");
                                break;
                            default:
                                Console.Write("    |........|");
                                break;
                        }
                        break;
                    case 7:
                        Console.Write("     --------");
                        break;
                    case 8:
                        Console.Write("     SCORE: {0}", score);
                        break;
                    case 9:
                        Console.Write("     W = rotate");
                        break;
                    case 10:
                        Console.Write("     A = left");
                        break;
                    case 11:
                        Console.Write("     D = right");
                        break;
                    case 12:
                        Console.Write("     S = down");
                        break;

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
            int score = 0;


        Reset:
            

            Console.Clear();
            DrawBoard(board, figure1, figure2, figure3, figure4, newFigure, score);
            if (MoveFigureDown(ref board, figure1, figure2, figure3, figure4) == false)
            {
                NextFigure(ref figure1, ref figure2, ref figure3, ref figure4, ref newFigure, ref rand, ref score);
            }

            switch (Console.ReadKey().Key)
            {

                case ConsoleKey.D:
                    MoveFigureRight(board, figure1, figure2, figure3, figure4);
                    break;
                case ConsoleKey.A:
                    MoveFigureLeft(board, figure1, figure2, figure3, figure4);
                    break;
                case ConsoleKey.W:
                    MoveFigureRotate(board, ref figure1, ref figure2, ref figure3, ref figure4);
                    break;

            }
            goto Reset;


        }
    }
}
