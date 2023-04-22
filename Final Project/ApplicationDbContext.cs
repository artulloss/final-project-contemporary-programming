using Microsoft.EntityFrameworkCore;

namespace Final_Project
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // public DbSet<WeatherForecast> WeatherForecasts { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<FavoriteFood> FavoriteFoods { get; set; }
        //public DbSet<MemberPets> MemberPets { get; set; }
    }
}
