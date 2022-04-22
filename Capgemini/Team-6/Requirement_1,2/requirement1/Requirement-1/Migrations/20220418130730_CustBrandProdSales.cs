using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Requirement_1.Migrations
{
    public partial class CustBrandProdSales : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand_Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Customer_Email = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Customer_Phone = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Brand_Name = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    SalePrice = table.Column<double>(type: "float", nullable: false),
                    Tax = table.Column<float>(type: "real", nullable: false),
                    ROM = table.Column<long>(type: "bigint", nullable: false),
                    RAM = table.Column<long>(type: "bigint", nullable: false),
                    PrimaryCam = table.Column<long>(type: "bigint", nullable: false),
                    MainCam = table.Column<long>(type: "bigint", nullable: false),
                    Battery = table.Column<int>(type: "int", nullable: false),
                    Processor = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Cur_stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalesInvoice",
                columns: table => new
                {
                    InvoiceNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesInvoice", x => x.InvoiceNumber);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "SalesInvoice");
        }
    }
}
