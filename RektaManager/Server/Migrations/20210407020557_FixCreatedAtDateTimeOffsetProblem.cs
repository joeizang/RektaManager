using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace RektaManager.Server.Migrations
{
    public partial class FixCreatedAtDateTimeOffsetProblem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdatedAt",
                table: "Users",
                type: "timestamp",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 4, 7, 2, 5, 56, 702, DateTimeKind.Unspecified).AddTicks(8384), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedAt",
                table: "Users",
                type: "timestamp",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 4, 7, 2, 5, 56, 696, DateTimeKind.Unspecified).AddTicks(6727), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedAt",
                table: "ApplicationRole",
                type: "timestamp",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 4, 7, 2, 5, 56, 704, DateTimeKind.Unspecified).AddTicks(3482), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ApplicationRole",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "ApplicationRole",
                type: "varbinary(4000)",
                rowVersion: true,
                nullable: true)
                .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "UpdatedAt",
                table: "ApplicationRole",
                type: "timestamp",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 4, 7, 2, 5, 56, 704, DateTimeKind.Unspecified).AddTicks(8212), new TimeSpan(0, 0, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ApplicationRole");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ApplicationRole");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "ApplicationRole");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "ApplicationRole");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdatedAt",
                table: "Users",
                type: "timestamp",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 4, 7, 2, 5, 56, 702, DateTimeKind.Unspecified).AddTicks(8384), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedAt",
                table: "Users",
                type: "timestamp",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 4, 7, 2, 5, 56, 696, DateTimeKind.Unspecified).AddTicks(6727), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
