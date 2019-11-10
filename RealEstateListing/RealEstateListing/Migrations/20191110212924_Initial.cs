using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstateListing.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NoOfRooms",
                table: "RealEstate");

            migrationBuilder.AddColumn<DateTime>(
                name: "BuyDate",
                table: "RealEstate",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BuyDate",
                table: "RealEstate");

            migrationBuilder.AddColumn<int>(
                name: "NoOfRooms",
                table: "RealEstate",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "RealEstate",
                keyColumn: "Id",
                keyValue: 1,
                column: "NoOfRooms",
                value: 3);

            migrationBuilder.UpdateData(
                table: "RealEstate",
                keyColumn: "Id",
                keyValue: 2,
                column: "NoOfRooms",
                value: 3);

            migrationBuilder.UpdateData(
                table: "RealEstate",
                keyColumn: "Id",
                keyValue: 3,
                column: "NoOfRooms",
                value: 4);

            migrationBuilder.UpdateData(
                table: "RealEstate",
                keyColumn: "Id",
                keyValue: 4,
                column: "NoOfRooms",
                value: 3);

            migrationBuilder.UpdateData(
                table: "RealEstate",
                keyColumn: "Id",
                keyValue: 5,
                column: "NoOfRooms",
                value: 5);

            migrationBuilder.UpdateData(
                table: "RealEstate",
                keyColumn: "Id",
                keyValue: 6,
                column: "NoOfRooms",
                value: 3);

            migrationBuilder.UpdateData(
                table: "RealEstate",
                keyColumn: "Id",
                keyValue: 7,
                column: "NoOfRooms",
                value: 4);

            migrationBuilder.UpdateData(
                table: "RealEstate",
                keyColumn: "Id",
                keyValue: 8,
                column: "NoOfRooms",
                value: 2);
        }
    }
}
