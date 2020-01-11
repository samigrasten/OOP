namespace OOP.CQS.Before
{
    public class Program {
        public void Main()
        {
            var filestore = new FileStore();
            filestore.Save(33, "Message to be stored");  // Exception -> Working directory is null
        }
    }
}
