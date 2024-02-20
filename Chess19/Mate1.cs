using ChessGame19.Figures;
using ChessLibrary19;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ChessGame19;


//class Mate
//{
//    Validate validate = new Validate();
//    public bool valid;
//    public Coordinates WhiteKingMove()
//    {
//        Console.WriteLine("Enter the move coordinate");
//        Coordinates coordinate = new Coordinates(Console.ReadLine());
//        valid = validate.CheckIsTheCoordRight(coordinate);
//        return coordinate;
//    }
//    public void CheckMate(Coordinates cRook1, Coordinates cRook2, Coordinates cQueen, Coordinates cBlackKing, Coordinates cWhiteKing)
//    {
//        ChessBoard chess = new ChessBoard();
//        PrintTeams printTeams = new PrintTeams();
//        cWhiteKing = WhiteKingMove();
//        bool mate;

//        do
//        {
//            if (Math.Abs(cRook2.number - cWhiteKing.number) != 1)
//            {
//                if (cWhiteKing.number != 1)
//                    cRook2.number = cWhiteKing.number - 1;
//                else
//                    cRook2.number = cWhiteKing.number + 1;
//                printTeams.PrintFiguresLetterOnTheBoard(chess.array, cRook1, cRook2, cQueen, cBlackKing, cWhiteKing);
//                cWhiteKing = WhiteKingMove();
//            }
//            else if (Math.Abs(cRook1.number - cWhiteKing.number) != 1)
//            {
//                if (cWhiteKing.number != 8)
//                    cRook1.number = cWhiteKing.number + 1;
//                else
//                    cRook1.number = cWhiteKing.number - 1;
//                printTeams.PrintFiguresLetterOnTheBoard(chess.array, cRook1, cRook2, cQueen, cBlackKing, cWhiteKing);
//                cWhiteKing = WhiteKingMove();
//            }
//            else if (Math.Abs(cQueen.number - cWhiteKing.number) != 0)
//            {
//                if (cWhiteKing.number <= 6)
//                    cQueen.number = cWhiteKing.number;
//                else
//                    cQueen.number = cWhiteKing.number;
//                printTeams.PrintFiguresLetterOnTheBoard(chess.array, cRook1, cRook2, cQueen, cBlackKing, cWhiteKing);
//                cWhiteKing = WhiteKingMove();
//            }

//            if (Math.Abs(cRook2.number - cWhiteKing.number) == 1 && Math.Abs(cRook1.number - cWhiteKing.number) == 1
//                && Math.Abs(cQueen.number - cWhiteKing.number) == 0)
//            {
//                mate = true;
//                Console.WriteLine("You loose the game!");
//            }
//            else
//            {
//                mate = false;
//            }

//        } while (mate == false);
//    }
//}
