using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoManager.Web.Data.Migrations
{
    public partial class DateColumnRename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompletedDate",
                table: "ToDos");

            migrationBuilder.DropColumn(
                name: "DueDate",
                table: "ToDos");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "ToDos");

            migrationBuilder.AddColumn<DateTime>(
                name: "Completed",
                table: "ToDos",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Due",
                table: "ToDos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Start",
                table: "ToDos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Completed",
                table: "ToDos");

            migrationBuilder.DropColumn(
                name: "Due",
                table: "ToDos");

            migrationBuilder.DropColumn(
                name: "Start",
                table: "ToDos");

            migrationBuilder.AddColumn<DateTime>(
                name: "CompletedDate",
                table: "ToDos",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DueDate",
                table: "ToDos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "ToDos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
