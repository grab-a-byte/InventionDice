namespace InventionDice.Infrastructure
{
    public class Result
    {
        public Result(bool sucessfull)
        {
            Successful = sucessfull;
        }
        public bool Successful { get; }

        public static Result Successfull => new Result(true);
        public static Result Failure => new Result(false);
    }

    public class Result<T> : Result
    {
        public Result(bool successfull, T data) : base(successfull)
        {
            Data = data;
        }

        public T Data { get; }

        public static Result<T> Successfull(T data) => new Result<T>(true, data);
        public static Result<T> Failure(T data) => new Result<T>(false, data);
    }
}
