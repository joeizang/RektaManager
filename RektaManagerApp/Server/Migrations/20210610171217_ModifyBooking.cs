using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RektaManagerApp.Server.Migrations
{
    public partial class ModifyBooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdatedAt",
                table: "Users",
                type: "timestamp",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 6, 10, 17, 12, 17, 185, DateTimeKind.Unspecified).AddTicks(4218), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 6, 8, 20, 39, 52, 335, DateTimeKind.Unspecified).AddTicks(1390), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedAt",
                table: "Users",
                type: "timestamp",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 6, 10, 17, 12, 17, 179, DateTimeKind.Unspecified).AddTicks(9466), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 6, 8, 20, 39, 52, 329, DateTimeKind.Unspecified).AddTicks(6614), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Bookings",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsFullyPaid",
                table: "Bookings",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPartPayment",
                table: "Bookings",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdatedAt",
                table: "ApplicationRole",
                type: "timestamp",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 6, 10, 17, 12, 17, 187, DateTimeKind.Unspecified).AddTicks(7853), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 6, 8, 20, 39, 52, 337, DateTimeKind.Unspecified).AddTicks(2521), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedAt",
                table: "ApplicationRole",
                type: "timestamp",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 6, 10, 17, 12, 17, 187, DateTimeKind.Unspecified).AddTicks(3556), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 6, 8, 20, 39, 52, 336, DateTimeKind.Unspecified).AddTicks(8491), new TimeSpan(0, 0, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "IsFullyPaid",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "IsPartPayment",
                table: "Bookings");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdatedAt",
                table: "Users",
                type: "timestamp",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 6, 8, 20, 39, 52, 335, DateTimeKind.Unspecified).AddTicks(1390), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 6, 10, 17, 12, 17, 185, DateTimeKind.Unspecified).AddTicks(4218), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedAt",
                table: "Users",
                type: "timestamp",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 6, 8, 20, 39, 52, 329, DateTimeKind.Unspecified).AddTicks(6614), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 6, 10, 17, 12, 17, 179, DateTimeKind.Unspecified).AddTicks(9466), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdatedAt",
                table: "ApplicationRole",
                type: "timestamp",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 6, 8, 20, 39, 52, 337, DateTimeKind.Unspecified).AddTicks(2521), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 6, 10, 17, 12, 17, 187, DateTimeKind.Unspecified).AddTicks(7853), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedAt",
                table: "ApplicationRole",
                type: "timestamp",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2021, 6, 8, 20, 39, 52, 336, DateTimeKind.Unspecified).AddTicks(8491), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp",
                oldDefaultValue: new DateTimeOffset(new DateTime(2021, 6, 10, 17, 12, 17, 187, DateTimeKind.Unspecified).AddTicks(3556), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
