namespace OOP.Helpers
{
    public class OperationResult
    {
        private OperationResult(bool isSuccess, string message = null)
        {
            IsSuccess = isSuccess;
            Message = message;
        }

        public static OperationResult Success() => new OperationResult(true);

        public static OperationResult Failed(string message) => new OperationResult(false, message);

        public readonly bool IsSuccess;
        public readonly string Message;
    }
}
