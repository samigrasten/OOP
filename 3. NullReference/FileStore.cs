using OOP.Helpers;
using OOP.Helpers.Maybe;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OOP._3._NullReference
{
    public class FileStore : IFileStore
    {
        public FileStore(string workingDirectory)
        {
            workingDirectory.AssertNotNullOrEmpty("Working directory is null");
            workingDirectory.AssertDirectoryExists("Directory not found");

            WorkingDirectory = workingDirectory;
        }

        public OperationResult Save(int id, string message)
        {
            try
            {
                var path = Path.Combine(WorkingDirectory, $"{id}.txt");
                File.WriteAllText(path, message);
            }
            catch(Exception e)
            {
                return OperationResult.Failed(e.Message);
            }
            return OperationResult.Success();
        }

        public Option<string> Read(int id)
        {
            var path = Path.Combine(WorkingDirectory, $"{id}.txt");
            if (!File.Exists(path)) return None.Value;
            return File.ReadAllText(path);
        }

        public string WorkingDirectory { get; private set; }
    }
}
