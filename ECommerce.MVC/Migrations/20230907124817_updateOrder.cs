using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.MVC.Migrations
{
    /// <inheritdoc />
    public partial class updateOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_UserId1",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UserId1",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6423), "Intelligent", new Guid("4fd752b2-06b5-4ac0-881c-51aa0622d27e"), "Practical Fresh Soap", 384.38m, (short)2550 });

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
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6491), new Guid("726013a1-64e8-44ff-a8e5-7a3d1a9e6072"), "Fantastic Plastic Chicken", 137.24m, (short)3559 });

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
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(6931), "Fantastic", new Guid("26a98c33-7023-4c62-bd28-a6f27a7e8032"), "Fantastic Concrete Tuna", 351.60m, (short)3553 });

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
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7207), "Generic", new Guid("86b6893c-c9a4-4b5f-b640-f0e63aeeec64"), "Unbranded Steel Chicken", 492.79m, (short)9250 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7223), "Ergonomic", new Guid("b561ff4f-0774-43c4-ad12-bde37885d69e"), "Small Soft Computer", 587.18m, (short)4326 });

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
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7472), new Guid("783b4643-6aaf-49c5-93fb-ea0371ae4e0b"), "Gorgeous Steel Bacon", 946.03m, (short)5684 });

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
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7772), new Guid("2a83a538-5647-4244-99d1-aa7e62f26af3"), "Handmade Frozen Tuna", 793.93m, (short)5283 });

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
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7849), "Sleek", new Guid("8f9f96e8-bded-4847-a00e-9c4821188466"), "Practical Frozen Ball", 368.46m, (short)3442 });

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
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 48, 17, 313, DateTimeKind.Local).AddTicks(7993), "Generic", new Guid("13ef246b-2cf9-42a6-8dbe-10f60513588f"), "Incredible Concrete Bike", 828.87m, (short)8737 });

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

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_UserId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UserId",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true);

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
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(5123), "Handcrafted", new Guid("33c87958-1531-4b96-9ae9-f0b3080b3c66"), "Intelligent Steel Gloves", 790.51m, (short)1895 });

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
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(5374), "Refined", new Guid("8c325ab4-7ee3-488b-8913-cc9d2e46209f"), "Intelligent Soft Keyboard", 908.26m, (short)2835 });

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
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(5506), new Guid("edff0d10-d455-4f77-a0a0-9a587b8ff3f6"), "Tasty Fresh Mouse", 793.24m, (short)2971 });

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
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(5818), "Awesome", new Guid("419a605a-9206-4cc4-8fe1-fb40f6c32666"), "Awesome Steel Towels", 833.42m, (short)5755 });

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
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6330), "Unbranded", new Guid("5076374b-6cdf-46c0-b1e1-810170e84047"), "Incredible Steel Towels", 949.02m, (short)5677 });

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
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6652), new Guid("ea7ebc3c-be8c-4859-b72d-a81d8d8a4ce0"), "Practical Plastic Cheese", 57.29m, (short)6656 });

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
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6957), new Guid("7dee53cd-1ffd-4f3b-a3ca-1e0ac775b994"), "Rustic Rubber Pizza", 76.24m, (short)5070 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 15, 40, 33, 69, DateTimeKind.Local).AddTicks(6981), "Gorgeous", new Guid("50377353-fafc-4c21-9f67-7ce152e594ee"), "Practical Soft Sausages", 131.28m, (short)8429 });

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
                name: "IX_Orders_UserId1",
                table: "Orders",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_UserId1",
                table: "Orders",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
