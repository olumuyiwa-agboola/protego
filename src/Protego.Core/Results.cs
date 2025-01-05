namespace Protego.Core
{
    public sealed class Results<TResult1, TResult2, TResult3>
    {
        private Results(dynamic activeResult)
        {
            Result = activeResult;
        }

        public dynamic Result { get; }

        public static implicit operator Results<TResult1, TResult2, TResult3>(TResult1 result) => new(result!);

        public static implicit operator Results<TResult1, TResult2, TResult3>(TResult2 result) => new(result!);

        public static implicit operator Results<TResult1, TResult2, TResult3>(TResult3 result) => new(result!);
    }
}
