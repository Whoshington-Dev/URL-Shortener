namespace Url_Shortener.Domain.Entites
{
    public class ShorteneUrl
    {
        public int Id { get; set; }
        public string ShortUrl { get; set; }
        public string LongUrl { get; set; }
        public DateTime CreationUrl { get; set; } = DateTime.Now;
        public DateTime ExpirationUrl { get; set; } 

        public ShorteneUrl() { }
        public ShorteneUrl(string shortUrl, string longUrl, DateTime creationUrl)
        {
            ShortUrl = shortUrl;
            LongUrl = longUrl;
            CreationUrl = creationUrl;

            // Set the expiration date to 30 days after the creation date
            ExpirationUrl = CreationUrl.AddDays(30);
        }
    }
}
