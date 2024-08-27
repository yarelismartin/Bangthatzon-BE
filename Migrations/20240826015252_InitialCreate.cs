using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Bangthatzon.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CategoryName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Username = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    Uid = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CardNumber = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentTypes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductName = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    QuantityAvailable = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    SellerId = table.Column<int>(type: "integer", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Users_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    PaymentTypeId = table.Column<int>(type: "integer", nullable: true),
                    PurchaseDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    OpenOrder = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_PaymentTypes_PaymentTypeId",
                        column: x => x.PaymentTypeId,
                        principalTable: "PaymentTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderProduct",
                columns: table => new
                {
                    OrdersId = table.Column<int>(type: "integer", nullable: false),
                    ProductsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProduct", x => new { x.OrdersId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_OrderProduct_Orders_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Electronics" },
                    { 2, "Clothing" },
                    { 3, "Home & Kitchen" },
                    { 4, "Books" },
                    { 5, "Sports & Outdoors" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "Email", "FirstName", "Image", "LastName", "Uid", "Username" },
                values: new object[,]
                {
                    { 1, "123 Elm Street", "alice.smith@example.com", "Alice", "alice.jpg", "Smith", "user1", "alice.smith" },
                    { 2, "456 Oak Avenue", "bob.johnson@example.com", "Bob", "bob.jpg", "Johnson", "user2", "bob.johnson" },
                    { 3, "789 Pine Road", "charlie.brown@example.com", "Charlie", "charlie.jpg", "Brown", "user3", "charlie.brown" },
                    { 4, "101 Maple Lane", "diana.williams@example.com", "Diana", "diana.jpg", "Williams", "user4", "diana.williams" },
                    { 5, "202 Birch Drive", "evan.jones@example.com", "Evan", "evan.jpg", "Jones", "user5", "evan.jones" },
                    { 6, "303 Cedar Boulevard", "fiona.miller@example.com", "Fiona", "fiona.jpg", "Miller", "user6", "fiona.miller" },
                    { 7, "404 Elm Street", "george.davis@example.com", "George", "george.jpg", "Davis", "user7", "george.davis" },
                    { 8, "505 Oak Avenue", "hannah.wilson@example.com", "Hannah", "hannah.jpg", "Wilson", "user8", "hannah.wilson" },
                    { 9, "606 Pine Road", "isaac.moore@example.com", "Isaac", "isaac.jpg", "Moore", "user9", "isaac.moore" },
                    { 10, "707 Maple Lane", "jessica.taylor@example.com", "Jessica", "jessica.jpg", "Taylor", "user10", "jessica.taylor" }
                });

            migrationBuilder.InsertData(
                table: "PaymentTypes",
                columns: new[] { "Id", "CardNumber", "UserId" },
                values: new object[,]
                {
                    { 1, "1234567812345678", 2 },
                    { 2, "2345678923456789", 3 },
                    { 3, "3456789034567890", 2 },
                    { 4, "4567890145678901", 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Image", "Price", "ProductName", "QuantityAvailable", "SellerId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Latest model with all the features", "smartphone.jpg", 699.99m, "Smartphone", 50, 4 },
                    { 2, 3, new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brews coffee in minutes", "coffee_maker.jpg", 89.99m, "Coffee Maker", 20, 5 },
                    { 3, 1, new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noise-cancelling over-ear headphones", "headphones.jpg", 149.99m, "Headphones", 30, 6 },
                    { 4, 5, new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "High-quality mat for yoga and workouts", "yoga_mat.jpg", 39.99m, "Yoga Mat", 40, 7 },
                    { 5, 1, new DateTime(2024, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fast wireless charger for all devices", "wireless_charger.jpg", 29.99m, "Wireless Charger", 25, 8 },
                    { 6, 5, new DateTime(2024, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Durable tent for outdoor camping", "camping_tent.jpg", 119.99m, "Camping Tent", 15, 9 },
                    { 7, 1, new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stylish smartwatch with fitness tracking", "smartwatch.jpg", 249.99m, "Smartwatch", 22, 10 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "OpenOrder", "PaymentTypeId", "PurchaseDate", "UserId" },
                values: new object[,]
                {
                    { 1, false, 4, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, false, 1, new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, true, 3, null, 2 },
                    { 4, true, 2, null, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_ProductsId",
                table: "OrderProduct",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PaymentTypeId",
                table: "Orders",
                column: "PaymentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTypes_UserId",
                table: "PaymentTypes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SellerId",
                table: "Products",
                column: "SellerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderProduct");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "PaymentTypes");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
