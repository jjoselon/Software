using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkRelationships.Migrations
{
    public partial class InitialCreate6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Binnacles_BinnacleId",
                table: "Tags");

            migrationBuilder.AlterColumn<int>(
                name: "BinnacleId",
                table: "Tags",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Binnacles_BinnacleId",
                table: "Tags",
                column: "BinnacleId",
                principalTable: "Binnacles",
                principalColumn: "BinnacleId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Binnacles_BinnacleId",
                table: "Tags");

            migrationBuilder.AlterColumn<int>(
                name: "BinnacleId",
                table: "Tags",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Binnacles_BinnacleId",
                table: "Tags",
                column: "BinnacleId",
                principalTable: "Binnacles",
                principalColumn: "BinnacleId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
