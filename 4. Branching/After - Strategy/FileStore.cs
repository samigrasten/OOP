using OOP.Helpers;
using OOP.Helpers.Maybe;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OOP._4._Branching.After
{
    public class FileStoreManager
    {
        public FileStoreManager(string workingDirectory)
        {
            workingDirectory.AssertNotNullOrEmpty("Working directory is null");
            workingDirectory.AssertDirectoryExists("Directory not found");

            WorkingDirectory = workingDirectory;
            _fileStoreStrategy = new LocalStrategy();
        }

        public FileStoreManager(string workingDirectory, string username, string password)
        {
            workingDirectory.AssertNotNullOrEmpty("Working directory is null");
            workingDirectory.AssertDirectoryExists("Directory not found");

            WorkingDirectory = workingDirectory;
            _fileStoreStrategy = new NetworkStrategy();
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

        public void Connect() => _fileStoreStrategy.Connect();
        public void Disconnect() => _fileStoreStrategy.Disconnect();

        public string WorkingDirectory { get; private set; }        
        public string Username { get; private set; }
        public string Password { get; private set; }

        private readonly IFileStoreStrategy _fileStoreStrategy;
    }
}
