﻿namespace ChessGame19.Figures;
using ChessLibrary19;
//using QueenGameLibrary;

class Queen
{
    public FigureColor color;

    //bool move = false;
    ///// <summary>
    ///// Checks, if the Queen can move or not
    ///// </summary>
    ///// <param name="figure">The name of the figure</param>
    //public void CanMoveOrNot()
    //{
    //    //Symbol symbol = new Symbol();
    //    ChessBoard chess= new ChessBoard();
    //    Print print = new Print();

    //    print.PrintTextForInitalCoordinate(FigureName.Queen);
    //    Coordinates coord = new Coordinates(Console.ReadLine());
    //    //symbol.CheckIsTheCoordRight(coord, SymbolOfFigure.Q);
    //    //int numberCoord = coord.numberCoordinate;
    //    //Letters letterCoord = coord.letterCoordinate;
    //    int numberCoord = coord.ReturnsNumberCoordinate();
    //    Letters letterCoord = coord.ReturnsLetterCoordinate();

    //    print.PrintTextForDestinationCoordinate(FigureName.Queen);
    //    Coordinates moveCoord = new Coordinates(Console.ReadLine());
    //    //int numberMoveCoord = moveCoord.numberCoordinate;
    //    //Letters letterMoveCoord = moveCoord.letterCoordinate;
    //    int numberMoveCoord = moveCoord.ReturnsNumberCoordinate();
    //    Letters letterMoveCoord = moveCoord.ReturnsLetterCoordinate();

    //    int x = Math.Abs(numberCoord - numberMoveCoord);
    //    int y = Math.Abs(letterCoord - letterMoveCoord);

    //    if (x == 0 || y == 0 || x == y)
    //    {
    //        move = true;
    //       // symbol.PrintSymbol(chess.array, moveCoord, SymbolOfFigure.Q);
    //    }
    //    print.PrintMove(move);
    //}
    PrintText print = new PrintText();
    Validate validate = new Validate();
    public bool valid;
    public Coordinates input = new Coordinates();
    public void ValidateCoordinates()
    {
        print.PrintTextForFigureCoord(FigureName.Queen);
        Coordinates coordinate = new Coordinates(Console.ReadLine());
        input = coordinate;
        valid = validate.CheckIsTheCoordRight(coordinate);
    }
}
