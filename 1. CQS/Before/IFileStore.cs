namespace OOP.CQS.Before
{
    public interface IFileStore
    {
        string FileContent { get; set; }

        string WorkingDirectory { get; set; }

        void Read(string id);

        string Save(int id, string message);
    }
}