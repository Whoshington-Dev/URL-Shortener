using Microsoft.EntityFrameworkCore;
using Url_Shortener.Domain.Entites;

namespace URL_Shortener.Infrastructure
{
    public class DbContextEF : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<ShortenedUrl> Urls { get; set; }
        
        public DbContextEF(DbContextOptions<DbContextEF> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ShortenedUrl>().ToTable("UrlShortener");
        }
    }
}