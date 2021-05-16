namespace TicTacToeLambdaBoard
{
    public sealed class Column
    {
        private readonly int _index;

        private Column(int index)
        {
            _index = index;
        }

        public static Column First = new Column(0);

        public static Column Second = new Column(1);

        public static Column Third = new Column(2);
    }
}

