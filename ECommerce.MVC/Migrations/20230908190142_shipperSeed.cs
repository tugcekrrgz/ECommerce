using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.MVC.Migrations
{
    /// <inheritdoc />
    public partial class shipperSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Home", new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(7569), "Home description.", new Guid("aee5b4a1-14e5-4cc8-be14-fdb650cdcdf4") });

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
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(7795), "Refined", new Guid("fc44cd5c-9339-48d2-bb29-dcb6a6ffc44a"), "Fantastic Steel Chicken", 325.10m, (short)4789 });

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
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8094), new Guid("9f406ca4-28c8-4086-b51d-3c3da1605aa8"), "Practical Metal Car", 559.12m, (short)4267 });

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
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8127), "Rustic", new Guid("c052d729-5eb0-4556-8012-484cd22c3a6c"), "Handcrafted Frozen Bike", 528.96m, (short)9939 });

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
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8460), "Licensed", new Guid("9b052116-6fe8-4a5c-97f7-667d0f9bf7bf"), "Handcrafted Fresh Chips", 137.39m, (short)2142 });

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
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8819), new Guid("22d11013-32d5-4fd8-95ab-6acd12be9aa5"), "Refined Metal Shirt", 938.25m, (short)989 });

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
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(8879), new Guid("65e271ba-8d43-49bb-8fa5-b78fae621fff"), "Handmade Granite Pizza", 27.17m, (short)5370 });

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
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9115), "Gorgeous", new Guid("8da9b0a8-259f-4c18-9462-5b69c6241f82"), "Handcrafted Concrete Table", 74.63m, (short)9334 });

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
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9256), new Guid("100b76b3-51d1-4f2c-9ccf-4094bea87e56"), "Rustic Plastic Fish", 554.99m, (short)5905 });

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
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9491), new Guid("2fa30847-7560-4a40-b13d-df6661766ba6"), "Practical Granite Soap", 21.77m, (short)6124 });

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
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9547), "Gorgeous", new Guid("a218e187-7858-4ca7-8997-8bb319220fb3"), "Intelligent Fresh Shoes", 976.66m, (short)4789 });

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
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9626), new Guid("0c404efa-02db-4c82-aeb4-d39ff361aa9a"), "Rustic Metal Soap", 531.29m, (short)8175 });

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
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 22, 1, 42, 26, DateTimeKind.Local).AddTicks(9698), "Unbranded", new Guid("b56ef674-0121-4328-9796-8ad0302b42f8"), "Practical Plastic Computer", 754.13m, (short)546 });

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
                columns: new[] { "Address", "CreatedDate", "MasterID" },
                values: new object[] { "Ankara/Çankaya", new DateTime(2023, 9, 8, 22, 1, 42, 24, DateTimeKind.Local).AddTicks(7492), new Guid("79969bd3-5b80-40ee-82c4-47ae88e3411f") });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Beauty", new DateTime(2023, 9, 8, 21, 59, 23, 583, DateTimeKind.Local).AddTicks(9329), "Beauty description.", new Guid("f262e17c-ad8e-41ac-b80e-6827088bfce5") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Industrial", new DateTime(2023, 9, 8, 21, 59, 23, 583, DateTimeKind.Local).AddTicks(9384), "Industrial description.", new Guid("f0683a83-2d28-4e81-95d7-d997e1c8b3c6") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Books", new DateTime(2023, 9, 8, 21, 59, 23, 583, DateTimeKind.Local).AddTicks(9387), "Books description.", new Guid("a8bca2d6-db42-4fe5-a39a-8c3146213673") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Jewelery", new DateTime(2023, 9, 8, 21, 59, 23, 583, DateTimeKind.Local).AddTicks(9389), "Jewelery description.", new Guid("31f3d268-dfae-4f9d-bfe8-b548fb0bc6b2") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Grocery", new DateTime(2023, 9, 8, 21, 59, 23, 583, DateTimeKind.Local).AddTicks(9392), "Grocery description.", new Guid("352506f2-e48c-4b4e-a865-db360f4d727e") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Jewelery", new DateTime(2023, 9, 8, 21, 59, 23, 583, DateTimeKind.Local).AddTicks(9396), "Jewelery description.", new Guid("973ab257-ff0f-468b-bb54-bd298128a9cc") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Industrial", new DateTime(2023, 9, 8, 21, 59, 23, 583, DateTimeKind.Local).AddTicks(9407), "Industrial description.", new Guid("b55f8b5e-5791-477d-b510-291a1d7ae98b") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Clothing", new DateTime(2023, 9, 8, 21, 59, 23, 583, DateTimeKind.Local).AddTicks(9410), "Clothing description.", new Guid("fde19d77-3c8f-4a89-95a6-d5b26a1eaa9d") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Industrial", new DateTime(2023, 9, 8, 21, 59, 23, 583, DateTimeKind.Local).AddTicks(9413), "Industrial description.", new Guid("8bb490fa-827b-4c00-a3c0-fcae1af761e0") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Health", new DateTime(2023, 9, 8, 21, 59, 23, 583, DateTimeKind.Local).AddTicks(9416), "Health description.", new Guid("57696adc-d6c8-4fcc-aa81-d61c96ed264e") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 583, DateTimeKind.Local).AddTicks(9559), "Awesome", new Guid("456a2df8-daf8-4724-b7fa-df8859791338"), "Intelligent Granite Fish", 956.37m, (short)7625 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 583, DateTimeKind.Local).AddTicks(9693), "Rustic", new Guid("427ae5eb-7bcc-4c1e-b44e-4c0627b2bd97"), "Practical Concrete Car", 477.91m, (short)2052 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 583, DateTimeKind.Local).AddTicks(9723), "Awesome", new Guid("d246ed38-ce9a-429a-94e2-123c70685c5c"), "Ergonomic Wooden Shoes", 250.32m, (short)8465 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 583, DateTimeKind.Local).AddTicks(9743), "Tasty", new Guid("8e25e2ca-f445-4608-ad20-5d23f67e8810"), "Intelligent Fresh Keyboard", 363.75m, (short)1697 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 583, DateTimeKind.Local).AddTicks(9763), "Practical", new Guid("190008ce-9d12-448e-9e43-473f694c6068"), "Handmade Metal Computer", 197.28m, (short)5517 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 583, DateTimeKind.Local).AddTicks(9782), "Sleek", new Guid("3adb396a-3052-4c4f-ac26-f214b10c72c6"), "Licensed Metal Pants", 312.13m, (short)4335 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 583, DateTimeKind.Local).AddTicks(9804), "Unbranded", new Guid("ccdf6037-5b00-41a7-9faa-2d0162e6fcb1"), "Incredible Steel Chair", 726.35m, (short)7752 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 583, DateTimeKind.Local).AddTicks(9825), "Practical", new Guid("1e841fa4-b637-433c-99b8-c7d036ec6053"), "Tasty Steel Keyboard", 389.24m, (short)5359 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 583, DateTimeKind.Local).AddTicks(9841), new Guid("d9b873a7-fc3c-4c99-95ae-b60973dd59f4"), "Awesome Cotton Bike", 95.68m, (short)1146 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 583, DateTimeKind.Local).AddTicks(9858), "Sleek", new Guid("421d5f67-989f-458f-9ed2-c67430750350"), "Unbranded Plastic Cheese", 363.68m, (short)4906 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 583, DateTimeKind.Local).AddTicks(9902), "Tasty", new Guid("0055bc42-1773-4320-8c23-99bc226d4ad0"), "Handmade Metal Fish", 617.12m, (short)4029 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 583, DateTimeKind.Local).AddTicks(9918), "Handmade", new Guid("f613a6a2-faa1-4523-a915-d5323582a4e4"), "Fantastic Wooden Chair", 159.48m, (short)9574 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 583, DateTimeKind.Local).AddTicks(9936), "Refined", new Guid("69408020-a471-4062-8478-c244748216a3"), "Gorgeous Granite Shoes", 905.03m, (short)6829 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 583, DateTimeKind.Local).AddTicks(9952), "Handmade", new Guid("db8faf71-021c-43ea-8d8b-e9103146ce49"), "Generic Frozen Car", 25.78m, (short)8223 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 583, DateTimeKind.Local).AddTicks(9969), "Tasty", new Guid("0dda2eac-0dfe-4b83-8394-ad303c5b9d67"), "Generic Steel Sausages", 585.50m, (short)8299 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 583, DateTimeKind.Local).AddTicks(9985), "Generic", new Guid("733fb640-af61-4b10-b447-db4363fb7891"), "Practical Wooden Cheese", 426.37m, (short)9653 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(1), "Licensed", new Guid("f2df18af-85bf-490e-9df8-1a14791c5bd5"), "Practical Granite Bacon", 652.46m, (short)5671 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(19), "Sleek", new Guid("7078e8bb-c772-4c9a-9368-ec3e89684ba3"), "Refined Plastic Sausages", 180.82m, (short)8352 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(35), "Handcrafted", new Guid("8f2e8acb-286a-46ec-b01a-4c837025daeb"), "Handcrafted Soft Pizza", 649.13m, (short)163 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(73), "Licensed", new Guid("40031365-ca08-47ee-a74a-d9192d0fa147"), "Generic Plastic Sausages", 83.77m, (short)4736 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(92), "Intelligent", new Guid("3be2355e-29da-4341-aee7-fc74a6ba7db7"), "Rustic Metal Soap", 566.38m, (short)5439 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(111), "Small", new Guid("6ae873dc-b41c-41f9-8025-93242b497992"), "Incredible Frozen Shoes", 978.51m, (short)6578 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(141), "Incredible", new Guid("d5236342-8cb0-470f-82e3-d33f72b61e3f"), "Rustic Fresh Table", 595.88m, (short)1769 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(156), "Small", new Guid("8e135045-2027-4f1e-8f5d-ddf641cc0456"), "Fantastic Steel Chicken", 292.62m, (short)9210 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(173), "Gorgeous", new Guid("1a927235-50b9-40f4-8916-99c1919eaae0"), "Unbranded Frozen Towels", 757.85m, (short)9370 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(189), "Practical", new Guid("7b2930e4-7fde-4d76-9ab9-77259ad74d7d"), "Generic Wooden Keyboard", 644.74m, (short)3318 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(205), "Tasty", new Guid("f35b48bb-1bd7-4458-90c2-8367ac2fd057"), "Intelligent Concrete Pizza", 38.18m, (short)8725 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(221), "Licensed", new Guid("a1a89b9e-dc63-4517-bbbd-7475166de77d"), "Handmade Metal Towels", 989.94m, (short)5161 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(237), "Handcrafted", new Guid("b5b8f563-865a-49ac-8a4e-6b69c26e23df"), "Awesome Metal Shoes", 835.62m, (short)8908 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(283), "Gorgeous", new Guid("f323acc8-32a0-4af7-be30-9daf7f43182c"), "Practical Granite Cheese", 692.38m, (short)1423 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(307), "Awesome", new Guid("7cb1a7b1-cfb5-4373-808e-6fcc7ede1efb"), "Licensed Plastic Computer", 278.26m, (short)707 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(331), "Small", new Guid("8ff1845a-6459-4151-911d-3be67adb42b0"), "Tasty Steel Ball", 607.42m, (short)3605 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(356), "Handmade", new Guid("8d05c3e5-ab17-49d0-bb3d-28294a4969f0"), "Incredible Metal Sausages", 106.60m, (short)794 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(380), "Licensed", new Guid("2823e576-2901-426e-9491-23d1802a0f63"), "Sleek Metal Computer", 694.54m, (short)4042 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(404), "Intelligent", new Guid("8fa92032-c910-4427-808c-3bf1b1e9667d"), "Fantastic Steel Towels", 864.10m, (short)3428 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(427), "Handcrafted", new Guid("5ac96ed1-fd73-453f-a680-0a1ec1413ebb"), "Rustic Cotton Ball", 738.64m, (short)7813 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(958), "Gorgeous", new Guid("3e93eb13-857e-423b-aec6-45bf16702593"), "Intelligent Wooden Tuna", 357.55m, (short)6364 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(1156), "Gorgeous", new Guid("6d14d161-494f-43d0-a713-9e9109cb7618"), "Handmade Soft Keyboard", 221.15m, (short)4764 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(1273), "Fantastic", new Guid("0d6e387f-3ad9-4465-a802-e6426eb4aa98"), "Intelligent Fresh Gloves", 309.81m, (short)4517 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(1306), "Licensed", new Guid("afcfa3a9-3818-42ae-bff3-8c2413c412fa"), "Rustic Plastic Cheese", 198.30m, (short)1135 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(1334), "Incredible", new Guid("7120e370-01b9-4f73-a341-4583f8d182a6"), "Sleek Plastic Bike", 50.99m, (short)3347 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(1361), "Handcrafted", new Guid("ac38d23f-2305-4c55-8d50-aa10b9bef0f4"), "Ergonomic Rubber Salad", 878.79m, (short)2372 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(1390), "Sleek", new Guid("336745ff-e6d4-4c86-9842-6bf2820f31cc"), "Handmade Wooden Bike", 678.29m, (short)4600 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(1413), "Handmade", new Guid("75b886c3-3293-4830-9074-d0e615ac2e0d"), "Handcrafted Fresh Salad", 690.14m, (short)1093 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(1445), "Rustic", new Guid("53b60671-66c4-4397-874e-a6d2929ef743"), "Refined Plastic Chair", 941.66m, (short)2529 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(1625), "Ergonomic", new Guid("a25a74e3-8e5d-40ff-9318-fe2650721a9d"), "Licensed Wooden Fish", 303.19m, (short)8916 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(1803), new Guid("0956261a-b567-4084-ae53-3bc2a7188750"), "Small Wooden Bacon", 271.18m, (short)9597 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(1836), "Ergonomic", new Guid("537565ff-b965-4459-95eb-5492db02dc52"), "Intelligent Frozen Chicken", 338.95m, (short)9991 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(1971), "Incredible", new Guid("23905c80-454e-4b3e-8132-d98451f84cf6"), "Handmade Plastic Ball", 741.31m, (short)4495 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(2002), "Incredible", new Guid("e0f1161c-27eb-4f23-a0b5-f38685bac8f1"), "Generic Granite Computer", 891.31m, (short)1913 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(2410), new Guid("fd6bc884-20f7-4eff-bed8-273721656a3b"), "Gorgeous Soft Bacon", 54.92m, (short)1009 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(2509), "Gorgeous", new Guid("7b523822-7536-4e77-81ee-78cf56074f6e"), "Ergonomic Concrete Pants", 752.45m, (short)4135 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(2533), "Small", new Guid("8ef10692-5abd-4416-bb8f-10a17c380e1d"), "Unbranded Concrete Soap", 121.88m, (short)9676 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(2554), "Unbranded", new Guid("f329fdc6-e44a-449c-8304-0b2458822eb6"), "Handcrafted Soft Fish", 3.03m, (short)4563 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(2577), "Small", new Guid("f4e745fd-6dc1-414d-9ede-1ad673c85e03"), "Practical Cotton Salad", 13.24m, (short)8048 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(2599), "Licensed", new Guid("0637aadc-4e03-48f5-abd4-1d30958577b5"), "Fantastic Wooden Chair", 400.21m, (short)4601 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(2620), "Awesome", new Guid("816921ed-4ace-43ff-96fb-e92d8a56438a"), "Licensed Plastic Mouse", 462.07m, (short)6032 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(2641), "Gorgeous", new Guid("605a62a3-e765-4d27-8da7-f254649cc4cb"), "Tasty Cotton Shoes", 474.40m, (short)8703 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(2755), "Small", new Guid("bf534be3-938b-4b17-9ddc-bc5dc96dd0b7"), "Licensed Granite Chicken", 265.91m, (short)5500 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(2777), "Handcrafted", new Guid("87d71396-13e3-4976-83eb-21f0b73c42df"), "Rustic Steel Chair", 524.28m, (short)4962 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(2797), "Practical", new Guid("de51d251-db8f-48b0-abc9-59383a678115"), "Handmade Plastic Pants", 801.69m, (short)8453 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(2817), "Handcrafted", new Guid("a7681fce-2028-4811-bf1e-1c47c703fc7f"), "Gorgeous Cotton Tuna", 33.27m, (short)1807 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(2838), "Licensed", new Guid("c543ea39-fac9-4d99-8962-208cacf4054c"), "Awesome Concrete Pizza", 585.75m, (short)5627 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(2857), "Practical", new Guid("de25e8cf-a7d6-4f05-a577-12177a896f51"), "Sleek Plastic Chicken", 221.63m, (short)4745 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(2878), "Intelligent", new Guid("06c1d67a-0bc9-4e38-bc94-9767c55d52bc"), "Gorgeous Concrete Tuna", 763.37m, (short)934 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(2910), "Rustic", new Guid("3cd791d9-b68b-4c51-af5a-c7116a0af60b"), "Refined Fresh Gloves", 971.31m, (short)9988 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(2930), "Fantastic", new Guid("74c2b9da-372f-40ba-b9b6-e86674ff0cf5"), "Refined Granite Bike", 199.51m, (short)3202 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(2989), "Intelligent", new Guid("7baa315d-89c8-4440-881d-dc2429461885"), "Intelligent Steel Towels", 363.66m, (short)7528 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(3008), "Awesome", new Guid("a39f1ca9-cd10-4ba9-9d8c-8d49864f06aa"), "Practical Rubber Gloves", 478.03m, (short)196 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(3029), "Practical", new Guid("ad1aae45-ffc1-44d6-aeba-7cd65d7a3e1c"), "Licensed Fresh Table", 316.89m, (short)2747 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(3051), "Ergonomic", new Guid("e27e34f5-bfb4-412e-b57f-11320981b441"), "Rustic Steel Table", 470.30m, (short)4297 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(3072), new Guid("e6d5d19e-b2f9-4bfd-ba48-64c4348c1cf5"), "Tasty Steel Bike", 725.49m, (short)8556 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(3092), "Practical", new Guid("9a315702-f875-49b5-a53e-467c6f4c5581"), "Fantastic Frozen Fish", 554.79m, (short)8683 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(3111), "Fantastic", new Guid("9f328ee2-31f7-4f47-97f1-0d898beff9a8"), "Fantastic Plastic Shoes", 29.72m, (short)3167 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(3131), "Tasty", new Guid("e476b10b-c3ad-47c1-b692-c85083697967"), "Ergonomic Frozen Ball", 117.53m, (short)9771 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(3152), "Sleek", new Guid("09706c85-a51c-4c27-b58a-81a3bc64e3e4"), "Fantastic Cotton Pants", 982.78m, (short)6355 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(3172), "Handcrafted", new Guid("bbfcf089-f052-439e-8633-43bb2548ea56"), "Handcrafted Rubber Tuna", 562.63m, (short)9423 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(3256), "Generic", new Guid("70215a00-9240-4ccc-bdc4-27dbe50a3637"), "Handcrafted Cotton Pants", 854.33m, (short)4523 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(3277), "Fantastic", new Guid("48829ca2-ab9b-4483-aee4-c14079de5f3d"), "Small Frozen Car", 651.73m, (short)5672 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(3297), "Incredible", new Guid("657b9dd1-baa6-4c35-a136-bd78119f3f4f"), "Practical Soft Salad", 251.01m, (short)8269 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(3317), "Tasty", new Guid("b445921b-eb70-4ffa-8353-eebf24564a17"), "Fantastic Concrete Pizza", 148.41m, (short)8769 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(3338), "Handcrafted", new Guid("0c24aeaa-784f-42be-bbe7-492852478a1d"), "Sleek Frozen Sausages", 827.52m, (short)2035 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(3358), "Sleek", new Guid("f25b96a4-8a9d-49a1-9fa2-c67fabfa17ae"), "Licensed Metal Bacon", 628.75m, (short)3391 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(3381), "Unbranded", new Guid("92a40317-63e6-4990-8721-2f52c8397701"), "Gorgeous Soft Pizza", 48.61m, (short)7202 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(3400), new Guid("9f53844a-bb9a-4709-8826-270d4b1d8311"), "Practical Granite Keyboard", 757.58m, (short)601 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(3420), "Refined", new Guid("4481c077-fe73-4788-940e-335bf3a9bc37"), "Sleek Metal Salad", 903.99m, (short)5121 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(3478), "Small", new Guid("476a7b35-087e-4ad9-9085-fe61b7927b1d"), "Fantastic Metal Salad", 785.14m, (short)5848 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(3497), "Incredible", new Guid("fdce2b85-50ac-4ea7-8777-20e51bcf18db"), "Practical Frozen Car", 337.79m, (short)2424 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(3517), "Awesome", new Guid("95048529-602d-433f-a887-0ffce694708f"), "Generic Fresh Gloves", 94.38m, (short)1260 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(3536), "Generic", new Guid("547aeac5-5e54-4b2b-8c70-fb8d28accc29"), "Rustic Frozen Soap", 453.67m, (short)7698 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(3555), "Rustic", new Guid("1a7c2a49-475f-4dcd-afec-97c7a7829e47"), "Small Wooden Bacon", 769.50m, (short)9962 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(3577), new Guid("96099e0a-905c-4c95-9aff-4cd579ce902a"), "Licensed Wooden Chips", 187.14m, (short)4946 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(3596), "Refined", new Guid("0b728223-22ca-4f15-8e2b-8b7ad4f64fd9"), "Generic Fresh Bacon", 273.20m, (short)2353 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(3615), "Licensed", new Guid("853329d3-6323-4cfb-a7bc-a67b59a6e9e4"), "Refined Granite Bacon", 22.68m, (short)3883 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(3634), "Refined", new Guid("b958149e-3ee0-467e-a928-5f6b64c7b6e7"), "Unbranded Rubber Sausages", 194.00m, (short)5403 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(3653), "Small", new Guid("95e37840-6917-4164-892d-6aae83dceaf4"), "Handmade Fresh Gloves", 980.34m, (short)1802 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(3708), "Gorgeous", new Guid("b0391b3f-5bd7-492e-96e8-01b85ad0db90"), "Rustic Plastic Table", 160.94m, (short)5239 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(3727), "Refined", new Guid("058451bd-9bd1-4e53-86a2-448b94fdd857"), "Gorgeous Granite Towels", 277.38m, (short)4255 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(3747), "Gorgeous", new Guid("28863410-633e-4b3d-b233-6b2398766bac"), "Generic Wooden Sausages", 298.75m, (short)4970 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 584, DateTimeKind.Local).AddTicks(3769), "Handmade", new Guid("8705bed2-fe5b-424a-b84b-6b8585ac2e3a"), "Rustic Concrete Pizza", 166.76m, (short)5804 });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterID" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 582, DateTimeKind.Local).AddTicks(907), new Guid("799d458f-5ff1-42ad-911c-7cfaecc5f6f0") });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "CreatedDate", "MasterID" },
                values: new object[] { "İAnkara/Çankaya", new DateTime(2023, 9, 8, 21, 59, 23, 582, DateTimeKind.Local).AddTicks(986), new Guid("ad87ccad-65d8-4ca5-87e9-7bed355b5996") });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "MasterID" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 582, DateTimeKind.Local).AddTicks(990), new Guid("b2a446c6-9c7d-4750-8ea2-f7def53a6e79") });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "MasterID" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 582, DateTimeKind.Local).AddTicks(1002), new Guid("97f23f23-5f7d-4768-a65a-52236ce36c48") });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "MasterID" },
                values: new object[] { new DateTime(2023, 9, 8, 21, 59, 23, 582, DateTimeKind.Local).AddTicks(1005), new Guid("6ad19686-d380-417f-b0de-e9ca911bcfc6") });
        }
    }
}
