using KursALX.Lessons.L2.Enums;

namespace KursALX.Lessons.L2
{
    public class ChessFigure
    {
        public ChessFiguresType FigureType;
        public ChessColor FigureColor;

        public ChessFigure() {}

        public ChessFigure(ChessFiguresType chessFigureType, ChessColor chessColor)
        {
            FigureType = chessFigureType;
            FigureColor = chessColor;
        }
    }
}
