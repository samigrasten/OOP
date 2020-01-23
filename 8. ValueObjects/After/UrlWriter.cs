using System;

namespace OOP.ValueObjects.After
{
    public class UrlWriter : ITextWriter
    {
        public UrlWriter(string baseurl)
            => _baseUrl = baseurl;

        public void Write(string url)
            => _url = url;

        public Uri ToUri()
            => new Uri($"{_baseUrl}/{_url}");

        private readonly string _baseUrl;
        private string _url;
    }
}