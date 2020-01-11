namespace OOP._2._Guard_clauses
{
    public interface IFileStore
    {
        string WorkingDirectory { get; }

        string Read(string id);

        void Save(int id, string message);
    }
}