using KursALX.Lessons.L2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursALX.Lessons.M2.L2.Classes.Inheritance
{
    public class Pawn : ChessPiece
    {
        public Pawn() : base()
        {
            Type = ChessFiguresType.PAWN;
        }

        public void Move()
        {
            Console.WriteLine("The Queen is moving... ");
        }
    }
}
