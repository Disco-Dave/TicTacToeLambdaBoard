using System;

namespace TicTacToeLambdaBoard
{
    public sealed class Board
    {
        private readonly Func<Column, Row, BoardSlot> _state;

        private Board(Func<Column, Row, BoardSlot> state)
        {
            _state = state;
        }

        public static Board Empty = new Board((_, _) => BoardSlot.Empty);

        public BoardSlot View(Column column, Row row)
        {
            return _state(column, row);
        }

        public Board Add(Column column, Row row, Piece piece)
        {
            var slot = piece == Piece.X 
                ? BoardSlot.FilledWithX 
                : BoardSlot.FilledWithY;

            return new Board((c, r) =>
            {
                if (c == column && r == row)
                {
                    return slot;
                }
                else
                {
                    return _state(c, r);
                }
            });
        }

        public Board Remove(Column column, Row row)
        {
            return new Board((c, r) =>
            {
                if (c == column && r == row)
                {
                    return BoardSlot.Empty;
                }
                else
                {
                    return _state(c, r);
                }
            });
        }
    }
}
