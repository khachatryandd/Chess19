using ChessGame19.Figures;

namespace ChessGame19;
using ChessLibrary19;
internal class Program
{
    static void Main()
    {
        ChooseTheGame chooseTheGame = new ChooseTheGame();
        chooseTheGame.ChooseQGameOrCGame();
    }
}


