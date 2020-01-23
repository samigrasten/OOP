using System.Text;

namespace OOP.ValueObjects.Before
{
    public class Program
    {
        public void Main()
        {
            var filestore = new FileStore(@"c:\temp");
            var content = filestore.Read("22");
            var base64Content = System.Convert.ToBase64String(Encoding.UTF8.GetBytes(content));

            var url = $"https://www.testi.fi/content/{base64Content}";
            // Do something with url
        }
    }
}