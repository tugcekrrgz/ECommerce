using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.MVC.Migrations
{
    /// <inheritdoc />
    public partial class updatedOrder2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPrice",
                table: "OrderDetails",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Outdoors", new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(1538), "Outdoors description.", new Guid("a207d301-8446-4e44-be6b-fc1902cc962c") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Garden", new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(1618), "Garden description.", new Guid("d5b8ef20-f002-4e6a-bb21-290ee7f8c04e") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Electronics", new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(1621), "Electronics description.", new Guid("5b6bf6f8-f7fb-486e-8a44-0d47a2350527") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Home", new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(1624), "Home description.", new Guid("89d4af3e-172d-4cf5-96cd-2e6fa9754f55") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Shoes", new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(1626), "Shoes description.", new Guid("42dde268-5ff4-453d-8ec3-ed42c31dc255") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Grocery", new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(1630), "Grocery description.", new Guid("c578c18b-73b0-4f50-a995-a4dcece11f23") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Movies", new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(1632), "Movies description.", new Guid("25dd00b9-adab-4772-aef1-3a1a09d30fe7") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Automotive", new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(1635), "Automotive description.", new Guid("927a2a9b-bda7-4148-a69c-cdb64eb39d7f") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Outdoors", new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(1647), "Outdoors description.", new Guid("c5ca70cd-7671-4339-a9b9-dfaf7029d854") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Health", new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(1650), "Health description.", new Guid("b49c4d1c-996c-4ec1-8d6d-ce8c128a9d04") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(1845), "Practical", new Guid("28a73652-a5e8-41d7-a023-55866412e1d1"), "Fantastic Granite Sausages", 453.89m, (short)1019 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(1978), "Rustic", new Guid("918051a9-cc34-4bca-bc45-d8e1a30b31da"), "Rustic Plastic Towels", 512.48m, (short)2366 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2000), new Guid("c1df0b3a-92ab-4a22-b3eb-9c278af24ba4"), "Ergonomic Granite Pants", 46.12m, (short)6162 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2020), "Handmade", new Guid("9fe24cb4-489e-44ba-8d03-2f4dee999c22"), "Rustic Cotton Chicken", 855.29m, (short)4853 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2041), "Practical", new Guid("7f41cf22-b6e9-439e-a299-f1aeaa9dc81e"), "Small Fresh Sausages", 578.97m, (short)6000 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2086), "Generic", new Guid("e2a138c3-d548-4784-8f0c-48c653b82f94"), "Rustic Plastic Sausages", 234.75m, (short)3827 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2107), "Generic", new Guid("3ee6bca1-b288-4b8d-9268-9afa0e4b9428"), "Intelligent Plastic Chair", 7.72m, (short)4562 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2125), "Small", new Guid("6c11f944-7576-4268-9fdd-8b78b7349492"), "Fantastic Cotton Tuna", 362.00m, (short)3023 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2144), new Guid("b68b0466-babb-4eb7-a33a-b9c944759131"), "Unbranded Steel Chair", 892.84m, (short)2214 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2163), "Licensed", new Guid("3a440268-6db0-4baa-a47a-0d15e9a885cf"), "Incredible Fresh Bacon", 59.08m, (short)7299 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2182), "Incredible", new Guid("e5ad33c4-750b-4b2c-a2a4-1e3f374e9096"), "Generic Wooden Chicken", 68.91m, (short)6540 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2198), "Tasty", new Guid("f4fba233-29c3-4374-b33b-07b2157556b0"), "Ergonomic Plastic Towels", 747.32m, (short)8272 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2215), "Small", new Guid("4ef62df9-c8fb-4f9a-b50f-b36cc20a07f6"), "Refined Steel Bacon", 892.24m, (short)1812 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2232), "Incredible", new Guid("1c49dd2e-3dcd-4a93-b0c9-59b72ccad1ba"), "Generic Steel Salad", 400.03m, (short)217 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2277), "Sleek", new Guid("c0f30309-3fa3-4e35-9fe2-a0928f341f39"), "Handmade Wooden Hat", 63.54m, (short)5495 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2297), "Gorgeous", new Guid("0d4d9358-55a4-482a-aaf6-c372c21bac06"), "Fantastic Fresh Towels", 509.62m, (short)4113 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2313), "Incredible", new Guid("524868b2-f4c7-4581-8715-cc597e2ead8a"), "Handcrafted Cotton Chips", 425.97m, (short)6700 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2332), "Refined", new Guid("aa6465c0-d78b-4287-a926-969373d13e75"), "Handcrafted Steel Hat", 670.97m, (short)4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2349), "Practical", new Guid("87c127aa-5466-4007-b8f5-5815b79034fb"), "Sleek Rubber Pizza", 556.28m, (short)4505 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2365), "Rustic", new Guid("b48edbd9-1c0e-4fc8-80a9-ce7e0a92b4a3"), "Refined Wooden Chair", 928.24m, (short)409 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2383), "Tasty", new Guid("43d74b8a-7c02-4c3c-b5ac-8b4f8f020664"), "Awesome Fresh Hat", 698.64m, (short)6804 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2399), "Sleek", new Guid("0aa55826-2f36-4ca6-8946-b90fc9ad0760"), "Small Frozen Bike", 891.94m, (short)3272 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2418), "Awesome", new Guid("c4903140-9c7c-4f60-a4c5-6b20569ba89a"), "Small Frozen Towels", 385.70m, (short)8859 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2435), "Awesome", new Guid("044ed7a6-fc45-4af4-993f-86108026a948"), "Intelligent Fresh Soap", 794.26m, (short)5325 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2474), "Intelligent", new Guid("13375bde-6218-4dd3-a051-20a36a38f3cb"), "Generic Rubber Fish", 84.50m, (short)2088 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2491), "Incredible", new Guid("99132f07-a765-44e6-a795-a2e0ab5c48e0"), "Sleek Steel Soap", 642.82m, (short)3279 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2508), "Refined", new Guid("eb1a8ff6-660d-441d-bcdb-265d7d080619"), "Incredible Frozen Soap", 646.72m, (short)3769 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2526), "Small", new Guid("8f8143fa-884a-4ea8-a40a-c7b496a3d2b5"), "Unbranded Metal Mouse", 221.89m, (short)1318 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2545), "Fantastic", new Guid("7b6f454a-e359-4ca3-9e06-76bdfcfa6c5f"), "Fantastic Granite Sausages", 494.12m, (short)4970 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2561), "Unbranded", new Guid("96e95a20-5b67-4df7-88d5-b22fd956e6f7"), "Practical Steel Chicken", 215.09m, (short)1913 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2579), "Sleek", new Guid("64a78f32-d771-418c-be4c-7b1a78937a57"), "Generic Frozen Gloves", 919.76m, (short)1542 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2595), "Handmade", new Guid("a060be46-cc5e-4e3c-bb39-c3d73d92cf8b"), "Handcrafted Concrete Hat", 122.00m, (short)8794 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2613), "Fantastic", new Guid("b3064a92-256c-4a5b-bcaf-cfe688c73367"), "Handmade Granite Sausages", 636.96m, (short)4198 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2690), "Rustic", new Guid("74be557b-013e-4be8-9bb5-deb818bde234"), "Rustic Metal Keyboard", 60.52m, (short)5512 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2708), new Guid("f6b8b7a4-8e39-41bf-b137-5240f3e81a30"), "Gorgeous Frozen Computer", 838.33m, (short)3000 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2724), "Handmade", new Guid("85d0910f-ebbb-462e-a3d1-0426aeca10ca"), "Licensed Rubber Shoes", 124.12m, (short)4150 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2742), "Ergonomic", new Guid("45d2026a-50fb-49f8-b44f-db3860d36b2a"), "Tasty Granite Salad", 906.06m, (short)7212 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2758), "Refined", new Guid("bcaf6afa-b563-4510-83f4-92ec95529ed8"), "Fantastic Granite Towels", 539.55m, (short)2221 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2777), "Incredible", new Guid("2b34b888-8e86-47c4-a5dc-a7a2983b1745"), "Refined Frozen Chicken", 688.87m, (short)7191 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2795), "Incredible", new Guid("5e3c2047-dec2-47ab-b8d8-f1818cb23cbc"), "Tasty Cotton Car", 54.36m, (short)7176 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2811), "Sleek", new Guid("1d880328-9afd-45da-a3aa-7fd593f981d3"), "Sleek Cotton Ball", 173.93m, (short)4651 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2827), "Licensed", new Guid("a5cc4663-985e-4393-b848-4d5a499acd44"), "Licensed Frozen Fish", 969.89m, (short)4292 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2844), "Generic", new Guid("cde58ac7-c816-4a05-a12e-59b383cfeaa2"), "Generic Cotton Towels", 370.77m, (short)3607 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2909), "Incredible", new Guid("0dccdce0-159c-4a65-8621-1e03e347abbc"), "Sleek Soft Chicken", 416.67m, (short)8182 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2927), "Generic", new Guid("c34494dc-c0ff-4396-aa01-5d3e103516e9"), "Practical Rubber Bike", 374.00m, (short)2086 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2942), new Guid("5d8da222-0435-44bd-b7d4-57c62464ddc9"), "Handcrafted Steel Bacon", 967.89m, (short)3784 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2961), "Fantastic", new Guid("953df991-5f10-43f5-b2b2-f136eae9c1d4"), "Handcrafted Wooden Mouse", 107.68m, (short)1893 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2978), "Handcrafted", new Guid("3acf639b-49d7-4eb7-9a07-5249b39ea9cc"), "Fantastic Soft Shoes", 360.11m, (short)2727 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2994), "Intelligent", new Guid("1a8d0024-e675-401d-a844-e7b299a8f491"), "Sleek Metal Keyboard", 322.08m, (short)4676 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3010), "Unbranded", new Guid("105c5b61-a7f8-4e0e-a71b-af20e270fd45"), "Refined Plastic Shirt", 529.33m, (short)6047 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3027), "Refined", new Guid("31faf5e8-446e-4fd1-aec1-01a5f53f66c8"), "Generic Wooden Tuna", 70.72m, (short)7220 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3044), "Intelligent", new Guid("5aec39f5-4d9a-4451-b9f3-df7f456789f0"), "Sleek Cotton Keyboard", 465.10m, (short)9568 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3060), "Gorgeous", new Guid("41146a1e-a495-4b1d-a426-f8b546571320"), "Rustic Frozen Fish", 719.23m, (short)3359 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3099), "Unbranded", new Guid("55359019-4618-4174-90e4-857e8989ca70"), "Generic Granite Hat", 922.06m, (short)8667 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3117), "Unbranded", new Guid("ca023d4d-15f6-46e2-b1c4-54d75dcf5512"), "Fantastic Concrete Hat", 803.76m, (short)3251 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3133), "Tasty", new Guid("851acbe6-81f9-4321-8d4c-c43d8ccbbcb2"), "Handmade Soft Keyboard", 675.43m, (short)2314 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3149), "Handcrafted", new Guid("781b2104-3f49-4cfe-8aa9-e4476ed4635f"), "Refined Metal Cheese", 663.33m, (short)9027 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3167), "Handmade", new Guid("5b8c5fda-04bd-4fc5-b06b-a34f849acdff"), "Unbranded Frozen Chair", 907.26m, (short)4778 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3184), "Handcrafted", new Guid("81217c58-9c54-4220-969f-d66c56430429"), "Sleek Fresh Pants", 367.09m, (short)9368 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3200), "Ergonomic", new Guid("d44abaec-fc9b-4a24-b008-61ed164efec7"), "Licensed Metal Ball", 262.01m, (short)5505 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3216), "Tasty", new Guid("969c88af-0e52-4726-b55b-851d67634cef"), "Generic Frozen Bike", 898.86m, (short)2193 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3233), "Licensed", new Guid("80a29d7e-cd15-4112-92c4-ff71fdd58426"), "Gorgeous Concrete Hat", 333.38m, (short)342 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3251), "Handmade", new Guid("5264d049-8dae-4b44-ae24-62f291319f27"), "Awesome Cotton Bacon", 609.73m, (short)9526 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3289), "Licensed", new Guid("9bdf5e8b-7e27-4977-b24a-db8ed197a2d4"), "Gorgeous Granite Car", 77.78m, (short)3081 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3306), "Refined", new Guid("537897a5-b6f6-4cd1-92fa-45f854f50c07"), "Refined Concrete Shoes", 997.78m, (short)2502 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3325), "Intelligent", new Guid("881d254a-1241-4c4c-bbd2-5ff91b6c56ea"), "Rustic Plastic Gloves", 565.34m, (short)6061 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3341), "Awesome", new Guid("9fb990aa-34e3-4f2c-8c71-6e1833689b71"), "Refined Concrete Soap", 7.36m, (short)4087 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3357), "Licensed", new Guid("6ba3f732-e654-4475-923b-e07654b17e55"), "Refined Steel Gloves", 785.72m, (short)3639 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3372), "Handcrafted", new Guid("32be83f5-7706-4097-a3b5-a8d0431989d9"), "Fantastic Fresh Pants", 373.30m, (short)5329 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3389), "Generic", new Guid("cf1c762f-17ba-4404-8ff9-bf146ed64678"), "Generic Frozen Table", 258.74m, (short)4271 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3408), "Fantastic", new Guid("954c6315-c12d-4b46-ae90-8827d06dc3e1"), "Intelligent Plastic Computer", 330.18m, (short)5908 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3425), "Incredible", new Guid("e4bf05de-3da5-4486-9405-31325449ce4d"), "Sleek Steel Towels", 801.55m, (short)9436 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3464), "Fantastic", new Guid("f0e17883-dcf0-45c5-b88a-2378e8a72e8b"), "Handmade Granite Chips", 540.80m, (short)9648 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3481), "Handcrafted", new Guid("59cd632c-2866-4b02-b672-ab29cb8988dc"), "Practical Rubber Shoes", 525.61m, (short)8374 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3498), "Generic", new Guid("6c0180e7-b78d-450d-88d7-0655348ecbd1"), "Licensed Cotton Bike", 888.58m, (short)8931 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3514), "Ergonomic", new Guid("0580b92d-f2a4-43a9-88d7-8c649cbaf347"), "Handcrafted Granite Chicken", 134.78m, (short)2577 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3530), new Guid("56114e94-0dda-4b17-a2d1-1026dac3dcde"), "Ergonomic Rubber Bacon", 110.44m, (short)8994 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3546), "Refined", new Guid("0def1f2e-3793-46f1-b7e1-911717e227ab"), "Fantastic Frozen Shirt", 770.79m, (short)7174 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3564), "Handmade", new Guid("db620e28-223c-4129-b343-7832fb8086a4"), "Practical Wooden Bacon", 37.10m, (short)8936 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3580), "Fantastic", new Guid("67113c09-e772-4883-b432-de2d6ad1bc79"), "Ergonomic Concrete Salad", 789.80m, (short)4712 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3596), "Handmade", new Guid("40dd4630-5203-42c9-91dd-12a25af844f8"), "Refined Rubber Chicken", 948.58m, (short)6577 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3633), "Intelligent", new Guid("23735ab2-2b70-4e00-a624-1a2114722f5e"), "Handcrafted Wooden Table", 285.96m, (short)535 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3651), "Awesome", new Guid("f1befeeb-2228-4343-a2c5-05dbcf6fc955"), "Incredible Granite Computer", 236.39m, (short)3562 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3668), "Incredible", new Guid("7b5d3d37-a889-4d71-bb2d-1b7d30da531e"), "Awesome Frozen Pants", 622.35m, (short)1264 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3683), "Unbranded", new Guid("73310c50-8b53-4e58-83ec-124ae6be985b"), "Handmade Rubber Chips", 356.75m, (short)7162 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3699), "Handcrafted", new Guid("a30c658f-6c3f-4e6c-9a78-d7833aaf635d"), "Handmade Fresh Towels", 971.47m, (short)9304 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3717), "Ergonomic", new Guid("ece5b9a5-a87b-4fcd-bc44-75bf48420e60"), "Incredible Frozen Pizza", 801.70m, (short)8539 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3732), "Awesome", new Guid("9d86c3eb-ab52-4135-89a3-3ec6f0096351"), "Rustic Metal Chicken", 605.36m, (short)1335 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3748), new Guid("9a416472-39cc-41b6-8635-0352c0c4bff4"), "Handcrafted Frozen Table", 775.09m, (short)7015 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3764), "Rustic", new Guid("5edf38e7-bd54-4ea1-bd97-27cad0f1205e"), "Unbranded Wooden Hat", 656.73m, (short)3240 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3780), "Rustic", new Guid("30010632-fba0-46ed-a510-0d713610bafe"), "Generic Concrete Towels", 537.70m, (short)3275 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3818), "Practical", new Guid("a5b16781-80e4-4511-a22a-e72ec2027b8a"), "Sleek Metal Tuna", 554.46m, (short)9831 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3834), "Practical", new Guid("06974c2c-7bcd-4239-adac-8edf66e2f2fd"), "Handmade Wooden Keyboard", 414.84m, (short)4373 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3850), "Fantastic", new Guid("ade964ef-c7ac-4b5c-aa82-1890927dd4fd"), "Handmade Soft Fish", 898.88m, (short)6019 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3867), "Refined", new Guid("8da0d73a-30ff-4a71-88e2-7261e534f98c"), "Handmade Concrete Sausages", 517.60m, (short)6546 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3883), "Unbranded", new Guid("5d82a822-741b-402a-a58d-1cf5fefd975c"), "Handmade Metal Computer", 891.14m, (short)8269 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3899), "Refined", new Guid("6450398d-e8e9-4256-8480-6b90dae408c1"), "Unbranded Soft Pizza", 430.67m, (short)6959 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3914), "Ergonomic", new Guid("02e2fae4-c2c7-4630-9e53-d4e0a769f29d"), "Practical Cotton Sausages", 815.62m, (short)7679 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3931), "Small", new Guid("22b951db-ac8d-4185-b9c0-6728336ced2f"), "Handmade Frozen Chicken", 534.44m, (short)3471 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3947), "Rustic", new Guid("c8bbbcc8-7bb4-4d80-8b0f-4ffec36664f7"), "Handmade Steel Bacon", 539.09m, (short)982 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPrice",
                table: "OrderDetails",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Home", new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(718), "Home description.", new Guid("e0c4b863-89a9-46d4-b81f-895100ae84ce") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Jewelery", new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(806), "Jewelery description.", new Guid("a8c98608-9c7f-4af0-8cb1-269cdaa0bb47") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Clothing", new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(811), "Clothing description.", new Guid("da53e331-9a17-405a-ba61-6b70303e9dec") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Toys", new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(863), "Toys description.", new Guid("8d21c335-c5c9-4c7b-9ae5-0a5235fa4181") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Games", new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(867), "Games description.", new Guid("94d2ad73-a880-47d6-8db2-51eef58d0478") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Sports", new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(873), "Sports description.", new Guid("762bf702-bb01-499d-9ff6-629d48b55231") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Jewelery", new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(877), "Jewelery description.", new Guid("585d5545-2056-439e-a49d-4f1cf6f735b5") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Sports", new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(889), "Sports description.", new Guid("f682a437-268b-4112-a1e6-071ecda0dff3") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Shoes", new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(892), "Shoes description.", new Guid("94bb341a-85c0-4735-b38b-7afc88345e46") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Electronics", new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(897), "Electronics description.", new Guid("15983ec0-dd87-4cdb-a21f-c86d6d73a19a") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(1165), "Gorgeous", new Guid("9a9b97e3-77d5-49b3-9e2a-2c1363c6ceaa"), "Ergonomic Frozen Salad", 404.30m, (short)1873 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(1386), "Refined", new Guid("e33c0129-5d2f-4e33-b4e6-dfcff2bf2429"), "Handcrafted Steel Sausages", 919.89m, (short)1988 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(1422), new Guid("5a17b9e7-6d80-49b5-a3ba-c21fedeb2edd"), "Gorgeous Granite Sausages", 951.60m, (short)9900 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(1457), "Generic", new Guid("a6ae34b6-b9a2-4eab-a0a9-f85149bde36d"), "Rustic Frozen Gloves", 579.59m, (short)1728 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(1484), "Incredible", new Guid("118c51ae-993b-4fd6-83d7-c49e62d44bd1"), "Practical Metal Car", 744.03m, (short)5153 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(1521), "Unbranded", new Guid("84cd758f-991a-4b43-911b-36443600a591"), "Handcrafted Cotton Keyboard", 36.82m, (short)6991 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(1548), "Tasty", new Guid("465827ee-0d58-4e14-96aa-3b9972a55536"), "Tasty Metal Computer", 816.07m, (short)5009 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(1620), "Unbranded", new Guid("73e09b75-780a-448b-87f2-fb97bcccc304"), "Awesome Wooden Fish", 716.31m, (short)9272 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(1647), new Guid("df7606b5-0e3f-4637-854c-b594384a140f"), "Awesome Plastic Hat", 851.86m, (short)3709 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(1676), "Intelligent", new Guid("a3abb2f5-bbf0-4b38-b1ba-1b9eb9621504"), "Tasty Plastic Gloves", 984.45m, (short)1070 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(1702), "Gorgeous", new Guid("be0fe829-4ecb-4785-8f25-69cd1d735503"), "Incredible Concrete Mouse", 286.84m, (short)9848 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(1727), "Intelligent", new Guid("04bcba0a-f3ed-4060-88c9-253849cbcec9"), "Ergonomic Fresh Keyboard", 323.00m, (short)1384 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(1753), "Rustic", new Guid("43b69228-5520-400a-95e8-528bc468f505"), "Unbranded Fresh Pizza", 215.93m, (short)5874 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(1781), "Refined", new Guid("bd1b139e-2bcb-4cd3-b564-80049dc85ff4"), "Fantastic Granite Keyboard", 643.58m, (short)2785 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(1806), "Practical", new Guid("147c05d5-80f4-4ced-a4a1-aff5e1fce267"), "Incredible Wooden Chair", 701.64m, (short)821 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(1831), "Fantastic", new Guid("d517eb92-34d9-469a-9924-60f0df7d32c2"), "Rustic Steel Pants", 758.74m, (short)1821 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(1916), "Handmade", new Guid("8eec5f14-ee25-488d-b4f9-2f2619c4083a"), "Practical Rubber Bacon", 907.53m, (short)9949 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(1949), "Gorgeous", new Guid("dadf7abd-46d7-466e-ad83-ca1598c28eb7"), "Practical Wooden Fish", 344.82m, (short)4792 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(1973), "Licensed", new Guid("63b64fb7-9ece-4f9c-917e-159b3743766f"), "Refined Concrete Pants", 688.83m, (short)2125 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(2001), "Sleek", new Guid("829faccf-87db-4ab5-a13f-ffe50182448e"), "Handmade Frozen Chair", 451.70m, (short)5065 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(2025), "Handmade", new Guid("c20a19c5-10ad-4982-b2c5-63d9a1ee0533"), "Refined Plastic Salad", 777.39m, (short)3441 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(2051), "Intelligent", new Guid("25dfbea5-38dc-4eda-be96-3b8171c02cd4"), "Small Frozen Hat", 395.07m, (short)5247 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(2076), "Handcrafted", new Guid("cc270393-d6e0-441e-a2d5-b32c5745da4e"), "Handmade Fresh Chair", 420.91m, (short)7178 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(2101), "Tasty", new Guid("04fc16cf-9ed5-4239-996c-4a5bc3f67719"), "Refined Frozen Salad", 517.48m, (short)7188 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(2124), "Handcrafted", new Guid("86374a5f-b52c-4f75-8032-fc6d9f665b1e"), "Practical Granite Towels", 292.59m, (short)6674 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(2148), "Generic", new Guid("670d3af2-2614-4d38-a43d-8d3b476e1a97"), "Ergonomic Wooden Mouse", 25.07m, (short)8382 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(2211), "Handcrafted", new Guid("d3e8eee6-245a-4d23-9b55-1fc10d17b2ad"), "Handcrafted Metal Car", 920.85m, (short)2735 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(2235), "Ergonomic", new Guid("023ea20c-d0c6-434c-895b-b5c3c4a0a2a6"), "Refined Steel Towels", 11.20m, (short)2684 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(2260), "Handmade", new Guid("fdc18683-5cb0-4410-88a1-2ebaa5ed7eb0"), "Ergonomic Fresh Cheese", 49.05m, (short)2069 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(2288), "Licensed", new Guid("a50592b0-1f0d-4c10-afa0-6edd213e019c"), "Sleek Plastic Keyboard", 869.57m, (short)4176 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(2312), "Handcrafted", new Guid("b3238af8-c2b1-4701-9e8c-ea615272ee62"), "Practical Granite Chicken", 997.63m, (short)4089 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(2339), "Sleek", new Guid("649cdcf9-cf85-4881-8218-35ed9418fc89"), "Gorgeous Frozen Car", 751.38m, (short)7577 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(2361), "Incredible", new Guid("4f9833d5-121b-435b-8e28-9ab405eff6c9"), "Sleek Cotton Hat", 657.85m, (short)9592 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(2388), "Handcrafted", new Guid("ff15739b-938f-411b-bcbd-a17857f0eba6"), "Rustic Rubber Computer", 75.55m, (short)7141 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(2412), new Guid("39fb2bb5-24ba-4ee7-ab29-04d5d9515892"), "Awesome Cotton Chicken", 734.22m, (short)6109 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(2484), "Gorgeous", new Guid("387a3a44-83dc-49f4-9ea1-e697fbfab22d"), "Practical Granite Cheese", 335.95m, (short)7569 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(2508), "Fantastic", new Guid("7bf5179d-4fb5-4431-ba03-0004727f8ef7"), "Refined Fresh Chair", 179.27m, (short)3059 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(2534), "Ergonomic", new Guid("4cbd5e81-8e29-41bd-8a16-2334be4b2588"), "Practical Steel Cheese", 121.33m, (short)4322 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(2557), "Practical", new Guid("d31417bc-f6c8-40e9-a561-8086d073db4b"), "Small Frozen Gloves", 940.26m, (short)609 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(2581), "Generic", new Guid("3aff0780-2d67-4708-a557-d32d0ff17604"), "Tasty Soft Chair", 131.11m, (short)5769 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(2605), "Licensed", new Guid("8bf47a13-2233-4b77-bb2b-24ddb8a507c9"), "Licensed Granite Shirt", 520.02m, (short)9862 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(2807), "Awesome", new Guid("2b40e53b-2890-4c32-9916-0f54242899ca"), "Awesome Steel Cheese", 805.52m, (short)1139 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(2833), "Gorgeous", new Guid("d39f0133-7e4d-4cc7-99bd-e59b5a4c6d35"), "Tasty Concrete Bacon", 228.03m, (short)6436 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(2856), "Intelligent", new Guid("60a76d83-2641-4725-9221-79c605db3705"), "Awesome Soft Ball", 776.21m, (short)1059 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(2878), "Intelligent", new Guid("e124e13c-cb9e-4015-803e-fc35e2cc08ac"), "Ergonomic Plastic Chair", 904.66m, (short)6805 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(2935), new Guid("a6ffab66-5bc3-4eae-b094-d52a4fe2075c"), "Practical Soft Cheese", 393.93m, (short)7554 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(2957), "Generic", new Guid("34c0adb3-ada0-4a28-aa5d-1445b23dff68"), "Handcrafted Fresh Keyboard", 438.55m, (short)9224 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(2979), "Generic", new Guid("07eb6c16-0bb5-4c36-904d-6202ca8fce92"), "Gorgeous Soft Bike", 146.46m, (short)7700 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(3002), "Ergonomic", new Guid("8b874071-c9fd-447b-ba1f-1daf9bac842c"), "Handmade Granite Computer", 805.85m, (short)8607 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(3024), "Licensed", new Guid("45e19fbf-b3eb-4a21-add0-d888d83b34d7"), "Rustic Fresh Shirt", 626.08m, (short)4028 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(3046), "Sleek", new Guid("bfca85da-9820-46c2-8701-1fa9af2834ad"), "Ergonomic Rubber Bike", 29.76m, (short)1446 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(3068), "Awesome", new Guid("9b0be08f-b8cd-49ba-8cdd-f4c6c04ded96"), "Refined Plastic Bike", 70.45m, (short)8242 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(3091), "Licensed", new Guid("800ef299-e0ac-406b-88ca-9f42d383cf0d"), "Handcrafted Rubber Cheese", 462.01m, (short)1715 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(3115), "Refined", new Guid("23ec742d-b694-445f-9ea6-3067d984036e"), "Practical Fresh Salad", 37.59m, (short)9082 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(3136), "Sleek", new Guid("b45ca8c3-ab23-4274-a7ad-acd51558bf7b"), "Rustic Granite Shoes", 546.47m, (short)9132 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(3191), "Small", new Guid("cd36af8c-488d-494b-ac89-b13868f6be82"), "Incredible Metal Pizza", 48.80m, (short)2135 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(3217), "Small", new Guid("2d724518-5862-4cf6-a3bf-4a5258eebf11"), "Rustic Frozen Chips", 839.92m, (short)3429 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(3241), "Practical", new Guid("1d28f3f8-abcb-4982-8f01-45e440a9fd82"), "Awesome Wooden Bacon", 219.37m, (short)8753 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(3265), "Gorgeous", new Guid("52ab6250-d057-43cd-a54b-64f0f78f85ba"), "Tasty Soft Shirt", 2.41m, (short)4888 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(3289), "Handcrafted", new Guid("89ce8706-c499-495b-8344-d78fc3d72bb2"), "Unbranded Fresh Bike", 718.11m, (short)6223 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(3313), "Fantastic", new Guid("997f1a6e-2f3a-47a4-ab92-13f39d540d5f"), "Incredible Wooden Hat", 16.80m, (short)3844 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(3341), "Fantastic", new Guid("22884159-ed9d-427c-a199-7e9f2d6c7624"), "Licensed Rubber Soap", 392.25m, (short)2135 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(3366), "Fantastic", new Guid("ace24827-49d5-4a52-9bba-6f0dc3a4df88"), "Awesome Plastic Keyboard", 365.66m, (short)1457 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(3390), "Incredible", new Guid("c979c9f9-fe03-4f7e-9c08-965a1c810352"), "Rustic Plastic Towels", 661.49m, (short)8095 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(3413), "Incredible", new Guid("5f465742-f5d5-42df-bd9e-a16bb4c74d95"), "Rustic Cotton Chair", 567.68m, (short)3508 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(3475), "Unbranded", new Guid("a970f2ed-a576-48d8-aeb4-84bb364600d9"), "Tasty Granite Computer", 693.30m, (short)5729 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(3502), "Rustic", new Guid("bbb7e516-d04f-49e8-b4ef-39c5b6605821"), "Small Fresh Bacon", 249.26m, (short)9698 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(3526), "Tasty", new Guid("109f8816-612b-43fd-89af-a965d8907470"), "Generic Steel Chair", 868.73m, (short)4160 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(3550), "Gorgeous", new Guid("8adfc82e-61ce-4e5d-b198-864f8296a23c"), "Incredible Cotton Soap", 554.99m, (short)5273 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(3576), "Fantastic", new Guid("1963308d-1fcb-4599-af8a-4c93c8c3ff74"), "Generic Wooden Chair", 304.37m, (short)1030 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(3599), "Refined", new Guid("024a8bb6-8b9e-45b0-b3fc-916686c9faa0"), "Unbranded Fresh Shirt", 235.76m, (short)5200 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(3623), "Handcrafted", new Guid("0bf71f1d-47df-4fe8-8873-69d59e8bac57"), "Practical Metal Table", 76.17m, (short)2140 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(3646), "Tasty", new Guid("ced6192d-1db9-4074-898a-6637ae0111c4"), "Intelligent Rubber Sausages", 170.50m, (short)1915 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(3670), "Gorgeous", new Guid("128366da-68d5-4098-ad68-b7c41f4a97af"), "Fantastic Concrete Bike", 435.39m, (short)8119 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(3732), "Handcrafted", new Guid("1c6fa7b6-a5ea-48da-bdf3-fa40216885b2"), "Fantastic Plastic Towels", 911.13m, (short)2735 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(3756), "Small", new Guid("b4ed6ef8-e35c-41c7-93d3-c7b8e13c3157"), "Refined Rubber Towels", 347.49m, (short)4372 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(3780), new Guid("05139ae5-42c3-41b7-8c36-b51040f6d306"), "Unbranded Steel Tuna", 31.42m, (short)760 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(3807), "Intelligent", new Guid("bf4439ac-7560-4eac-8859-5af9eaf9a8f7"), "Small Soft Shoes", 35.24m, (short)132 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(3830), "Sleek", new Guid("4ef91a67-f0ae-4454-8953-60afd481c7d8"), "Incredible Rubber Sausages", 64.10m, (short)2286 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(3854), "Awesome", new Guid("fdad3104-c6de-49b5-9b2b-fd5f73970744"), "Sleek Metal Chicken", 188.88m, (short)8471 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(3879), "Incredible", new Guid("d8998ece-f8d5-4253-a3ad-98968663199e"), "Handmade Granite Tuna", 960.81m, (short)4801 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(3903), "Sleek", new Guid("c5ff3d61-fd54-484e-8b7d-fe5be67909ad"), "Handmade Steel Bacon", 288.45m, (short)2014 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(3925), "Handcrafted", new Guid("8b1c2315-7d61-4412-9d84-b57a04c0448a"), "Licensed Steel Shirt", 156.06m, (short)335 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(3948), "Gorgeous", new Guid("867a26ca-8cf8-467b-b29e-30e3bd4015b8"), "Generic Soft Fish", 748.17m, (short)2180 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(4009), "Handmade", new Guid("02ce874d-dcf4-4d7a-8a44-b75b606a8e04"), "Tasty Steel Ball", 105.58m, (short)5503 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(4036), "Licensed", new Guid("cc63fd77-cc40-4726-b7c3-76ff6464df1d"), "Practical Metal Keyboard", 197.81m, (short)8974 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(4060), "Handcrafted", new Guid("525fcabb-a8ee-4dd7-bb9b-5810e4b8738c"), "Unbranded Steel Soap", 338.14m, (short)9172 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(4084), "Unbranded", new Guid("13df034f-45ca-4451-ac2d-cbff5a764175"), "Awesome Cotton Gloves", 387.01m, (short)5153 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(4109), new Guid("22f04b58-16ad-4abd-9535-d4d0a409e0c9"), "Fantastic Plastic Bacon", 877.91m, (short)5536 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(4132), "Intelligent", new Guid("9835f4d1-cb20-4d51-b446-55ce370873e4"), "Refined Concrete Ball", 199.31m, (short)4535 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(4155), "Handmade", new Guid("8337b08e-6ecb-4f9c-9046-2491416c6bcc"), "Generic Plastic Gloves", 167.50m, (short)3889 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(4178), "Refined", new Guid("d4590c1b-0d45-4757-9d87-7f9d61437e03"), "Handmade Plastic Mouse", 116.09m, (short)7135 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(4202), "Tasty", new Guid("f0694950-988f-46ad-a9fd-45d43e2a9fdb"), "Incredible Cotton Car", 85.70m, (short)644 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(4280), "Tasty", new Guid("255d63d2-6f11-45d4-8a90-3b692f0dea62"), "Refined Wooden Table", 20.85m, (short)5156 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(4306), "Licensed", new Guid("c848adae-f045-4ef2-928d-64a3e2cc9fbd"), "Licensed Wooden Bacon", 379.22m, (short)5120 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(4328), "Practical", new Guid("0feebd41-5540-4b9c-8286-2fac540b7c05"), "Practical Granite Chicken", 704.59m, (short)6707 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(4352), "Incredible", new Guid("29836a97-a15f-424c-8988-300f878e2a9b"), "Rustic Frozen Pants", 870.03m, (short)8451 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(4376), "Gorgeous", new Guid("beeeead4-1f9c-4655-9606-784ffc8695bc"), "Tasty Frozen Sausages", 100.84m, (short)3325 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(4400), "Incredible", new Guid("42bcaa44-fbbe-4f6e-86f1-c922d56ca8e1"), "Ergonomic Soft Ball", 261.05m, (short)5836 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(4424), "Fantastic", new Guid("a641c24d-6bb8-4233-b75a-5b8fd093dddc"), "Practical Frozen Towels", 787.70m, (short)1140 });
        }
    }
}
