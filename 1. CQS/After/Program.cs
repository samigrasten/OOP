namespace OOP.CQS.After
{
    public class Program {
        public void Main()
        {
            var filestore = new FileStore(@"c:\temp");
            filestore.Save(33, "Message to be stored");  
        }
    }
}
