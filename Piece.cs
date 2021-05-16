namespace TicTacToeLambdaBoard
{
    public sealed class Piece
    {
        private readonly string _color;

        private Piece(string color)
        {
            _color = color;
        }

        public static Piece X = new Piece("X");

        public static Piece O = new Piece("O");

        public override string ToString()
        {
            return _color;
        }
    }
}


