using System;

namespace TicTacToeLambdaBoard
{
    public abstract class BoardSlot
    {
        public abstract T Match<T>(Func<T> onEmpty, Func<T> onX, Func<T> onO);

        private sealed class EmptyInstance : BoardSlot
        {
            public override T Match<T>(Func<T> onEmpty, Func<T> onX, Func<T> onO)
            {
                return onEmpty();
            }
        }

        private sealed class FilledWithXInstance : BoardSlot
        {
            public override T Match<T>(Func<T> onEmpty, Func<T> onX, Func<T> onO)
            {
                return onX();
            }
        }

        private sealed class FilledWithOInstance : BoardSlot
        {
            public override T Match<T>(Func<T> onEmpty, Func<T> onX, Func<T> onO)
            {
                return onO();
            }
        }

        public static BoardSlot Empty = new EmptyInstance();

        public static BoardSlot FilledWithX = new FilledWithXInstance();

        public static BoardSlot FilledWithO = new FilledWithOInstance();
    }
}

