﻿namespace ChessGame19.Figures;
using ChessLibrary19;
class King
{
    public FigureColor color;

    //bool move = false;
    ///// <summary>
    ///// Checks, if the King can move or not
    ///// </summary>
    ///// <param name="figure">The name of the figure</param>
    //public void CanMoveOrNot()
    //{
    //   // Symbol symbol = new Symbol();
    //    ChessBoard chess = new ChessBoard();
    //    Print print = new Print();

    //    print.PrintTextForInitalCoordinate(FigureName.King);
    //    Coordinates coord = new Coordinates(Console.ReadLine());
    //    //symbol.CheckIsTheCoordRight(coord, SymbolOfFigure.K);
    //    //int numberCoord = coord.numberCoordinate;
    //    //Letters letterCoord = coord.letterCoordinate;
    //    int numberCoord = coord.ReturnsNumberCoordinate();
    //    Letters letterCoord = coord.ReturnsLetterCoordinate();

    //    print.PrintTextForDestinationCoordinate(FigureName.King);
    //    Coordinates moveCoord = new Coordinates(Console.ReadLine());
    //    //int numberMoveCoord = moveCoord.numberCoordinate;
    //    //Letters letterMoveCoord = moveCoord.letterCoordinate;
    //    int numberMoveCoord = moveCoord.ReturnsNumberCoordinate();
    //    Letters letterMoveCoord = moveCoord.ReturnsLetterCoordinate();

    //    int x = Math.Abs(numberCoord - numberMoveCoord);
    //    int y = Math.Abs(letterCoord - letterMoveCoord);

    //    if ((x == 1 && y == 0) || (x == 0 && y == 1) || (x == 1 && y == 1))
    //    {
    //        move = true;
    //       // symbol.PrintSymbol(chess.array, moveCoord, SymbolOfFigure.K);
    //    }
    //    print.PrintMove(move);
    //}
    PrintText print = new PrintText();
    Validate validate = new Validate();
    public bool valid;
    public Coordinates input = new Coordinates();
    public void ValidateCoordinates()
    {
        print.PrintTextForFigureCoord(FigureName.King);
        Coordinates coordinate = new Coordinates(Console.ReadLine());
        input = coordinate;
        valid = validate.CheckIsTheCoordRight(coordinate);
    }
}

