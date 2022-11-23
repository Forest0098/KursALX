using KursALX.Lessons.L2.Enums;

namespace KursALX.Lessons.M2.L2.Classes.Inheritance
{
    public class Bishop : ChessPiece
    {
        public Bishop() : base()
        {
            Type = ChessFiguresType.BISHOP;
        }

        public void Move()
        {
            Console.WriteLine("The Bishop is moving... ");
        }
    }
}
