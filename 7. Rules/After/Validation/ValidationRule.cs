using System;

namespace OOP.Rules.After
{
    public class ValidationRule<T> where T : class
    {
        public ValidationRule(Predicate<T> rule, string errorMessage)
        {
            Rule = rule;
            ValidationErrorMessage = errorMessage;
        }

        public readonly Predicate<T> Rule;

        public readonly string ValidationErrorMessage;
    }
}
