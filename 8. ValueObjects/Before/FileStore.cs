﻿using OOP.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OOP.ValueObjects.Before
{
    public class FileStore
    {
        public FileStore(string workingDirectory)
        {
            if (string.IsNullOrEmpty(workingDirectory)) throw new ArgumentNullException("workingDirectory");
            if (!Directory.Exists(workingDirectory)) throw new ArgumentException("Directory not found", "workingDirectory");
            WorkingDirectory = workingDirectory;
        }

        public OperationResult Save(int id, string message)
        {
            var path = Path.Combine(WorkingDirectory, $"{id}.txt");
            File.WriteAllText(path, message);
            return OperationResult.Success();
        }

        public string Read(string id)
        {
            var path = Path.Combine(WorkingDirectory, $"{id}.txt");
            return File.ReadAllText(path);
        }

        public string WorkingDirectory { get; private set; }
    }
}
