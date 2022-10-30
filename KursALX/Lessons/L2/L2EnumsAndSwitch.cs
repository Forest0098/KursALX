﻿using KursALX.Lessons.L2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursALX.Lessons.L2
{
    public class L2EnumsAndSwitch
    {
        public static void Run()
        {
            var whiteQueen = new ChessFigure(Enums.ChessFiguresType.QUEEN, ChessColor.WHITE);

            var blackQueen = new ChessFigure();
            blackQueen.FigureType = ChessFiguresType.QUEEN;
            blackQueen.FigureColor = ChessColor.BLACK;

            var whiteKing = new ChessFigure
            {
                FigureType = ChessFiguresType.KING,
                FigureColor = ChessColor.WHITE
            };

            var blackBishop = new ChessFigure(ChessFiguresType.BISHOP, ChessColor.BLACK);

            GetFiguresType(whiteQueen);
            GetFiguresType(blackQueen);
            GetFiguresType(whiteKing);
            GetFiguresType(blackBishop);
        }

        private static void GetFiguresType(ChessFigure chessFigure)
        {
            switch (chessFigure.FigureType)
            {
                case ChessFiguresType.QUEEN:
                    Console.WriteLine("The figure is a queen.");
                    break;
                case ChessFiguresType.KING:
                    Console.WriteLine("The figure is a king.");
                    break;
                case ChessFiguresType.ROOK:
                    Console.WriteLine("The figure is a rook.");
                    break;
                case ChessFiguresType.BISHOP:
                    Console.WriteLine("The figure is a bishop.");
                    break;
                case ChessFiguresType.KNIGHT:
                    Console.WriteLine("The figure is a knight.");
                    break;
                case ChessFiguresType.PAWN:
                    Console.WriteLine("The figure is a pawn.");
                    break;
                default:
                    Console.WriteLine("The type is undefined");
                    break;
            }
            Console.WriteLine("The figure has been classified.");
        }
    }
}
