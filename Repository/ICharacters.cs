using Url_Shortener.Domain.Entites;

namespace URL_Shortener.Repository
{
    public interface ICharacters
    {
        public ShortenedUrl GetByLongUrl(string longUrl);
        public ShortenedUrl AddUrl(string longUrl, string shortUrl);
        public ShortenedUrl GetShortUrl(string shortUrl);

    }
}