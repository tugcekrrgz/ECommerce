using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.MVC.Migrations
{
    /// <inheritdoc />
    public partial class updatedShipper : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Shippers_ShipperId",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "ShipperId",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Grocery", new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(2990), "Grocery description.", new Guid("b903af20-655d-45e2-b358-214c4c0ecafe") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Kids", new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(3083), "Kids description.", new Guid("983d961c-2757-4f24-b3ea-de904971e159") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Outdoors", new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(3087), "Outdoors description.", new Guid("4bec5146-ef76-4b26-84cf-a165d3169009") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Toys", new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(3105), "Toys description.", new Guid("5fc57a7c-cf80-468a-9a8e-ae86dffeed77") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Health", new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(3108), "Health description.", new Guid("98239a81-2884-4ae2-ac93-3f6473e7384d") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Garden", new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(3113), "Garden description.", new Guid("80a85e92-56ed-4898-85c2-4961e78da2ba") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Games", new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(3116), "Games description.", new Guid("d7feee28-7004-46c2-8e61-f216885f3167") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Health", new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(3119), "Health description.", new Guid("1f2344c5-f21e-4012-b776-26f1f1ac39c3") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Grocery", new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(3123), "Grocery description.", new Guid("435f99c0-1bfa-4630-8cb7-0d66844c7c92") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterID" },
                values: new object[] { "Toys", new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(3127), "Toys description.", new Guid("0e2fb57e-ea71-4ed5-991a-a2a1b39962d6") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(3406), "Tasty", new Guid("04853fc0-fc1c-4069-9fe4-d610c1e84020"), "Sleek Cotton Shoes", 490.70m, (short)8119 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(3642), "Tasty", new Guid("dcf12953-069c-49bd-ab74-6064015bf09f"), "Handcrafted Fresh Sausages", 483.59m, (short)6274 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(3679), "Intelligent", new Guid("1f00c2e0-0967-4aa8-80f2-ec5326dd9e72"), "Licensed Wooden Fish", 107.60m, (short)1233 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(3709), "Tasty", new Guid("fe2f3237-f729-494c-b8e6-776b5f836dfd"), "Intelligent Cotton Shirt", 77.98m, (short)3098 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(3736), "Intelligent", new Guid("8d658134-c8df-4c54-991a-4163bdecf26f"), "Small Wooden Ball", 53.43m, (short)9302 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(3766), "Incredible", new Guid("de7921c2-e92b-4419-b229-ee006ae262cb"), "Handcrafted Granite Tuna", 63.66m, (short)2006 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(3797), "Practical", new Guid("5358d47a-489c-4e04-a38a-d83c28b1b329"), "Gorgeous Steel Pizza", 346.92m, (short)1738 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(3824), "Generic", new Guid("9143e3e9-6984-4b27-b705-f8ced44bf3f8"), "Tasty Cotton Shirt", 689.78m, (short)8059 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(3853), "Handcrafted", new Guid("02d818e6-1d79-4a1f-b983-6f6625882e7a"), "Licensed Cotton Pizza", 876.32m, (short)2993 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(3937), "Intelligent", new Guid("35342e13-17c0-4418-95c4-9ae5b5f3f694"), "Refined Soft Keyboard", 30.34m, (short)7017 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(3968), "Tasty", new Guid("c9a56a22-4fde-4119-aad1-cdd11d9dc4d2"), "Fantastic Plastic Hat", 230.00m, (short)8003 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(3996), "Practical", new Guid("cd0abea5-f86c-4500-826e-2fc60912f432"), "Tasty Steel Chips", 415.16m, (short)3662 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(4027), new Guid("27959f02-a2a9-4f85-91cf-96241b574a8b"), "Handmade Wooden Cheese", 523.16m, (short)6984 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(4053), "Unbranded", new Guid("7424d3c0-9817-445d-bf53-7f18537e9792"), "Tasty Concrete Gloves", 732.45m, (short)2205 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(4080), "Tasty", new Guid("91644ffd-0db2-4621-9cd2-e8e80bfe3a31"), "Ergonomic Rubber Hat", 666.79m, (short)1478 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(4110), "Unbranded", new Guid("9df29e0d-8b84-4b71-8215-2bf43fe5d146"), "Practical Cotton Bike", 849.07m, (short)7424 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(4137), "Intelligent", new Guid("d7c376a9-cd1f-4670-a2c1-5955e35e3448"), "Rustic Wooden Car", 188.58m, (short)9396 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(4168), "Small", new Guid("8f1e0a15-b2df-4c04-a44c-dc54c5962c3f"), "Gorgeous Frozen Chair", 269.43m, (short)7421 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(4195), "Generic", new Guid("ca12dd7b-4ed3-42cc-94c6-d43c8991ebcc"), "Unbranded Steel Cheese", 697.70m, (short)9658 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(4280), new Guid("0ef2dd20-16d0-4705-8e9b-b0e192a34d87"), "Awesome Soft Pizza", 345.77m, (short)2182 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(4307), "Awesome", new Guid("75f886cc-9345-441f-92f5-7cd595eb9f6b"), "Refined Metal Shirt", 212.77m, (short)3307 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(4366), "Intelligent", new Guid("ab72b60a-83ff-4065-98cd-13d895b4f7c5"), "Awesome Frozen Gloves", 157.40m, (short)8872 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(4390), "Intelligent", new Guid("afef444f-3b72-47e0-8e21-ef1b96e481f0"), "Generic Fresh Table", 50.08m, (short)9828 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(4420), "Fantastic", new Guid("90773262-13b9-476e-bea5-0da45e54e976"), "Generic Steel Bacon", 671.55m, (short)2057 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(4447), "Handcrafted", new Guid("46a07878-5625-41d6-afbd-9e83dd4ea322"), "Gorgeous Plastic Chair", 500.76m, (short)498 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(4478), "Handcrafted", new Guid("34a69888-f261-465b-ac74-4a2df6431270"), "Handmade Fresh Soap", 332.47m, (short)7515 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(4506), "Intelligent", new Guid("858e564b-ddbe-4aee-a711-43ee5ce987f8"), "Refined Rubber Soap", 762.04m, (short)5315 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(4530), "Rustic", new Guid("44eb43d1-0a56-4530-b3c9-f624cf6a0fac"), "Handcrafted Metal Pants", 947.71m, (short)8259 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(4557), "Small", new Guid("c0696989-83ea-4357-8374-3016b976c3c1"), "Tasty Fresh Mouse", 765.92m, (short)2845 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(4628), "Handmade", new Guid("4c2bcd4e-1b86-456a-94fd-312221a0dc3d"), "Awesome Fresh Pants", 588.52m, (short)9521 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(4655), "Handcrafted", new Guid("4c9bc54d-e31b-4951-a693-d1e504eeb56e"), "Sleek Soft Hat", 942.13m, (short)3090 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(4682), "Unbranded", new Guid("a397cb0e-aadd-4fb5-b33f-f1091fbcd0d2"), "Handmade Steel Keyboard", 639.75m, (short)2882 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(4705), "Licensed", new Guid("afb5228e-84db-45fc-b09c-d52e2ab24358"), "Incredible Cotton Salad", 772.98m, (short)2713 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(4738), "Generic", new Guid("5097a79d-e397-4c50-a038-c3a2913117ef"), "Licensed Granite Keyboard", 58.41m, (short)7465 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(4763), "Awesome", new Guid("c063046c-da07-48bc-94e7-fc3df8c33f40"), "Rustic Frozen Towels", 106.48m, (short)5565 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(4792), "Awesome", new Guid("d59248ea-424a-4754-9b53-a56752b2c3bd"), "Ergonomic Cotton Pizza", 478.85m, (short)269 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(4818), "Handcrafted", new Guid("0006e355-6dab-4230-a2ed-ec48e286a30a"), "Licensed Rubber Computer", 71.55m, (short)4844 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(4848), "Small", new Guid("2c96b9cc-66b9-400b-b922-931037396258"), "Handmade Fresh Bike", 622.52m, (short)8725 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(4909), "Practical", new Guid("61ca3138-089c-4382-b051-e2728af4f3cb"), "Unbranded Plastic Salad", 39.64m, (short)2303 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(4937), "Gorgeous", new Guid("2bea22ba-77bf-432e-a859-d437191bfa31"), "Handcrafted Metal Pizza", 46.77m, (short)3642 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(4962), "Refined", new Guid("37bf8e26-e8ea-4e2b-874e-b65cd8809d6d"), "Unbranded Frozen Tuna", 29.08m, (short)7100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(4991), new Guid("eb87837a-d26c-4d19-8ab9-cb8102eb4334"), "Handmade Metal Chair", 433.91m, (short)7030 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(5018), "Sleek", new Guid("23b0f468-304d-40e7-9b2c-596e2e4befb7"), "Handmade Rubber Computer", 78.82m, (short)4061 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(5044), "Handcrafted", new Guid("8822c7f2-efe8-41e8-be4f-0d250979bf1e"), "Awesome Plastic Computer", 843.04m, (short)4654 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(5068), "Sleek", new Guid("9624669c-f9f2-47c3-b737-1b2975de9027"), "Intelligent Metal Bacon", 644.22m, (short)9066 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(5093), "Small", new Guid("f096f8ca-854b-4a8d-be23-dfcf9057664b"), "Awesome Fresh Salad", 305.87m, (short)5016 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(5119), "Sleek", new Guid("1dc6c313-324c-47dc-b4b5-dd6ded96355e"), "Unbranded Granite Ball", 556.39m, (short)6246 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(5145), "Rustic", new Guid("3f5fbbf5-8070-425e-9011-2bad502a808e"), "Handmade Frozen Shirt", 411.88m, (short)4961 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(5208), "Ergonomic", new Guid("c2305166-5de3-4c06-8936-ca50370ee5f5"), "Gorgeous Fresh Hat", 326.01m, (short)3549 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(5236), "Sleek", new Guid("408fb03f-d542-4e80-a9d5-a915d1f9a5d4"), "Practical Cotton Table", 485.65m, (short)7573 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(5261), "Unbranded", new Guid("f7efac3c-8f14-416e-90c3-aaa0bd911562"), "Intelligent Concrete Pizza", 765.07m, (short)1062 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(5287), "Rustic", new Guid("1ed23bfe-79cb-4ef9-b228-65f797487623"), "Handmade Steel Table", 651.13m, (short)6484 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(5312), "Ergonomic", new Guid("51e3968a-af0e-4acb-8977-479ef6f686e3"), "Generic Granite Pizza", 245.18m, (short)2472 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(5339), "Sleek", new Guid("6bc43ad5-f66b-4d69-8fc0-b863806d5313"), "Tasty Steel Tuna", 255.69m, (short)4992 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(5365), "Tasty", new Guid("f3749406-8fc9-464a-b620-2a2054f56296"), "Unbranded Cotton Computer", 802.28m, (short)2236 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(5391), "Awesome", new Guid("a42779b2-34d4-45ab-ad8f-3a3379cf319c"), "Fantastic Wooden Towels", 664.27m, (short)1329 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(5417), "Fantastic", new Guid("811b8536-1840-4af1-bd22-069d64511a4b"), "Fantastic Wooden Chair", 202.53m, (short)4348 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(5445), "Intelligent", new Guid("761bfbb7-3fbb-4e21-bc0d-80145647f6d4"), "Rustic Cotton Chair", 877.53m, (short)5777 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(5507), "Unbranded", new Guid("a8f08ac5-583d-49f3-8d34-bceaed6295bf"), "Refined Wooden Car", 15.27m, (short)9808 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(5534), "Generic", new Guid("e4f624e8-97af-4ee5-834b-929324a42401"), "Intelligent Frozen Towels", 92.43m, (short)8860 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(5564), "Awesome", new Guid("2b8573c6-3af1-487e-9a81-56530e8f7b68"), "Sleek Frozen Car", 685.39m, (short)7728 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(5599), "Gorgeous", new Guid("4a5d8f3f-3b1d-4817-8b85-effc3c74a012"), "Incredible Rubber Ball", 911.18m, (short)3014 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(5629), "Unbranded", new Guid("80d17b48-490a-47dc-bfbe-79b0195cd752"), "Fantastic Fresh Gloves", 25.80m, (short)7080 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(5659), "Refined", new Guid("b40cda25-f9ea-464e-95ba-6d43ae0d16bf"), "Gorgeous Frozen Hat", 854.75m, (short)47 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(5684), "Awesome", new Guid("dfc206ff-ea12-4a5f-a1d9-ba39f9e34c95"), "Licensed Plastic Table", 442.70m, (short)5017 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(5712), "Gorgeous", new Guid("abe83211-3719-49ae-96cb-8d3f7b89b3a1"), "Tasty Plastic Keyboard", 24.06m, (short)6742 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(5738), "Practical", new Guid("998b4f47-e025-4f9f-b183-3d24a7006dcb"), "Incredible Wooden Keyboard", 35.77m, (short)9885 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(5808), "Tasty", new Guid("6bc166c4-ad80-44c0-907a-0c5280b8ff6b"), "Handmade Metal Ball", 802.65m, (short)417 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(5833), "Small", new Guid("6161ac04-bcb3-40a4-96a9-eadc6e71be9b"), "Incredible Metal Shoes", 10.75m, (short)3761 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(5859), "Licensed", new Guid("5a1a98ad-38ae-46c5-b898-ada3516f93b2"), "Intelligent Wooden Bacon", 746.04m, (short)3679 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(5885), "Handcrafted", new Guid("b3092c0b-e51f-48f9-8800-4e56031a5f47"), "Gorgeous Wooden Bike", 520.51m, (short)4834 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(5909), "Ergonomic", new Guid("87f37bd7-d3ac-456f-9e30-1ffc6d4abcb1"), "Small Granite Salad", 115.02m, (short)3493 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(5933), "Refined", new Guid("c204338a-27c8-4898-adf0-307fbcb3a06a"), "Intelligent Wooden Keyboard", 988.96m, (short)2650 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(5965), "Generic", new Guid("133d495b-c638-43fb-a3ed-074886cdf550"), "Generic Granite Chair", 444.77m, (short)8431 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(5990), "Incredible", new Guid("7b050d86-b632-4121-9a94-0b1022831bea"), "Rustic Rubber Shoes", 338.52m, (short)5192 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(6013), "Practical", new Guid("68abcd97-2105-427a-be36-547789c90d29"), "Unbranded Soft Mouse", 385.84m, (short)9069 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(6041), "Practical", new Guid("69cab37a-8876-4f9f-bdc6-71cd359b6445"), "Small Metal Hat", 242.31m, (short)4166 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(6147), "Awesome", new Guid("f7b9da97-c056-4908-abb4-b7970bc36ba0"), "Fantastic Concrete Towels", 341.55m, (short)8636 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(6172), "Licensed", new Guid("b596fafb-f114-4934-888e-6958513d6edb"), "Gorgeous Soft Hat", 436.09m, (short)3796 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(6199), "Generic", new Guid("aeac13ce-7514-43fb-b67a-475842ea5c90"), "Incredible Metal Mouse", 679.95m, (short)1701 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(6224), "Small", new Guid("81e776ff-b4f2-4df7-bf05-03859c10e4ad"), "Small Rubber Chicken", 711.62m, (short)5153 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(6255), "Licensed", new Guid("89691c92-0159-4032-8470-bc5dd7055e6b"), "Handmade Plastic Fish", 427.47m, (short)877 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(6280), "Gorgeous", new Guid("e2066d4f-caaf-40f9-aac5-199ff04cc083"), "Incredible Granite Soap", 132.06m, (short)6873 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(6306), "Fantastic", new Guid("c624fd3d-b50d-4407-b411-bb894902bf79"), "Incredible Concrete Shirt", 844.60m, (short)1788 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(6331), "Licensed", new Guid("853c3995-206f-4d69-95cc-6296de5b1aa9"), "Awesome Fresh Towels", 548.23m, (short)9884 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(6357), "Incredible", new Guid("0790727b-3722-4ae8-9599-6eb22793f320"), "Gorgeous Plastic Fish", 204.05m, (short)896 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(6412), "Gorgeous", new Guid("c46b3f01-d393-4cd7-9209-5f85feb84aad"), "Licensed Soft Soap", 180.01m, (short)8302 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(6440), "Small", new Guid("e8189a8e-afb8-454a-aa02-9de8e40740c3"), "Rustic Steel Tuna", 319.75m, (short)1010 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(6466), "Awesome", new Guid("708a0231-dbef-49dc-8855-623987884039"), "Generic Steel Towels", 563.50m, (short)9790 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(6492), new Guid("c69416dc-81b7-4fe1-99de-d100884fed10"), "Ergonomic Soft Computer", 964.50m, (short)28 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(6516), "Ergonomic", new Guid("4540e3ad-fc05-45d9-be77-cc25b0216d37"), "Generic Plastic Computer", 543.17m, (short)1716 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(6540), "Small", new Guid("359d6942-1a6f-4099-be6e-fc8a00d02d27"), "Unbranded Wooden Soap", 56.38m, (short)2058 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(6565), "Gorgeous", new Guid("4256c6cc-350d-415c-b987-db8e3c1f6563"), "Practical Wooden Pants", 526.33m, (short)1372 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(6592), "Small", new Guid("95725a67-e0c2-427b-b522-0b937b2ec9d1"), "Gorgeous Granite Soap", 330.27m, (short)7226 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(6619), "Handcrafted", new Guid("3b8c8629-f121-4340-885f-d62f8f33a9c3"), "Licensed Steel Sausages", 321.81m, (short)4027 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(6643), "Sleek", new Guid("dee1af6b-565d-4364-a883-32ea1ebb5fe3"), "Gorgeous Metal Shoes", 860.75m, (short)9538 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(6724), "Incredible", new Guid("ce2577a1-5381-4a58-99a9-ba66c1a71fc9"), "Small Concrete Computer", 876.48m, (short)2419 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(6752), "Licensed", new Guid("50339122-33e8-485c-ba8d-19a152865a2f"), "Generic Cotton Salad", 273.17m, (short)7395 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(6777), "Handcrafted", new Guid("4c18d001-58bb-4d10-a871-ef7586a0700e"), "Handcrafted Cotton Ball", 193.39m, (short)7563 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 45, 26, 455, DateTimeKind.Local).AddTicks(6802), "Generic", new Guid("fc56b5df-34f7-4052-be08-a8658e190855"), "Gorgeous Frozen Bike", 25.58m, (short)3969 });

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Shippers_ShipperId",
                table: "Orders",
                column: "ShipperId",
                principalTable: "Shippers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Shippers_ShipperId",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "ShipperId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2000), "Tasty", new Guid("c1df0b3a-92ab-4a22-b3eb-9c278af24ba4"), "Ergonomic Granite Pants", 46.12m, (short)6162 });

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
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2144), "Licensed", new Guid("b68b0466-babb-4eb7-a33a-b9c944759131"), "Unbranded Steel Chair", 892.84m, (short)2214 });

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
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2215), new Guid("4ef62df9-c8fb-4f9a-b50f-b36cc20a07f6"), "Refined Steel Bacon", 892.24m, (short)1812 });

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
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2365), new Guid("b48edbd9-1c0e-4fc8-80a9-ce7e0a92b4a3"), "Refined Wooden Chair", 928.24m, (short)409 });

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
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2708), "Unbranded", new Guid("f6b8b7a4-8e39-41bf-b137-5240f3e81a30"), "Gorgeous Frozen Computer", 838.33m, (short)3000 });

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
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2827), new Guid("a5cc4663-985e-4393-b848-4d5a499acd44"), "Licensed Frozen Fish", 969.89m, (short)4292 });

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
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(2942), "Handcrafted", new Guid("5d8da222-0435-44bd-b7d4-57c62464ddc9"), "Handcrafted Steel Bacon", 967.89m, (short)3784 });

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
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3530), "Tasty", new Guid("56114e94-0dda-4b17-a2d1-1026dac3dcde"), "Ergonomic Rubber Bacon", 110.44m, (short)8994 });

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
                columns: new[] { "CreatedDate", "Description", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3748), "Generic", new Guid("9a416472-39cc-41b6-8635-0352c0c4bff4"), "Handcrafted Frozen Table", 775.09m, (short)7015 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "MasterID", "ProductName", "UnitPrice", "UnitsInStock" },
                values: new object[] { new DateTime(2023, 9, 8, 14, 36, 57, 535, DateTimeKind.Local).AddTicks(3764), new Guid("5edf38e7-bd54-4ea1-bd97-27cad0f1205e"), "Unbranded Wooden Hat", 656.73m, (short)3240 });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Shippers_ShipperId",
                table: "Orders",
                column: "ShipperId",
                principalTable: "Shippers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
