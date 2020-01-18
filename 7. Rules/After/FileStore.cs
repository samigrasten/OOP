using OOP.Helpers;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace OOP.Rules.After
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
            var validationRules = FileStoreSavingValidationRules.GetRulesFor(_user);
            var validationResult = validationRules.Validate(new UserContext(_user, message));
            if (!validationResult.Success) return OperationResult.Failed(validationResult.Errors.Aggregate((list, item) => $"{list},{item}"));

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
        public string FileContent { get; set; }
        private User _user { get; }
    }
}
