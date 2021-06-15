using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace RektaManagerApp.Server.Migrations
{
    public partial class FreshAppInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationRole",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(90)", maxLength: 90, nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2021, 6, 14, 14, 36, 32, 20, DateTimeKind.Unspecified).AddTicks(3615), new TimeSpan(0, 0, 0, 0, 0))),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2021, 6, 14, 14, 36, 32, 20, DateTimeKind.Unspecified).AddTicks(8043), new TimeSpan(0, 0, 0, 0, 0))),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Timestamp = table.Column<byte[]>(type: "varbinary(4000)", rowVersion: true, nullable: true)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    NormalizedName = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BillActionAudits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", rowVersion: true, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn),
                    Changes = table.Column<string>(type: "text", nullable: true),
                    Actions = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillActionAudits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BillPaymentActionAudits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", rowVersion: true, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn),
                    Changes = table.Column<string>(type: "text", nullable: true),
                    Actions = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillPaymentActionAudits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BillPayments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(90)", nullable: false),
                    TransactionDate = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    Description = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true),
                    Reference = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true),
                    Total = table.Column<decimal>(type: "decimal(20,2)", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", rowVersion: true, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillPayments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookedItemActionAudits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", rowVersion: true, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn),
                    Changes = table.Column<string>(type: "text", nullable: true),
                    Actions = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookedItemActionAudits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookingAudits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Changes = table.Column<string>(type: "text", nullable: true),
                    Actions = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingAudits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChartOfAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", rowVersion: true, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChartOfAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChartOfAccountsActionAudits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", rowVersion: true, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn),
                    Changes = table.Column<string>(type: "text", nullable: true),
                    Actions = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChartOfAccountsActionAudits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerActionAudits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", rowVersion: true, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn),
                    Changes = table.Column<string>(type: "text", nullable: true),
                    Actions = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerActionAudits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "varchar(44)", maxLength: 44, nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", rowVersion: true, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceFlowCodes",
                columns: table => new
                {
                    UserCode = table.Column<string>(type: "varchar(90)", nullable: false),
                    DeviceCode = table.Column<string>(type: "text", nullable: true),
                    SubjectId = table.Column<string>(type: "text", nullable: true),
                    SessionId = table.Column<string>(type: "text", nullable: true),
                    ClientId = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime", nullable: true),
                    Data = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceFlowCodes", x => x.UserCode);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    SupplyDate = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    TotalInventoryValuation = table.Column<decimal>(type: "decimal(20,2)", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", rowVersion: true, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InventoryActionsAudit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Changes = table.Column<string>(type: "text", nullable: true),
                    Actions = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", rowVersion: true, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryActionsAudit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InventoryCategoryActionAudits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", rowVersion: true, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn),
                    Changes = table.Column<string>(type: "text", nullable: true),
                    Actions = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryCategoryActionAudits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceAudits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Changes = table.Column<string>(type: "text", nullable: true),
                    Actions = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", rowVersion: true, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceAudits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InvoicePayments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(90)", nullable: false),
                    TransactionDate = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    Description = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true),
                    Reference = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true),
                    Total = table.Column<decimal>(type: "decimal(20,2)", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", rowVersion: true, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoicePayments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InvoicePaymentsActionAudit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", rowVersion: true, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn),
                    Changes = table.Column<string>(type: "text", nullable: true),
                    Actions = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoicePaymentsActionAudit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderActionsAudit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", rowVersion: true, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn),
                    Changes = table.Column<string>(type: "text", nullable: true),
                    Actions = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderActionsAudit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderedItemActionAudits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", rowVersion: true, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn),
                    Changes = table.Column<string>(type: "text", nullable: true),
                    Actions = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderedItemActionAudits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderItemActionsAudits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", rowVersion: true, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn),
                    Changes = table.Column<string>(type: "text", nullable: true),
                    Actions = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItemActionsAudits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ImageUrl = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(20,2)", nullable: false),
                    ItemName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    ItemCode = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", rowVersion: true, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    Key = table.Column<string>(type: "varchar(90)", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: true),
                    SubjectId = table.Column<string>(type: "text", nullable: true),
                    SessionId = table.Column<string>(type: "text", nullable: true),
                    ClientId = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime", nullable: true),
                    ConsumedTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Data = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "ProductActionsAudit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", rowVersion: true, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn),
                    Changes = table.Column<string>(type: "text", nullable: true),
                    Actions = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductActionsAudit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategoryActionsAudits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", rowVersion: true, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn),
                    Changes = table.Column<string>(type: "text", nullable: true),
                    Actions = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategoryActionsAudits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 90, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "text", nullable: true),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(90)", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    NormalizedName = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceActionsAudits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", rowVersion: true, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn),
                    Changes = table.Column<string>(type: "text", nullable: true),
                    Actions = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceActionsAudits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StaffShiftActionsAudit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    Changes = table.Column<string>(type: "text", nullable: true),
                    Actions = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffShiftActionsAudit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SupplierActionsAudits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", rowVersion: true, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn),
                    Changes = table.Column<string>(type: "text", nullable: true),
                    Actions = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierActionsAudits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "varchar(44)", maxLength: 44, nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", rowVersion: true, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 90, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(90)", maxLength: 90, nullable: false),
                    ProviderKey = table.Column<string>(type: "varchar(90)", maxLength: 90, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(90)", nullable: false),
                    RoleId = table.Column<string>(type: "varchar(90)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(90)", maxLength: 90, nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2021, 6, 14, 14, 36, 32, 13, DateTimeKind.Unspecified).AddTicks(9608), new TimeSpan(0, 0, 0, 0, 0))),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2021, 6, 14, 14, 36, 32, 19, DateTimeKind.Unspecified).AddTicks(7802), new TimeSpan(0, 0, 0, 0, 0))),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    OtherNames = table.Column<string>(type: "text", nullable: true),
                    StaffIdNumber = table.Column<string>(type: "text", nullable: true),
                    Timestamp = table.Column<byte[]>(type: "varbinary(4000)", rowVersion: true, nullable: true)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "text", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(90)", nullable: false),
                    LoginProvider = table.Column<string>(type: "varchar(90)", maxLength: 90, nullable: false),
                    Name = table.Column<string>(type: "varchar(90)", maxLength: 90, nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                });

            migrationBuilder.CreateTable(
                name: "InventoryCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    InventoryId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", rowVersion: true, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InventoryCategories_Inventories_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "Inventories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(90)", nullable: false),
                    TransactionDate = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    DueDate = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    InvoicePaymentStatus = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    InvoicePaymentId = table.Column<string>(type: "varchar(90)", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", rowVersion: true, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoices_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoices_InvoicePayments_InvoicePaymentId",
                        column: x => x.InvoicePaymentId,
                        principalTable: "InvoicePayments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(90)", nullable: false),
                    TransactionDate = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    DueDate = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    Description = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true),
                    References = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true),
                    Total = table.Column<decimal>(type: "decimal(20,2)", nullable: false),
                    PaymentStatus = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ChartOfAccountsId = table.Column<int>(type: "int", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    BillPaymentId = table.Column<string>(type: "varchar(90)", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", rowVersion: true, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bills_BillPayments_BillPaymentId",
                        column: x => x.BillPaymentId,
                        principalTable: "BillPayments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bills_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CostPrice = table.Column<decimal>(type: "decimal(20,2)", nullable: false),
                    QuantityBought = table.Column<double>(type: "double", nullable: false),
                    ProductUniqueIdentifier = table.Column<string>(type: "text", nullable: true),
                    UnitMeasure = table.Column<int>(type: "int", nullable: false),
                    ProductInventoryId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", rowVersion: true, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Inventories_ProductInventoryId",
                        column: x => x.ProductInventoryId,
                        principalTable: "Inventories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(90)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    OrderedItemsCount = table.Column<float>(type: "float", nullable: false),
                    StaffId = table.Column<string>(type: "varchar(90)", nullable: false),
                    OrderDate = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(20,2)", nullable: false),
                    InvoiceId = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", rowVersion: true, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Users_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StaffShifts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    StaffId = table.Column<string>(type: "varchar(90)", nullable: false),
                    OffDay = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    ShiftStartsAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    ShiftEndsAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "varchar(90)", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", rowVersion: true, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffShifts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaffShifts_Users_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StaffShifts_Users_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(90)", nullable: false),
                    Deposit = table.Column<decimal>(type: "decimal(20,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(20,2)", nullable: false),
                    BookingDate = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    EventDate = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    StaffProcessingId = table.Column<string>(type: "varchar(90)", nullable: true),
                    StaffId = table.Column<string>(type: "text", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsPartPayment = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsFullyPaid = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InvoiceId = table.Column<int>(type: "int", nullable: false),
                    InvoiceId1 = table.Column<string>(type: "varchar(90)", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", rowVersion: true, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bookings_Invoices_InvoiceId1",
                        column: x => x.InvoiceId1,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bookings_Users_StaffProcessingId",
                        column: x => x.StaffProcessingId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChartOfAccountsInvoice",
                columns: table => new
                {
                    ChartOfAccountsId = table.Column<int>(type: "int", nullable: false),
                    InvoicesId = table.Column<string>(type: "varchar(90)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChartOfAccountsInvoice", x => new { x.ChartOfAccountsId, x.InvoicesId });
                    table.ForeignKey(
                        name: "FK_ChartOfAccountsInvoice_ChartOfAccounts_ChartOfAccountsId",
                        column: x => x.ChartOfAccountsId,
                        principalTable: "ChartOfAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChartOfAccountsInvoice_Invoices_InvoicesId",
                        column: x => x.InvoicesId,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BillChartOfAccounts",
                columns: table => new
                {
                    BillsId = table.Column<string>(type: "varchar(90)", nullable: false),
                    ChartOfAccountsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillChartOfAccounts", x => new { x.BillsId, x.ChartOfAccountsId });
                    table.ForeignKey(
                        name: "FK_BillChartOfAccounts_Bills_BillsId",
                        column: x => x.BillsId,
                        principalTable: "Bills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillChartOfAccounts_ChartOfAccounts_ChartOfAccountsId",
                        column: x => x.ChartOfAccountsId,
                        principalTable: "ChartOfAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", rowVersion: true, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderedItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<string>(type: "varchar(90)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(20,2)", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Quantity = table.Column<double>(type: "double", nullable: false),
                    ItemCode = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", rowVersion: true, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderedItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderedItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderSales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    InvoiceId = table.Column<string>(type: "varchar(90)", nullable: false),
                    OrderId = table.Column<string>(type: "varchar(90)", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", rowVersion: true, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderSales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderSales_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderSales_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookedItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Price = table.Column<decimal>(type: "decimal(20,2)", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    BookingId = table.Column<string>(type: "varchar(90)", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", rowVersion: true, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookedItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookedItems_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookingSales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    BookingId = table.Column<string>(type: "varchar(90)", nullable: false),
                    InvoiceId = table.Column<string>(type: "varchar(90)", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", rowVersion: true, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingSales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingSales_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookingSales_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(20,2)", nullable: false),
                    BookingId = table.Column<string>(type: "varchar(90)", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime", rowVersion: true, nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.ComputedColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Services_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ApplicationRole",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedAt", "IsDeleted", "Name", "NormalizedName", "UpdatedAt" },
                values: new object[,]
                {
                    { "77561da0-1c49-4435-a097-52ea3e982781", "dc14452f-b048-453f-8542-dda4122f3871", new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 994, DateTimeKind.Unspecified).AddTicks(5387), new TimeSpan(0, 1, 0, 0, 0)), false, "Admins", null, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 994, DateTimeKind.Unspecified).AddTicks(5111), new TimeSpan(0, 1, 0, 0, 0)) },
                    { "500f8b0c-87b7-4b30-8863-ea5e3157ddb8", "15db4591-ebe3-439f-b6b9-24c059726bdb", new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 994, DateTimeKind.Unspecified).AddTicks(5952), new TimeSpan(0, 1, 0, 0, 0)), false, "Users", null, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 994, DateTimeKind.Unspecified).AddTicks(5937), new TimeSpan(0, 1, 0, 0, 0)) },
                    { "bc58ab7e-4229-430e-8605-3b40d19b5121", "0f19530b-a404-40d7-b151-bc1677183b1f", new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 994, DateTimeKind.Unspecified).AddTicks(5972), new TimeSpan(0, 1, 0, 0, 0)), false, "Owner", null, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 994, DateTimeKind.Unspecified).AddTicks(5958), new TimeSpan(0, 1, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "BookedItems",
                columns: new[] { "Id", "BookingId", "CreatedAt", "CreatedBy", "IsDeleted", "Name", "Price", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 12, null, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(8771), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Very Heavy Decoration", 300000m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(8772), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 11, null, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(8764), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Heavy Decoration", 200000m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(8765), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 10, null, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(8757), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Medium Decoration", 100000m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(8759), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 9, null, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(8751), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Light Decoration", 20000m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(8752), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 8, null, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(8744), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Plastic Tables", 300m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(8745), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 7, null, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(8737), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Banquet Tables", 1000m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(8739), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 6, null, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(8730), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Plastic Chairs", 30m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(8732), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 5, null, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(8724), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Tiffany Chairs", 200m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(8725), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 4, null, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(8716), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "100 Capacity Tent", 8000m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(8718), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 3, null, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(8710), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "250 Capacity Tent", 20000m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(8712), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 2, null, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(8704), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "350 Capacity Tent", 30000m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(8705), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 1, null, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "500 Capacity Tent", 40000m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(8697), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" }
                });

            migrationBuilder.InsertData(
                table: "InventoryCategories",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "InventoryId", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 4, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(9962), new TimeSpan(0, 1, 0, 0, 0)), "SYSTEM", "Cooked Food and other types of Food", null, false, "FOODS", new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(9963), new TimeSpan(0, 1, 0, 0, 0)), "SYSTEM" },
                    { 3, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(9955), new TimeSpan(0, 1, 0, 0, 0)), "SYSTEM", "Both alcoholic and non alcoholic drinks", null, false, "WINE AND SPIRITS", new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(9956), new TimeSpan(0, 1, 0, 0, 0)), "SYSTEM" },
                    { 1, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(9675), new TimeSpan(0, 1, 0, 0, 0)), "SYSTEM", "Non Alcoholic drinks", null, false, "SOFT DRINKS", new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(9682), new TimeSpan(0, 1, 0, 0, 0)), "SYSTEM" },
                    { 2, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(9946), new TimeSpan(0, 1, 0, 0, 0)), "SYSTEM", "Alcoholic Beverage drinks", null, false, "DRINKS", new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(9948), new TimeSpan(0, 1, 0, 0, 0)), "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ImageUrl", "IsDeleted", "ItemCode", "ItemName", "Price", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 42, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1501), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Hero", "Hero", 300m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1503), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 31, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1435), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Smirnoff", "Smirnoff Ice", 500m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1437), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 32, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1441), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Big-Origin", "Big Origin", 450m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1443), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 33, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1447), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Tiger", "Tiger", 300m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1449), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 34, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1453), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Radler", "Radler", 300m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1455), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 35, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1459), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Gulder", "Gulder", 350m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1461), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 36, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1465), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Golfberg", "Golfberg", 300m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1467), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 37, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1472), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Star", "Star", 300m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1473), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 38, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1477), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "StarLite", "StarLite", 300m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1479), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 39, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1483), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Legend", "Legend", 450m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1485), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 40, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1489), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "CastleLite", "Castle-Lite", 350m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1491), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 41, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1495), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "D-Black", "Double-Black", 350m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1497), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 43, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1507), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Trophy", "Trophy", 300m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1508), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 52, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1560), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "EnergyDnk", "Energy Drink", 500m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1562), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 45, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1518), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Coke", "Coke", 300m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1520), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 46, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1524), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Sprite", "Sprite", 300m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1526), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 47, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1530), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Fanta", "Fanta", 300m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1532), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 48, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1536), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Can-Malt", "Can Malt", 300m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1538), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 49, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1542), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "MaltBottle", "Bottled Malt", 300m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1544), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 50, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1549), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Juice", "Juice", 500m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1550), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 51, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1555), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Water", "Water", 100m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1556), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 30, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1429), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "ExSmooth", "Extra Smooth", 400m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1431), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 53, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1566), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Mateaus", "Mateaus", 3000m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1568), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 54, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1572), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Donfed", "DonFelder", 3000m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1574), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 55, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1578), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Donfed", "Four Cousins", 2700m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1579), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 56, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1584), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Baron", "Baron", 2000m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1585), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 44, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1513), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Budweiser", "Budweiser", 450m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1514), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 29, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1423), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "MedStout", "Medium Stout", 400m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1425), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 23, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1389), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "TilapiaBig", "Roasted Tilapia", 2000m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1390), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 27, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1412), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Isiewu", "Isiewu", 800m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1413), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 1, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1242), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Semo-Any", "Semovita/Any Soup", 600m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1250), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 2, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1257), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Eba-Any", "Eba/Any Soup", 600m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1259), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 3, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1264), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Beans-P", "Beans-Plantain", 500m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1266), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 4, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1270), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "F-Rice", "Fried Rice", 700m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1272), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 5, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1276), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "J-Rice", "Jollof Rice", 600m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1278), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 6, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1282), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Rice-Stew", "Rice-Stew", 600m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1284), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 7, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1288), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Chips-Eggs", "Chips-Eggs", 700m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1290), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 8, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1295), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "IndomieEgg", "Indomie-Egg", 700m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1298), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 9, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1303), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "LeafMoimoi", "Leaf Moimoi", 200m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1304), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 28, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1418), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Heineken", "Heineken", 450m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1419), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 11, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1315), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Cowtail", "CowTail P.Soup", 1000m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1317), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 12, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1321), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Fresh-Fish", "Fresh Fish", 800m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1322), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 13, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1327), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Intestine", "Intestine", 600m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1328), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 10, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1309), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "CowLeg", "CowLeg P.Soup", 1000m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1311), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 15, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1339), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "PepGoat", "Asun", 700m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1341), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 26, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1406), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "CatfishSm", "Steamed Catfish", 3000m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1407), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 14, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1332), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "PepChicken", "Peppered Chicken", 800m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1334), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 24, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1394), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "TilapiaSm", "Roasted Tilapia", 1800m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1396), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 22, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1383), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "ShwmChick", "Burger", 1000m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1384), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 21, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1377), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "ShwmBeef", "Shawarma Beef", 800m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1378), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 25, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1400), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "StmCatfish", "Steamed Catfish", 3500m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1402), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 19, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1365), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Semo-Any", "Potato Salad", 1000m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1366), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 18, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1359), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "MixedSalad", "Mixed Salad", 500m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1360), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 17, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1353), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Coleslaw", "Coleslaw", 200m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1355), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 16, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1345), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Gizdodo", "Gizdodo", 600m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1348), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 20, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1371), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "ShwmChick", "Shawarma Chicken", 1200m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 996, DateTimeKind.Unspecified).AddTicks(1373), new TimeSpan(0, 1, 0, 0, 0)), null }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "BookingId", "CreatedAt", "CreatedBy", "IsDeleted", "Name", "Price", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 8, null, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(7696), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Party (Indoor)", 30000m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(7697), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 1, null, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(6673), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Wedding", 100000m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(6953), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 2, null, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(7654), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "BirthdaysAnniversaries", 40000m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(7656), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 3, null, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(7663), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "ChildBirthdays", 20000m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(7664), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 4, null, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(900), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Hangouts", 40000m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(902), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 5, null, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(906), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Concerts", 100000m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(907), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 6, null, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(7683), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Picnics", 5000m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(7684), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 7, null, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(7690), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Corporate Events", 50000m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(7691), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 9, null, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(7702), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "MiniConference-Training", 20000m, new DateTimeOffset(new DateTime(2021, 6, 14, 15, 36, 31, 995, DateTimeKind.Unspecified).AddTicks(7704), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BillChartOfAccounts_ChartOfAccountsId",
                table: "BillChartOfAccounts",
                column: "ChartOfAccountsId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_BillPaymentId",
                table: "Bills",
                column: "BillPaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_SupplierId",
                table: "Bills",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_BookedItems_BookingId",
                table: "BookedItems",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CustomerId",
                table: "Bookings",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_InvoiceId1",
                table: "Bookings",
                column: "InvoiceId1");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_StaffProcessingId",
                table: "Bookings",
                column: "StaffProcessingId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingSales_BookingId",
                table: "BookingSales",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingSales_InvoiceId",
                table: "BookingSales",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ChartOfAccountsInvoice_InvoicesId",
                table: "ChartOfAccountsInvoice",
                column: "InvoicesId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryCategories_InventoryId",
                table: "InventoryCategories",
                column: "InventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_CustomerId",
                table: "Invoices",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_InvoicePaymentId",
                table: "Invoices",
                column: "InvoicePaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderedItems_OrderId",
                table: "OrderedItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StaffId",
                table: "Orders",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderSales_InvoiceId",
                table: "OrderSales",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderSales_OrderId",
                table: "OrderSales",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_ProductId",
                table: "ProductCategories",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductInventoryId",
                table: "Products",
                column: "ProductInventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupplierId",
                table: "Products",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_BookingId",
                table: "Services",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffShifts_ApplicationUserId",
                table: "StaffShifts",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffShifts_StaffId",
                table: "StaffShifts",
                column: "StaffId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationRole");

            migrationBuilder.DropTable(
                name: "BillActionAudits");

            migrationBuilder.DropTable(
                name: "BillChartOfAccounts");

            migrationBuilder.DropTable(
                name: "BillPaymentActionAudits");

            migrationBuilder.DropTable(
                name: "BookedItemActionAudits");

            migrationBuilder.DropTable(
                name: "BookedItems");

            migrationBuilder.DropTable(
                name: "BookingAudits");

            migrationBuilder.DropTable(
                name: "BookingSales");

            migrationBuilder.DropTable(
                name: "ChartOfAccountsActionAudits");

            migrationBuilder.DropTable(
                name: "ChartOfAccountsInvoice");

            migrationBuilder.DropTable(
                name: "CustomerActionAudits");

            migrationBuilder.DropTable(
                name: "DeviceFlowCodes");

            migrationBuilder.DropTable(
                name: "InventoryActionsAudit");

            migrationBuilder.DropTable(
                name: "InventoryCategories");

            migrationBuilder.DropTable(
                name: "InventoryCategoryActionAudits");

            migrationBuilder.DropTable(
                name: "InvoiceAudits");

            migrationBuilder.DropTable(
                name: "InvoicePaymentsActionAudit");

            migrationBuilder.DropTable(
                name: "OrderActionsAudit");

            migrationBuilder.DropTable(
                name: "OrderedItemActionAudits");

            migrationBuilder.DropTable(
                name: "OrderedItems");

            migrationBuilder.DropTable(
                name: "OrderItemActionsAudits");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "OrderSales");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "ProductActionsAudit");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "ProductCategoryActionsAudits");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "ServiceActionsAudits");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "StaffShiftActionsAudit");

            migrationBuilder.DropTable(
                name: "StaffShifts");

            migrationBuilder.DropTable(
                name: "SupplierActionsAudits");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "ChartOfAccounts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "BillPayments");

            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "InvoicePayments");
        }
    }
}
