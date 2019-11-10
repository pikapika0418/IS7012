using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstateListing.Migrations
{
    public partial class SeedBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RealEstate",
                columns: new[] { "Id", "Cost", "NoOfRooms", "Sqft", "Type" },
                values: new object[,]
                {
                    { 1, 300000.0, 3, 2100, "Apartment" },
                    { 2, 170000.0, 3, 1350, "Condominium" },
                    { 3, 210000.0, 4, 1780, "Co-op" },
                    { 4, 231000.0, 3, 2100, "Single family" },
                    { 5, 450000.0, 5, 3000, "Apartment" },
                    { 6, 185000.0, 3, 2050, "Single family" },
                    { 7, 215200.0, 4, 2300, "Condominium" },
                    { 8, 150000.0, 2, 1500, "Single family" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RealEstate",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RealEstate",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RealEstate",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RealEstate",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RealEstate",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RealEstate",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RealEstate",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RealEstate",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
