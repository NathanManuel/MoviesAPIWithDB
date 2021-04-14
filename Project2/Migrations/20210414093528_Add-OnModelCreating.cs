using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project2.Migrations
{
    public partial class AddOnModelCreating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "ID", "MovieL", "Name" },
                values: new object[] { new Guid("44d96b7e-0f4d-4930-a9cd-78192e0adc0f"), "120 m", "Star Wars III" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "ID",
                keyValue: new Guid("44d96b7e-0f4d-4930-a9cd-78192e0adc0f"));
        }
    }
}
