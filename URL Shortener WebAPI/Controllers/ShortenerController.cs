using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using URL_Shortener.Services;
using URL_Shortener_WebAPI.DTOs.DTOAdd;

namespace URL_Shortener_WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShortenerController : ControllerBase
    {
        private readonly UrlShortenerService _urlShortener;

        public ShortenerController(UrlShortenerService urlShortener)
        {
            _urlShortener = urlShortener;
        }

        [HttpPost]
        public IActionResult ShortenUrl([FromBody] AddingURL _addingURL)
        {

                var shortUrl = _urlShortener.GetCharacters(_addingURL.LongUrl);
                _addingURL.ShortUrl = shortUrl;
                return Created();

        }
        [HttpGet]
        public IActionResult ShortenedUrl(string shortUrl)
        {
            var longUrl = _urlShortener.GetCharactersByShortUrl(shortUrl);
            if (longUrl == null)
            {
                return NotFound();
            }
            else
            {
                return Redirect(longUrl);
            }
        }
    }
}