using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back_Projet_RPG.Migrations
{
    public partial class AddPlayerEnemy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Enemies",
                columns: new[] { "Id", "Agility", "Intellect", "LifePoint", "Luck", "Stamina", "Strength" },
                values: new object[] { 1, 10, 10, 10, 10, 10, 10 });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Agility", "Intellect", "LifePoint", "Luck", "Stamina", "Strength" },
                values: new object[] { 1, 10, 10, 10, 10, 10, 10 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
