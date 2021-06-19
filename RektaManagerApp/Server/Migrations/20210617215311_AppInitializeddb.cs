using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace RektaManagerApp.Server.Migrations
{
    public partial class AppInitializeddb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationRole",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(90)", maxLength: 90, nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2021, 6, 17, 21, 53, 11, 153, DateTimeKind.Unspecified).AddTicks(1736), new TimeSpan(0, 0, 0, 0, 0))),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2021, 6, 17, 21, 53, 11, 153, DateTimeKind.Unspecified).AddTicks(6796), new TimeSpan(0, 0, 0, 0, 0))),
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
                    PartPayment = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    FullPayment = table.Column<bool>(type: "tinyint(1)", nullable: false),
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
                    PartPayment = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    FullPayment = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Reference = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true),
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
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2021, 6, 17, 21, 53, 11, 146, DateTimeKind.Unspecified).AddTicks(1902), new TimeSpan(0, 0, 0, 0, 0))),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2021, 6, 17, 21, 53, 11, 152, DateTimeKind.Unspecified).AddTicks(3656), new TimeSpan(0, 0, 0, 0, 0))),
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
                    Total = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    FullyPaid = table.Column<bool>(type: "tinyint(1)", nullable: false),
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
                    FullyPaid = table.Column<bool>(type: "tinyint(1)", nullable: false),
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
                    { "3a11b384-bc25-436e-aa76-bfe4b825abeb", "22c2ca80-4880-4cc6-9713-1c12bcf07cb5", new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 123, DateTimeKind.Unspecified).AddTicks(7811), new TimeSpan(0, 1, 0, 0, 0)), false, "Admins", null, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 123, DateTimeKind.Unspecified).AddTicks(7448), new TimeSpan(0, 1, 0, 0, 0)) },
                    { "ea3906dd-668e-439c-9fdd-06730841186f", "c9d92978-0d09-4fb5-adad-811cdc4913f5", new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 123, DateTimeKind.Unspecified).AddTicks(8901), new TimeSpan(0, 1, 0, 0, 0)), false, "Users", null, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 123, DateTimeKind.Unspecified).AddTicks(8881), new TimeSpan(0, 1, 0, 0, 0)) },
                    { "5d5ee991-722a-4089-83ee-52a824b8e3b2", "7bdc34e3-b326-4a5e-8c91-99a6e9492384", new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 123, DateTimeKind.Unspecified).AddTicks(8912), new TimeSpan(0, 1, 0, 0, 0)), false, "Owner", null, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 123, DateTimeKind.Unspecified).AddTicks(8908), new TimeSpan(0, 1, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "BookedItems",
                columns: new[] { "Id", "BookingId", "CreatedAt", "CreatedBy", "IsDeleted", "Name", "Price", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 12, null, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(4176), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Very Heavy Decoration", 300000m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(4178), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 11, null, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(4170), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Heavy Decoration", 200000m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(4171), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 10, null, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(4163), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Medium Decoration", 100000m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(4165), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 9, null, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(4156), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Light Decoration", 20000m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(4158), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 8, null, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(4148), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Plastic Tables", 300m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(4150), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 7, null, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(4141), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Banquet Tables", 1000m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(4143), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 6, null, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(4134), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Plastic Chairs", 30m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(4135), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 5, null, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(4127), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Tiffany Chairs", 200m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(4129), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 4, null, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(4120), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "100 Capacity Tent", 8000m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(4122), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 3, null, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(4113), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "250 Capacity Tent", 20000m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(4115), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 2, null, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(4106), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "350 Capacity Tent", 30000m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(4108), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 1, null, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(4090), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "500 Capacity Tent", 40000m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(4097), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" }
                });

            migrationBuilder.InsertData(
                table: "InventoryCategories",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "InventoryId", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 4, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(5646), new TimeSpan(0, 1, 0, 0, 0)), "SYSTEM", "Cooked Food and other types of Food", null, false, "FOODS", new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(5648), new TimeSpan(0, 1, 0, 0, 0)), "SYSTEM" },
                    { 3, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(5639), new TimeSpan(0, 1, 0, 0, 0)), "SYSTEM", "Both alcoholic and non alcoholic drinks", null, false, "WINE AND SPIRITS", new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(5640), new TimeSpan(0, 1, 0, 0, 0)), "SYSTEM" },
                    { 1, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(5308), new TimeSpan(0, 1, 0, 0, 0)), "SYSTEM", "Non Alcoholic drinks", null, false, "SOFT DRINKS", new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(5314), new TimeSpan(0, 1, 0, 0, 0)), "SYSTEM" },
                    { 2, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(5630), new TimeSpan(0, 1, 0, 0, 0)), "SYSTEM", "Alcoholic Beverage drinks", null, false, "DRINKS", new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(5632), new TimeSpan(0, 1, 0, 0, 0)), "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ImageUrl", "IsDeleted", "ItemCode", "ItemName", "Price", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 42, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7285), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Hero", "Hero", 300m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7287), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 31, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7213), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Smirnoff", "Smirnoff Ice", 500m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7214), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 32, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7220), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Big-Origin", "Big Origin", 450m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7222), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 33, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7227), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Tiger", "Tiger", 300m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7228), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 34, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7233), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Radler", "Radler", 300m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7235), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 35, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7239), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Gulder", "Gulder", 350m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7241), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 36, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7247), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Golfberg", "Golfberg", 300m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7248), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 37, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7253), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Star", "Star", 300m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7255), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 38, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7260), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "StarLite", "StarLite", 300m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7262), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 39, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7266), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Legend", "Legend", 450m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7268), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 40, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7273), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "CastleLite", "Castle-Lite", 350m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7274), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 41, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7279), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "D-Black", "Double-Black", 350m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7281), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 43, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7292), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Trophy", "Trophy", 300m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7293), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 52, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7349), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "EnergyDnk", "Energy Drink", 500m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7351), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 45, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7304), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Coke", "Coke", 300m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7306), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 46, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7311), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Sprite", "Sprite", 300m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7312), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 47, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7317), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Fanta", "Fanta", 300m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7319), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 48, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7324), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Can-Malt", "Can Malt", 300m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7325), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 49, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7330), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "MaltBottle", "Bottled Malt", 300m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7332), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 50, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7337), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Juice", "Juice", 500m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7338), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 51, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7343), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Water", "Water", 100m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7345), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 30, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7155), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "ExSmooth", "Extra Smooth", 400m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7156), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 53, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7356), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Mateaus", "Mateaus", 3000m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7357), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 54, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7362), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Donfed", "DonFelder", 3000m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7364), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 55, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7368), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Donfed", "Four Cousins", 2700m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7370), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 56, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7375), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Baron", "Baron", 2000m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7376), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 44, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7298), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Budweiser", "Budweiser", 450m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7299), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 29, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7148), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "MedStout", "Medium Stout", 400m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7150), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 23, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7107), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "TilapiaBig", "Roasted Tilapia", 2000m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7108), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 27, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7134), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Isiewu", "Isiewu", 800m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7135), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 1, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(6949), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Semo-Any", "Semovita/Any Soup", 600m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(6956), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 2, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(6965), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Eba-Any", "Eba/Any Soup", 600m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(6966), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 3, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(6972), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Beans-P", "Beans-Plantain", 500m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(6973), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 4, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(6979), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "F-Rice", "Fried Rice", 700m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(6980), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 5, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(6985), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "J-Rice", "Jollof Rice", 600m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(6987), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 6, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(6992), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Rice-Stew", "Rice-Stew", 600m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(6994), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 7, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(6999), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Chips-Eggs", "Chips-Eggs", 700m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7000), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 8, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7006), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "IndomieEgg", "Indomie-Egg", 700m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7007), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 9, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7012), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "LeafMoimoi", "Leaf Moimoi", 200m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7014), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 28, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7141), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Heineken", "Heineken", 450m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7143), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 11, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7026), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Cowtail", "CowTail P.Soup", 1000m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7028), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 12, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7033), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Fresh-Fish", "Fresh Fish", 800m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7034), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 13, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7039), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Intestine", "Intestine", 600m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7041), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 10, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7019), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "CowLeg", "CowLeg P.Soup", 1000m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7021), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 15, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7053), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "PepGoat", "Asun", 700m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7054), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 26, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7127), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "CatfishSm", "Steamed Catfish", 3000m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7129), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 14, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7046), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "PepChicken", "Peppered Chicken", 800m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7048), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 24, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7114), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "TilapiaSm", "Roasted Tilapia", 1800m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7115), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 22, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7100), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "ShwmChick", "Burger", 1000m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7102), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 21, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7093), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "ShwmBeef", "Shawarma Beef", 800m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7095), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 25, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7120), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "StmCatfish", "Steamed Catfish", 3500m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7122), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 19, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7080), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Semo-Any", "Potato Salad", 1000m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7082), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 18, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7073), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "MixedSalad", "Mixed Salad", 500m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7075), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 17, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7066), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Coleslaw", "Coleslaw", 200m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7069), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 16, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7060), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Gizdodo", "Gizdodo", 600m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7061), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 20, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7087), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "ShwmChick", "Shawarma Chicken", 1200m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(7088), new TimeSpan(0, 1, 0, 0, 0)), null }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "BookingId", "CreatedAt", "CreatedBy", "IsDeleted", "Name", "Price", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 8, null, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(2919), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Party (Indoor)", 30000m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(2921), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 1, null, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(1635), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Wedding", 100000m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(1947), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 2, null, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(2768), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "BirthdaysAnniversaries", 40000m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(2772), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 3, null, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(2782), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "ChildBirthdays", 20000m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(2784), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 4, null, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(2890), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Hangouts", 40000m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(2892), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 5, null, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(2898), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Concerts", 100000m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(2899), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 6, null, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(2905), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Picnics", 5000m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(2907), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 7, null, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(2912), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Corporate Events", 50000m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(2913), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 9, null, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(2927), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "MiniConference-Training", 20000m, new DateTimeOffset(new DateTime(2021, 6, 17, 22, 53, 11, 125, DateTimeKind.Unspecified).AddTicks(2929), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" }
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
