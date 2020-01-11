using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OOP.CQS.Before
{
    public class FileStore : IFileStore
    {
        public string Save(int id, string message)
        {
            var path = Path.Combine(WorkingDirectory, $"{id}.txt");
            File.WriteAllText(path, message);
            return path;
        }

        public void Read(string id)
        {
            var path = Path.Combine(WorkingDirectory, $"{id}.txt");
            var message = File.ReadAllText(path);
            FileContent = message;
        }

        public string WorkingDirectory { get; set; }
        public string FileContent { get; set; }
    }
}
