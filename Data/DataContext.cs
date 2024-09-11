using BlazorServerCrudDotnet8.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerCrudDotnet8.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<VideoGame>().HasData(
            new VideoGame {Id = 1, Title ="Cyberpunk 2077", Publisher="CD Project", ReleaseYear= 2020},
            new VideoGame {Id = 2, Title ="Elden Ring", Publisher="FromSoftware", ReleaseYear= 2022},
            new VideoGame {Id = 3, Title ="Cyberpunk 19999", Publisher="CD Project", ReleaseYear= 2024}
            );
        }
        public DbSet<VideoGame> VideoGames {get; set;}
    }
}