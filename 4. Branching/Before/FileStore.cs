using OOP.Helpers;
using OOP.Helpers.Maybe;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OOP._4._Branching.Before
{
    public class FileStore 
    {
        public enum Types { File, Network }

        public FileStore(string workingDirectory)
        {
            workingDirectory.AssertNotNullOrEmpty("Working directory is null");
            workingDirectory.AssertDirectoryExists("Directory not found");

            WorkingDirectory = workingDirectory;
            Type = Types.File;
        }

        public FileStore(string workingDirectory, string username, string password)
        {
            workingDirectory.AssertNotNullOrEmpty("Working directory is null");
            workingDirectory.AssertDirectoryExists("Directory not found");

            WorkingDirectory = workingDirectory;
            Type = Types.Network;
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

        public void Connect() { }
        public void Disconnect() { }

        public string WorkingDirectory { get; private set; }
        public Types Type { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
    }
}
