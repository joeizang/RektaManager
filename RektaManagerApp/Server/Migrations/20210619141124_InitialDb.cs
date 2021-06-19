using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace RektaManagerApp.Server.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationRole",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(90)", maxLength: 90, nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2021, 6, 19, 14, 11, 23, 569, DateTimeKind.Unspecified).AddTicks(2869), new TimeSpan(0, 0, 0, 0, 0))),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2021, 6, 19, 14, 11, 23, 569, DateTimeKind.Unspecified).AddTicks(7262), new TimeSpan(0, 0, 0, 0, 0))),
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
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2021, 6, 19, 14, 11, 23, 560, DateTimeKind.Unspecified).AddTicks(6010), new TimeSpan(0, 0, 0, 0, 0))),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "timestamp", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2021, 6, 19, 14, 11, 23, 568, DateTimeKind.Unspecified).AddTicks(5606), new TimeSpan(0, 0, 0, 0, 0))),
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
                    IsFullyPaid = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InvoiceId = table.Column<string>(type: "varchar(90)", nullable: true),
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
                        name: "FK_Bookings_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
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
                    { "75d8c592-c53b-4375-a3c0-a78cd4029224", "ab9ce810-5585-483f-875a-67991cfee00b", new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 532, DateTimeKind.Unspecified).AddTicks(4409), new TimeSpan(0, 1, 0, 0, 0)), false, "Admins", null, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 532, DateTimeKind.Unspecified).AddTicks(3833), new TimeSpan(0, 1, 0, 0, 0)) },
                    { "a506fe5c-39be-4163-ba9f-d9d7e6a744b6", "df1e74cb-e0ac-4d01-ae12-edd8bc8e5df5", new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 532, DateTimeKind.Unspecified).AddTicks(5681), new TimeSpan(0, 1, 0, 0, 0)), false, "Users", null, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 532, DateTimeKind.Unspecified).AddTicks(5654), new TimeSpan(0, 1, 0, 0, 0)) },
                    { "c3c2ae01-e41d-43c0-9e4d-a9c1152a029b", "8bb614a4-e7fb-4245-a73b-07b4a6884bf5", new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 532, DateTimeKind.Unspecified).AddTicks(5694), new TimeSpan(0, 1, 0, 0, 0)), false, "Owner", null, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 532, DateTimeKind.Unspecified).AddTicks(5689), new TimeSpan(0, 1, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "BookedItems",
                columns: new[] { "Id", "BookingId", "CreatedAt", "CreatedBy", "IsDeleted", "Name", "Price", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 12, null, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(5371), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Very Heavy Decoration", 300000m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(5372), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 11, null, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(5363), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Heavy Decoration", 200000m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(5365), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 10, null, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(5355), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Medium Decoration", 100000m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(5357), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 9, null, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(5348), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Light Decoration", 20000m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(5350), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 8, null, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(5341), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Plastic Tables", 300m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(5343), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 7, null, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(5329), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Banquet Tables", 1000m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(5336), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 6, null, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(5322), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Plastic Chairs", 30m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(5324), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 5, null, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(5312), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Tiffany Chairs", 200m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(5316), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 4, null, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(5305), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "100 Capacity Tent", 8000m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(5307), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 3, null, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(5298), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "250 Capacity Tent", 20000m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(5300), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 2, null, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(5291), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "350 Capacity Tent", 30000m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(5292), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 1, null, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(5273), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "500 Capacity Tent", 40000m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(5281), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" }
                });

            migrationBuilder.InsertData(
                table: "InventoryCategories",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "InventoryId", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 4, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(6894), new TimeSpan(0, 1, 0, 0, 0)), "SYSTEM", "Cooked Food and other types of Food", null, false, "FOODS", new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(6896), new TimeSpan(0, 1, 0, 0, 0)), "SYSTEM" },
                    { 3, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(6886), new TimeSpan(0, 1, 0, 0, 0)), "SYSTEM", "Both alcoholic and non alcoholic drinks", null, false, "WINE AND SPIRITS", new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(6888), new TimeSpan(0, 1, 0, 0, 0)), "SYSTEM" },
                    { 1, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(6539), new TimeSpan(0, 1, 0, 0, 0)), "SYSTEM", "Non Alcoholic drinks", null, false, "SOFT DRINKS", new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(6546), new TimeSpan(0, 1, 0, 0, 0)), "SYSTEM" },
                    { 2, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(6877), new TimeSpan(0, 1, 0, 0, 0)), "SYSTEM", "Alcoholic Beverage drinks", null, false, "DRINKS", new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(6879), new TimeSpan(0, 1, 0, 0, 0)), "SYSTEM" }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ImageUrl", "IsDeleted", "ItemCode", "ItemName", "Price", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 42, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9169), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Hero", "Hero", 300m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9171), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 31, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9093), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Smirnoff", "Smirnoff Ice", 500m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9095), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 32, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9100), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Big-Origin", "Big Origin", 450m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9102), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 33, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9107), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Tiger", "Tiger", 300m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9109), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 34, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9114), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Radler", "Radler", 300m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9116), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 35, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9121), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Gulder", "Gulder", 350m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9123), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 36, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9128), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Golfberg", "Golfberg", 300m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9130), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 37, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9135), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Star", "Star", 300m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9136), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 38, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9141), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "StarLite", "StarLite", 300m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9143), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 39, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9148), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Legend", "Legend", 450m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9150), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 40, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9155), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "CastleLite", "Castle-Lite", 350m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9157), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 41, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9162), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "D-Black", "Double-Black", 350m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9164), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 43, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9176), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Trophy", "Trophy", 300m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9178), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 52, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9238), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "EnergyDnk", "Energy Drink", 500m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9240), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 45, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9190), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Coke", "Coke", 300m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9191), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 46, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9196), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Sprite", "Sprite", 300m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9198), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 47, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9203), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Fanta", "Fanta", 300m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9205), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 48, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9211), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Can-Malt", "Can Malt", 300m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9212), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 49, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9217), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "MaltBottle", "Bottled Malt", 300m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9219), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 50, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9224), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Juice", "Juice", 500m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9226), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 51, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9231), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Water", "Water", 100m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9233), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 30, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9087), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "ExSmooth", "Extra Smooth", 400m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9088), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 53, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9245), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Mateaus", "Mateaus", 3000m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9247), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 54, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9251), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Donfed", "DonFelder", 3000m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9253), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 55, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9258), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Donfed", "Four Cousins", 2700m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9260), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 56, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9265), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Baron", "Baron", 2000m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9267), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 44, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9183), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Budweiser", "Budweiser", 450m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9184), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 29, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9080), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "MedStout", "Medium Stout", 400m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9082), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 23, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9036), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "TilapiaBig", "Roasted Tilapia", 2000m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9037), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 27, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9065), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Isiewu", "Isiewu", 800m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9066), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 1, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(8788), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Semo-Any", "Semovita/Any Soup", 600m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(8799), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 2, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(8808), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Eba-Any", "Eba/Any Soup", 600m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(8810), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 3, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(8816), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Beans-P", "Beans-Plantain", 500m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(8818), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 4, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(8824), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "F-Rice", "Fried Rice", 700m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(8826), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 5, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(8831), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "J-Rice", "Jollof Rice", 600m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(8833), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 6, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(8839), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Rice-Stew", "Rice-Stew", 600m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(8841), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 7, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(8846), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Chips-Eggs", "Chips-Eggs", 700m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(8848), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 8, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(8856), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "IndomieEgg", "Indomie-Egg", 700m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(8858), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 9, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(8864), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "LeafMoimoi", "Leaf Moimoi", 200m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(8866), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 28, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9073), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Heineken", "Heineken", 450m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9075), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 11, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(8879), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Cowtail", "CowTail P.Soup", 1000m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(8880), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 12, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(8886), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Fresh-Fish", "Fresh Fish", 800m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(8888), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 13, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(8894), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Intestine", "Intestine", 600m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(8896), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 10, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(8871), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "CowLeg", "CowLeg P.Soup", 1000m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(8873), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 15, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(8908), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "PepGoat", "Asun", 700m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(8910), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 26, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9057), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "CatfishSm", "Steamed Catfish", 3000m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9060), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 14, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(8901), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "PepChicken", "Peppered Chicken", 800m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(8903), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 24, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9043), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "TilapiaSm", "Roasted Tilapia", 1800m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9045), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 22, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9029), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "ShwmChick", "Burger", 1000m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9030), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 21, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9022), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "ShwmBeef", "Shawarma Beef", 800m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9023), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 25, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9050), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "StmCatfish", "Steamed Catfish", 3500m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9052), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 19, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9004), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Semo-Any", "Potato Salad", 1000m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9006), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 18, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(8997), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "MixedSalad", "Mixed Salad", 500m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(8999), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 17, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(8988), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Coleslaw", "Coleslaw", 200m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(8991), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 16, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(8915), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "Gizdodo", "Gizdodo", 600m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(8917), new TimeSpan(0, 1, 0, 0, 0)), null },
                    { 20, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9014), new TimeSpan(0, 1, 0, 0, 0)), null, null, false, "ShwmChick", "Shawarma Chicken", 1200m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(9016), new TimeSpan(0, 1, 0, 0, 0)), null }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "BookingId", "CreatedAt", "CreatedBy", "IsDeleted", "Name", "Price", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 8, null, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(3729), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Party (Indoor)", 30000m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(3732), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 1, null, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(1797), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Wedding", 100000m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(2250), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 2, null, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(3662), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "BirthdaysAnniversaries", 40000m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(3665), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 3, null, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(3673), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "ChildBirthdays", 20000m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(3675), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 4, null, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(3683), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Hangouts", 40000m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(3685), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 5, null, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(3698), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Concerts", 100000m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(3700), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 6, null, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(3708), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Picnics", 5000m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(3710), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 7, null, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(3717), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "Corporate Events", 50000m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(3720), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" },
                    { 9, null, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(3740), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com", false, "MiniConference-Training", 20000m, new DateTimeOffset(new DateTime(2021, 6, 19, 15, 11, 23, 534, DateTimeKind.Unspecified).AddTicks(3743), new TimeSpan(0, 1, 0, 0, 0)), "owner@rektaparkgardens.com" }
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
                name: "IX_Bookings_InvoiceId",
                table: "Bookings",
                column: "InvoiceId");

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
