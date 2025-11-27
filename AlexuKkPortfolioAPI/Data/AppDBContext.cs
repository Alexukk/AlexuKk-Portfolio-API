using AlexuKkPortfolioAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace AlexuKkPortfolioAPI.Data
{
    public class AppDBContext(DbContextOptions<AppDBContext> options) : DbContext(options)
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }

        public DbSet<AppConfigEnt> AppConfigurations { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<AppConfigEnt>().HasData(GetConfigSeedData());

        }

        private static AppConfigEnt GetConfigSeedData()
        {
            return new AppConfigEnt
            {
                Id = 1, 

                GitHubURL = "https://github.com/AlexuKk",
                GitHubUseraname = "AlexuKk",
                FlashTitle = "Welcome to AlexuKk's Lab.",
                FlashContent = "Currently developing this app.",
                ProjTitle = "AlexuKk Portfolio API",
                ProjContent = "Backend using ASP.NET Core 9.",
                ProjURL = "https://github.com/AlexuKk/repo-name",
                TelegramUsername = "@AlexuKk",
                Email = "alexukker@gmail.com",
                LinkedInUrl = "link to LinkedIn",
                DonationURL = "URL для донатов",


            };
        }

    }
}
