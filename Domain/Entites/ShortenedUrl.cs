namespace Url_Shortener.Domain.Entites
{
    public class ShortenedUrl
    {
        public int Id { get; set; }
        public string ShortUrl { get; set; }
        public string LongUrl { get; set; }
        public DateTime CreationUrl { get; set; } = DateTime.Now;
        public DateTime UrlExpiration { get; set; } 

        public ShortenedUrl() { }
        public ShortenedUrl(string shortUrl, string longUrl, DateTime creationUrl)
        {
            ShortUrl = shortUrl;
            LongUrl = longUrl;
            CreationUrl = creationUrl;

            // Set the expiration date to 30 days after the creation date
            UrlExpiration = CreationUrl.AddDays(30);
        }
    }
}