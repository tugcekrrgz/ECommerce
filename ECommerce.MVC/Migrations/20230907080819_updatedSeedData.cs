using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.MVC.Migrations
{
    /// <inheritdoc />
    public partial class updatedSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(406), "Handcrafted", new Guid("4e659864-497c-44c2-a190-90433fbb46fb"), "Unbranded Granite Bike", 869.47m, (short)9953 });

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
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(972), "Awesome", new Guid("4fb7bc1a-496d-4bb4-99e3-633bed87f67b"), "Ergonomic Granite Mouse", 604.02m, (short)7886 });

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
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1061), new Guid("33d072f3-20d1-4412-878d-f8fe0a026f11"), "Tasty Granite Sausages", 659.28m, (short)7627 });

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
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1268), new Guid("2867b9e4-951d-4b94-a1d8-1e4d7989b473"), "Gorgeous Plastic Computer", 370.21m, (short)3199 });

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
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1388), "Unbranded", new Guid("89234bdc-bb36-4321-ac2f-592c3b547c77"), "Handmade Concrete Tuna", 840.42m, (short)8527 });

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
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1542), new Guid("8ccc6c52-4c26-489a-8621-98bf1fa0cdab"), "Awesome Wooden Chair", 948.44m, (short)1102 });

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
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1735), new Guid("f9e01207-d395-4042-aafe-63d6b79205eb"), "Handmade Frozen Pants", 267.41m, (short)6400 });

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
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1820), new Guid("cab55d4b-eb63-4cb3-a174-b777800f04da"), "Handmade Steel Car", 771.54m, (short)139 });

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
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(1922), "Gorgeous", new Guid("9c51bd65-c11a-4cbe-96eb-12a824323dad"), "Refined Steel Salad", 24.99m, (short)2131 });

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
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(2023), new Guid("27f57eeb-dfe8-4444-9a00-065a37e04a7f"), "Sleek Granite Shoes", 18.97m, (short)478 });

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
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 8, 19, 677, DateTimeKind.Local).AddTicks(2159), new Guid("1bdd5024-483b-4ed4-9bc4-1236d01cdad2"), "Small Soft Ball", 366.46m, (short)612 });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Automotive", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5397), "Automotive description.", new Guid("b5af9053-9583-498e-b1f2-c4761b092766") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Jewelery", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5495), "Jewelery description.", new Guid("4d4f11af-6fb8-49f0-9023-1f45cd160cea") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Clothing", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5498), "Clothing description.", new Guid("dfd9a2d6-36d8-46d6-a117-8bf0b303b7d8") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Baby", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5500), "Baby description.", new Guid("a5531b3c-02f7-4668-bce6-4c9c988bee03") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Outdoors", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5502), "Outdoors description.", new Guid("9073b865-3d3d-473b-8daf-34c071b88546") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Toys", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5517), "Toys description.", new Guid("3edb5b0c-797e-493c-b026-e190e2503d95") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Beauty", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5519), "Beauty description.", new Guid("7c23281b-c613-46e5-be57-da242f87fc8f") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Tools", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5521), "Tools description.", new Guid("7b6499fa-7ab9-4e82-bc8e-3aee0d966eab") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Garden", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5523), "Garden description.", new Guid("6a3ee68c-9660-4a7a-a7c0-44b3bd2b19c6") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Games", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5526), "Games description.", new Guid("32886faa-0154-42af-8f84-9398b8b35ba9") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5665), "Sleek", new Guid("ad462075-38a6-4c29-99de-b6f2c613f5e2"), "Tasty Rubber Soap", 834.15m, (short)8422 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5793), "Incredible", new Guid("5180a1a1-2320-4e11-a1fe-e97ed1283cb4"), "Handmade Rubber Chips", 376.97m, (short)2581 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5812), "Unbranded", new Guid("ca679140-dd89-4d38-b97c-fd23e240f944"), "Handcrafted Steel Salad", 450.87m, (short)4755 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5832), "Unbranded", new Guid("eef29644-22d3-4af1-9c84-8f47d08a5a14"), "Gorgeous Granite Hat", 671.35m, (short)4245 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5849), "Generic", new Guid("1c113ed1-b471-4cc1-b4a1-d0c35e35851b"), "Unbranded Fresh Chicken", 238.87m, (short)3413 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5866), "Awesome", new Guid("af5a5305-b685-4118-b0da-daf57b2f2855"), "Intelligent Metal Pizza", 410.09m, (short)2072 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5883), "Awesome", new Guid("a13fdc8c-6f07-4f8d-8eaa-bef96ec8ba1a"), "Ergonomic Soft Mouse", 917.85m, (short)4562 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5928), "Rustic", new Guid("44532397-d358-46fb-a0fd-c644f5f4eb7b"), "Small Plastic Shoes", 622.93m, (short)8314 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5944), "Unbranded", new Guid("5a08ed01-f2eb-41df-81b3-9642d109f220"), "Tasty Wooden Tuna", 336.61m, (short)4319 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5962), "Rustic", new Guid("fd70e8dd-2260-4aee-963c-62e520a1585b"), "Intelligent Metal Table", 334.88m, (short)2563 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5978), new Guid("af969825-c826-4b66-be30-4e33e6512c9f"), "Intelligent Steel Tuna", 668.34m, (short)3569 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5994), "Handcrafted", new Guid("5fffe756-0062-4847-af5c-5eec96cddf0a"), "Practical Soft Bacon", 519.23m, (short)6719 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6009), "Ergonomic", new Guid("d365b431-c513-42ce-be81-25e5b91dcd7c"), "Handcrafted Soft Pants", 757.20m, (short)7820 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6024), "Rustic", new Guid("8adb4869-ae4a-450c-88cd-f3bf9c965478"), "Handcrafted Steel Salad", 261.81m, (short)7004 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6038), "Refined", new Guid("70e95f2b-7280-43d8-8583-b7f88d6dcb95"), "Intelligent Frozen Pizza", 284.80m, (short)7458 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6052), "Awesome", new Guid("0a0fd4e1-1663-4cb3-8b66-742d26287013"), "Practical Cotton Pizza", 831.34m, (short)4703 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6092), "Ergonomic", new Guid("fe4dfe5f-cb72-43a9-b769-7e3ffd9205b7"), "Rustic Fresh Sausages", 578.52m, (short)3462 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6109), "Licensed", new Guid("dbd08080-8ee4-4d92-a6cf-17ea8f745eef"), "Incredible Soft Towels", 961.89m, (short)2631 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6123), "Tasty", new Guid("b619e6bc-f1da-46b0-9d42-d9712ab0d97b"), "Incredible Metal Fish", 921.47m, (short)5736 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6139), "Generic", new Guid("125e8356-14c5-4048-8335-776395b1855f"), "Licensed Cotton Keyboard", 775.43m, (short)5111 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6153), "Tasty", new Guid("f04d7d51-222e-44f2-8013-93e5b96af6f6"), "Handmade Rubber Chips", 743.01m, (short)9692 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6167), "Tasty", new Guid("59be86aa-445a-47e1-bf0f-bea5dcba315a"), "Refined Metal Tuna", 37.08m, (short)4701 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6181), "Unbranded", new Guid("0fb70d8d-afe9-4be2-bc88-334b09cf489a"), "Sleek Wooden Table", 635.19m, (short)4923 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6195), "Licensed", new Guid("0c909591-754b-493c-8509-c2484eb0d65c"), "Rustic Fresh Pizza", 169.13m, (short)3001 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6208), "Incredible", new Guid("cfb3f6d5-8230-48e9-a7fc-1a7e8a4d50d3"), "Handmade Rubber Shirt", 155.65m, (short)2824 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6223), "Ergonomic", new Guid("0aafca1d-dbdc-41d8-85ac-9c0b0e8e1570"), "Ergonomic Concrete Gloves", 972.32m, (short)6197 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6266), "Handcrafted", new Guid("916f3adf-c538-4c30-b430-cab7545a0af6"), "Intelligent Granite Sausages", 223.62m, (short)1509 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6282), "Practical", new Guid("f27e9c47-c0f5-42fa-9fba-410680a2e703"), "Fantastic Soft Bike", 854.90m, (short)1984 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6295), "Sleek", new Guid("f8eef3cd-ebb9-4c17-9512-8d30df9dbf08"), "Sleek Concrete Salad", 945.97m, (short)8829 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6309), "Small", new Guid("45d30fbb-556b-4ee1-b79d-93736924453d"), "Tasty Metal Chips", 569.90m, (short)4698 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6322), "Generic", new Guid("f8d15d92-285f-4d09-9399-406678330558"), "Gorgeous Soft Salad", 366.16m, (short)4221 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6337), "Gorgeous", new Guid("fb7f200d-8c03-43c6-b5fb-1be58e84ca21"), "Gorgeous Rubber Cheese", 309.22m, (short)8626 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6352), "Sleek", new Guid("670aea4f-af47-46db-8cfc-f75869968c32"), "Rustic Metal Bike", 371.40m, (short)6766 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6367), new Guid("2453dc1c-02ec-44f3-b933-2122ce3227af"), "Licensed Wooden Computer", 11.61m, (short)5448 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6381), "Practical", new Guid("3c92c551-1f26-4a39-9c5e-ea9d42543042"), "Incredible Frozen Salad", 355.64m, (short)3627 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6437), "Generic", new Guid("fec77b29-c953-43c0-b4bb-8c66037be46b"), "Fantastic Rubber Pants", 600.68m, (short)2955 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6454), "Practical", new Guid("c2333471-ec8b-49cd-aea3-c64aea783569"), "Ergonomic Fresh Bacon", 692.74m, (short)2884 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6468), "Licensed", new Guid("9dad8f36-4602-4c05-85e9-e95a1e9f1c4b"), "Intelligent Plastic Gloves", 341.38m, (short)617 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6482), "Generic", new Guid("31e4c99b-f315-42c2-9031-1fb6fd6869e4"), "Unbranded Granite Shoes", 177.98m, (short)7523 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6495), "Small", new Guid("4ccd852f-3813-4508-964a-8d302cfefded"), "Fantastic Wooden Computer", 947.69m, (short)4629 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6510), "Gorgeous", new Guid("cff8f69b-79d4-4b08-a033-d73137ff4fb6"), "Gorgeous Wooden Hat", 663.80m, (short)6408 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6523), "Ergonomic", new Guid("e1ec302b-5f9a-49f8-8133-4ba824b38a29"), "Intelligent Steel Soap", 790.40m, (short)9205 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6537), "Fantastic", new Guid("411b90c6-c75f-422f-b017-53915dfef698"), "Handcrafted Cotton Car", 349.18m, (short)3982 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6554), new Guid("17761335-441e-4c4a-93b1-d406093276b7"), "Awesome Metal Tuna", 603.43m, (short)3015 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6568), "Small", new Guid("256ef471-3bf2-4d3d-98ef-1babdf3e80e6"), "Incredible Granite Car", 814.27m, (short)4359 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6607), "Tasty", new Guid("0e5b1a4d-08ca-4d72-8976-f69d17749ef6"), "Incredible Rubber Cheese", 955.08m, (short)4145 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6622), "Small", new Guid("664300f8-226e-4587-81db-f75939ab2311"), "Gorgeous Cotton Hat", 21.95m, (short)7500 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6636), "Gorgeous", new Guid("dadb37d5-4716-4138-a716-96fae90b8c8a"), "Licensed Steel Bacon", 791.64m, (short)4606 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6650), "Practical", new Guid("09be7645-d31a-49de-8e73-b48bfc194061"), "Unbranded Granite Pizza", 161.00m, (short)316 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6664), "Fantastic", new Guid("a16cdf52-e579-4d63-bfa9-6e1c21d286c1"), "Incredible Soft Chicken", 611.98m, (short)9928 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6677), "Sleek", new Guid("e964b19e-9e84-4aab-9363-d20ccdbe493c"), "Intelligent Fresh Chair", 122.24m, (short)9018 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6693), "Handmade", new Guid("44623044-a047-4ca8-87b8-44a5d1390dfd"), "Unbranded Rubber Table", 995.81m, (short)4928 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6706), "Licensed", new Guid("2e202ac7-f522-4766-b922-f3482498add1"), "Licensed Cotton Bacon", 701.53m, (short)6722 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6719), "Awesome", new Guid("fa6daee5-8e43-4119-9078-8968e1654dd6"), "Intelligent Metal Hat", 778.37m, (short)2868 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6733), "Refined", new Guid("d27cf2ae-187d-479c-8146-a033f0d8ab26"), "Intelligent Rubber Gloves", 257.31m, (short)5406 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6771), "Sleek", new Guid("d30270e9-1c70-4cee-b512-7bad89bfdbe2"), "Awesome Frozen Shoes", 310.98m, (short)4196 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6785), "Ergonomic", new Guid("91ec4a8e-1708-4c48-b61b-61ec117c82ba"), "Refined Concrete Chips", 398.26m, (short)1880 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6799), new Guid("bb2c3a43-34db-4f9c-9539-c97cd336539d"), "Incredible Fresh Cheese", 986.21m, (short)4843 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6812), "Awesome", new Guid("b14fcf72-d335-48c8-a4e0-72792ca5f661"), "Gorgeous Cotton Mouse", 658.54m, (short)5791 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6827), "Unbranded", new Guid("baa2beb9-7803-415a-918c-49894b3ad07e"), "Practical Cotton Cheese", 405.92m, (short)3794 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6842), "Ergonomic", new Guid("8d6b482f-c236-40ca-aef5-bd7672faa2d2"), "Rustic Soft Table", 553.00m, (short)4722 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6855), "Practical", new Guid("ef44af75-f04e-448d-8518-dbca487971ab"), "Incredible Steel Bike", 306.50m, (short)2492 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6869), "Ergonomic", new Guid("decfa5c5-bc63-4220-8a1e-485f98190ff1"), "Handmade Soft Computer", 104.78m, (short)4491 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6883), "Intelligent", new Guid("7630ac29-b9d7-4214-82d2-b53aa02eb998"), "Tasty Frozen Salad", 966.54m, (short)928 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6897), "Tasty", new Guid("50911989-92c4-4e19-8521-bf94b0baa99b"), "Generic Soft Bacon", 121.98m, (short)9861 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6937), "Generic", new Guid("b6975f12-0377-45b9-9446-2a742f46d8e9"), "Gorgeous Steel Shirt", 913.04m, (short)3214 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6951), "Refined", new Guid("fe789cb2-df0d-41c3-885c-b7006a856d3b"), "Handcrafted Cotton Chips", 286.40m, (short)9685 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6966), new Guid("82f26339-c74d-436c-aeec-8c832b668e6d"), "Licensed Concrete Tuna", 28.89m, (short)8462 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6980), "Fantastic", new Guid("66f23178-7ba2-4667-bdf3-369397cb3b26"), "Incredible Plastic Soap", 683.03m, (short)8795 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6994), "Generic", new Guid("8b959bfc-a456-4eaa-a8f8-aefd993eb5d6"), "Incredible Steel Table", 978.37m, (short)2361 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7008), "Awesome", new Guid("a7138a90-0743-4be3-9901-fee0bcd7a2dd"), "Intelligent Concrete Keyboard", 145.59m, (short)3332 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7021), "Intelligent", new Guid("9d479782-becc-4ffb-8bec-c9dc87aa26d8"), "Ergonomic Fresh Bike", 262.72m, (short)8337 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7035), new Guid("6444abef-3a12-4f09-aa1c-4c170e847827"), "Fantastic Fresh Computer", 886.26m, (short)94 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7050), "Small", new Guid("0106f1e5-dbfb-4f9b-b8f0-b7a8f089f8c5"), "Gorgeous Wooden Mouse", 887.21m, (short)4595 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7088), "Handcrafted", new Guid("efaa9b35-19e3-4c37-9420-4622077f7edc"), "Refined Granite Chicken", 139.27m, (short)4500 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7105), "Fantastic", new Guid("d559b041-6c19-49c4-875f-5a48309a1f13"), "Ergonomic Frozen Shirt", 248.92m, (short)4825 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7118), "Handcrafted", new Guid("60d97d64-5b82-40d0-aca3-49274958612b"), "Incredible Frozen Ball", 619.69m, (short)3010 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7132), "Fantastic", new Guid("be3e6b81-1eee-437c-87b3-11eeddc85930"), "Ergonomic Granite Bacon", 355.38m, (short)5549 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7146), "Sleek", new Guid("27642bc8-c607-4bb2-bd24-19585f8de8ed"), "Ergonomic Rubber Salad", 381.88m, (short)4070 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7159), "Handcrafted", new Guid("2061d084-6b16-4893-aa67-1338d3a6048c"), "Unbranded Soft Bacon", 954.86m, (short)5284 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7173), "Licensed", new Guid("7dfa28f7-0f1a-4cb1-8c05-7f082935f784"), "Incredible Soft Soap", 204.67m, (short)5878 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7187), "Sleek", new Guid("1934f49f-5b6e-4cfc-bdc4-3f1cd58bec23"), "Handmade Frozen Bacon", 808.91m, (short)2945 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7201), "Handcrafted", new Guid("5b5c2cd0-c3df-403d-8d9d-434bddb917cb"), "Handmade Fresh Computer", 24.22m, (short)3850 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7216), new Guid("b4790f10-3ac9-4446-b79b-431894d4c5b4"), "Gorgeous Cotton Soap", 447.55m, (short)343 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7255), "Refined", new Guid("50523a17-99c7-482b-bc02-3986f183633d"), "Sleek Cotton Keyboard", 403.29m, (short)64 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7269), "Ergonomic", new Guid("4e60ae5b-8621-410b-a734-fa9c33769bc5"), "Licensed Wooden Cheese", 147.71m, (short)7905 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7283), "Small", new Guid("aa20ac0e-a70d-4829-be4e-330eedd59f9c"), "Generic Soft Chips", 51.54m, (short)8281 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7297), "Handcrafted", new Guid("5443829b-91cc-421b-840f-253528a9a245"), "Handcrafted Cotton Table", 427.72m, (short)667 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7310), "Gorgeous", new Guid("600fc7fc-ccde-47c1-8e51-a4ebf1b6ddc3"), "Fantastic Rubber Cheese", 236.07m, (short)2676 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7324), "Generic", new Guid("7e987a21-3a24-4869-bb76-ab64b32196aa"), "Handmade Metal Gloves", 308.21m, (short)3988 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7337), new Guid("291a62d5-b3a9-4434-96ea-3b8675cee99a"), "Small Soft Chair", 393.48m, (short)3352 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7353), "Generic", new Guid("a48c05fc-6e49-4dde-aea9-43970224f57d"), "Gorgeous Plastic Salad", 118.19m, (short)8032 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7366), "Handcrafted", new Guid("4ca6220c-0fd3-4873-91fb-dda6c0afa472"), "Fantastic Cotton Soap", 799.49m, (short)5265 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7380), "Gorgeous", new Guid("4bd1eede-c672-4827-b6f3-e7832ba4001f"), "Fantastic Granite Shoes", 319.27m, (short)8492 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7420), "Licensed", new Guid("6fcbbf4c-7e6e-471d-abe6-6471875b9af7"), "Intelligent Rubber Pants", 976.11m, (short)6718 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7434), "Refined", new Guid("469a816c-88a8-4805-9a22-ff2913992752"), "Tasty Frozen Ball", 410.48m, (short)5580 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7447), "Practical", new Guid("6b6cb8bc-f139-4cd6-968d-a4c234d1877b"), "Generic Frozen Salad", 656.91m, (short)4617 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7460), "Practical", new Guid("3cdd3ba9-ce11-4802-a936-edc6b34c9c02"), "Handcrafted Cotton Gloves", 525.22m, (short)3563 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7474), "Intelligent", new Guid("53e39093-5c96-4e81-bae0-cc8c832ef9ab"), "Ergonomic Steel Pizza", 98.21m, (short)943 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7489), "Small", new Guid("7d151d24-d84c-4742-a88a-d8337bc371d0"), "Rustic Plastic Ball", 37.89m, (short)5610 });
        }
    }
}
