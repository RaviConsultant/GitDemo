using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DigiTradeMVC.NET.Migrations
{
    public partial class AddDigiTradeInvoicing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Building = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: false),
                    Area = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    Zip = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Brand_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Brand_Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Cust_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustName = table.Column<string>(maxLength: 64, nullable: false),
                    Mobile = table.Column<string>(maxLength: 10, nullable: false),
                    EmailId = table.Column<string>(maxLength: 128, nullable: false),
                    AddressId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Cust_Id);
                    table.ForeignKey(
                        name: "FK_Customers_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Prod_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdName = table.Column<string>(maxLength: 64, nullable: false),
                    Processor = table.Column<string>(nullable: false),
                    Ram = table.Column<string>(nullable: false),
                    Rom = table.Column<string>(nullable: false),
                    Battery = table.Column<string>(nullable: false),
                    Primary_cam = table.Column<string>(nullable: false),
                    Front_cam = table.Column<string>(nullable: false),
                    Current_Stock = table.Column<int>(nullable: false),
                    Sales_Price = table.Column<int>(nullable: false),
                    Tax = table.Column<int>(nullable: false),
                    Brand_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Prod_Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_Brand_Id",
                        column: x => x.Brand_Id,
                        principalTable: "Brands",
                        principalColumn: "Brand_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SaleInvoices",
                columns: table => new
                {
                    InvoiceNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Invoicedate = table.Column<DateTime>(nullable: true),
                    Cust_Id = table.Column<int>(nullable: true),
                    Prod_Id = table.Column<int>(nullable: true),
                    Qty = table.Column<int>(nullable: false),
                    Rate = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleInvoices", x => x.InvoiceNo);
                    table.ForeignKey(
                        name: "FK_SaleInvoices_Customers_Cust_Id",
                        column: x => x.Cust_Id,
                        principalTable: "Customers",
                        principalColumn: "Cust_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SaleInvoices_Products_Prod_Id",
                        column: x => x.Prod_Id,
                        principalTable: "Products",
                        principalColumn: "Prod_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_AddressId",
                table: "Customers",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Brand_Id",
                table: "Products",
                column: "Brand_Id");

            migrationBuilder.CreateIndex(
                name: "IX_SaleInvoices_Cust_Id",
                table: "SaleInvoices",
                column: "Cust_Id");

            migrationBuilder.CreateIndex(
                name: "IX_SaleInvoices_Prod_Id",
                table: "SaleInvoices",
                column: "Prod_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SaleInvoices");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
