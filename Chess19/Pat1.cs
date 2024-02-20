
using ChessGame19.Figures;
using ChessLibrary19;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame19;

class Mate
{
    Validate validate = new Validate();
    public bool valid;
    public Coordinates WhiteKingMove()
    {
        Console.WriteLine("Enter the move coordinate");
        Coordinates coordinate = new Coordinates(Console.ReadLine());
        valid = validate.CheckIsTheCoordRight(coordinate);
        return coordinate;
    }
    public void CheckMate(Coordinates cRook1, Coordinates cRook2, Coordinates cQueen, Coordinates cBlackKing, Coordinates cWhiteKing)
    {
        ChessBoard chess = new ChessBoard();
        PrintTeams printTeams = new PrintTeams();
        cWhiteKing = WhiteKingMove();
        bool mate;

        int[] NumCoordArr = { cRook1.number, cRook2.number, cQueen.number, cBlackKing.number, cWhiteKing.number };
        Letters[] LetCoordArr = { cRook1.letter, cRook2.letter, cQueen.letter, cBlackKing.letter, cWhiteKing.letter };
        for (int i = 0; i < 5; i++)
        {
            if (cRook1.number == NumCoordArr[i] || cRook1.letter == LetCoordArr[i])
            {
                if (NumCoordArr[i] < cWhiteKing.number - 1)
                {
                    if (cRook1.number == NumCoordArr[i] && cRook1.number != 1)
                    {
                        cRook1.number += 1;
                    }
                    else if (cRook1.number == NumCoordArr[i] && cRook1.number == 1)
                    {
                        cRook1.number -= 1;
                    }
                    else if (cRook1.letter == LetCoordArr[i] && cRook1.letter != Letters.H)
                    {
                        cRook1.letter += 1;
                    }
                    else if (cRook1.letter == LetCoordArr[i] && cRook1.letter == Letters.H)
                    {
                        cRook1.letter -= 1;
                    }
                }
            }

            if (cRook2.number == NumCoordArr[i] || cRook2.letter == LetCoordArr[i])
            {
                if (NumCoordArr[i] < cWhiteKing.number + 1)
                {

                    if (cRook2.number == NumCoordArr[i] && cRook2.number != 1)
                    {
                        cRook2.number += 1;
                    }
                    else if (cRook2.number == NumCoordArr[i] && cRook2.number == 1)
                    {
                        cRook2.number -= 1;
                    }
                    else if (cRook2.letter == LetCoordArr[i] && cRook2.letter != Letters.H)
                    {
                        cRook2.letter += 1;
                    }
                    else if (cRook2.letter == LetCoordArr[i] && cRook2.letter == Letters.H)
                    {
                        cRook2.letter -= 1;
                    }
                }
            }
            //if (cQueen.number == NumCoordArr[i] || cQueen.letter == LetCoordArr[i] ||
            //    Math.Abs(cQueen.letter - LetCoordArr[i]) == Math.Abs(cQueen.number - NumCoordArr[i]))
            //{
            //    if (cQueen.number == NumCoordArr[i] && cQueen.number != 1)
            //    {
            //        cQueen.number += 1;
            //    }
            //    else if (cQueen.number == NumCoordArr[i] && cQueen.number == 1)
            //    {
            //       cQueen.number -= 1;
            //    }
            //    else if (cQueen.letter == LetCoordArr[i] && cQueen.letter != Letters.H)
            //    {
            //        cQueen.letter += 1;
            //    }
            //    else if (cQueen.letter == LetCoordArr[i] && cQueen.letter == Letters.H)
            //    {
            //        cQueen.letter -= 1;
            //    }
            //    else if()
            //}
        }
        do
        {
            if (Math.Abs(cRook1.number - cWhiteKing.number) != 1)
            {
                if (cWhiteKing.number != 1)
                    cRook1.number = cWhiteKing.number - 1;
                else
                    cRook1.number = cWhiteKing.number + 1;
                printTeams.PrintFiguresLetterOnTheBoard(chess.array, cRook1, cRook2, cQueen, cBlackKing, cWhiteKing);
                cWhiteKing = WhiteKingMove();
            }
            else if (Math.Abs(cRook2.number - cWhiteKing.number) != 1)
            {
                if (cWhiteKing.number != 8)
                    cRook2.number = cWhiteKing.number + 1;
                else
                    cRook2.number = cWhiteKing.number - 1;
                printTeams.PrintFiguresLetterOnTheBoard(chess.array, cRook1, cRook2, cQueen, cBlackKing, cWhiteKing);
                cWhiteKing = WhiteKingMove();
            }
            else if (Math.Abs(cQueen.number - cWhiteKing.number) != 0)
            {
                if (cWhiteKing.number <= 6)
                    cQueen.number = cWhiteKing.number;
                else
                    cQueen.number = cWhiteKing.number;
                printTeams.PrintFiguresLetterOnTheBoard(chess.array, cRook1, cRook2, cQueen, cBlackKing, cWhiteKing);
                cWhiteKing = WhiteKingMove();
            }

            if (Math.Abs(cRook2.number - cWhiteKing.number) == 1 && Math.Abs(cRook1.number - cWhiteKing.number) == 1
                && Math.Abs(cQueen.number - cWhiteKing.number) == 0)
            {
                mate = true;
                Console.WriteLine("You loose the game!");
            }
            else
            {
                mate = false;
            }

        } while (mate == false);
    }
}

