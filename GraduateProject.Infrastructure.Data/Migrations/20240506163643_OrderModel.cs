using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GraduateProject.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class OrderModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("319759c6-d65a-42c9-b201-5ee0601e5048"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8dd08c45-8b66-411e-8ccc-d4d73197b791"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("94c4e072-9e3f-4535-88b4-652362d6c733"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0d307b2a-e9e9-4ca2-9c1a-4f16414ddaf1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("545f70c1-4422-4b8e-b309-a6b20745014c"));

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("1127cdea-dcad-4350-b53f-a07f70d3ee26"), "Description of a book.", "Sam", 24 },
                    { new Guid("c4204024-8247-4588-9df9-7e335497938b"), "Description of a book.", "Bob", 41 },
                    { new Guid("efd27265-0268-4b23-b35b-8e7e234683bd"), "Description of a book.", "Tom", 37 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Login", "Password" },
                values: new object[,]
                {
                    { new Guid("49108f76-0090-4db0-b299-872fe4298426"), "asd", "asd" },
                    { new Guid("6634994b-7dc5-4338-87ea-1590bee5f41f"), "qwe", "qwe" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BookId",
                table: "Orders",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1127cdea-dcad-4350-b53f-a07f70d3ee26"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c4204024-8247-4588-9df9-7e335497938b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("efd27265-0268-4b23-b35b-8e7e234683bd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("49108f76-0090-4db0-b299-872fe4298426"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6634994b-7dc5-4338-87ea-1590bee5f41f"));

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("319759c6-d65a-42c9-b201-5ee0601e5048"), "Description of a book.", "Tom", 37 },
                    { new Guid("8dd08c45-8b66-411e-8ccc-d4d73197b791"), "Description of a book.", "Sam", 24 },
                    { new Guid("94c4e072-9e3f-4535-88b4-652362d6c733"), "Description of a book.", "Bob", 41 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Login", "Password" },
                values: new object[,]
                {
                    { new Guid("0d307b2a-e9e9-4ca2-9c1a-4f16414ddaf1"), "qwe", "qwe" },
                    { new Guid("545f70c1-4422-4b8e-b309-a6b20745014c"), "asd", "asd" }
                });
        }
    }
}
