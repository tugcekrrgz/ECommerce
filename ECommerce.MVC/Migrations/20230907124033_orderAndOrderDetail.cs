using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.MVC.Migrations
{
    /// <inheritdoc />
    public partial class orderAndOrderDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShippedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
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
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                    table.PrimaryKey("PK_OrderDetails", x => new { x.ProductId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Baby", new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(4677), "Baby description.", new Guid("6f7197b0-8190-4a24-bd83-4d421abc4eca") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Grocery", new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(4766), "Grocery description.", new Guid("c3e88177-40ad-4842-bd0f-b0069dcb2b9f") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Grocery", new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(4771), "Grocery description.", new Guid("d506c03d-501f-42ba-b626-06d055441951") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Movies", new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(4774), "Movies description.", new Guid("e0a544e0-b2ec-45bf-a21f-0335a7fc5b66") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Clothing", new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(4776), "Clothing description.", new Guid("4288d6d2-0627-4395-8b28-a447a6ba4001") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Tools", new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(4780), "Tools description.", new Guid("fe8cbfd7-2149-4e7b-b8bc-ac0a6da09a39") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Electronics", new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(4783), "Electronics description.", new Guid("ae4e470e-5981-44b5-be88-23849daf42a7") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Clothing", new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(4798), "Clothing description.", new Guid("3348df7d-659c-4824-9daa-3e96ec8f9368") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Health", new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(4802), "Health description.", new Guid("888a3713-6298-49eb-8b99-07b5268a25e6") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Jewelery", new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(4805), "Jewelery description.", new Guid("b9090f44-199f-4feb-8e72-c11d797c2ede") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(4962), "Handcrafted", new Guid("e24e9a0d-3ca9-4c7b-82cd-d7a442572b35"), "Rustic Concrete Fish", 993.82m, (short)2445 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(5123), new Guid("33c87958-1531-4b96-9ae9-f0b3080b3c66"), "Intelligent Steel Gloves", 790.51m, (short)1895 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(5150), "Unbranded", new Guid("4794ca8c-e612-4cb9-ba1c-0d45133eb44b"), "Handcrafted Plastic Pizza", 254.92m, (short)971 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(5201), "Tasty", new Guid("ed29185e-1243-4c01-b65d-74213840a06c"), "Fantastic Soft Salad", 142.38m, (short)9031 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(5230), "Rustic", new Guid("e766199b-0a13-4370-bd7b-33e3db021c0e"), "Generic Rubber Keyboard", 194.67m, (short)1946 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(5260), "Gorgeous", new Guid("6df331d9-3635-421b-b8b6-6f02b33c00a2"), "Fantastic Soft Bacon", 63.89m, (short)4938 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(5285), "Practical", new Guid("6b921f68-c3ce-4489-b7dc-7985888a00ba"), "Tasty Fresh Chair", 960.95m, (short)1062 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(5307), "Sleek", new Guid("2afc9b51-f365-4844-bd80-489507e06b51"), "Rustic Cotton Cheese", 866.10m, (short)2402 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(5331), "Handmade", new Guid("3cf0688c-ab8f-423b-a542-37c26c0dbd37"), "Handcrafted Plastic Gloves", 816.29m, (short)9052 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(5353), "Sleek", new Guid("1930b9e9-fc3f-4650-b468-b2e4caf74b13"), "Handmade Cotton Gloves", 141.17m, (short)7748 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(5374), new Guid("8c325ab4-7ee3-488b-8913-cc9d2e46209f"), "Intelligent Soft Keyboard", 908.26m, (short)2835 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(5397), "Rustic", new Guid("386dddf9-fe1c-4147-96b9-fb2afc27abda"), "Rustic Steel Gloves", 379.37m, (short)2351 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(5440), "Tasty", new Guid("5156f402-24a9-4a94-9787-1164d6f94696"), "Tasty Concrete Table", 169.10m, (short)904 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(5463), "Fantastic", new Guid("364f4902-820d-4afd-885f-5ef2b41a9ea8"), "Generic Rubber Car", 259.94m, (short)8816 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(5485), "Fantastic", new Guid("68f60a95-9d5a-49c1-b29b-1ed450fe5775"), "Gorgeous Metal Chair", 867.95m, (short)5872 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(5506), "Refined", new Guid("edff0d10-d455-4f77-a0a0-9a587b8ff3f6"), "Tasty Fresh Mouse", 793.24m, (short)2971 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(5526), "Gorgeous", new Guid("d1d6521e-7024-4cd1-a40b-1fdcf46e8187"), "Licensed Rubber Table", 989.32m, (short)5807 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(5549), "Fantastic", new Guid("708ec459-c9a6-4d1b-a0ef-af9122ac410c"), "Licensed Frozen Computer", 676.16m, (short)7920 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(5570), "Awesome", new Guid("dc2a8093-2061-4cab-9bc7-9466b00860ad"), "Gorgeous Fresh Gloves", 192.36m, (short)2555 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(5592), "Unbranded", new Guid("0e87c48c-c088-4637-8290-e01be8ae020a"), "Handmade Rubber Tuna", 531.50m, (short)5143 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(5615), "Awesome", new Guid("32363425-862c-4056-a25b-18a1acc7bbfb"), "Gorgeous Granite Fish", 672.17m, (short)4666 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(5638), "Ergonomic", new Guid("45260423-1c38-4b2c-b877-54e6390e847d"), "Refined Metal Shirt", 134.19m, (short)2500 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(5684), "Tasty", new Guid("e35fb554-5c05-472a-a330-5a6e3628c7db"), "Intelligent Granite Shoes", 158.50m, (short)2188 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(5710), "Handmade", new Guid("ab2610a3-95d8-43a6-bbdf-dab58f57975c"), "Small Metal Shoes", 230.01m, (short)4390 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(5731), "Sleek", new Guid("692a22e7-85b3-4904-98e9-e957955be4ee"), "Unbranded Granite Hat", 362.21m, (short)9716 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(5753), "Awesome", new Guid("07b1d661-f0f1-4739-b6a0-ebc3af2be90f"), "Handcrafted Cotton Chicken", 399.49m, (short)447 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(5776), "Licensed", new Guid("e441a67c-f4da-4d9f-be05-8d4c9d32531e"), "Unbranded Soft Pants", 970.42m, (short)4446 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(5797), "Generic", new Guid("eca48207-01e0-44d4-acde-c392c405a916"), "Fantastic Frozen Chicken", 910.46m, (short)265 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(5818), new Guid("419a605a-9206-4cc4-8fe1-fb40f6c32666"), "Awesome Steel Towels", 833.42m, (short)5755 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(5840), "Gorgeous", new Guid("9348b67c-fbaf-4a88-ae8d-95d10d624292"), "Intelligent Steel Sausages", 790.10m, (short)5643 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(5862), "Licensed", new Guid("5af8088f-db85-4d25-afd7-8b855f4317b2"), "Intelligent Granite Pizza", 27.67m, (short)7104 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(5882), "Small", new Guid("c62c2cc0-b599-4db2-9788-94c5d3c5c623"), "Intelligent Concrete Chair", 490.98m, (short)8669 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(5928), "Small", new Guid("faa61df1-fff4-4617-8dc4-06536d88a63d"), "Sleek Steel Pizza", 799.76m, (short)3915 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(5953), "Practical", new Guid("d1467eb0-75db-48c4-bbf4-0e479c2c795c"), "Small Concrete Ball", 634.65m, (short)9595 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(5974), "Sleek", new Guid("e97db87e-b2a2-4815-be42-b745d8e23391"), "Ergonomic Fresh Gloves", 156.38m, (short)6497 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(5996), "Small", new Guid("bf33bd95-8117-4dd4-b361-0739611e0a07"), "Generic Cotton Chair", 791.91m, (short)6380 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6016), "Handmade", new Guid("7b740a38-777d-4262-a970-b078421ff0d1"), "Incredible Metal Shoes", 664.76m, (short)3917 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6040), "Gorgeous", new Guid("d3aa8c63-b184-4003-9276-f805e83262f0"), "Unbranded Concrete Table", 372.49m, (short)8583 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6060), "Refined", new Guid("d82b3e99-43a8-4f66-a9b8-6fae33be799b"), "Awesome Plastic Gloves", 152.16m, (short)4317 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6079), "Small", new Guid("3f37f47f-d631-41aa-97f9-24c6a335cb93"), "Licensed Cotton Pants", 729.55m, (short)4966 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6099), "Handmade", new Guid("b751ed37-d862-456c-bc43-da47ce7c8009"), "Incredible Wooden Pizza", 121.84m, (short)2333 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6162), "Fantastic", new Guid("6cae3241-9ef1-4d62-b644-80d0b57d71a4"), "Refined Fresh Mouse", 807.14m, (short)4732 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6183), "Generic", new Guid("67e167b8-1531-4913-a5ba-b21a66fa29a3"), "Licensed Granite Bike", 100.70m, (short)9548 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6205), "Incredible", new Guid("90e555a0-7462-4836-9723-f47fa6f28e5c"), "Practical Plastic Keyboard", 717.59m, (short)5708 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6227), "Licensed", new Guid("e8b36050-7869-4d55-b0c1-56c5857af4ee"), "Refined Concrete Car", 363.77m, (short)9393 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6249), "Tasty", new Guid("05033bbf-0a5d-445f-aa12-0bcb57eade40"), "Handcrafted Wooden Pizza", 968.30m, (short)5423 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6269), "Practical", new Guid("9cef8f0e-a8fe-4a8d-ac90-651a5bb8d266"), "Generic Wooden Soap", 293.90m, (short)8159 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6289), "Practical", new Guid("f9e0b6d7-2a92-4b63-828c-213a3965d30c"), "Unbranded Fresh Bacon", 759.58m, (short)4479 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6310), "Intelligent", new Guid("49f54509-9c85-4610-92cd-ce4083352e5f"), "Handmade Wooden Bike", 924.62m, (short)8951 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6330), new Guid("5076374b-6cdf-46c0-b1e1-810170e84047"), "Incredible Steel Towels", 949.02m, (short)5677 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6350), "Tasty", new Guid("db94220a-1539-44b2-b5dc-720ffca5113d"), "Gorgeous Wooden Soap", 632.46m, (short)1028 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6397), "Fantastic", new Guid("d8b3a8cc-74c4-45bf-bfdd-d88bcf6fbe9d"), "Small Steel Sausages", 635.86m, (short)7384 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6416), "Small", new Guid("998fa5ab-5121-4828-8797-cf479911752e"), "Incredible Concrete Towels", 300.47m, (short)4378 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6440), "Gorgeous", new Guid("136064b4-7f5e-4fbc-84ba-a91f66a5e565"), "Awesome Fresh Keyboard", 107.50m, (short)8079 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6463), "Small", new Guid("cbbaf5e2-dde6-48be-96dc-a543698a7c03"), "Handcrafted Steel Mouse", 666.77m, (short)6024 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6483), "Sleek", new Guid("0c5138fd-8744-4cb4-be24-e6b6337d0780"), "Tasty Plastic Sausages", 739.59m, (short)3662 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6503), "Tasty", new Guid("9714e652-9558-473a-885b-6794586e0e1c"), "Fantastic Metal Computer", 51.35m, (short)9407 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6524), "Incredible", new Guid("70301c6b-eaa3-402e-9045-218f7e705100"), "Sleek Rubber Mouse", 33.61m, (short)6773 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6543), "Intelligent", new Guid("2c44e8d4-afe8-4ae7-84bd-7091ae32a377"), "Handcrafted Cotton Shirt", 705.11m, (short)9350 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6563), "Intelligent", new Guid("514cb87b-5829-48ff-ab80-ae38f6fa9069"), "Sleek Fresh Salad", 731.91m, (short)5718 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6583), "Incredible", new Guid("c2f7bd65-c0a5-4284-b650-f598eceac0f8"), "Practical Granite Keyboard", 755.73m, (short)1843 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6632), "Sleek", new Guid("a775cbb7-0374-47c1-858f-fa6727c2ec24"), "Intelligent Wooden Chips", 900.32m, (short)5440 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6652), "Awesome", new Guid("ea7ebc3c-be8c-4859-b72d-a81d8d8a4ce0"), "Practical Plastic Cheese", 57.29m, (short)6656 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6672), "Incredible", new Guid("e884c164-d806-45f6-b6a7-4ef817e8de82"), "Sleek Cotton Gloves", 366.73m, (short)6352 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6691), "Ergonomic", new Guid("fd1f3980-d846-40b3-b5c3-6565502c2e26"), "Ergonomic Metal Ball", 106.57m, (short)991 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6714), "Small", new Guid("9cc75576-9098-4afb-91a4-259518db3639"), "Incredible Fresh Pants", 734.25m, (short)6627 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6733), "Sleek", new Guid("33d47ede-1e4b-4258-a116-9efd9e5cea0b"), "Fantastic Granite Towels", 633.37m, (short)882 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6753), "Tasty", new Guid("2f105178-8caa-4344-9cdd-4603ae940c4a"), "Awesome Granite Computer", 851.73m, (short)5414 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6773), "Licensed", new Guid("a6e3c05b-4dea-49d4-9bb9-e7df6e962431"), "Generic Concrete Bacon", 316.74m, (short)5096 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6817), "Sleek", new Guid("61c38049-1a5d-4c4a-8472-90c9a80f0e75"), "Ergonomic Granite Shirt", 766.65m, (short)910 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6837), "Awesome", new Guid("d627e873-8840-4f60-bb19-e7f5ecedfe58"), "Unbranded Cotton Ball", 177.44m, (short)490 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6856), "Intelligent", new Guid("2e459fff-cab2-407b-a5ea-67c58ae00d1a"), "Gorgeous Plastic Tuna", 145.62m, (short)9584 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6877), "Licensed", new Guid("fe875002-0738-45e2-962b-a9cb41b82de7"), "Rustic Cotton Chicken", 862.56m, (short)3952 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6898), "Ergonomic", new Guid("9bb48f9f-3032-4f99-ad20-d49906753dd1"), "Refined Granite Pizza", 304.50m, (short)5405 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6919), "Tasty", new Guid("f8296965-44ab-489c-ac25-80db064b8df9"), "Ergonomic Cotton Chips", 241.72m, (short)2594 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6938), "Unbranded", new Guid("2aa9a288-e34a-4a0e-96e5-b1276bf86d16"), "Fantastic Granite Sausages", 833.14m, (short)5550 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6957), "Refined", new Guid("7dee53cd-1ffd-4f3b-a3ca-1e0ac775b994"), "Rustic Rubber Pizza", 76.24m, (short)5070 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6981), new Guid("50377353-fafc-4c21-9f67-7ce152e594ee"), "Practical Soft Sausages", 131.28m, (short)8429 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(7000), "Practical", new Guid("5d071fd1-3f15-4c1d-b7d4-0b132baca3a1"), "Handmade Steel Bacon", 82.37m, (short)4691 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(7048), "Sleek", new Guid("40c58503-5198-481b-a3b5-c369512d9f5a"), "Incredible Frozen Shirt", 180.83m, (short)5081 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(7069), "Intelligent", new Guid("2f675881-7d40-4ae2-8fed-a02f0638ba0c"), "Gorgeous Wooden Shoes", 973.04m, (short)277 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(7089), "Practical", new Guid("08678269-dd89-47aa-bd20-de060fa82456"), "Intelligent Steel Chicken", 858.90m, (short)39 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(7109), "Handcrafted", new Guid("76375470-a22e-417a-b9be-1cac12c1dacd"), "Handcrafted Steel Chicken", 586.01m, (short)7752 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(7129), "Practical", new Guid("8f6cc538-95d2-4370-a43d-005cccd76f44"), "Ergonomic Rubber Salad", 567.90m, (short)9731 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(7148), "Generic", new Guid("3e90a874-4ff8-4569-8e0e-e8cea20afe67"), "Rustic Concrete Hat", 581.56m, (short)3788 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(7171), "Refined", new Guid("523d0895-9246-40e0-96bd-8d7634883c2d"), "Licensed Soft Gloves", 216.48m, (short)2601 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(7190), "Handmade", new Guid("3d6fe8f5-6f55-4bb6-b625-79d4fb5e20e6"), "Generic Soft Hat", 383.17m, (short)2856 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(7209), "Handcrafted", new Guid("335923dc-e9df-441c-b4fe-539f34953a46"), "Gorgeous Cotton Shirt", 506.99m, (short)7977 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(7228), "Handcrafted", new Guid("c9d8ebfa-a581-457c-b1cf-78e9ed3d8557"), "Generic Concrete Cheese", 216.99m, (short)3235 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(7275), "Sleek", new Guid("92e7cbf5-321e-4938-9f7e-0d1790549679"), "Small Wooden Soap", 481.80m, (short)717 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(7298), "Practical", new Guid("9002c6f2-99f8-4e09-82b4-1369323f4358"), "Intelligent Frozen Table", 798.62m, (short)1631 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(7318), "Sleek", new Guid("cc3ebbe2-3d38-4c20-98b8-f580105cb998"), "Handcrafted Plastic Computer", 795.56m, (short)4534 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(7338), "Unbranded", new Guid("de01b720-dee4-4aa0-966d-f556286de4ab"), "Rustic Granite Towels", 704.05m, (short)77 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(7361), "Unbranded", new Guid("25e0f658-0065-4d6f-a11c-32692b9fb179"), "Sleek Steel Salad", 979.13m, (short)4520 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(7380), "Ergonomic", new Guid("affeaf46-9264-445c-978f-963901363f81"), "Tasty Fresh Ball", 153.64m, (short)3232 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(7400), "Unbranded", new Guid("b6cc7a5f-6c90-4587-bdfe-be2b7fa31560"), "Refined Metal Hat", 213.03m, (short)6233 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(7421), "Awesome", new Guid("692f489b-a9b1-4283-8273-15b0adbb2eb6"), "Handcrafted Plastic Gloves", 624.89m, (short)6636 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(7441), "Handcrafted", new Guid("d1b38c25-7a64-48a8-9485-ee72a6834674"), "Gorgeous Concrete Salad", 821.42m, (short)1461 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(7462), "Sleek", new Guid("b8db8883-7dc2-407e-be26-f7e8310e2ead"), "Awesome Soft Bike", 14.83m, (short)6344 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(7509), "Small", new Guid("9e71e2ce-cdc5-4e2f-81e3-ebe68f3fc4f1"), "Unbranded Plastic Gloves", 850.03m, (short)669 });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId1",
                table: "Orders",
                column: "UserId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Electronics", new DateTime(2023, 9, 7, 11, 8, 19, 676, DateTimeKind.Local).AddTicks(9997), "Electronics description.", new Guid("91974cce-d4e4-4c53-998a-19fdc549603c") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Beauty", new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(76), "Beauty description.", new Guid("729db11a-dd62-42d4-9b2a-75bd3a0e2c84") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Automotive", new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(79), "Automotive description.", new Guid("2e77a78c-647c-4ba0-b56e-e590a7b9b669") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Home", new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(82), "Home description.", new Guid("c50b5a7b-27ab-4adc-8cc1-5b3b0b9e53c3") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Books", new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(84), "Books description.", new Guid("5e35f5e8-e363-443d-bdfb-19c66a70c81e") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Computers", new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(109), "Computers description.", new Guid("70c9d09b-6126-4764-ac0f-fb4549cc2af6") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Outdoors", new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(112), "Outdoors description.", new Guid("6bf0cc03-1296-4dd6-a844-28dd78cca9fe") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Beauty", new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(115), "Beauty description.", new Guid("89e991b5-326d-4d7e-a403-1e4377c230a3") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Tools", new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(127), "Tools description.", new Guid("c0ea52ea-5407-41b5-8b1a-1cb03b438d58") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Shoes", new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(131), "Shoes description.", new Guid("de5db860-a040-4570-a2b8-6da251c679c7") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(268), "Refined", new Guid("b863c4aa-2e7e-46db-9a37-4fb111e9d2b6"), "Incredible Fresh Gloves", 776.26m, (short)6521 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(406), new Guid("4e659864-497c-44c2-a190-90433fbb46fb"), "Unbranded Granite Bike", 869.47m, (short)9953 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(431), "Ergonomic", new Guid("6c09b794-d9a3-4a5c-a240-5206d9bd1fa3"), "Handcrafted Soft Soap", 615.85m, (short)1512 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(452), "Intelligent", new Guid("5e45de56-f4cd-4cc7-9676-b26b714fa860"), "Awesome Plastic Gloves", 312.61m, (short)2918 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(471), "Small", new Guid("d094f0fd-6573-4d11-8552-13b0fa28c210"), "Fantastic Steel Shoes", 15.51m, (short)6010 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(491), "Fantastic", new Guid("25508abb-aea9-41b1-bb9f-6d110ee3398e"), "Small Metal Chicken", 301.64m, (short)1418 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(513), "Tasty", new Guid("791b6722-266e-4e6d-ac1c-7ce34246abce"), "Gorgeous Frozen Ball", 465.24m, (short)6521 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(532), "Practical", new Guid("359abf6c-9773-4afd-9dbd-3c05edd028bb"), "Generic Rubber Computer", 102.46m, (short)1070 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(575), "Fantastic", new Guid("4b5f1ad9-c645-4a0f-9f9c-d146b5de3436"), "Practical Fresh Cheese", 435.32m, (short)917 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(595), "Generic", new Guid("53dc2a42-c820-4fd4-b7e2-b2b4a54a7de2"), "Licensed Cotton Tuna", 318.83m, (short)8919 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(614), new Guid("ecd3b773-06f5-45f4-996e-427a44fc1433"), "Ergonomic Frozen Towels", 587.57m, (short)5999 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(632), "Handmade", new Guid("c4723e37-e502-4ae6-bd6a-91c0ebfb09fb"), "Tasty Granite Computer", 479.78m, (short)3610 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(648), "Refined", new Guid("bffdc0ce-1420-4646-b571-f38ec675c70a"), "Rustic Concrete Chicken", 331.63m, (short)8599 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(665), "Sleek", new Guid("aeb8d450-ba46-4c42-8ec7-77cc453822af"), "Awesome Plastic Towels", 938.53m, (short)78 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(684), "Gorgeous", new Guid("748d3b77-48a2-435a-8301-80c4212e117f"), "Incredible Metal Hat", 628.01m, (short)8345 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(702), "Sleek", new Guid("eedc45b3-9a50-431d-85e0-33350d61426e"), "Practical Metal Tuna", 31.27m, (short)2028 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(719), "Handcrafted", new Guid("21c717d6-33d4-4866-82ee-17c2577e2e9e"), "Sleek Rubber Chair", 976.48m, (short)5344 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(759), "Small", new Guid("eeee8f72-6081-4fbe-8c13-bbf3e23344a5"), "Tasty Plastic Table", 514.68m, (short)2674 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(779), "Fantastic", new Guid("35eb5f07-5f03-4f90-930a-3a1d788d38f5"), "Tasty Rubber Bike", 225.23m, (short)1409 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(796), "Ergonomic", new Guid("ec35e6d1-a747-4fbf-9024-e93f82b190e8"), "Generic Plastic Shoes", 686.00m, (short)9188 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(815), "Generic", new Guid("4f8811f7-e009-471f-b015-7814034e6cec"), "Handmade Fresh Gloves", 519.34m, (short)3867 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(833), "Sleek", new Guid("f4c18886-2522-4b82-a024-719fb40eabef"), "Unbranded Frozen Soap", 455.28m, (short)4567 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(851), "Generic", new Guid("b672a78d-ab72-438a-809e-207909959c5f"), "Small Steel Mouse", 749.79m, (short)5300 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(868), "Incredible", new Guid("6d74cd2e-8047-4ec2-8178-5a58ea5fd6fb"), "Practical Plastic Pizza", 492.15m, (short)3187 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(886), "Tasty", new Guid("05de8da3-9b39-4052-bc51-33d9ccd4e341"), "Refined Rubber Hat", 321.06m, (short)7290 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(903), "Fantastic", new Guid("70e26e44-671b-40ac-947b-60b7d05e553c"), "Incredible Frozen Mouse", 778.55m, (short)122 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(919), "Awesome", new Guid("3bfcbfd5-ea13-41a3-9581-b90bcea50989"), "Ergonomic Rubber Shoes", 792.62m, (short)485 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(955), "Tasty", new Guid("c058b2ae-69bb-48cc-aee9-3b25ceda7c4e"), "Awesome Concrete Bike", 42.83m, (short)883 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(972), new Guid("4fb7bc1a-496d-4bb4-99e3-633bed87f67b"), "Ergonomic Granite Mouse", 604.02m, (short)7886 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(989), "Intelligent", new Guid("db8e9941-b14f-40bc-8513-76642835570e"), "Unbranded Wooden Ball", 626.17m, (short)3575 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1009), "Intelligent", new Guid("d94bf42f-1414-430c-993e-ebf134cd77aa"), "Generic Rubber Bacon", 625.18m, (short)2520 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1026), "Licensed", new Guid("93993e2f-593a-408f-8514-556a6b52cedf"), "Handmade Steel Car", 670.47m, (short)7501 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1043), "Practical", new Guid("44a34cde-cc7e-4063-bfc0-29bffe2f802a"), "Gorgeous Wooden Towels", 596.38m, (short)5686 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1061), "Awesome", new Guid("33d072f3-20d1-4412-878d-f8fe0a026f11"), "Tasty Granite Sausages", 659.28m, (short)7627 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1079), "Incredible", new Guid("9d4276a2-f399-4531-a281-bb4b27caec4f"), "Tasty Fresh Car", 596.06m, (short)8938 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1095), "Ergonomic", new Guid("3f88b35b-e0a0-4bb9-9f68-5e4cee554a21"), "Gorgeous Frozen Shirt", 813.99m, (short)1897 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1113), "Handcrafted", new Guid("a768b990-2d49-4234-a666-58c7e8c331ef"), "Small Granite Pants", 839.88m, (short)5647 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1165), "Handmade", new Guid("95eb3f46-37be-457d-8db1-3a99fab9d333"), "Refined Soft Chicken", 248.48m, (short)3752 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1184), "Gorgeous", new Guid("9a429f1f-13bd-48a8-92cb-b6b94bd6f556"), "Handmade Rubber Table", 266.70m, (short)5827 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1201), "Refined", new Guid("f9b1d55e-d961-43d8-9d62-e8a6dc8bead6"), "Licensed Fresh Computer", 77.75m, (short)2551 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1218), "Small", new Guid("27ffbda7-d339-4112-872a-0a86e20498f6"), "Incredible Cotton Salad", 897.14m, (short)5985 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1235), "Generic", new Guid("241af248-1acc-43d8-a0c1-f6ee2c32bad2"), "Sleek Soft Keyboard", 576.85m, (short)3952 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1252), "Small", new Guid("4d814088-a518-4318-93d0-de86b350187a"), "Handcrafted Rubber Computer", 655.15m, (short)627 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1268), "Refined", new Guid("2867b9e4-951d-4b94-a1d8-1e4d7989b473"), "Gorgeous Plastic Computer", 370.21m, (short)3199 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1285), "Intelligent", new Guid("44569646-922a-40df-baf1-5f07cac13088"), "Handmade Metal Keyboard", 202.16m, (short)2387 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1301), "Sleek", new Guid("4aa6829f-9260-469f-bb6d-e1fffaa7a42a"), "Sleek Steel Shoes", 721.68m, (short)5981 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1319), "Handcrafted", new Guid("614abfe0-b92d-4993-b06a-ba50fb556be9"), "Ergonomic Frozen Mouse", 938.39m, (short)7582 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1356), "Small", new Guid("486d1041-27c0-4dd0-98cc-b0663bfa7730"), "Small Fresh Cheese", 619.15m, (short)3254 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1372), "Fantastic", new Guid("61c92957-d739-4a46-b64b-8ba90ef0fc86"), "Incredible Steel Gloves", 755.84m, (short)6215 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1388), new Guid("89234bdc-bb36-4321-ac2f-592c3b547c77"), "Handmade Concrete Tuna", 840.42m, (short)8527 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1404), "Incredible", new Guid("e4a91a56-9d96-4951-86cc-a8b479294d23"), "Unbranded Soft Car", 915.79m, (short)3943 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1421), "Sleek", new Guid("aa625e2a-2537-4fa9-8651-9d014c448c11"), "Handmade Concrete Table", 540.56m, (short)250 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1436), "Practical", new Guid("cbbd7871-c672-4b2b-8471-5f727d27c41e"), "Sleek Plastic Gloves", 972.29m, (short)501 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1452), "Practical", new Guid("e0ba8dd6-30c2-4e85-807b-6566ff5aa521"), "Refined Steel Chair", 560.12m, (short)6764 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1470), "Handcrafted", new Guid("3617300a-7f1a-4e73-b66c-48975e4daa26"), "Generic Cotton Shirt", 22.98m, (short)7460 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1487), "Ergonomic", new Guid("70493b29-a1b2-4b14-a683-753d87c1c050"), "Refined Metal Chips", 13.90m, (short)6407 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1504), "Refined", new Guid("345a5f6e-b486-4663-9da0-fc0bc3cf4709"), "Incredible Cotton Fish", 138.53m, (short)2263 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1542), "Generic", new Guid("8ccc6c52-4c26-489a-8621-98bf1fa0cdab"), "Awesome Wooden Chair", 948.44m, (short)1102 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1558), "Tasty", new Guid("b3d6cc73-c839-4216-907e-bf5556b7c545"), "Rustic Steel Cheese", 728.22m, (short)3882 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1573), "Licensed", new Guid("2d74f722-236f-40bb-9850-f07ef7391365"), "Intelligent Concrete Bacon", 591.09m, (short)5560 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1590), "Gorgeous", new Guid("61af9b8c-c916-4720-b421-784f832ff23c"), "Incredible Soft Chair", 360.09m, (short)3523 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1606), "Intelligent", new Guid("d7f14950-9909-4396-819b-650c9ea061d1"), "Intelligent Metal Chicken", 415.38m, (short)4678 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1625), "Licensed", new Guid("658092b6-1e18-4f1f-9d3c-52c6e2901229"), "Fantastic Cotton Towels", 534.94m, (short)7146 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1642), "Refined", new Guid("94758869-fe52-4cc2-964c-6b80a5c26092"), "Rustic Granite Bike", 539.67m, (short)5091 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1659), "Unbranded", new Guid("0a2501fa-a5c9-46ce-96cc-408d3d8a7578"), "Sleek Frozen Mouse", 909.67m, (short)7743 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1698), "Licensed", new Guid("556e5f60-f74b-4412-bf9f-b9b2f7e22cfd"), "Generic Fresh Tuna", 931.81m, (short)9983 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1717), "Ergonomic", new Guid("86e474f3-665a-4539-a347-4ff7ebbfdfc6"), "Ergonomic Soft Car", 700.46m, (short)5448 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1735), "Gorgeous", new Guid("f9e01207-d395-4042-aafe-63d6b79205eb"), "Handmade Frozen Pants", 267.41m, (short)6400 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1751), "Intelligent", new Guid("8b256d20-956a-4426-b8a1-a8776fac2597"), "Licensed Fresh Hat", 605.79m, (short)9026 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1768), "Small", new Guid("d4ef796e-a397-42d6-a243-0298179b0dd1"), "Small Steel Salad", 374.28m, (short)1558 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1787), "Gorgeous", new Guid("ab1c3ea4-c762-41ab-9872-fbd79db8f7e2"), "Unbranded Frozen Hat", 649.89m, (short)2701 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1803), "Ergonomic", new Guid("0da53bcc-5e62-46e1-b552-fdc941ae1de4"), "Sleek Cotton Hat", 435.20m, (short)7023 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1820), "Awesome", new Guid("cab55d4b-eb63-4cb3-a174-b777800f04da"), "Handmade Steel Car", 771.54m, (short)139 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1835), "Handcrafted", new Guid("251e5cf3-edaf-4b2a-9ec8-da2acfaec574"), "Awesome Steel Towels", 44.33m, (short)7226 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1851), "Practical", new Guid("55ed92a2-7d14-4bcd-b3d4-2802a07a1773"), "Intelligent Granite Bike", 321.50m, (short)5295 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1888), "Handcrafted", new Guid("b4d1080b-1c38-4480-a325-0919e3f0238d"), "Awesome Metal Ball", 785.60m, (short)5745 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1906), "Incredible", new Guid("b7335755-dd50-43d8-9e21-cce767563524"), "Rustic Steel Keyboard", 93.00m, (short)4664 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1922), new Guid("9c51bd65-c11a-4cbe-96eb-12a824323dad"), "Refined Steel Salad", 24.99m, (short)2131 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1940), "Handcrafted", new Guid("0dc3598a-1f33-4858-a454-5428d5da0486"), "Sleek Cotton Computer", 973.59m, (short)3173 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1957), "Practical", new Guid("2aed93ad-921d-452a-894e-a05d15976f70"), "Fantastic Granite Keyboard", 269.75m, (short)9783 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1974), "Unbranded", new Guid("fbfe24cc-5fa7-4154-bd8d-f21368766c4e"), "Generic Plastic Chair", 127.87m, (short)8041 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1990), "Intelligent", new Guid("713f1613-2519-469a-afa5-baf9e711a984"), "Handcrafted Wooden Chair", 596.44m, (short)1482 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(2007), "Sleek", new Guid("6b41648a-1d30-4a9d-814b-59230c4ec8f6"), "Rustic Fresh Soap", 882.83m, (short)6286 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(2023), "Refined", new Guid("27f57eeb-dfe8-4444-9a00-065a37e04a7f"), "Sleek Granite Shoes", 18.97m, (short)478 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(2040), "Small", new Guid("6ff0354a-769d-4f4e-88fe-4e38582d21fc"), "Licensed Soft Shoes", 169.63m, (short)6231 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(2075), "Gorgeous", new Guid("bb190316-0ce2-4168-ad32-4219cc2ec3c8"), "Small Concrete Cheese", 131.26m, (short)9916 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(2094), "Handcrafted", new Guid("71b351c7-51aa-4696-a2a3-685ca46f4454"), "Awesome Metal Ball", 652.92m, (short)7354 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(2111), "Practical", new Guid("cead07df-48a3-41e1-b487-68c55b3a5d3a"), "Sleek Concrete Towels", 822.16m, (short)6452 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(2127), "Awesome", new Guid("e466a062-5b14-4fa8-b200-a7fd93972107"), "Fantastic Metal Fish", 735.47m, (short)4880 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(2143), "Awesome", new Guid("5b21d299-b4a6-460e-b83c-fd1ab4fee2f6"), "Incredible Soft Pants", 87.18m, (short)2803 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(2159), "Handcrafted", new Guid("1bdd5024-483b-4ed4-9bc4-1236d01cdad2"), "Small Soft Ball", 366.46m, (short)612 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(2175), "Licensed", new Guid("282e4142-ac5d-4354-8ae8-c91369b9794b"), "Licensed Fresh Cheese", 730.87m, (short)8558 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(2192), "Generic", new Guid("41ebce6e-8352-45ca-8204-0ce3c63d517b"), "Rustic Frozen Sausages", 384.42m, (short)6586 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(2208), "Practical", new Guid("4178ea2b-862f-4ed6-aaa4-8801c7750194"), "Intelligent Rubber Computer", 678.82m, (short)2295 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(2226), "Gorgeous", new Guid("24db758c-a108-4525-96e9-012a8661fc24"), "Awesome Frozen Chips", 24.80m, (short)7880 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(2261), "Rustic", new Guid("eba0ef50-6f73-420d-8635-4d091f13e7cf"), "Tasty Wooden Pants", 385.80m, (short)7104 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(2280), "Unbranded", new Guid("b5b92ae2-94f3-4a04-887e-af207e329911"), "Ergonomic Fresh Pants", 245.65m, (short)6836 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(2297), "Handmade", new Guid("963c63ac-c3c4-4a3f-93a5-fc0a789127d5"), "Gorgeous Granite Chair", 759.05m, (short)1584 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(2313), "Awesome", new Guid("68002253-94bc-4fd1-9d9e-34a4f75ae3d9"), "Small Frozen Chips", 787.59m, (short)8158 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(2329), "Refined", new Guid("460bf6c8-3a05-42e3-a92d-829fb123737c"), "Intelligent Cotton Chair", 606.87m, (short)910 });
        }
    }
}
