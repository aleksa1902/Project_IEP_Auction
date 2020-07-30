using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectIepAuction.Migrations
{
    public partial class tokenBag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18eff6e8-20e9-46b7-ac69-c5f5fcd1efd9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c2e82ca-0d75-4b34-99bd-8370e9683685");

            migrationBuilder.DropColumn(
                name: "sex",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "gender",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "BagToken",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bagName = table.Column<string>(nullable: false),
                    amount = table.Column<int>(nullable: false),
                    price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BagToken", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TokenTransaction",
                columns: table => new
                {
                    IdTra = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    purchaseDate = table.Column<DateTime>(nullable: false),
                    userId = table.Column<string>(nullable: true),
                    bagId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TokenTransaction", x => x.IdTra);
                    table.ForeignKey(
                        name: "FK_TokenTransaction_BagToken_bagId",
                        column: x => x.bagId,
                        principalTable: "BagToken",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TokenTransaction_AspNetUsers_userId",
                        column: x => x.userId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6c5b964e-edd0-46c0-9c37-abdd82e255c7", "4bb31c30-e815-403a-bd59-a2c590ecb80b", "User", "USER" },
                    { "480e0d5a-e097-4a40-8b05-8030658927c0", "2d0a4b42-6830-4dc7-9098-06087d925cf0", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "BagToken",
                columns: new[] { "Id", "amount", "bagName", "price" },
                values: new object[,]
                {
                    { 1, 5, "Silver", 4.9900000000000002 },
                    { 2, 10, "Gold", 9.9900000000000002 },
                    { 3, 20, "Platinum", 17.989999999999998 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TokenTransaction_bagId",
                table: "TokenTransaction",
                column: "bagId");

            migrationBuilder.CreateIndex(
                name: "IX_TokenTransaction_userId",
                table: "TokenTransaction",
                column: "userId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TokenTransaction");

            migrationBuilder.DropTable(
                name: "BagToken");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "480e0d5a-e097-4a40-8b05-8030658927c0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c5b964e-edd0-46c0-9c37-abdd82e255c7");

            migrationBuilder.DropColumn(
                name: "gender",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "sex",
                table: "AspNetUsers",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8c2e82ca-0d75-4b34-99bd-8370e9683685", "39b140b9-5b4f-4734-b263-2c43b6c13409", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "18eff6e8-20e9-46b7-ac69-c5f5fcd1efd9", "45d6e569-a94b-41b3-a575-a246928162ca", "Administrator", "ADMINISTRATOR" });
        }
    }
}
