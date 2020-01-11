using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OOP.CQS.After
{
    public class FileStore : IFileStore
    {
        public FileStore(string workingDirectory)
        {
            if (string.IsNullOrEmpty(workingDirectory)) throw new ArgumentNullException("workingDirectory");
            if (!Directory.Exists(workingDirectory)) throw new ArgumentException("Directory not found", "workingDirectory");
            WorkingDirectory = workingDirectory;
        }

        public void Save(int id, string message)
        {
            var path = Path.Combine(WorkingDirectory, $"{id}.txt");
            File.WriteAllText(path, message);
        }

        public string Read(string id)
        {
            var path = Path.Combine(WorkingDirectory, $"{id}.txt");
            return File.ReadAllText(path);
        }

        public string WorkingDirectory { get; private set; }
        public string FileContent { get; set; }
    }
}
