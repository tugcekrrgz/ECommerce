using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.MVC.Migrations
{
    /// <inheritdoc />
    public partial class updateShipperStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterID" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(6701), new Guid("1c3cda6e-d0a0-4c56-bc01-27ca4416793c") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Music", new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(6777), "Music description.", new Guid("efe9e119-d778-42a7-98b3-3a017ad3f33e") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Tools", new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(6779), "Tools description.", new Guid("ee6717be-a83d-4dc0-8b32-0a578fb8f9b7") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Jewelery", new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(6781), "Jewelery description.", new Guid("6cc79c1a-6d7c-4e5b-bc81-15d9681f3f37") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Industrial", new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(6791), "Industrial description.", new Guid("91cfbc8c-efb2-4b1f-bad1-0d4f3e395e07") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Music", new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(6794), "Music description.", new Guid("6f2c35ba-ce9c-4d14-bead-deff66802c31") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Automotive", new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(6797), "Automotive description.", new Guid("a92bd6dd-2802-4dac-8e80-038d2dcac370") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Toys", new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(6799), "Toys description.", new Guid("44152fc6-6bbb-474e-89c5-a60c2868c424") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Shoes", new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(6801), "Shoes description.", new Guid("8a0ead7c-baa1-4c01-980b-7b1cbcccf413") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Shoes", new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(6803), "Shoes description.", new Guid("96974e2b-c02d-475e-905b-bfadf002adc4") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(7457), new Guid("a3d0c66d-5d57-4a4a-ba19-ec8751ac7a8c"), "Intelligent Cotton Bike", 516.51m, (short)1092 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(7586), "Unbranded", new Guid("fa44ad73-4a48-46fe-8745-e578a0e15e40"), "Handmade Fresh Hat", 668.98m, (short)9658 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(7608), "Handmade", new Guid("c1a52d38-30ec-42ba-bc38-54ed9505f82b"), "Tasty Frozen Bacon", 824.85m, (short)4270 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(7624), "Awesome", new Guid("ccd50f3b-1a66-463b-8795-c6bd3ffd61eb"), "Generic Frozen Pants", 25.32m, (short)9511 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(7640), "Intelligent", new Guid("ff9f3b8c-31db-43c7-91f9-39d0b7c986b5"), "Gorgeous Frozen Shoes", 7.85m, (short)8581 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(7656), "Generic", new Guid("f9407369-5657-4883-b8f4-debbf43463c9"), "Awesome Soft Gloves", 101.47m, (short)3377 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(7698), "Unbranded", new Guid("d1c8adf0-d4d9-4d1d-b5fa-aed486f85d37"), "Awesome Fresh Computer", 404.63m, (short)9110 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(7713), "Handcrafted", new Guid("c2460c37-5002-4725-9651-49e99493dffa"), "Awesome Rubber Pizza", 317.07m, (short)1887 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(7729), "Incredible", new Guid("408cd631-e989-4c59-bdb8-3cdf4502b935"), "Practical Cotton Computer", 178.51m, (short)6957 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(7745), "Generic", new Guid("28be5b7b-19d1-4da0-82c2-2bc24e0c2da7"), "Sleek Soft Pants", 514.03m, (short)4830 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(7759), new Guid("620a0cc6-9ee4-483b-a2a9-3700f5b94e0f"), "Tasty Frozen Car", 511.75m, (short)7506 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(7773), "Intelligent", new Guid("469a0d62-11b4-46ae-9135-bad1697ffe88"), "Intelligent Fresh Tuna", 34.34m, (short)4483 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(7789), "Handmade", new Guid("29e3b93d-fde3-4a9f-ad43-23b34c6011fa"), "Intelligent Fresh Bike", 886.69m, (short)9232 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(7803), "Licensed", new Guid("cb347e25-6a93-4855-830e-5306ee83268a"), "Tasty Fresh Gloves", 7.26m, (short)3484 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(7816), "Generic", new Guid("c427ea5f-0410-4748-a673-5aa2ee260753"), "Gorgeous Steel Car", 484.06m, (short)5302 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(7828), "Incredible", new Guid("2b09b105-991c-463f-95fa-32492cd05759"), "Generic Granite Table", 149.92m, (short)4927 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(7888), "Unbranded", new Guid("1b2a2a60-3d8a-40fe-bb19-6a528a40ef35"), "Practical Wooden Soap", 720.93m, (short)3995 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(7903), "Fantastic", new Guid("aee4730f-9cd8-4767-aaeb-5c2aea7e7e15"), "Generic Fresh Cheese", 405.78m, (short)2074 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(7920), "Handcrafted", new Guid("074b8a09-f4be-41ef-8a08-ad2cc4a1de45"), "Incredible Steel Chips", 409.88m, (short)7201 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(7936), "Fantastic", new Guid("f2c3d53b-03a3-48ff-ad1b-9fb6b4bb2dde"), "Intelligent Wooden Pants", 765.14m, (short)3493 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(7949), "Rustic", new Guid("9ecfe872-6105-43d0-812e-2fc7ed0ce6a4"), "Ergonomic Cotton Sausages", 104.11m, (short)9969 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(7963), "Small", new Guid("02cb5869-9cff-40b1-9df9-e7f53f226176"), "Refined Soft Bike", 161.77m, (short)2925 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(7975), "Awesome", new Guid("8e40ad1a-ef05-435e-a829-32ca4c819973"), "Refined Steel Shirt", 13.51m, (short)9936 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(7988), "Intelligent", new Guid("00e6ef27-813e-4775-bf57-cc619ef0c13c"), "Licensed Concrete Towels", 740.42m, (short)9407 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8001), "Ergonomic", new Guid("3244baf2-fd53-4405-8c4a-05e4d7333576"), "Fantastic Fresh Pants", 145.97m, (short)596 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8037), new Guid("76a2765c-e449-44fc-9035-5e76f0f7f6a1"), "Rustic Steel Pants", 158.36m, (short)9592 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8052), "Sleek", new Guid("783bc916-680b-4ef3-8b41-e947e3bc0bec"), "Small Plastic Chair", 679.37m, (short)402 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8066), "Unbranded", new Guid("185dc509-37b1-47c8-96b9-2d4248de835e"), "Practical Rubber Car", 875.57m, (short)4312 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8079), "Handmade", new Guid("df4f6869-89de-4533-9cd2-97da292ab11c"), "Licensed Rubber Ball", 967.40m, (short)5910 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8092), "Incredible", new Guid("44607735-3ab5-46f6-8c0a-e7d64a253821"), "Tasty Frozen Bike", 175.58m, (short)6678 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8105), "Sleek", new Guid("2d6870f4-027d-463d-99db-6383a8c1a764"), "Fantastic Wooden Bacon", 828.23m, (short)5120 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8117), "Handcrafted", new Guid("50890949-ecea-41cc-91a3-a0d25ae21aff"), "Gorgeous Cotton Car", 794.22m, (short)1358 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8130), "Licensed", new Guid("05191ef1-1859-4e0c-8799-1f94d0daff5c"), "Awesome Soft Chips", 225.47m, (short)9608 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8143), "Sleek", new Guid("13854ae0-c434-4f61-9c90-5d06262e9900"), "Ergonomic Steel Fish", 688.36m, (short)1549 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8157), "Rustic", new Guid("0d9ade41-53ae-4322-b4f5-589ef244adf6"), "Practical Cotton Chips", 528.34m, (short)9622 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8196), "Ergonomic", new Guid("1adf2ab6-9677-4cb7-a03c-f323a432c21c"), "Rustic Wooden Bacon", 923.06m, (short)6018 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8209), "Practical", new Guid("adf50f7f-cf4a-428b-b65e-31d9377fb175"), "Unbranded Metal Pants", 238.53m, (short)6432 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8222), "Generic", new Guid("c8d9ec62-ce3b-4c68-b3d2-28e97bf13f12"), "Gorgeous Steel Shoes", 530.88m, (short)195 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8234), "Incredible", new Guid("eb90cd13-75d9-462e-b23f-90d83dbfcce9"), "Handcrafted Wooden Sausages", 649.85m, (short)553 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8248), "Ergonomic", new Guid("f0fa112e-29ee-4632-a73a-6bbfd8112af8"), "Tasty Frozen Bacon", 962.61m, (short)7535 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8262), "Tasty", new Guid("c00b82fa-c0e7-4af5-a271-538577bf208f"), "Intelligent Cotton Shoes", 620.61m, (short)8150 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8275), "Gorgeous", new Guid("47bf97c1-4d4c-41eb-95f4-cbf36fe2545c"), "Intelligent Concrete Mouse", 634.55m, (short)5846 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8289), "Licensed", new Guid("6864e013-981f-46c8-8b61-9c38fc015790"), "Handmade Steel Hat", 714.32m, (short)9128 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8301), "Generic", new Guid("c5122bf9-b7ce-42b9-b47f-e1a51359f02e"), "Fantastic Cotton Shoes", 402.63m, (short)7618 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8339), "Awesome", new Guid("2bea3740-4e33-44cd-9902-28a8fa959173"), "Ergonomic Metal Chair", 401.02m, (short)3420 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8353), "Handcrafted", new Guid("00d62444-097f-40cc-baa7-e571e0d6053d"), "Handcrafted Fresh Table", 786.24m, (short)8850 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8365), "Intelligent", new Guid("655b0c40-7acc-48aa-800f-c87b6d0662a1"), "Handcrafted Cotton Shirt", 904.83m, (short)6518 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8378), "Unbranded", new Guid("40d233c3-adbf-4052-9553-3133a7f8af8c"), "Unbranded Wooden Pizza", 625.84m, (short)2276 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8390), "Ergonomic", new Guid("6e42bd71-e09d-4bc0-a02b-50c69d0fdca0"), "Practical Plastic Keyboard", 710.20m, (short)873 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8403), "Licensed", new Guid("70cc64b9-b13f-4670-a6c4-3bb443b91426"), "Awesome Rubber Towels", 419.87m, (short)7883 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8418), "Sleek", new Guid("f8c2d84f-67d7-4d71-b48b-7e6aa5cdd195"), "Intelligent Rubber Fish", 465.72m, (short)242 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8429), "Licensed", new Guid("dab97a10-62e4-4252-8379-087ed932dfae"), "Refined Plastic Towels", 654.78m, (short)4932 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8442), "Fantastic", new Guid("77c21509-afa7-47b5-abb9-6ced341e504e"), "Unbranded Granite Chips", 84.48m, (short)8894 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8455), "Incredible", new Guid("cb9c0408-79d6-4bd6-b764-e7a8f176f2e3"), "Small Rubber Hat", 428.51m, (short)8242 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8493), "Fantastic", new Guid("bf89c2f6-b2a7-400c-a79c-baaaccbf1043"), "Intelligent Granite Fish", 927.01m, (short)1979 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8508), "Rustic", new Guid("b0bea02a-824a-4496-9c09-cf43eeb1d758"), "Practical Soft Shirt", 808.33m, (short)4862 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8521), "Intelligent", new Guid("82099504-dbf2-49ba-985f-c634f2d3b5cc"), "Intelligent Steel Fish", 494.52m, (short)9241 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8534), "Refined", new Guid("5c76248f-511c-4c4a-8295-21352b956406"), "Incredible Metal Soap", 578.95m, (short)5837 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8548), "Rustic", new Guid("b4420716-3fd7-44f1-9e92-db9a5cb28503"), "Licensed Steel Table", 781.62m, (short)8699 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8561), "Rustic", new Guid("dd7a5c9b-7b49-45c4-8e8e-7f374aea2a01"), "Intelligent Wooden Bacon", 502.47m, (short)6679 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8573), "Refined", new Guid("c4ea97da-b204-420f-85e6-f2377f1856f3"), "Refined Granite Car", 332.03m, (short)2184 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8587), "Handmade", new Guid("ee4f8b36-9f2a-466c-9d72-68caa3b72bde"), "Awesome Plastic Bike", 401.67m, (short)3546 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8599), "Unbranded", new Guid("d4cef553-83f0-42b9-88c6-bae80255afe9"), "Handmade Rubber Salad", 611.40m, (short)5757 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8612), new Guid("effbebf5-cc56-40cd-a604-1b0897d195ca"), "Generic Rubber Tuna", 390.16m, (short)6920 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8652), "Sleek", new Guid("306d9029-955e-4a8c-9662-b88c7823c7f2"), "Ergonomic Granite Mouse", 204.95m, (short)9083 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8666), "Practical", new Guid("068a2ba3-cdf3-4203-9743-b2770199b4b9"), "Refined Frozen Shoes", 896.44m, (short)7180 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8680), "Handmade", new Guid("498a90cc-b691-416a-91ff-278f2e16bdec"), "Sleek Cotton Cheese", 609.70m, (short)944 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8692), "Fantastic", new Guid("d19b5c20-f686-48a4-9e02-bc9a679a345c"), "Incredible Fresh Pants", 520.86m, (short)1864 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8705), "Refined", new Guid("09a8665d-5365-4092-bf1e-d2a31f00bd3c"), "Handmade Rubber Chips", 197.11m, (short)9832 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8717), "Small", new Guid("a297c2bc-10dc-4f8a-85de-b075b8f4f4a2"), "Tasty Metal Sausages", 200.93m, (short)7007 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8731), "Ergonomic", new Guid("31fa2630-72a5-48be-905d-155cc59bd1ee"), "Licensed Rubber Bacon", 664.36m, (short)4516 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8743), "Handmade", new Guid("af718ce3-7a2b-44c7-a2d7-e5e99d496cb6"), "Licensed Soft Car", 142.50m, (short)6614 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8755), "Generic", new Guid("0e7c85cd-bc1a-45c3-bddb-7dae10c93308"), "Incredible Steel Sausages", 206.02m, (short)8472 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8795), "Awesome", new Guid("5e3efc10-1c3c-4d0c-87f2-c0b79f18d433"), "Practical Granite Hat", 654.95m, (short)5718 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8809), "Generic", new Guid("6b426c61-32a9-4f46-83b9-39a6b2bfaa7d"), "Practical Concrete Fish", 491.42m, (short)8500 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8822), "Handcrafted", new Guid("8471ff28-98b9-46d9-8348-8fb101e45542"), "Incredible Fresh Table", 138.92m, (short)4000 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8835), "Licensed", new Guid("98c92576-45ab-46d9-acd1-df27ddd7c651"), "Tasty Cotton Ball", 76.02m, (short)9667 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8848), "Licensed", new Guid("81c08928-1481-471b-9c13-4cc765ef8cfc"), "Rustic Fresh Hat", 387.55m, (short)4648 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8860), "Refined", new Guid("55bfbaf5-8a86-4f21-b231-5460498cdd28"), "Tasty Steel Towels", 318.68m, (short)4981 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8872), "Incredible", new Guid("f4b4e2a5-0f80-4d1c-9198-05f8315aa89b"), "Tasty Cotton Cheese", 925.14m, (short)6399 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8884), "Sleek", new Guid("71bfc792-6669-4d3e-98be-13dab7f9572d"), "Intelligent Soft Mouse", 3.32m, (short)849 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8896), "Fantastic", new Guid("ceb2be6c-bf65-4f99-9b25-b414432105d0"), "Fantastic Fresh Tuna", 894.69m, (short)7253 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8910), "Sleek", new Guid("34d5c43b-115c-44b4-b057-36458957d83d"), "Ergonomic Cotton Car", 232.76m, (short)5699 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8950), "Handcrafted", new Guid("803efc8b-9084-4536-b083-700afd90ba66"), "Gorgeous Plastic Hat", 954.16m, (short)1108 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8963), "Rustic", new Guid("cdf48756-c158-452c-a39f-36761c5e9f79"), "Unbranded Rubber Chicken", 821.06m, (short)9821 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8977), "Refined", new Guid("c3c2fe95-ff6b-462c-a427-13062fb5974a"), "Licensed Frozen Pizza", 73.84m, (short)721 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(8989), "Unbranded", new Guid("8d505129-abee-4fe1-95d7-0189560fc421"), "Sleek Metal Soap", 719.05m, (short)8262 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(9003), "Awesome", new Guid("b902bf37-ee3a-414f-be56-334b83b19ac7"), "Refined Concrete Cheese", 328.37m, (short)790 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(9015), new Guid("74b138e3-417d-4642-b4e8-3e93c8c079da"), "Tasty Plastic Gloves", 937.52m, (short)8299 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(9028), "Incredible", new Guid("9f8eb670-76cf-4074-9f1a-7b1ff9588fb6"), "Handcrafted Soft Pizza", 46.43m, (short)4899 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(9043), "Awesome", new Guid("0cf3ecde-138b-4b51-97b9-c8d3a01ca5e2"), "Small Steel Shirt", 348.11m, (short)5393 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(9055), "Generic", new Guid("5b694e3a-2c0d-484c-9719-e1888550e364"), "Handcrafted Fresh Shirt", 628.42m, (short)9392 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(9067), "Rustic", new Guid("861e2221-9c48-46b5-a9a6-1493d00317b9"), "Sleek Rubber Chicken", 53.62m, (short)6766 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(9115), "Handcrafted", new Guid("d3621945-d1d2-44b8-9cc5-fb0038914404"), "Intelligent Wooden Pants", 988.20m, (short)2253 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(9128), "Fantastic", new Guid("ee89c3ae-fc5e-4fb2-af79-16f415d00830"), "Refined Steel Bacon", 658.61m, (short)9893 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(9141), "Handmade", new Guid("8307f965-d3b7-46ac-a80a-bcb6a6ff6f2b"), "Tasty Granite Chair", 999.56m, (short)1132 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(9155), new Guid("bf62ece6-a322-4cfd-a8e1-84656463b317"), "Awesome Granite Car", 456.95m, (short)7578 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(9168), "Intelligent", new Guid("d87f87d3-d9a3-4f1e-b4ba-255bc61fab18"), "Tasty Rubber Soap", 480.33m, (short)7268 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(9183), "Tasty", new Guid("1c14874d-1d23-43d6-9d48-a72c428f5276"), "Rustic Steel Towels", 247.30m, (short)9170 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 551, DateTimeKind.Local).AddTicks(9196), "Awesome", new Guid("0f62f81a-237a-4ee0-a7e6-a5a703a1655e"), "Sleek Soft Bacon", 883.45m, (short)2567 });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterID" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 549, DateTimeKind.Local).AddTicks(2222), new Guid("417ec3cb-b446-4faa-8a80-f21d0f8c7926") });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterID" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 549, DateTimeKind.Local).AddTicks(2352), new Guid("4a0d0c89-6cf8-4334-8104-f9890d27703c") });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterID" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 549, DateTimeKind.Local).AddTicks(2357), new Guid("9a31941d-e7cf-4004-8451-2775eb177577") });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "MasterID" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 549, DateTimeKind.Local).AddTicks(2360), new Guid("ced33641-0264-4983-8ab7-64cbce4ba519") });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "MasterID" },
                values: new object[] { new DateTime(2023, 9, 11, 23, 57, 31, 549, DateTimeKind.Local).AddTicks(2362), new Guid("1b3edac1-4be9-4dec-8021-e5801d5e9c37") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterID" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(7569), new Guid("aee5b4a1-14e5-4cc8-be14-fdb650cdcdf4") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Clothing", new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(7627), "Clothing description.", new Guid("b78f000c-5ae7-486c-a28e-b0400ca318e4") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Kids", new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(7630), "Kids description.", new Guid("7bc41e1e-a8c3-4fd5-8ac4-e1630b0a84f9") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Health", new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(7632), "Health description.", new Guid("edbcb465-77f8-43c4-9339-f67e17266a7e") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Movies", new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(7646), "Movies description.", new Guid("5d03049d-6930-4184-b557-8412428c7625") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Electronics", new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(7650), "Electronics description.", new Guid("19076eda-804a-4b1f-bc88-c8ed5713402b") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Tools", new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(7653), "Tools description.", new Guid("bb0fdf11-0ece-488f-adf6-cd7969e1b3bc") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Sports", new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(7655), "Sports description.", new Guid("274e4274-9c81-4cca-9563-e98c52a3fe51") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Automotive", new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(7657), "Automotive description.", new Guid("6e1bc83c-d51f-4c80-82f9-5d2176d1bb2f") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Automotive", new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(7661), "Automotive description.", new Guid("52b66426-8846-404b-b87c-ffdcf07772b4") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(7795), new Guid("fc44cd5c-9339-48d2-bb29-dcb6a6ffc44a"), "Fantastic Steel Chicken", 325.10m, (short)4789 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(7922), "Sleek", new Guid("225c5c86-0819-494c-8ce1-2588387c6848"), "Intelligent Concrete Fish", 37.54m, (short)6545 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(7945), "Tasty", new Guid("62d3e9e0-38aa-4b2d-80a8-0d1b1e609084"), "Unbranded Frozen Chair", 683.79m, (short)7976 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(7963), "Intelligent", new Guid("f96828aa-8f20-4b98-95cf-db48be6e14de"), "Sleek Granite Ball", 850.86m, (short)2642 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8025), "Gorgeous", new Guid("cbddc82e-2e55-4999-a9bd-0e773a286e73"), "Handcrafted Cotton Computer", 534.94m, (short)1887 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8046), "Licensed", new Guid("fba7e1be-42a0-4153-b2f2-2d5b3a51a29f"), "Unbranded Steel Sausages", 637.19m, (short)5270 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8063), "Refined", new Guid("e1faddb4-3cbe-444d-8408-e0b7ae6136e0"), "Awesome Frozen Ball", 82.54m, (short)1575 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8078), "Tasty", new Guid("22ec4c3e-b4a9-4c47-a970-38a07911aa5b"), "Ergonomic Fresh Chicken", 296.42m, (short)7002 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8094), "Awesome", new Guid("9f406ca4-28c8-4086-b51d-3c3da1605aa8"), "Practical Metal Car", 559.12m, (short)4267 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8110), "Rustic", new Guid("0bc49869-a609-4613-b576-ee37a03a1805"), "Fantastic Granite Chicken", 205.10m, (short)6932 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8127), new Guid("c052d729-5eb0-4556-8012-484cd22c3a6c"), "Handcrafted Frozen Bike", 528.96m, (short)9939 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8143), "Generic", new Guid("60268891-6012-4586-822e-ce97fc640a3c"), "Tasty Soft Hat", 158.14m, (short)1872 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8159), "Practical", new Guid("5289fa38-4272-413a-9b32-6adbd165e860"), "Rustic Concrete Chips", 431.62m, (short)2925 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8173), "Practical", new Guid("19fa2baa-26f0-4c15-9e60-9d2fab038522"), "Practical Granite Pizza", 273.65m, (short)6203 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8230), "Licensed", new Guid("8467e99d-1df6-4b44-a249-5704bca57365"), "Small Rubber Chicken", 867.28m, (short)7753 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8244), "Unbranded", new Guid("feb47d15-3a9e-424a-b39e-821ed6e74111"), "Handmade Fresh Cheese", 984.40m, (short)150 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8260), "Awesome", new Guid("7d4e31cf-833d-4ced-a079-2612be6f9a59"), "Handmade Cotton Keyboard", 822.52m, (short)919 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8276), "Tasty", new Guid("dade3ea5-866e-42e8-8eda-e40cb6d37117"), "Practical Fresh Car", 2.19m, (short)1495 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8294), "Licensed", new Guid("61ef4e10-ecbc-4dce-ae31-32ea0543d28e"), "Licensed Metal Chips", 459.90m, (short)8454 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8309), "Generic", new Guid("5e2ede34-7c63-42f9-98ae-6371096dfcb2"), "Sleek Wooden Salad", 906.26m, (short)9658 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8324), "Small", new Guid("f7ee9332-ce2f-4e89-bdc0-13582dcd8356"), "Ergonomic Metal Car", 185.03m, (short)6636 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8339), "Ergonomic", new Guid("884f0a6c-4256-4b14-8a53-04f0dc6e5194"), "Refined Rubber Bacon", 36.44m, (short)9144 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8355), "Licensed", new Guid("f4c8159f-3bf0-46ff-b0d2-b553d9c17d4c"), "Practical Metal Bike", 808.48m, (short)9702 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8428), "Fantastic", new Guid("8985463c-d0f7-4181-ba8a-54492375df83"), "Handmade Cotton Cheese", 494.68m, (short)792 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8444), "Licensed", new Guid("e1aef3bd-67b4-41dc-a5d7-8d566adb8c26"), "Ergonomic Concrete Shoes", 604.43m, (short)2386 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8460), new Guid("9b052116-6fe8-4a5c-97f7-667d0f9bf7bf"), "Handcrafted Fresh Chips", 137.39m, (short)2142 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8476), "Rustic", new Guid("67b44ed1-4390-4353-a650-e77e35de958c"), "Licensed Steel Car", 976.89m, (short)6169 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8491), "Practical", new Guid("3bfba40f-ba51-444c-a921-043a048c50ad"), "Refined Steel Ball", 960.47m, (short)8300 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8505), "Small", new Guid("43216f2b-7fa0-4d45-9bee-cf0499132f58"), "Unbranded Rubber Ball", 995.38m, (short)1302 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8520), "Handcrafted", new Guid("1f2ac748-8e0d-41e1-ab78-bb39dcbc97d0"), "Handcrafted Metal Shirt", 33.38m, (short)6503 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8534), "Incredible", new Guid("68d9a023-de6d-4072-88e7-8ab9c1c0bc95"), "Fantastic Soft Bacon", 283.32m, (short)7599 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8548), "Handmade", new Guid("86617e75-d4c5-431c-80e3-0c1c4234ffa6"), "Licensed Soft Pants", 424.14m, (short)432 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8562), "Practical", new Guid("9129c58c-0cef-4c10-bf9b-f190987eb533"), "Handcrafted Fresh Gloves", 324.56m, (short)4426 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8598), "Incredible", new Guid("dca933a7-c5d4-4efa-ab78-0ef1aff25368"), "Handmade Concrete Pizza", 738.79m, (short)8617 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8617), "Fantastic", new Guid("663fc9aa-5529-4f9a-89d8-53fdced454cc"), "Tasty Concrete Pants", 705.88m, (short)6476 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8631), "Generic", new Guid("45fa3708-fef8-4195-8566-6f518cb1f13b"), "Fantastic Frozen Fish", 708.82m, (short)8112 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8646), "Refined", new Guid("e8955422-e101-46be-b804-aba30c04bc50"), "Handcrafted Granite Pants", 970.30m, (short)6191 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8660), "Sleek", new Guid("06701953-760b-4186-842a-e50ca6478ebe"), "Small Rubber Tuna", 661.67m, (short)6708 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8675), "Practical", new Guid("49d3045d-5df8-402c-8f01-0b8ad1ed219f"), "Unbranded Concrete Shirt", 677.18m, (short)9063 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8689), "Practical", new Guid("776bb0a3-5b3d-4550-8082-740cdac1fab4"), "Rustic Granite Fish", 14.81m, (short)5147 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8704), "Sleek", new Guid("26c53a18-c2c2-494e-9faa-40dfabb3646a"), "Gorgeous Frozen Keyboard", 684.41m, (short)9621 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8719), "Licensed", new Guid("d61c2079-6247-4f86-a1d7-7c857c550b08"), "Small Cotton Table", 36.43m, (short)4558 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8738), "Unbranded", new Guid("f4389c7f-e100-481b-afeb-e7ae22c89389"), "Rustic Steel Salad", 722.36m, (short)3858 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8775), "Handcrafted", new Guid("e12ada84-5fb1-43d3-ba10-159bed5982d0"), "Sleek Soft Tuna", 821.35m, (short)5523 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8790), "Unbranded", new Guid("72486292-0619-443d-ba97-f348450bff72"), "Refined Rubber Towels", 910.63m, (short)572 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8805), "Fantastic", new Guid("1f288992-5ec6-440b-b5cd-38c9395d4cba"), "Awesome Granite Ball", 351.18m, (short)8563 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8819), "Rustic", new Guid("22d11013-32d5-4fd8-95ab-6acd12be9aa5"), "Refined Metal Shirt", 938.25m, (short)989 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8833), "Gorgeous", new Guid("1ddd1c88-8d8a-4ddd-9c6b-363c184ff951"), "Fantastic Metal Soap", 596.99m, (short)8387 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8849), "Tasty", new Guid("70146754-7997-4ce6-98fd-a497c32eb0fc"), "Ergonomic Plastic Tuna", 220.31m, (short)6791 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8863), "Tasty", new Guid("76271fe3-5bd4-4967-ba99-2b13a2d2771e"), "Refined Rubber Car", 417.56m, (short)3421 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8879), "Generic", new Guid("65e271ba-8d43-49bb-8fa5-b78fae621fff"), "Handmade Granite Pizza", 27.17m, (short)5370 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8893), "Awesome", new Guid("2977d9dc-11f7-41bb-8e88-363f978c9e6e"), "Handcrafted Plastic Cheese", 475.95m, (short)1364 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8928), "Sleek", new Guid("6930b7a6-497b-455c-8ed9-8bf2e66da35a"), "Fantastic Steel Tuna", 605.56m, (short)9598 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8944), "Gorgeous", new Guid("4373b015-339c-4012-9cf1-c3d1d533efbb"), "Sleek Soft Shirt", 454.61m, (short)7509 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8958), "Ergonomic", new Guid("7c14be54-c099-4124-b5c6-71a7f1f6fbbe"), "Practical Granite Chair", 594.04m, (short)987 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8971), "Refined", new Guid("ebc2240d-c5fd-4860-990a-9e3c07e44b82"), "Practical Steel Shoes", 33.81m, (short)5420 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8985), "Practical", new Guid("2f670ba8-d979-4224-b8fe-2366bdd11fd7"), "Rustic Fresh Keyboard", 220.74m, (short)2610 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8999), "Rustic", new Guid("426e74d3-fde5-4ad3-9a98-10e1c21cc329"), "Sleek Metal Hat", 463.21m, (short)3946 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9015), "Gorgeous", new Guid("8d5a52bc-1ce9-4f99-92b1-aaa4f85662bf"), "Unbranded Concrete Mouse", 538.20m, (short)3037 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9031), "Small", new Guid("9d7554f3-179f-457e-8c41-6e3051151916"), "Practical Cotton Bike", 165.73m, (short)3139 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9045), "Intelligent", new Guid("7fc10a26-b083-45a3-bee6-fc6d7956dce1"), "Unbranded Granite Keyboard", 304.57m, (short)3683 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9060), "Unbranded", new Guid("06b0df42-01c6-43f8-997b-c3520eececdd"), "Unbranded Metal Chips", 748.21m, (short)7666 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9100), "Refined", new Guid("c7f66258-b575-4b57-9ece-07309293f259"), "Generic Fresh Bike", 146.78m, (short)8361 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9115), new Guid("8da9b0a8-259f-4c18-9462-5b69c6241f82"), "Handcrafted Concrete Table", 74.63m, (short)9334 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9130), "Handcrafted", new Guid("e6e00385-da6b-4e8d-a20f-691787e691d9"), "Fantastic Steel Shoes", 445.03m, (short)819 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9146), "Handmade", new Guid("1e9e39ea-7d67-4bf1-b9e7-19407b984b80"), "Small Cotton Chips", 85.67m, (short)2768 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9162), "Gorgeous", new Guid("4e52e79e-011f-48ac-ae33-61a143807545"), "Handcrafted Steel Bike", 877.27m, (short)2609 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9176), "Generic", new Guid("42de149a-7e48-47ab-9178-21a9975e3885"), "Fantastic Granite Tuna", 945.92m, (short)6780 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9190), "Practical", new Guid("5cad4e25-cecd-4ffc-b1af-e8c43612ab42"), "Tasty Concrete Car", 813.95m, (short)2019 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9205), "Rustic", new Guid("e390b7ff-35ff-413b-8bc6-7285e9a1a209"), "Generic Plastic Tuna", 806.97m, (short)6504 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9219), "Tasty", new Guid("e2137826-6616-4b7d-ae6f-6f03edd21189"), "Awesome Soft Mouse", 529.27m, (short)4135 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9256), "Practical", new Guid("100b76b3-51d1-4f2c-9ccf-4094bea87e56"), "Rustic Plastic Fish", 554.99m, (short)5905 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9271), "Fantastic", new Guid("28825c82-2129-4448-8851-1fd75cf61b2a"), "Rustic Steel Ball", 856.09m, (short)7884 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9285), "Gorgeous", new Guid("62af8360-b369-45ea-9f6a-7e1798a55a98"), "Practical Steel Salad", 97.14m, (short)2259 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9302), "Awesome", new Guid("b1c974f5-a1eb-4bed-9e79-3f34202b10b9"), "Practical Concrete Shirt", 780.23m, (short)1857 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9316), "Small", new Guid("d1a43480-30f1-4019-b988-5f7094b6643e"), "Practical Fresh Shoes", 383.81m, (short)177 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9330), "Awesome", new Guid("3008bffb-64d6-4dd4-a965-be2a9f8823b5"), "Tasty Frozen Pants", 533.42m, (short)9943 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9344), "Practical", new Guid("9cf48a74-c393-40d5-9d3b-e388c61a421b"), "Handcrafted Granite Sausages", 309.95m, (short)1628 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9359), "Handmade", new Guid("c05d3e71-70f4-42c5-9560-a579834096c7"), "Tasty Cotton Salad", 735.99m, (short)4996 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9373), "Handmade", new Guid("12c75895-b4c0-4bd9-87a2-12243651af41"), "Fantastic Concrete Salad", 559.39m, (short)6058 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9387), "Intelligent", new Guid("2b61cea5-a127-4623-a50d-3cb24866faf6"), "Gorgeous Wooden Hat", 595.05m, (short)5657 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9445), "Small", new Guid("c3a196c1-ceb6-43b7-ba8c-42f224750ed9"), "Incredible Wooden Fish", 933.17m, (short)4607 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9462), "Rustic", new Guid("57136666-b771-48a8-9d82-31d4f00e1a06"), "Gorgeous Granite Ball", 196.86m, (short)8582 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9477), "Small", new Guid("7fe88751-b19c-41e3-b50d-ee21dc307b5f"), "Handcrafted Soft Chair", 486.36m, (short)6838 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9491), "Sleek", new Guid("2fa30847-7560-4a40-b13d-df6661766ba6"), "Practical Granite Soap", 21.77m, (short)6124 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9505), "Intelligent", new Guid("6e4629ba-ae18-4b4c-a249-455c5ff5b526"), "Handcrafted Wooden Shoes", 193.97m, (short)5075 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9519), "Awesome", new Guid("da252cea-d5cc-46ca-8efc-e93573326cd0"), "Tasty Granite Car", 851.75m, (short)2781 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9533), "Intelligent", new Guid("fea45692-7db3-4415-a5b6-042bf636e28d"), "Fantastic Soft Mouse", 931.69m, (short)8708 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9547), new Guid("a218e187-7858-4ca7-8997-8bb319220fb3"), "Intelligent Fresh Shoes", 976.66m, (short)4789 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9562), "Unbranded", new Guid("b7941186-f900-4f6b-b247-cf27ce9a2e90"), "Incredible Frozen Hat", 650.26m, (short)9149 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9577), "Sleek", new Guid("8f6d4879-45ee-4a97-9e69-a5b7d199af38"), "Small Frozen Ball", 236.43m, (short)5248 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9626), "Fantastic", new Guid("0c404efa-02db-4c82-aeb4-d39ff361aa9a"), "Rustic Metal Soap", 531.29m, (short)8175 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9642), "Gorgeous", new Guid("aa021e13-c7e5-4c90-a279-6ec0011114e9"), "Practical Metal Towels", 451.37m, (short)1952 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9656), "Practical", new Guid("464552ed-fe91-4886-9cd1-67a5d324ef20"), "Generic Rubber Computer", 863.45m, (short)4222 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9670), "Licensed", new Guid("c3e2e41d-5d15-47f6-b5a8-f01dc433e666"), "Unbranded Frozen Shirt", 454.07m, (short)5852 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9684), "Rustic", new Guid("d59e3a74-5857-468e-892e-bf3f0fee38fa"), "Handcrafted Fresh Keyboard", 198.47m, (short)4313 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9698), new Guid("b56ef674-0121-4328-9796-8ad0302b42f8"), "Practical Plastic Computer", 754.13m, (short)546 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9712), "Small", new Guid("1010a899-2669-4487-b6e5-fc230611af16"), "Handcrafted Plastic Pizza", 489.42m, (short)1288 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9728), "Intelligent", new Guid("85f4f0a3-4178-4dfc-aa18-dfa9a5022486"), "Handcrafted Rubber Keyboard", 837.35m, (short)8249 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9743), "Tasty", new Guid("05f09a46-d252-468b-919b-ed9e8872f672"), "Fantastic Concrete Gloves", 168.54m, (short)3946 });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterID" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 24, DateTimeKind.Local).AddTicks(7410), new Guid("93b1e94d-3ca5-4fc1-bf15-33eca6fd265f") });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "MasterID" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 24, DateTimeKind.Local).AddTicks(7492), new Guid("79969bd3-5b80-40ee-82c4-47ae88e3411f") });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterID" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 24, DateTimeKind.Local).AddTicks(7496), new Guid("6834c09e-e59f-4419-a734-1fe494ac2c96") });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "MasterID" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 24, DateTimeKind.Local).AddTicks(7499), new Guid("c448ca4e-8602-4f97-9e92-1b6dd01706b2") });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "MasterID" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 24, DateTimeKind.Local).AddTicks(7501), new Guid("d0bcac63-dae1-40b2-8fca-e587d98650e9") });
        }
    }
}
