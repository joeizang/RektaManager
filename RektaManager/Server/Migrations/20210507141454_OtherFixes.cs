using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RektaManager.Server.Migrations
{
    public partial class OtherFixes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdatedAt",
                table: "Users",
                type: "timestamp",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 5, 7, 14, 14, 54, 61, DateTimeKind.Unspecified).AddTicks(4185), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 4, 20, 12, 32, 25, 31, DateTimeKind.Unspecified).AddTicks(8894), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedAt",
                table: "Users",
                type: "timestamp",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 5, 7, 14, 14, 54, 52, DateTimeKind.Unspecified).AddTicks(4447), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 4, 20, 12, 32, 25, 13, DateTimeKind.Unspecified).AddTicks(6083), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<float>(
                name: "OrderedItemsCount",
                table: "Orders",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdatedAt",
                table: "ApplicationRole",
                type: "timestamp",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 5, 7, 14, 14, 54, 63, DateTimeKind.Unspecified).AddTicks(8939), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 4, 20, 12, 32, 25, 36, DateTimeKind.Unspecified).AddTicks(9594), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedAt",
                table: "ApplicationRole",
                type: "timestamp",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 5, 7, 14, 14, 54, 63, DateTimeKind.Unspecified).AddTicks(2311), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 4, 20, 12, 32, 25, 35, DateTimeKind.Unspecified).AddTicks(5639), new TimeSpan(0, 0, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderedItemsCount",
                table: "Orders");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdatedAt",
                table: "Users",
                type: "timestamp",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 4, 20, 12, 32, 25, 31, DateTimeKind.Unspecified).AddTicks(8894), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 5, 7, 14, 14, 54, 61, DateTimeKind.Unspecified).AddTicks(4185), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedAt",
                table: "Users",
                type: "timestamp",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 4, 20, 12, 32, 25, 13, DateTimeKind.Unspecified).AddTicks(6083), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 5, 7, 14, 14, 54, 52, DateTimeKind.Unspecified).AddTicks(4447), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdatedAt",
                table: "ApplicationRole",
                type: "timestamp",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 4, 20, 12, 32, 25, 36, DateTimeKind.Unspecified).AddTicks(9594), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 5, 7, 14, 14, 54, 63, DateTimeKind.Unspecified).AddTicks(8939), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedAt",
                table: "ApplicationRole",
                type: "timestamp",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 4, 20, 12, 32, 25, 35, DateTimeKind.Unspecified).AddTicks(5639), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 5, 7, 14, 14, 54, 63, DateTimeKind.Unspecified).AddTicks(2311), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
