using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace lab365_Todo_Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TodoItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(250)", maxLength: 250, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TodoItem", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TodoItem",
                columns: new[] { "Id", "Active", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { 1, false, new DateTime(2024, 4, 15, 2, 12, 57, 698, DateTimeKind.Utc).AddTicks(8671), "Item 1" },
                    { 2, true, new DateTime(2024, 4, 15, 2, 12, 57, 698, DateTimeKind.Utc).AddTicks(8681), "Item 2" },
                    { 3, false, new DateTime(2024, 4, 15, 2, 12, 57, 698, DateTimeKind.Utc).AddTicks(8685), "Item 3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TodoItem");
        }
    }
}
