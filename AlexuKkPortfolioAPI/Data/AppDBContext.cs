using AlexuKkPortfolioAPI.Enities;
using Microsoft.EntityFrameworkCore;

namespace AlexuKkPortfolioAPI.Data
{
    public class AppDBContext(DbContextOptions<AppDBContext> options) : DbContext(options)
    {
        public DbSet<Post> Posts { get; set; }


    }
}
