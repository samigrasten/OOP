using System.Text;
using OOP.Helpers;

namespace OOP.ValueObjects.After
{
    public class TextFile
    {
        public TextFile(string content)
        {
            content.AssertNotNullOrEmpty("Empty content not allowed");
            _content = content;
        }

        public Base64TextFile ToBase64Text()
            => new Base64TextFile(System.Convert.ToBase64String(Encoding.UTF8.GetBytes(_content)));

        private readonly string _content;
    }
}