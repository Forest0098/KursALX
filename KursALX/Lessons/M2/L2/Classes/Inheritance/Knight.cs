using KursALX.Lessons.L2.Enums;

namespace KursALX.Lessons.M2.L2.Classes.Inheritance
{
    public class Knight : ChessPiece
    {
        public Knight() : base()
        {
            Type = ChessFiguresType.KNIGHT;
        }

        public void Move()
        {
            Console.WriteLine("The Queen is moving... ");
        }
    }
}
