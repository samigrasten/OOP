namespace OOP.Rules.After
{
    public class ValidationResult
    {
        public ValidationResult(bool success, string[] errors)
        {
            Success = success;
            Failed = !success;
            Errors = errors;
        }

        public readonly bool Success;
        public readonly bool Failed;
        public readonly string[] Errors;
    }
}
