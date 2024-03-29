﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sprint1.Migrations
{
    public partial class AddSprint1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(maxLength: 16, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(maxLength: 32, nullable: false),
                    CustomerPhone = table.Column<string>(maxLength: 10, nullable: false),
                    CustomerEmail = table.Column<string>(maxLength: 64, nullable: false),
                    HouseNum = table.Column<string>(nullable: false),
                    Street = table.Column<string>(nullable: false),
                    Area = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    Zip = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductTitle = table.Column<string>(maxLength: 32, nullable: false),
                    ProductDescription = table.Column<string>(maxLength: 128, nullable: false),
                    SalePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrentStock = table.Column<int>(nullable: false),
                    BrandId = table.Column<int>(nullable: true),
                    Processor = table.Column<string>(maxLength: 16, nullable: false),
                    Ram = table.Column<int>(nullable: false),
                    ROM = table.Column<int>(nullable: false),
                    PrimaryCamera = table.Column<int>(nullable: false),
                    FrontCamera = table.Column<int>(nullable: false),
                    Battery = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SalesInvoice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceDate = table.Column<DateTime>(nullable: false),
                    CustomerId = table.Column<int>(nullable: true),
                    ProductId = table.Column<int>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Rate = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesInvoice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesInvoice_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalesInvoice_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoice_CustomerId",
                table: "SalesInvoice",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesInvoice_ProductId",
                table: "SalesInvoice",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalesInvoice");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
