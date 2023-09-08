using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.MVC.Migrations
{
    /// <inheritdoc />
    public partial class addShipper : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShipperId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Shippers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shippers", x => x.Id);
                });

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
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(1422), "Tasty", new Guid("5a17b9e7-6d80-49b5-a3ba-c21fedeb2edd"), "Gorgeous Granite Sausages", 951.60m, (short)9900 });

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
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(1647), "Licensed", new Guid("df7606b5-0e3f-4637-854c-b594384a140f"), "Awesome Plastic Hat", 851.86m, (short)3709 });

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
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(1727), new Guid("04bcba0a-f3ed-4060-88c9-253849cbcec9"), "Ergonomic Fresh Keyboard", 323.00m, (short)1384 });

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
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(2412), "Unbranded", new Guid("39fb2bb5-24ba-4ee7-ab29-04d5d9515892"), "Awesome Cotton Chicken", 734.22m, (short)6109 });

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
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(2508), new Guid("7bf5179d-4fb5-4431-ba03-0004727f8ef7"), "Refined Fresh Chair", 179.27m, (short)3059 });

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
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(2935), "Handcrafted", new Guid("a6ffab66-5bc3-4eae-b094-d52a4fe2075c"), "Practical Soft Cheese", 393.93m, (short)7554 });

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
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(2979), new Guid("07eb6c16-0bb5-4c36-904d-6202ca8fce92"), "Gorgeous Soft Bike", 146.46m, (short)7700 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(3002), new Guid("8b874071-c9fd-447b-ba1f-1daf9bac842c"), "Handmade Granite Computer", 805.85m, (short)8607 });

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
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(3780), "Tasty", new Guid("05139ae5-42c3-41b7-8c36-b51040f6d306"), "Unbranded Steel Tuna", 31.42m, (short)760 });

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
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 53, 56, 396, DateTimeKind.Local).AddTicks(3903), new Guid("c5ff3d61-fd54-484e-8b7d-fe5be67909ad"), "Handmade Steel Bacon", 288.45m, (short)2014 });

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

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ShipperId",
                table: "Orders",
                column: "ShipperId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Shippers_ShipperId",
                table: "Orders",
                column: "ShipperId",
                principalTable: "Shippers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Shippers_ShipperId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Shippers");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ShipperId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ShipperId",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Sports", new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(5749), "Sports description.", new Guid("afafdaef-ec9e-4799-b8a0-3250fc4b1483") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Kids", new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(5864), "Kids description.", new Guid("25b95fcb-cf8e-46e4-9ed2-4ba449fc6a79") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Music", new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(5868), "Music description.", new Guid("326c0144-e796-4827-aaa6-c459c16fd1c7") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Home", new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(5871), "Home description.", new Guid("fed6d367-c319-4b8f-8222-a345e7c5b4e5") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Baby", new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(5874), "Baby description.", new Guid("319302cc-03fe-45a4-833b-bb61827ec89e") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Automotive", new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(5877), "Automotive description.", new Guid("9b674a00-b1ab-4fcc-8a1f-85fd7adca175") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Baby", new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(5924), "Baby description.", new Guid("fe416e27-2ffe-4d62-9bae-285b1c603417") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Music", new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(5927), "Music description.", new Guid("56b29bb3-e4c1-4ea7-83c5-33778dd98d31") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Books", new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(5929), "Books description.", new Guid("a015d2f6-673f-4232-9a2b-6b839d3d4c53") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Books", new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(5934), "Books description.", new Guid("7fef3631-5967-4ac3-bf15-f24936ebbfad") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6063), "Handmade", new Guid("44e85d8d-f470-480f-b4db-2a33b1c69549"), "Gorgeous Granite Chips", 841.32m, (short)367 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6188), "Unbranded", new Guid("b1ea1f2b-ad92-46e4-9c3a-25b20de3b6d0"), "Refined Granite Fish", 100.42m, (short)5646 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6209), "Small", new Guid("a6efb5ba-3f5b-4df8-93e5-8a096616b96b"), "Sleek Cotton Hat", 390.06m, (short)6585 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6228), "Incredible", new Guid("5ea95d7d-4941-499d-a4dc-de1a9f7508ce"), "Practical Frozen Pizza", 374.92m, (short)1515 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6247), "Intelligent", new Guid("a2f75469-aa1e-443f-b92e-d74cf0e6b3af"), "Practical Frozen Shoes", 790.49m, (short)2788 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6265), "Handmade", new Guid("79671f13-e6f6-4278-bd6d-d03e6e21a295"), "Intelligent Wooden Sausages", 586.98m, (short)243 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6285), "Rustic", new Guid("d8d515bb-de5b-4509-9aed-62fd83cc83fd"), "Gorgeous Rubber Tuna", 335.11m, (short)1481 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6303), "Practical", new Guid("0005f4f1-990f-4621-b085-8878168ff199"), "Gorgeous Granite Car", 874.38m, (short)1932 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6365), "Refined", new Guid("658cabf8-f12f-4f02-bf00-89612e817d15"), "Handcrafted Plastic Bacon", 738.96m, (short)8302 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6388), "Ergonomic", new Guid("7aeda104-be88-4d3f-92cb-52c5a1fcc32d"), "Unbranded Fresh Shoes", 927.45m, (short)4468 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6405), "Ergonomic", new Guid("dda101d2-b84c-4e21-9c68-79efa145d660"), "Generic Granite Soap", 7.37m, (short)6445 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6423), new Guid("4fd752b2-06b5-4ac0-881c-51aa0622d27e"), "Practical Fresh Soap", 384.38m, (short)2550 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6439), "Awesome", new Guid("3c1350e3-632f-49b2-b2b7-f01507f77737"), "Tasty Soft Mouse", 481.15m, (short)2635 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6456), "Handcrafted", new Guid("60612a19-4179-40b4-a206-05ae0b4a7545"), "Fantastic Fresh Bacon", 794.50m, (short)1367 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6473), "Unbranded", new Guid("0c765700-ba7f-4897-91e3-3b2416d3d5c6"), "Handcrafted Wooden Chicken", 765.82m, (short)1125 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6491), "Refined", new Guid("726013a1-64e8-44ff-a8e5-7a3d1a9e6072"), "Fantastic Plastic Chicken", 137.24m, (short)3559 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6507), "Fantastic", new Guid("c5d8753f-b79b-482e-81c7-6faa028d0b09"), "Rustic Concrete Gloves", 995.70m, (short)9047 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6567), "Rustic", new Guid("a53d89c8-6f7c-435b-a668-250d5c621354"), "Handcrafted Metal Bacon", 341.58m, (short)9019 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6584), "Generic", new Guid("22b161ef-9faa-41c9-8a6b-8382ca0dd3cf"), "Refined Steel Ball", 699.60m, (short)1649 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6614), "Fantastic", new Guid("dcf23f75-986f-4b26-964e-0bc52208fe67"), "Refined Plastic Cheese", 613.12m, (short)6748 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6632), "Sleek", new Guid("6f05c37a-1354-4f40-acb5-f3020c4ac1c5"), "Handmade Steel Shoes", 857.61m, (short)9743 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6647), "Rustic", new Guid("c0b5ed6d-0fdf-415c-b368-e4fe8b2767ab"), "Gorgeous Soft Salad", 970.50m, (short)3269 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6663), "Practical", new Guid("e65c23f3-2c0e-4c2e-85ef-f03c8f7bd5a9"), "Unbranded Rubber Chair", 31.61m, (short)4498 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6681), "Gorgeous", new Guid("2b5385f9-0f69-4bd7-bd41-836628f6da9f"), "Sleek Frozen Fish", 935.27m, (short)1705 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6697), "Practical", new Guid("97f751cc-e3b4-41f0-b40c-fb7e8c15ebc9"), "Incredible Frozen Bacon", 455.50m, (short)3085 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6712), "Sleek", new Guid("011d66a2-5538-40fa-b8bc-bdad426d0789"), "Refined Frozen Fish", 309.99m, (short)4314 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6729), "Generic", new Guid("130b13b6-784a-4e51-8c1b-8a5ad1271b55"), "Small Steel Shoes", 440.89m, (short)6966 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6785), "Sleek", new Guid("3bb9b5a9-4e31-48b6-9c15-1c6c7f5b2702"), "Small Soft Pizza", 940.28m, (short)9770 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6801), "Small", new Guid("2abd7e2d-8a2a-46fc-9c65-b9a6135b203a"), "Licensed Granite Table", 125.56m, (short)3282 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6818), "Refined", new Guid("b8c56ca4-19d4-489f-aa18-7e4cf180572f"), "Small Soft Pants", 93.07m, (short)2889 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6835), "Incredible", new Guid("8709daa6-1c2b-480f-9846-e6bc67a3f1bc"), "Generic Frozen Salad", 731.68m, (short)3803 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6852), "Ergonomic", new Guid("2146acb5-b03e-482d-b064-e241e2e7249c"), "Practical Metal Salad", 750.59m, (short)6809 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6868), "Handcrafted", new Guid("c8c6b7db-59ac-4ba9-b019-6a6390061046"), "Ergonomic Concrete Soap", 548.40m, (short)3549 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6885), "Rustic", new Guid("df02ddd0-6d78-4c8b-bd7c-9b59e94d1fa2"), "Licensed Frozen Shoes", 130.70m, (short)9208 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6901), "Intelligent", new Guid("d1030788-72fd-451f-95e1-682f8ddbeaa4"), "Unbranded Plastic Towels", 191.13m, (short)2244 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6917), "Intelligent", new Guid("a85f952a-447d-4647-885c-8816b93a2b1b"), "Ergonomic Frozen Pizza", 701.10m, (short)1748 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6931), new Guid("26a98c33-7023-4c62-bd28-a6f27a7e8032"), "Fantastic Concrete Tuna", 351.60m, (short)3553 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6999), "Refined", new Guid("f6ae73ba-f28c-4453-8379-44f2ab8528bb"), "Fantastic Steel Pants", 644.56m, (short)2782 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7014), "Ergonomic", new Guid("b7ba556f-38cb-43c8-be57-7dbf5734f10e"), "Practical Granite Towels", 734.70m, (short)7960 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7031), "Ergonomic", new Guid("96e54138-4588-4f3b-a28f-de386fba999f"), "Generic Metal Pizza", 230.56m, (short)6250 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7046), "Rustic", new Guid("6bbb4164-b481-4817-a4a0-6c2c8e1d296f"), "Gorgeous Fresh Gloves", 572.36m, (short)9417 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7061), "Incredible", new Guid("556dd04c-f925-420f-a4c4-815005eb497a"), "Gorgeous Metal Pants", 64.10m, (short)1275 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7077), "Rustic", new Guid("f4f429ca-1b99-4da5-ae2b-e58dd96b1bca"), "Incredible Concrete Car", 463.08m, (short)2903 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7092), "Handcrafted", new Guid("f0d0dda0-8c0c-477f-8227-f229018a5976"), "Fantastic Metal Sausages", 228.21m, (short)3900 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7107), "Generic", new Guid("6d0202a5-6a5b-43e5-96e8-81f42710b972"), "Handmade Wooden Shoes", 405.21m, (short)4421 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7123), "Licensed", new Guid("60b8d09e-6ba7-4d62-ba4f-0f58c381051b"), "Tasty Concrete Hat", 157.58m, (short)8185 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7188), "Gorgeous", new Guid("1efbd74e-1d10-4715-9097-c01d89dc37c8"), "Awesome Rubber Towels", 17.10m, (short)4497 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7207), new Guid("86b6893c-c9a4-4b5f-b640-f0e63aeeec64"), "Unbranded Steel Chicken", 492.79m, (short)9250 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7223), new Guid("b561ff4f-0774-43c4-ad12-bde37885d69e"), "Small Soft Computer", 587.18m, (short)4326 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7237), "Awesome", new Guid("576b8717-c47b-4e7a-80ef-c2cfadde8057"), "Handcrafted Wooden Pants", 502.46m, (short)4302 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7252), "Fantastic", new Guid("51d0a362-3734-42d1-a564-9d7580145746"), "Sleek Cotton Towels", 586.16m, (short)8031 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7267), "Intelligent", new Guid("217e0b8a-a1bc-4987-8c9f-e76d3dc8b1cb"), "Tasty Frozen Ball", 803.70m, (short)873 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7282), "Tasty", new Guid("e1d1bb06-3976-468f-afe0-83ce188be034"), "Ergonomic Rubber Shoes", 569.64m, (short)7710 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7297), "Awesome", new Guid("775258ef-20d0-4865-99cb-4df34c985248"), "Intelligent Fresh Tuna", 430.40m, (short)5584 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7312), "Gorgeous", new Guid("2feb286b-9bce-4023-bd1e-cb7d24728244"), "Tasty Concrete Soap", 111.49m, (short)1385 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7328), "Fantastic", new Guid("f2dd284f-6b0a-4bc7-a749-50c98d7ede7c"), "Practical Soft Ball", 45.01m, (short)9602 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7378), "Handcrafted", new Guid("8ad84327-f476-404d-a139-277384d59f61"), "Practical Cotton Pizza", 222.19m, (short)9545 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7393), "Unbranded", new Guid("2db46f41-2ab8-4b2d-8cec-088a9f4e1cf7"), "Intelligent Steel Sausages", 168.49m, (short)790 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7409), "Practical", new Guid("36257d51-46da-4fb5-a15d-ffcccdb857ce"), "Small Frozen Fish", 210.46m, (short)7376 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7423), "Gorgeous", new Guid("81328027-ba94-44ac-b454-a2f4a8099a79"), "Intelligent Cotton Bike", 716.49m, (short)9303 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7439), "Rustic", new Guid("82724d73-d698-4183-95d2-0a36178f8ee1"), "Handmade Concrete Keyboard", 865.67m, (short)7141 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7457), "Awesome", new Guid("49b87c5e-4952-47f0-8e73-58ac86a36b5c"), "Incredible Wooden Mouse", 925.36m, (short)5234 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7472), "Awesome", new Guid("783b4643-6aaf-49c5-93fb-ea0371ae4e0b"), "Gorgeous Steel Bacon", 946.03m, (short)5684 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7488), "Handcrafted", new Guid("bec58ec2-1e55-4f80-8121-80b4f5d5558f"), "Small Cotton Pizza", 132.79m, (short)6908 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7504), "Awesome", new Guid("db9f5ef2-a281-4c82-b70a-4d111cd65a95"), "Rustic Fresh Table", 430.16m, (short)9217 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7562), "Handmade", new Guid("0bd9ae84-b1e1-46b8-910f-6d52d3031ba1"), "Generic Rubber Tuna", 294.02m, (short)5690 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7578), "Licensed", new Guid("caafff31-964f-46ef-995e-18dd7db22f78"), "Rustic Rubber Table", 531.97m, (short)7786 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7593), "Gorgeous", new Guid("cf73a84b-f601-4972-9cbf-700504585c87"), "Handmade Frozen Towels", 344.22m, (short)4552 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7607), "Generic", new Guid("131c31f7-8f41-4f9a-8805-798d76ff28ad"), "Sleek Frozen Sausages", 772.07m, (short)8453 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7622), "Intelligent", new Guid("e4d0674f-f67c-4a1c-8704-8529297893b5"), "Intelligent Plastic Shirt", 747.18m, (short)5587 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7638), "Tasty", new Guid("4deef78d-c39b-4c5a-9597-f8193352a608"), "Rustic Soft Sausages", 434.82m, (short)7249 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7654), "Small", new Guid("4f2a5850-6080-4bd3-9a23-fe5230810214"), "Handcrafted Frozen Shirt", 92.74m, (short)8242 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7669), "Sleek", new Guid("83feacb5-44f7-4f53-9c27-3aaae72884f3"), "Sleek Soft Shoes", 60.01m, (short)744 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7684), "Practical", new Guid("693278a9-80e4-4d36-ae17-648766cf9829"), "Unbranded Granite Towels", 470.33m, (short)4553 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7698), "Awesome", new Guid("eb944b10-12d6-4b2d-9d45-818b3f021b25"), "Awesome Steel Tuna", 789.21m, (short)1471 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7757), "Awesome", new Guid("45074e1d-f201-45b6-85df-d0e3c2b975ff"), "Gorgeous Granite Shirt", 549.15m, (short)5309 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7772), "Refined", new Guid("2a83a538-5647-4244-99d1-aa7e62f26af3"), "Handmade Frozen Tuna", 793.93m, (short)5283 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7787), "Handmade", new Guid("3738decc-5755-42e0-8ea0-d7abb1aed4d8"), "Gorgeous Fresh Gloves", 106.24m, (short)7665 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7802), "Ergonomic", new Guid("5325c34f-3675-4d24-9258-c6a5483db210"), "Awesome Plastic Cheese", 508.33m, (short)9153 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7818), "Gorgeous", new Guid("9bacff7a-9620-4e6d-85f9-bad88ea40ef5"), "Unbranded Rubber Keyboard", 639.61m, (short)2146 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7834), "Unbranded", new Guid("ab1461c2-db89-464f-aa49-36f3c223f6c8"), "Awesome Cotton Chicken", 118.79m, (short)1185 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7849), new Guid("8f9f96e8-bded-4847-a00e-9c4821188466"), "Practical Frozen Ball", 368.46m, (short)3442 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7864), "Fantastic", new Guid("93d2da34-30d2-45cb-9e76-0c70b7cfd5c0"), "Handmade Granite Sausages", 331.04m, (short)6476 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7878), "Ergonomic", new Guid("fb54c341-f127-46db-8697-0a852496f06f"), "Gorgeous Metal Ball", 529.08m, (short)8495 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7892), "Licensed", new Guid("7a690d5a-25dd-4b8e-b848-1d9b68e33769"), "Fantastic Soft Bike", 834.38m, (short)145 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7946), "Incredible", new Guid("6909fd0b-f3a3-4456-91f5-1d25c6bf3370"), "Unbranded Steel Car", 485.44m, (short)9296 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7961), "Generic", new Guid("05f088f0-ca70-47ac-8eb4-d2b4d2782c9c"), "Fantastic Cotton Ball", 707.56m, (short)2401 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7978), "Ergonomic", new Guid("5d7585db-e358-4d0f-8de7-22c2e035e387"), "Refined Concrete Mouse", 561.08m, (short)4745 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7993), new Guid("13ef246b-2cf9-42a6-8dbe-10f60513588f"), "Incredible Concrete Bike", 828.87m, (short)8737 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(8008), "Rustic", new Guid("0f12bbb2-a289-4924-8310-920a830f5e67"), "Rustic Steel Hat", 977.20m, (short)9453 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(8023), "Tasty", new Guid("7ad49676-f150-4476-bb29-a61501bab034"), "Tasty Steel Shoes", 530.44m, (short)6558 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(8038), "Handcrafted", new Guid("ddf6242d-ca47-4ea6-949a-d7becf66c156"), "Tasty Fresh Shirt", 870.74m, (short)6864 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(8052), "Gorgeous", new Guid("366601fb-2437-44f2-8f35-3cc1f6251326"), "Handcrafted Plastic Car", 857.40m, (short)477 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(8068), "Small", new Guid("d9e4a81c-d78f-4cae-a0a9-a1a76d7226f4"), "Handcrafted Steel Car", 260.30m, (short)4152 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(8083), "Unbranded", new Guid("776af78e-293a-4a6b-a2f6-eeb272e26f10"), "Handcrafted Fresh Towels", 893.12m, (short)7349 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(8134), "Fantastic", new Guid("50dca6b5-e2f3-4806-b3f1-8ea21f9e925f"), "Handcrafted Cotton Hat", 280.47m, (short)1068 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(8150), "Refined", new Guid("89a9ba7a-54c4-4e17-a449-8634d4d78b20"), "Fantastic Concrete Salad", 589.84m, (short)8408 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(8167), "Awesome", new Guid("37b21cf0-dd0e-4d8a-b438-9c05d7c76c03"), "Practical Frozen Bike", 348.05m, (short)6176 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(8183), "Intelligent", new Guid("c6a048a8-2e02-4618-9328-14b70967c8fe"), "Ergonomic Soft Car", 380.42m, (short)5725 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(8198), "Handmade", new Guid("a26139a3-e715-430a-bcbb-e3214736bb7b"), "Unbranded Frozen Bike", 231.49m, (short)8261 });
        }
    }
}
