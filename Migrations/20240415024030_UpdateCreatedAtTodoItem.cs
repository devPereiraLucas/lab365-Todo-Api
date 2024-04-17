using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lab365_Todo_Api.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCreatedAtTodoItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TodoItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 23, 40, 30, 171, DateTimeKind.Local).AddTicks(2716));

            migrationBuilder.UpdateData(
                table: "TodoItem",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 23, 40, 30, 171, DateTimeKind.Local).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "TodoItem",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 23, 40, 30, 171, DateTimeKind.Local).AddTicks(2735));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TodoItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 2, 12, 57, 698, DateTimeKind.Utc).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "TodoItem",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 2, 12, 57, 698, DateTimeKind.Utc).AddTicks(8681));

            migrationBuilder.UpdateData(
                table: "TodoItem",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 2, 12, 57, 698, DateTimeKind.Utc).AddTicks(8685));
        }
    }
}
