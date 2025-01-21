using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UserMicroserviceDAL.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("0f5ea429-2e73-4a0b-93c3-f3b8b0eafb31"), "ethan.jones@example.com", "Ethan", "Jones" },
                    { new Guid("6f9a39fb-6876-4dbf-9657-f1f29b519f4d"), "alice.smith@example.com", "Alic", "Smith" },
                    { new Guid("e3a1976b-83e4-4f65-9b8f-67a5c317f8a7"), "bob.johnson@example.com", "Bob", "Johnson" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0f5ea429-2e73-4a0b-93c3-f3b8b0eafb31"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6f9a39fb-6876-4dbf-9657-f1f29b519f4d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e3a1976b-83e4-4f65-9b8f-67a5c317f8a7"));
        }
    }
}
