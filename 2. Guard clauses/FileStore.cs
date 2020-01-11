using OOP.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OOP._2._Guard_clauses
{
    public class FileStore : IFileStore
    {
        public FileStore(string workingDirectory)
        {
            //Contracts.Requires(() => !string.IsNullOrEmpty(workingDirectory), "Working directory is null");
            //Contracts.Requires(() => Directory.Exists(workingDirectory), "Directory not found");
            workingDirectory.AssertNotNullOrEmpty("Working directory is null");
            workingDirectory.AssertDirectoryExists("Directory not found");

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
