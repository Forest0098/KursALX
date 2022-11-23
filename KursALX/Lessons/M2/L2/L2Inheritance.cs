using KursALX.Lessons.L2.Enums;
using KursALX.Lessons.M2.L2.Classes.Inheritance;

namespace KursALX.Lessons.M2.L2
{
    public class L2Inheritance
    {
        public static void Run()
        {
            ChessPiece chessPiece = new King();
            chessPiece.XPosition = 1;
            chessPiece.YPosition = 1;
            chessPiece.Color =ChessColor.WHITE;
            chessPiece.Move();
            chessPiece.Present();

            Queen queen = new Queen();
            queen.XPosition = 1;
            queen.YPosition = 2;
            queen.Color = ChessColor.WHITE;
            queen.Move();
            queen.Present();

            Pawn pawn = new Pawn();
            pawn.XPosition = 1;
            pawn.YPosition = 2;
            pawn.Color = ChessColor.WHITE;
            pawn.Move();
            pawn.Present();

            Knight knight = new Knight();
            knight.XPosition = 2;
            knight.YPosition = 2;
            knight.Color = ChessColor.WHITE;
            knight.Move();
            knight.Present();

            Rook rook = new Rook();
            rook.XPosition = 3;
            rook.YPosition = 2;
            rook.Color = ChessColor.WHITE;
            rook.Move();
            rook.Present();

            Bishop bishop = new Bishop();
            bishop.XPosition = 3;
            bishop.YPosition = 3;
            bishop.Color = ChessColor.WHITE;
            bishop.Move();
            bishop.Present();
        }

        public static void ConfirmLiveness(ChessPiece queen)
        {
            if (queen.IsAlive)
            {
                Console.WriteLine("The piece is alive!");
            }
            else 
            {
                Console.WriteLine("The piece is dead...");
            }
        }
    }
}