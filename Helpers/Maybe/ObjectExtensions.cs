using System;

namespace OOP.Helpers.Maybe
{
    public static class ObjectExtensions
    {
        public static Option<T> When<T>(this T obj, bool condition) =>
            condition ? (Option<T>)new Some<T>(obj) : None.Value;

        public static Option<T> When<T>(this T obj, Func<T, bool> predicate) =>
            obj.When(predicate(obj));

        public static Option<T> NoneIfNull<T>(this T obj) =>
            obj.When(!object.ReferenceEquals(obj, null));

        public static bool IsSome<T>(this Option<T> option) =>
            option is Some<T>;

        public static Option<T> WhenSome<T>(this Option<T> option, Action<T> action)
        {
            if (option.IsSome()) action((Some<T>)option);
            return option;
        }

        public static Option<T> WhenNone<T>(this Option<T> option, Action action)
        {
            if (option.IsSome()) action();
            return option;
        }
    }
}