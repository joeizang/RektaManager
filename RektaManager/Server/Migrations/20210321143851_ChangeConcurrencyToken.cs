using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RektaManager.Server.Migrations
{
    public partial class ChangeConcurrencyToken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "xmin",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "xmin",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "xmin",
                table: "StaffShifts");

            migrationBuilder.DropColumn(
                name: "xmin",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "xmin",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "xmin",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "xmin",
                table: "OrderSales");

            migrationBuilder.DropColumn(
                name: "xmin",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "xmin",
                table: "OrderedItems");

            migrationBuilder.DropColumn(
                name: "xmin",
                table: "InvoicePayment");

            migrationBuilder.DropColumn(
                name: "xmin",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "xmin",
                table: "InventoryCategories");

            migrationBuilder.DropColumn(
                name: "xmin",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "xmin",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "xmin",
                table: "ChartOfAccounts");

            migrationBuilder.DropColumn(
                name: "xmin",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "xmin",
                table: "BookedItems");

            migrationBuilder.DropColumn(
                name: "xmin",
                table: "Bills");

            migrationBuilder.DropColumn(
                name: "xmin",
                table: "BillPayments");

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "Users",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "Suppliers",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "StaffShifts",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "Services",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "Products",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "ProductCategories",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "Orders",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "OrderedItems",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "InvoicePayment",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "Invoice",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "InventoryCategories",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "Inventories",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "Customers",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "ChartOfAccounts",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "Bookings",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "BookedItems",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "Bills",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "BillPayments",
                type: "rowversion",
                rowVersion: true,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "StaffShifts");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "OrderedItems");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "InvoicePayment");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "InventoryCategories");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "ChartOfAccounts");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "BookedItems");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Bills");

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "BillPayments");

            migrationBuilder.AddColumn<long>(
                name: "xmin",
                table: "Users",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "xmin",
                table: "Suppliers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "xmin",
                table: "StaffShifts",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "xmin",
                table: "Services",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "xmin",
                table: "Products",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "xmin",
                table: "ProductCategories",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "xmin",
                table: "OrderSales",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "xmin",
                table: "Orders",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "xmin",
                table: "OrderedItems",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "xmin",
                table: "InvoicePayment",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "xmin",
                table: "Invoice",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "xmin",
                table: "InventoryCategories",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "xmin",
                table: "Inventories",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "xmin",
                table: "Customers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "xmin",
                table: "ChartOfAccounts",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "xmin",
                table: "Bookings",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "xmin",
                table: "BookedItems",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "xmin",
                table: "Bills",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "xmin",
                table: "BillPayments",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
