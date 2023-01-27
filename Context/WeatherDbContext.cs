using AWeatherAPI.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AWeatherAPI.Context
{
    public class WeatherDbContext : IdentityDbContext<User>
    {
        public DbSet<User> Users { get; set; }

        public WeatherDbContext(DbContextOptions<WeatherDbContext> Options) : base(Options)
        {

        }
    }
}