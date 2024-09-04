using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bangthatzon.Migrations
{
    public partial class ProductDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Image", "Price", "ProductName", "QuantityAvailable", "SellerId" },
                values: new object[,]
                {
                    { 8, 2, new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Comfortable and durable running shoes", "running_shoes.jpg", 79.99m, "Running Shoes", 60, 3 },
                    { 9, 3, new DateTime(2024, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "High-speed blender for smoothies", "blender.jpg", 99.99m, "Blender", 45, 5 },
                    { 10, 4, new DateTime(2024, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Portable e-book reader with backlight", "ebook_reader.jpg", 129.99m, "E-Book Reader", 33, 2 },
                    { 11, 5, new DateTime(2024, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Official size and weight basketball", "basketball.jpg", 29.99m, "Basketball", 50, 7 },
                    { 12, 1, new DateTime(2024, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Next-gen gaming console with 4K support", "gaming_console.jpg", 499.99m, "Gaming Console", 10, 6 },
                    { 13, 2, new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stylish leather jacket for men", "leather_jacket.jpg", 199.99m, "Leather Jacket", 25, 8 },
                    { 14, 1, new DateTime(2024, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Compact digital camera with 20MP resolution", "digital_camera.jpg", 299.99m, "Digital Camera", 12, 9 },
                    { 15, 3, new DateTime(2024, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Non-stick cookware set for all your cooking needs", "cookware_set.jpg", 149.99m, "Cookware Set", 20, 5 },
                    { 16, 5, new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Foldable treadmill with multiple speed settings", "treadmill.jpg", 599.99m, "Treadmill", 8, 10 },
                    { 17, 1, new DateTime(2024, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Portable Bluetooth speaker with deep bass", "bluetooth_speaker.jpg", 89.99m, "Bluetooth Speaker", 70, 4 },
                    { 18, 1, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "WiFi-enabled smart light bulbs with color change", "smart_light_bulbs.jpg", 49.99m, "Smart Light Bulbs", 100, 3 },
                    { 19, 3, new DateTime(2024, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fast boiling electric kettle with auto shut-off", "electric_kettle.jpg", 29.99m, "Electric Kettle", 30, 6 },
                    { 20, 2, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Breathable running shorts for men", "running_shorts.jpg", 24.99m, "Running Shorts", 40, 8 },
                    { 21, 4, new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Best-selling fiction novel", "fiction_book.jpg", 14.99m, "Fiction Book", 60, 2 },
                    { 22, 5, new DateTime(2024, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Replacement tent poles for camping", "tent_poles.jpg", 19.99m, "Tent Poles", 25, 9 },
                    { 23, 1, new DateTime(2024, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "High-performance laptop with SSD", "laptop.jpg", 999.99m, "Laptop", 15, 4 },
                    { 24, 2, new DateTime(2024, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Warm winter coat for extreme cold", "winter_coat.jpg", 149.99m, "Winter Coat", 35, 7 },
                    { 25, 3, new DateTime(2024, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Compact microwave oven with presets", "microwave_oven.jpg", 129.99m, "Microwave Oven", 22, 5 },
                    { 26, 5, new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Supportive yoga block for all levels", "yoga_block.jpg", 12.99m, "Yoga Block", 50, 6 },
                    { 27, 1, new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "27-inch 4K monitor with adjustable stand", "monitor.jpg", 399.99m, "Monitor", 14, 10 },
                    { 28, 2, new DateTime(2024, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Slim fit jeans for men", "jeans.jpg", 49.99m, "Jeans", 40, 3 },
                    { 29, 4, new DateTime(2024, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Recipe book with 100+ easy meals", "cookbook.jpg", 19.99m, "Cookbook", 80, 1 },
                    { 30, 5, new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lightweight running hat with moisture-wicking", "running_hat.jpg", 19.99m, "Running Hat", 35, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);
        }
    }
}
