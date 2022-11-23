using KursALX.Lessons.L2.Enums;

namespace KursALX.Lessons.M2.L2.Classes.Inheritance
{
    public class Queen : ChessPiece
    {
        public Queen() : base()
        {
            Type = ChessFiguresType.QUEEN;
        }

        public void Move()
        {
            Console.WriteLine("The Queen is moving... ");
        }
    }
}
