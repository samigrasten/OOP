using System.Text;
using System.Text.RegularExpressions;
using OOP.Helpers;

namespace OOP.ValueObjects.After
{
    public class Base64TextFile
    {
        public Base64TextFile(string text)
        {
            text.AssertNotNullOrEmpty("Empty content not allowed");
            IsBase64String(text).AssertTrue("Not valid base64 text");
            _text = text;
        }

        public TextFile ToText()
        {
            var content = Encoding.UTF8.GetString(System.Convert.FromBase64String(_text));
            return new TextFile(content);
        }

        public void WriteTo(ITextWriter writer)
            => writer.Write(_text);

        private bool IsBase64String(string text)
        {
            var trimmedtext = text.Trim();
            return (trimmedtext.Length % 4 == 0) 
                   && Regex.IsMatch(trimmedtext, @"^[a-zA-Z0-9\+/]*={0,3}$", RegexOptions.None);
        }

        private readonly string _text;
    }
}