using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back_Projet_RPG.Migrations
{
    public partial class AddPlayerEnemyv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Players",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Enemies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Enemies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Enemy1");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Player1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Enemies");
        }
    }
}
