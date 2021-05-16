namespace TicTacToeLambdaBoard
{
    public sealed class Row
    {
        private readonly int _index;

        private Row(int index)
        {
            _index = index;
        }

        public static Row First = new Row(0);

        public static Row Second = new Row(1);

        public static Row Third = new Row(2);
    }
}
