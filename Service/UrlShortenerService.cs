using System.Security.Cryptography.X509Certificates;
using URL_Shortener.Repository;

namespace URL_Shortener.Services
{
    public class UrlShortenerService
    {
        private readonly ICharacters _characters;
        public UrlShortenerService(ICharacters characters)
        {
            _characters = characters;
        }
        public string GetCharacters(string LongUrl)
        {
            if (_characters.GetByLongUrl(LongUrl)?.ShortUrl != null)
            {
                return _characters.GetByLongUrl(LongUrl).ShortUrl;
            }
            else
            {
                var CharRandom = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var random = new Random();
                var ShortCode = new char[6];
                for (int i = 0; i < ShortCode.Length; i++)
                {
                    ShortCode[i] = CharRandom[random.Next(CharRandom.Length)];
                }
                _characters.AddUrl(LongUrl, new string(ShortCode));
                return new string(ShortCode);
            }
        }
        public string GetCharactersByShortUrl(string ShortUrl)
        {
            if (_characters.GetShortUrl(ShortUrl)?.LongUrl != null)
            {
                return _characters.GetShortUrl(ShortUrl).LongUrl;
            }
            else
            {
                return null;
            }
        }
    }
}