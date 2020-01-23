namespace OOP.ValueObjects.After
{
    public class Program
    {
        public void Main()
        {
            var urlWriter = new UrlWriter($"https://www.testi.fi/content");
            new FileStore(@"c:\temp")
                .Read("22")
                .ToBase64Text()
                .WriteTo(urlWriter);

            var url = urlWriter.ToUri();
            // Do something with url
        }
    }
}