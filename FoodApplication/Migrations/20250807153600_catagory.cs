using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodApplication.Migrations
{
    /// <inheritdoc />
    public partial class catagory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05b32cca-ce74-4626-a66f-3922ca94e390");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "806cc349-b8c4-4219-8ec4-d175e0dae376");

            migrationBuilder.AddColumn<string>(
                name: "Catagory",
                table: "Items",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "001b9c43-6304-4d4e-a301-6cc81727ea7f", null, "Admin", "ADMIN" },
                    { "38c72d04-a772-4f07-aa56-6e6b30017444", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "001b9c43-6304-4d4e-a301-6cc81727ea7f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38c72d04-a772-4f07-aa56-6e6b30017444");

            migrationBuilder.DropColumn(
                name: "Catagory",
                table: "Items");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "05b32cca-ce74-4626-a66f-3922ca94e390", null, "Admin", "ADMIN" },
                    { "806cc349-b8c4-4219-8ec4-d175e0dae376", null, "User", "USER" }
                });
        }
    }
}
