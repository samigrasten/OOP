using OOP.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OOP.Rules.Before
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
            if (!_user.IsAuthenticated) return OperationResult.Failed("User not authenticated");

            if (_user.HasValidSubscription)
            {
                if (_user.IsBasicUser() && message.Length > MAX_MESSAGE_LENGTH) return OperationResult.Failed("Message is too long for basic user");
                if (_user.IsPremiumUser())
                {
                    var path = Path.Combine(WorkingDirectory, $"{id}.txt");
                    File.WriteAllText(path, message);
                    return OperationResult.Success();
                }
                return OperationResult.Failed("User cannot save message");
            }

            return OperationResult.Failed("No active subscription");
        }

        public string Read(string id)
        {
            var path = Path.Combine(WorkingDirectory, $"{id}.txt");
            return File.ReadAllText(path);
        }

        int MAX_MESSAGE_LENGTH = 5000;
        public string WorkingDirectory { get; private set; }
        public string FileContent { get; set; }
        private User _user { get; }
    }
}
