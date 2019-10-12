using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class Initial8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Availability",
                table: "Book");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfBooksAvailable",
                table: "Book",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfBooksAvailable",
                table: "Book");

            migrationBuilder.AddColumn<bool>(
                name: "Availability",
                table: "Book",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
