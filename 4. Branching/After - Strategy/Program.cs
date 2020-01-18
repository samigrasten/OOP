using OOP.Helpers.Maybe;
using System;

namespace OOP._4._Branching.After
{
    public class Program {
        public void Main()
        {
            var filestore = new FileStoreManager(@"c:\temp");
            filestore.Connect();
            
            filestore.Save(33, "Message to be stored");
            // :

            filestore.Disconnect();            
        }
    }
}
