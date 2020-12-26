using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Moves
    {
        FigureMove fm;
        Board board;

        public Moves (Board board)
        {
            this.board = board;
        }

        public bool CanMove (FigureMove fm)
        {
            this.fm = fm;
            return CanMoveFrom() && CanMoveTo() && CanFigureMove();
        }

        bool CanMoveFrom()
        {
            return fm.from.OnBoard() && fm.figure.GetColor() == board.moveColor;
        }

        bool CanMoveTo()
        {
            return fm.to.OnBoard() && board.GetFigureAt(fm.to).GetColor() != board.moveColor;
        }

        bool CanFigureMove()
        {
            return true;
        }
    }
}
