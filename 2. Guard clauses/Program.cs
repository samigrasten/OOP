namespace OOP._2._Guard_clauses
{
    public class Program {
        public void Main()
        {
            var filestore = new FileStore(@"c:\temp");
            filestore.Save(33, "Message to be stored");  
        }
    }
}
