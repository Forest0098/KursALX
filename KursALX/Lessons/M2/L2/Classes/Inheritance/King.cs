using KursALX.Lessons.L2.Enums;

namespace KursALX.Lessons.M2.L2.Classes.Inheritance
{
    public class King : ChessPiece
    {
        public bool Checked { get; set; }
        public King() : base()
        {
            Checked = false;
            Type = ChessFiguresType.KING;
        }
        public void Move()
        {
            Console.WriteLine("The Queen is moving... ");
        }
    }
}
