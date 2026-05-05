using Microsoft.EntityFrameworkCore;
using Url_Shortener.Domain.Entites;

namespace URL_Shortener.DbContextEF
{
    public class DbContextEF : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<ShortenedUrl> Urls { get; set; }
        public DbContextEF(DbContextOptions<DbContextEF> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

    }
}