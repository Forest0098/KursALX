using KursALX.Lessons.L2.Enums;

namespace KursALX.Lessons.M2.L2.Classes.Inheritance
{
    public class Rook : ChessPiece
    {
        public Rook() : base()
        {
            Type = ChessFiguresType.ROOK;
        }

        public void Move()
        {
            Console.WriteLine("The Rook is moving... ");
        }
    }
}
