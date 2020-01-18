using System.Collections.Generic;
using System.Linq;

namespace OOP.Rules.After
{
    public class Validation<T> where T:class {
        public Validation(List<ValidationRule<T>> rules) {
            _rules = rules;
        }

        public ValidationResult Validate(T context)
        {
            var errors = _rules
                 .Where(rule => !rule.Rule(context))
                 .Select(rule => rule.ValidationErrorMessage)
                 .ToArray();
            return new ValidationResult(errors.Length == 0, errors);
        }

        private readonly List<ValidationRule<T>> _rules;
    }
}
