using OOP.Helpers.Maybe;
using System;

namespace OOP._4._Branching.Before
{
    public class Program {
        public void Main()
        {
            var filestore = new FileStore(@"c:\temp");
            SaveMessage(filestore, 33, "Message to be stored");
        }

        private void SaveMessage(FileStore filestore, int id, string message)
        {
            if (filestore.Type == FileStore.Types.Network)
            {
                filestore.Connect();
            }

            filestore.Save(id, message);

            if (filestore.Type == FileStore.Types.Network)
            {
                filestore.Disconnect();
            }
        }
    }
}
