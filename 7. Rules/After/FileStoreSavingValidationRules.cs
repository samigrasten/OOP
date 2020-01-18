using System.Collections.Generic;

namespace OOP.Rules.After
{
    public class FileStoreSavingValidationRules
    {
        const int MAX_MESSAGE_LENGTH = 5000;

        public static Validation<UserContext> GetRulesFor(User user) => user.IsPremiumUser()
            ? new Validation<UserContext>(_premiumUserRules)
            : new Validation<UserContext>(_basicUserRules);

        private static List<ValidationRule<UserContext>> _basicUserRules = new List<ValidationRule<UserContext>> {
            new ValidationRule<UserContext>(
                rule: ctx => ctx.User.IsAuthenticated,
                errorMessage: "User not authenticated"),
            new ValidationRule<UserContext>(
                rule: ctx => ctx.User.HasValidSubscription,
                errorMessage: "No active subscription"),
            new ValidationRule<UserContext>(
                rule: ctx => ctx.Message.Length > MAX_MESSAGE_LENGTH,
                errorMessage: "Message is too long for basic user"),
        };

        private static List<ValidationRule<UserContext>> _premiumUserRules = new List<ValidationRule<UserContext>> {
            new ValidationRule<UserContext>(
                rule: ctx => ctx.User.IsAuthenticated,
                errorMessage: "User not authenticated"),
            new ValidationRule<UserContext>(
                rule: ctx => ctx.User.HasValidSubscription,
                errorMessage: "No active subscription"),
        };
    }
}
