using System;

namespace TicTacToeLambdaBoard
{
    public abstract class BoardSlot
    {
        public abstract T Match<T>(Func<T> onEmpty, Func<T> onX, Func<T> onY);

        private sealed class EmptyInstance : BoardSlot
        {
            public override T Match<T>(Func<T> onEmpty, Func<T> onX, Func<T> onY)
            {
                return onEmpty();
            }
        }

        private sealed class FilledWithXInstance : BoardSlot
        {
            public override T Match<T>(Func<T> onEmpty, Func<T> onX, Func<T> onY)
            {
                return onX();
            }
        }

        private sealed class FilledWithYInstance : BoardSlot
        {
            public override T Match<T>(Func<T> onEmpty, Func<T> onX, Func<T> onY)
            {
                return onY();
            }
        }

        public static BoardSlot Empty = new EmptyInstance();

        public static BoardSlot FilledWithX = new FilledWithXInstance();

        public static BoardSlot FilledWithY = new FilledWithYInstance();
    }
}

