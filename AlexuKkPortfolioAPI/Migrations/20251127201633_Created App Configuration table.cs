using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AlexuKkPortfolioAPI.Migrations
{
    /// <inheritdoc />
    public partial class CreatedAppConfigurationtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppConfigurations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GitHubURL = table.Column<string>(type: "TEXT", nullable: false),
                    GitHubUseraname = table.Column<string>(type: "TEXT", nullable: false),
                    FlashTitle = table.Column<string>(type: "TEXT", nullable: true),
                    FlashContent = table.Column<string>(type: "TEXT", nullable: true),
                    ProjTitle = table.Column<string>(type: "TEXT", nullable: true),
                    ProjContent = table.Column<string>(type: "TEXT", nullable: true),
                    ProjURL = table.Column<string>(type: "TEXT", nullable: true),
                    TelegramUsername = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    LinkedInUrl = table.Column<string>(type: "TEXT", nullable: false),
                    DonationURL = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppConfigurations", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AppConfigurations",
                columns: new[] { "Id", "DonationURL", "Email", "FlashContent", "FlashTitle", "GitHubURL", "GitHubUseraname", "LinkedInUrl", "ProjContent", "ProjTitle", "ProjURL", "TelegramUsername" },
                values: new object[] { 1, "URL для донатов", "alexukker@gmail.com", "Currently developing this app.", "Welcome to AlexuKk's Lab.", "https://github.com/AlexuKk", "AlexuKk", "link to LinkedIn", "Backend using ASP.NET Core 9.", "AlexuKk Portfolio API", "https://github.com/AlexuKk/repo-name", "@AlexuKk" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppConfigurations");
        }
    }
}
