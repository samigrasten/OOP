using OOP.Helpers;
using OOP.Helpers.Maybe;

namespace OOP._3._NullReference
{
    public interface IFileStore
    {
        string WorkingDirectory { get; }

        Option<string> Read(int id);

        OperationResult Save(int id, string message);
    }
}