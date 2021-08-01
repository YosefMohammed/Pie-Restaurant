﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo1.Migrations
{
    public partial class AddIdentity : Migration
    {
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
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OrderTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderPlaced = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
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
                name: "Pies",
                columns: table => new
                {
                    PieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LongDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AllergyInformation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageThumbnailUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPieOfTheWeek = table.Column<bool>(type: "bit", nullable: false),
                    InStock = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pies", x => x.PieId);
                    table.ForeignKey(
                        name: "FK_Pies_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    PieId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Pies_PieId",
                        column: x => x.PieId,
                        principalTable: "Pies",
                        principalColumn: "PieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PieId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    ShoppingCartId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Pies_PieId",
                        column: x => x.PieId,
                        principalTable: "Pies",
                        principalColumn: "PieId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Fruit pies", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Cheese cakes", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Seasonal pies", null });

            migrationBuilder.InsertData(
                table: "Pies",
                columns: new[] { "PieId", "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsPieOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, "", 1, "https://i.kym-cdn.com/photos/images/original/001/782/719/73d.png", "https://i.kym-cdn.com/photos/images/original/001/782/719/73d.png", true, true, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Apple Pie", 12.95m, "Our famous cheems pies!" },
                    { 4, "", 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg", true, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Cherry Pie", 15.95m, "A summer classic!" },
                    { 7, "", 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg", false, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Peach Pie", 15.95m, "Sweet as peach" },
                    { 9, "", 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg", true, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Rhubarb Pie", 15.95m, "My God, so sweet!" },
                    { 10, "", 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg", true, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Strawberry Pie", 15.95m, "Our delicious strawberry pie!" },
                    { 2, "", 2, "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg", true, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Blueberry Cheese Cake", 18.95m, "You'll love it!" },
                    { 3, "", 2, "data:image/jpeg;base64,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", "data:image/jpeg;base64,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", true, true, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Cheem's Cake", 18.95m, "Plain cheese cake. Plain pleasure." },
                    { 11, "", 2, "data:image/jpeg;base64,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", "data:image/jpeg;base64,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", false, true, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Strawberry Cheem's Cake", 18.95m, "You'll love it!" },
                    { 5, "", 3, "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg", true, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Christmas Apple Pie", 13.95m, "Happy holidays with this pie!" },
                    { 6, "", 3, "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypie.jpg", true, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Cranberry Pie", 17.95m, "A Christmas favorite" },
                    { 8, "", 3, "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg", true, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Pumpkin Pie", 12.95m, "Our Halloween favorite" }
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
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_PieId",
                table: "OrderDetails",
                column: "PieId");

            migrationBuilder.CreateIndex(
                name: "IX_Pies_CategoryId",
                table: "Pies",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_PieId",
                table: "ShoppingCartItems",
                column: "PieId");
        }

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
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Pies");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
