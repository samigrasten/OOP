using OOP.Helpers.Maybe;
using System;

namespace OOP._3._NullReference
{
    public class Program {
        public void Main()
        {
            var filestore = new FileStore(@"c:\temp");
            filestore.Save(33, "Message to be stored");

            var optionalValue = filestore.Read(33);
            var value = optionalValue.Reduce("");

            if (optionalValue.IsSome()) {
                // :
            }

            optionalValue
                .WhenSome(str => Console.WriteLine(str))
                .WhenNone(() => Console.WriteLine("No value"));
        }
    }
}
