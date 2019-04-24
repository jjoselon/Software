using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCapplicacion.Migrations
{
    public partial class Rating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BinnacleType",
                table: "Binnacle",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BinnacleType",
                table: "Binnacle");
        }
    }
}
