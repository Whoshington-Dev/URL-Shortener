namespace URL_Shortener_WebAPI.DTOs.DTOAdd
{
    public class AddingURL
    {
        public string? ShortUrl { get; set; }
        public string LongUrl { get; set; }
        public DateTime CreationUrl { get; set; } = DateTime.Now;
        public DateTime UrlExpiration { get; set; }

    }
}