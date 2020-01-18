using OOP.Helpers.Maybe;
using System;

namespace OOP._4._Branching.After_ISP
{
    public class Program {
        public void Main()
        {
            var filestore = FileStoreFactory.Create(@"c:\temp");
            SaveMessage(filestore, 33, "Message to be stored");
        }

        private void SaveMessage(FileStore filestore, int id, string message)
        {
            var connectableFileStore = filestore as IConnectable;
            connectableFileStore?.Connect();
            filestore.Save(id, message);
            // :

            connectableFileStore?.Disconnect();            
        }
    }

    public class FileStoreFactory
    {
        public static FileStore Create(string workingDirectory) => new FileStore(workingDirectory);
        public static FileStore Create(string workingDirectory, string username, string password) => new NetworkFileStore(workingDirectory, username, password);
    }
}
