using Microsoft.EntityFrameworkCore;
using URL_Shortener.Infrastructure;
using URL_Shortener.Repository;
using URL_Shortener.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
// registe services and repositories
builder.Services.AddScoped<ICharacters, Characters>();
builder.Services.AddScoped<UrlShortenerService>();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<DbContextEF>(Options => Options.UseMySql(
    builder.Configuration.GetConnectionString("DefaultConnection"),
    ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))
));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();