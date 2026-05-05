using URL_Shortener.DbContext;
using Url_Shortener.Domain.Entites;

namespace URL_Shortener.Repository
{
    public class Characters : ICharacters
    {
        private readonly DbContextEF _dbContext;

        public Characters(DbContextEF dbContext)
        {
            _dbContext = dbContext;
        }

        public ShortenedUrl GetByLongUrl(string longUrl)
        {
            return _dbContext.Urls.FirstOrDefault(url => url.LongUrl == longUrl);
        }
        public ShortenedUrl AddUrl(string longUrl, string shortUrl)
        {
            var newUrl = _dbContext.Urls.Add(new ShortenedUrl {LongUrl = longUrl,ShortUrl = shortUrl,CreationUrl = DateTime.Now, ExpirationUrl = DateTime.Now.AddDays(30)}).Entity;
            _dbContext.SaveChanges();
            return newUrl;
        }
    }
}
