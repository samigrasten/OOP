namespace OOP.Rules.After
{
    public class UserContext
    {
        public UserContext(User user, string message) {
            User = user;
            Message = message;
        }

        public readonly User User;
        public readonly string Message;
    }
}
