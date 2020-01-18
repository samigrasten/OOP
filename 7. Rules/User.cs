using System;

namespace OOP.Rules
{
    public class User
    {
        public bool HasValidSubscription { get; internal set; }
        public bool IsAuthenticated { get; internal set; }

        internal bool IsBasicUser()
        {
            return false;
        }
        internal bool IsPremiumUser()
        {
            return true;
        }
    }
}