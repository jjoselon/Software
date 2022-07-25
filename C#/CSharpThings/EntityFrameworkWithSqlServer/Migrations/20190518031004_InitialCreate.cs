using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkWithSqlite.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Binnacles",
                columns: table => new
                {
                    BinnacleId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BinnacleTitle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Binnacles", x => x.BinnacleId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Binnacles");
        }
    }
}
