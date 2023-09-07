using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerce.MVC.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
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
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitsInStock = table.Column<short>(type: "smallint", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Description", "MasterID", "Status", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 1, "Automotive", "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5397), "192.161.1.1", "Automotive description.", new Guid("b5af9053-9583-498e-b1f2-c4761b092766"), 0, null, null, null },
                    { 2, "Jewelery", "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5495), "192.161.1.1", "Jewelery description.", new Guid("4d4f11af-6fb8-49f0-9023-1f45cd160cea"), 0, null, null, null },
                    { 3, "Clothing", "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5498), "192.161.1.1", "Clothing description.", new Guid("dfd9a2d6-36d8-46d6-a117-8bf0b303b7d8"), 0, null, null, null },
                    { 4, "Baby", "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5500), "192.161.1.1", "Baby description.", new Guid("a5531b3c-02f7-4668-bce6-4c9c988bee03"), 0, null, null, null },
                    { 5, "Outdoors", "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5502), "192.161.1.1", "Outdoors description.", new Guid("9073b865-3d3d-473b-8daf-34c071b88546"), 0, null, null, null },
                    { 6, "Toys", "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5517), "192.161.1.1", "Toys description.", new Guid("3edb5b0c-797e-493c-b026-e190e2503d95"), 0, null, null, null },
                    { 7, "Beauty", "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5519), "192.161.1.1", "Beauty description.", new Guid("7c23281b-c613-46e5-be57-da242f87fc8f"), 0, null, null, null },
                    { 8, "Tools", "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5521), "192.161.1.1", "Tools description.", new Guid("7b6499fa-7ab9-4e82-bc8e-3aee0d966eab"), 0, null, null, null },
                    { 9, "Garden", "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5523), "192.161.1.1", "Garden description.", new Guid("6a3ee68c-9660-4a7a-a7c0-44b3bd2b19c6"), 0, null, null, null },
                    { 10, "Games", "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5526), "192.161.1.1", "Games description.", new Guid("32886faa-0154-42af-8f84-9398b8b35ba9"), 0, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Description", "ImagePath", "MasterID", "ProductName", "Status", "UnitPrice", "UnitsInStock", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 1, 1, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5665), "192.161.1.1", "Sleek", null, new Guid("ad462075-38a6-4c29-99de-b6f2c613f5e2"), "Tasty Rubber Soap", 0, 834.15m, (short)8422, null, null, null },
                    { 2, 1, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5793), "192.161.1.1", "Incredible", null, new Guid("5180a1a1-2320-4e11-a1fe-e97ed1283cb4"), "Handmade Rubber Chips", 0, 376.97m, (short)2581, null, null, null },
                    { 3, 1, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5812), "192.161.1.1", "Unbranded", null, new Guid("ca679140-dd89-4d38-b97c-fd23e240f944"), "Handcrafted Steel Salad", 0, 450.87m, (short)4755, null, null, null },
                    { 4, 1, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5832), "192.161.1.1", "Unbranded", null, new Guid("eef29644-22d3-4af1-9c84-8f47d08a5a14"), "Gorgeous Granite Hat", 0, 671.35m, (short)4245, null, null, null },
                    { 5, 1, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5849), "192.161.1.1", "Generic", null, new Guid("1c113ed1-b471-4cc1-b4a1-d0c35e35851b"), "Unbranded Fresh Chicken", 0, 238.87m, (short)3413, null, null, null },
                    { 6, 1, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5866), "192.161.1.1", "Awesome", null, new Guid("af5a5305-b685-4118-b0da-daf57b2f2855"), "Intelligent Metal Pizza", 0, 410.09m, (short)2072, null, null, null },
                    { 7, 1, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5883), "192.161.1.1", "Awesome", null, new Guid("a13fdc8c-6f07-4f8d-8eaa-bef96ec8ba1a"), "Ergonomic Soft Mouse", 0, 917.85m, (short)4562, null, null, null },
                    { 8, 1, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5928), "192.161.1.1", "Rustic", null, new Guid("44532397-d358-46fb-a0fd-c644f5f4eb7b"), "Small Plastic Shoes", 0, 622.93m, (short)8314, null, null, null },
                    { 9, 1, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5944), "192.161.1.1", "Unbranded", null, new Guid("5a08ed01-f2eb-41df-81b3-9642d109f220"), "Tasty Wooden Tuna", 0, 336.61m, (short)4319, null, null, null },
                    { 10, 1, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5962), "192.161.1.1", "Rustic", null, new Guid("fd70e8dd-2260-4aee-963c-62e520a1585b"), "Intelligent Metal Table", 0, 334.88m, (short)2563, null, null, null },
                    { 11, 2, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5978), "192.161.1.1", "Refined", null, new Guid("af969825-c826-4b66-be30-4e33e6512c9f"), "Intelligent Steel Tuna", 0, 668.34m, (short)3569, null, null, null },
                    { 12, 2, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(5994), "192.161.1.1", "Handcrafted", null, new Guid("5fffe756-0062-4847-af5c-5eec96cddf0a"), "Practical Soft Bacon", 0, 519.23m, (short)6719, null, null, null },
                    { 13, 2, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6009), "192.161.1.1", "Ergonomic", null, new Guid("d365b431-c513-42ce-be81-25e5b91dcd7c"), "Handcrafted Soft Pants", 0, 757.20m, (short)7820, null, null, null },
                    { 14, 2, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6024), "192.161.1.1", "Rustic", null, new Guid("8adb4869-ae4a-450c-88cd-f3bf9c965478"), "Handcrafted Steel Salad", 0, 261.81m, (short)7004, null, null, null },
                    { 15, 2, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6038), "192.161.1.1", "Refined", null, new Guid("70e95f2b-7280-43d8-8583-b7f88d6dcb95"), "Intelligent Frozen Pizza", 0, 284.80m, (short)7458, null, null, null },
                    { 16, 2, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6052), "192.161.1.1", "Awesome", null, new Guid("0a0fd4e1-1663-4cb3-8b66-742d26287013"), "Practical Cotton Pizza", 0, 831.34m, (short)4703, null, null, null },
                    { 17, 2, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6092), "192.161.1.1", "Ergonomic", null, new Guid("fe4dfe5f-cb72-43a9-b769-7e3ffd9205b7"), "Rustic Fresh Sausages", 0, 578.52m, (short)3462, null, null, null },
                    { 18, 2, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6109), "192.161.1.1", "Licensed", null, new Guid("dbd08080-8ee4-4d92-a6cf-17ea8f745eef"), "Incredible Soft Towels", 0, 961.89m, (short)2631, null, null, null },
                    { 19, 2, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6123), "192.161.1.1", "Tasty", null, new Guid("b619e6bc-f1da-46b0-9d42-d9712ab0d97b"), "Incredible Metal Fish", 0, 921.47m, (short)5736, null, null, null },
                    { 20, 2, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6139), "192.161.1.1", "Generic", null, new Guid("125e8356-14c5-4048-8335-776395b1855f"), "Licensed Cotton Keyboard", 0, 775.43m, (short)5111, null, null, null },
                    { 21, 3, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6153), "192.161.1.1", "Tasty", null, new Guid("f04d7d51-222e-44f2-8013-93e5b96af6f6"), "Handmade Rubber Chips", 0, 743.01m, (short)9692, null, null, null },
                    { 22, 3, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6167), "192.161.1.1", "Tasty", null, new Guid("59be86aa-445a-47e1-bf0f-bea5dcba315a"), "Refined Metal Tuna", 0, 37.08m, (short)4701, null, null, null },
                    { 23, 3, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6181), "192.161.1.1", "Unbranded", null, new Guid("0fb70d8d-afe9-4be2-bc88-334b09cf489a"), "Sleek Wooden Table", 0, 635.19m, (short)4923, null, null, null },
                    { 24, 3, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6195), "192.161.1.1", "Licensed", null, new Guid("0c909591-754b-493c-8509-c2484eb0d65c"), "Rustic Fresh Pizza", 0, 169.13m, (short)3001, null, null, null },
                    { 25, 3, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6208), "192.161.1.1", "Incredible", null, new Guid("cfb3f6d5-8230-48e9-a7fc-1a7e8a4d50d3"), "Handmade Rubber Shirt", 0, 155.65m, (short)2824, null, null, null },
                    { 26, 3, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6223), "192.161.1.1", "Ergonomic", null, new Guid("0aafca1d-dbdc-41d8-85ac-9c0b0e8e1570"), "Ergonomic Concrete Gloves", 0, 972.32m, (short)6197, null, null, null },
                    { 27, 3, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6266), "192.161.1.1", "Handcrafted", null, new Guid("916f3adf-c538-4c30-b430-cab7545a0af6"), "Intelligent Granite Sausages", 0, 223.62m, (short)1509, null, null, null },
                    { 28, 3, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6282), "192.161.1.1", "Practical", null, new Guid("f27e9c47-c0f5-42fa-9fba-410680a2e703"), "Fantastic Soft Bike", 0, 854.90m, (short)1984, null, null, null },
                    { 29, 3, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6295), "192.161.1.1", "Sleek", null, new Guid("f8eef3cd-ebb9-4c17-9512-8d30df9dbf08"), "Sleek Concrete Salad", 0, 945.97m, (short)8829, null, null, null },
                    { 30, 3, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6309), "192.161.1.1", "Small", null, new Guid("45d30fbb-556b-4ee1-b79d-93736924453d"), "Tasty Metal Chips", 0, 569.90m, (short)4698, null, null, null },
                    { 31, 4, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6322), "192.161.1.1", "Generic", null, new Guid("f8d15d92-285f-4d09-9399-406678330558"), "Gorgeous Soft Salad", 0, 366.16m, (short)4221, null, null, null },
                    { 32, 4, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6337), "192.161.1.1", "Gorgeous", null, new Guid("fb7f200d-8c03-43c6-b5fb-1be58e84ca21"), "Gorgeous Rubber Cheese", 0, 309.22m, (short)8626, null, null, null },
                    { 33, 4, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6352), "192.161.1.1", "Sleek", null, new Guid("670aea4f-af47-46db-8cfc-f75869968c32"), "Rustic Metal Bike", 0, 371.40m, (short)6766, null, null, null },
                    { 34, 4, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6367), "192.161.1.1", "Awesome", null, new Guid("2453dc1c-02ec-44f3-b933-2122ce3227af"), "Licensed Wooden Computer", 0, 11.61m, (short)5448, null, null, null },
                    { 35, 4, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6381), "192.161.1.1", "Practical", null, new Guid("3c92c551-1f26-4a39-9c5e-ea9d42543042"), "Incredible Frozen Salad", 0, 355.64m, (short)3627, null, null, null },
                    { 36, 4, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6437), "192.161.1.1", "Generic", null, new Guid("fec77b29-c953-43c0-b4bb-8c66037be46b"), "Fantastic Rubber Pants", 0, 600.68m, (short)2955, null, null, null },
                    { 37, 4, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6454), "192.161.1.1", "Practical", null, new Guid("c2333471-ec8b-49cd-aea3-c64aea783569"), "Ergonomic Fresh Bacon", 0, 692.74m, (short)2884, null, null, null },
                    { 38, 4, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6468), "192.161.1.1", "Licensed", null, new Guid("9dad8f36-4602-4c05-85e9-e95a1e9f1c4b"), "Intelligent Plastic Gloves", 0, 341.38m, (short)617, null, null, null },
                    { 39, 4, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6482), "192.161.1.1", "Generic", null, new Guid("31e4c99b-f315-42c2-9031-1fb6fd6869e4"), "Unbranded Granite Shoes", 0, 177.98m, (short)7523, null, null, null },
                    { 40, 4, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6495), "192.161.1.1", "Small", null, new Guid("4ccd852f-3813-4508-964a-8d302cfefded"), "Fantastic Wooden Computer", 0, 947.69m, (short)4629, null, null, null },
                    { 41, 5, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6510), "192.161.1.1", "Gorgeous", null, new Guid("cff8f69b-79d4-4b08-a033-d73137ff4fb6"), "Gorgeous Wooden Hat", 0, 663.80m, (short)6408, null, null, null },
                    { 42, 5, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6523), "192.161.1.1", "Ergonomic", null, new Guid("e1ec302b-5f9a-49f8-8133-4ba824b38a29"), "Intelligent Steel Soap", 0, 790.40m, (short)9205, null, null, null },
                    { 43, 5, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6537), "192.161.1.1", "Fantastic", null, new Guid("411b90c6-c75f-422f-b017-53915dfef698"), "Handcrafted Cotton Car", 0, 349.18m, (short)3982, null, null, null },
                    { 44, 5, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6554), "192.161.1.1", "Refined", null, new Guid("17761335-441e-4c4a-93b1-d406093276b7"), "Awesome Metal Tuna", 0, 603.43m, (short)3015, null, null, null },
                    { 45, 5, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6568), "192.161.1.1", "Small", null, new Guid("256ef471-3bf2-4d3d-98ef-1babdf3e80e6"), "Incredible Granite Car", 0, 814.27m, (short)4359, null, null, null },
                    { 46, 5, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6607), "192.161.1.1", "Tasty", null, new Guid("0e5b1a4d-08ca-4d72-8976-f69d17749ef6"), "Incredible Rubber Cheese", 0, 955.08m, (short)4145, null, null, null },
                    { 47, 5, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6622), "192.161.1.1", "Small", null, new Guid("664300f8-226e-4587-81db-f75939ab2311"), "Gorgeous Cotton Hat", 0, 21.95m, (short)7500, null, null, null },
                    { 48, 5, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6636), "192.161.1.1", "Gorgeous", null, new Guid("dadb37d5-4716-4138-a716-96fae90b8c8a"), "Licensed Steel Bacon", 0, 791.64m, (short)4606, null, null, null },
                    { 49, 5, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6650), "192.161.1.1", "Practical", null, new Guid("09be7645-d31a-49de-8e73-b48bfc194061"), "Unbranded Granite Pizza", 0, 161.00m, (short)316, null, null, null },
                    { 50, 5, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6664), "192.161.1.1", "Fantastic", null, new Guid("a16cdf52-e579-4d63-bfa9-6e1c21d286c1"), "Incredible Soft Chicken", 0, 611.98m, (short)9928, null, null, null },
                    { 51, 6, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6677), "192.161.1.1", "Sleek", null, new Guid("e964b19e-9e84-4aab-9363-d20ccdbe493c"), "Intelligent Fresh Chair", 0, 122.24m, (short)9018, null, null, null },
                    { 52, 6, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6693), "192.161.1.1", "Handmade", null, new Guid("44623044-a047-4ca8-87b8-44a5d1390dfd"), "Unbranded Rubber Table", 0, 995.81m, (short)4928, null, null, null },
                    { 53, 6, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6706), "192.161.1.1", "Licensed", null, new Guid("2e202ac7-f522-4766-b922-f3482498add1"), "Licensed Cotton Bacon", 0, 701.53m, (short)6722, null, null, null },
                    { 54, 6, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6719), "192.161.1.1", "Awesome", null, new Guid("fa6daee5-8e43-4119-9078-8968e1654dd6"), "Intelligent Metal Hat", 0, 778.37m, (short)2868, null, null, null },
                    { 55, 6, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6733), "192.161.1.1", "Refined", null, new Guid("d27cf2ae-187d-479c-8146-a033f0d8ab26"), "Intelligent Rubber Gloves", 0, 257.31m, (short)5406, null, null, null },
                    { 56, 6, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6771), "192.161.1.1", "Sleek", null, new Guid("d30270e9-1c70-4cee-b512-7bad89bfdbe2"), "Awesome Frozen Shoes", 0, 310.98m, (short)4196, null, null, null },
                    { 57, 6, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6785), "192.161.1.1", "Ergonomic", null, new Guid("91ec4a8e-1708-4c48-b61b-61ec117c82ba"), "Refined Concrete Chips", 0, 398.26m, (short)1880, null, null, null },
                    { 58, 6, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6799), "192.161.1.1", "Generic", null, new Guid("bb2c3a43-34db-4f9c-9539-c97cd336539d"), "Incredible Fresh Cheese", 0, 986.21m, (short)4843, null, null, null },
                    { 59, 6, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6812), "192.161.1.1", "Awesome", null, new Guid("b14fcf72-d335-48c8-a4e0-72792ca5f661"), "Gorgeous Cotton Mouse", 0, 658.54m, (short)5791, null, null, null },
                    { 60, 6, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6827), "192.161.1.1", "Unbranded", null, new Guid("baa2beb9-7803-415a-918c-49894b3ad07e"), "Practical Cotton Cheese", 0, 405.92m, (short)3794, null, null, null },
                    { 61, 7, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6842), "192.161.1.1", "Ergonomic", null, new Guid("8d6b482f-c236-40ca-aef5-bd7672faa2d2"), "Rustic Soft Table", 0, 553.00m, (short)4722, null, null, null },
                    { 62, 7, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6855), "192.161.1.1", "Practical", null, new Guid("ef44af75-f04e-448d-8518-dbca487971ab"), "Incredible Steel Bike", 0, 306.50m, (short)2492, null, null, null },
                    { 63, 7, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6869), "192.161.1.1", "Ergonomic", null, new Guid("decfa5c5-bc63-4220-8a1e-485f98190ff1"), "Handmade Soft Computer", 0, 104.78m, (short)4491, null, null, null },
                    { 64, 7, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6883), "192.161.1.1", "Intelligent", null, new Guid("7630ac29-b9d7-4214-82d2-b53aa02eb998"), "Tasty Frozen Salad", 0, 966.54m, (short)928, null, null, null },
                    { 65, 7, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6897), "192.161.1.1", "Tasty", null, new Guid("50911989-92c4-4e19-8521-bf94b0baa99b"), "Generic Soft Bacon", 0, 121.98m, (short)9861, null, null, null },
                    { 66, 7, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6937), "192.161.1.1", "Generic", null, new Guid("b6975f12-0377-45b9-9446-2a742f46d8e9"), "Gorgeous Steel Shirt", 0, 913.04m, (short)3214, null, null, null },
                    { 67, 7, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6951), "192.161.1.1", "Refined", null, new Guid("fe789cb2-df0d-41c3-885c-b7006a856d3b"), "Handcrafted Cotton Chips", 0, 286.40m, (short)9685, null, null, null },
                    { 68, 7, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6966), "192.161.1.1", "Gorgeous", null, new Guid("82f26339-c74d-436c-aeec-8c832b668e6d"), "Licensed Concrete Tuna", 0, 28.89m, (short)8462, null, null, null },
                    { 69, 7, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6980), "192.161.1.1", "Fantastic", null, new Guid("66f23178-7ba2-4667-bdf3-369397cb3b26"), "Incredible Plastic Soap", 0, 683.03m, (short)8795, null, null, null },
                    { 70, 7, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(6994), "192.161.1.1", "Generic", null, new Guid("8b959bfc-a456-4eaa-a8f8-aefd993eb5d6"), "Incredible Steel Table", 0, 978.37m, (short)2361, null, null, null },
                    { 71, 8, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7008), "192.161.1.1", "Awesome", null, new Guid("a7138a90-0743-4be3-9901-fee0bcd7a2dd"), "Intelligent Concrete Keyboard", 0, 145.59m, (short)3332, null, null, null },
                    { 72, 8, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7021), "192.161.1.1", "Intelligent", null, new Guid("9d479782-becc-4ffb-8bec-c9dc87aa26d8"), "Ergonomic Fresh Bike", 0, 262.72m, (short)8337, null, null, null },
                    { 73, 8, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7035), "192.161.1.1", "Awesome", null, new Guid("6444abef-3a12-4f09-aa1c-4c170e847827"), "Fantastic Fresh Computer", 0, 886.26m, (short)94, null, null, null },
                    { 74, 8, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7050), "192.161.1.1", "Small", null, new Guid("0106f1e5-dbfb-4f9b-b8f0-b7a8f089f8c5"), "Gorgeous Wooden Mouse", 0, 887.21m, (short)4595, null, null, null },
                    { 75, 8, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7088), "192.161.1.1", "Handcrafted", null, new Guid("efaa9b35-19e3-4c37-9420-4622077f7edc"), "Refined Granite Chicken", 0, 139.27m, (short)4500, null, null, null },
                    { 76, 8, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7105), "192.161.1.1", "Fantastic", null, new Guid("d559b041-6c19-49c4-875f-5a48309a1f13"), "Ergonomic Frozen Shirt", 0, 248.92m, (short)4825, null, null, null },
                    { 77, 8, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7118), "192.161.1.1", "Handcrafted", null, new Guid("60d97d64-5b82-40d0-aca3-49274958612b"), "Incredible Frozen Ball", 0, 619.69m, (short)3010, null, null, null },
                    { 78, 8, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7132), "192.161.1.1", "Fantastic", null, new Guid("be3e6b81-1eee-437c-87b3-11eeddc85930"), "Ergonomic Granite Bacon", 0, 355.38m, (short)5549, null, null, null },
                    { 79, 8, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7146), "192.161.1.1", "Sleek", null, new Guid("27642bc8-c607-4bb2-bd24-19585f8de8ed"), "Ergonomic Rubber Salad", 0, 381.88m, (short)4070, null, null, null },
                    { 80, 8, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7159), "192.161.1.1", "Handcrafted", null, new Guid("2061d084-6b16-4893-aa67-1338d3a6048c"), "Unbranded Soft Bacon", 0, 954.86m, (short)5284, null, null, null },
                    { 81, 9, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7173), "192.161.1.1", "Licensed", null, new Guid("7dfa28f7-0f1a-4cb1-8c05-7f082935f784"), "Incredible Soft Soap", 0, 204.67m, (short)5878, null, null, null },
                    { 82, 9, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7187), "192.161.1.1", "Sleek", null, new Guid("1934f49f-5b6e-4cfc-bdc4-3f1cd58bec23"), "Handmade Frozen Bacon", 0, 808.91m, (short)2945, null, null, null },
                    { 83, 9, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7201), "192.161.1.1", "Handcrafted", null, new Guid("5b5c2cd0-c3df-403d-8d9d-434bddb917cb"), "Handmade Fresh Computer", 0, 24.22m, (short)3850, null, null, null },
                    { 84, 9, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7216), "192.161.1.1", "Refined", null, new Guid("b4790f10-3ac9-4446-b79b-431894d4c5b4"), "Gorgeous Cotton Soap", 0, 447.55m, (short)343, null, null, null },
                    { 85, 9, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7255), "192.161.1.1", "Refined", null, new Guid("50523a17-99c7-482b-bc02-3986f183633d"), "Sleek Cotton Keyboard", 0, 403.29m, (short)64, null, null, null },
                    { 86, 9, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7269), "192.161.1.1", "Ergonomic", null, new Guid("4e60ae5b-8621-410b-a734-fa9c33769bc5"), "Licensed Wooden Cheese", 0, 147.71m, (short)7905, null, null, null },
                    { 87, 9, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7283), "192.161.1.1", "Small", null, new Guid("aa20ac0e-a70d-4829-be4e-330eedd59f9c"), "Generic Soft Chips", 0, 51.54m, (short)8281, null, null, null },
                    { 88, 9, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7297), "192.161.1.1", "Handcrafted", null, new Guid("5443829b-91cc-421b-840f-253528a9a245"), "Handcrafted Cotton Table", 0, 427.72m, (short)667, null, null, null },
                    { 89, 9, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7310), "192.161.1.1", "Gorgeous", null, new Guid("600fc7fc-ccde-47c1-8e51-a4ebf1b6ddc3"), "Fantastic Rubber Cheese", 0, 236.07m, (short)2676, null, null, null },
                    { 90, 9, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7324), "192.161.1.1", "Generic", null, new Guid("7e987a21-3a24-4869-bb76-ab64b32196aa"), "Handmade Metal Gloves", 0, 308.21m, (short)3988, null, null, null },
                    { 91, 10, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7337), "192.161.1.1", "Handcrafted", null, new Guid("291a62d5-b3a9-4434-96ea-3b8675cee99a"), "Small Soft Chair", 0, 393.48m, (short)3352, null, null, null },
                    { 92, 10, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7353), "192.161.1.1", "Generic", null, new Guid("a48c05fc-6e49-4dde-aea9-43970224f57d"), "Gorgeous Plastic Salad", 0, 118.19m, (short)8032, null, null, null },
                    { 93, 10, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7366), "192.161.1.1", "Handcrafted", null, new Guid("4ca6220c-0fd3-4873-91fb-dda6c0afa472"), "Fantastic Cotton Soap", 0, 799.49m, (short)5265, null, null, null },
                    { 94, 10, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7380), "192.161.1.1", "Gorgeous", null, new Guid("4bd1eede-c672-4827-b6f3-e7832ba4001f"), "Fantastic Granite Shoes", 0, 319.27m, (short)8492, null, null, null },
                    { 95, 10, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7420), "192.161.1.1", "Licensed", null, new Guid("6fcbbf4c-7e6e-471d-abe6-6471875b9af7"), "Intelligent Rubber Pants", 0, 976.11m, (short)6718, null, null, null },
                    { 96, 10, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7434), "192.161.1.1", "Refined", null, new Guid("469a816c-88a8-4805-9a22-ff2913992752"), "Tasty Frozen Ball", 0, 410.48m, (short)5580, null, null, null },
                    { 97, 10, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7447), "192.161.1.1", "Practical", null, new Guid("6b6cb8bc-f139-4cd6-968d-a4c234d1877b"), "Generic Frozen Salad", 0, 656.91m, (short)4617, null, null, null },
                    { 98, 10, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7460), "192.161.1.1", "Practical", null, new Guid("3cdd3ba9-ce11-4802-a936-edc6b34c9c02"), "Handcrafted Cotton Gloves", 0, 525.22m, (short)3563, null, null, null },
                    { 99, 10, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7474), "192.161.1.1", "Intelligent", null, new Guid("53e39093-5c96-4e81-bae0-cc8c832ef9ab"), "Ergonomic Steel Pizza", 0, 98.21m, (short)943, null, null, null },
                    { 100, 10, "DESKTOP-I9V1GOS", new DateTime(2023, 9, 7, 11, 4, 24, 950, DateTimeKind.Local).AddTicks(7489), "192.161.1.1", "Small", null, new Guid("7d151d24-d84c-4742-a88a-d8337bc371d0"), "Rustic Plastic Ball", 0, 37.89m, (short)5610, null, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
