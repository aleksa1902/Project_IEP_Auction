using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectIepAuction.Migrations
{
    public partial class AuctionAndBids : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TokenTransaction_BagToken_bagId",
                table: "TokenTransaction");

            migrationBuilder.DropForeignKey(
                name: "FK_TokenTransaction_AspNetUsers_userId",
                table: "TokenTransaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TokenTransaction",
                table: "TokenTransaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BagToken",
                table: "BagToken");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "480e0d5a-e097-4a40-8b05-8030658927c0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c5b964e-edd0-46c0-9c37-abdd82e255c7");

            migrationBuilder.RenameTable(
                name: "TokenTransaction",
                newName: "TokenTransactions");

            migrationBuilder.RenameTable(
                name: "BagToken",
                newName: "BagTokens");

            migrationBuilder.RenameIndex(
                name: "IX_TokenTransaction_userId",
                table: "TokenTransactions",
                newName: "IX_TokenTransactions_userId");

            migrationBuilder.RenameIndex(
                name: "IX_TokenTransaction_bagId",
                table: "TokenTransactions",
                newName: "IX_TokenTransactions_bagId");

            migrationBuilder.AlterColumn<int>(
                name: "tokens",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "state",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "Active",
                oldClrType: typeof(string),
                oldType: "nvarchar(1)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TokenTransactions",
                table: "TokenTransactions",
                column: "IdTra");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BagTokens",
                table: "BagTokens",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Auctions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: false),
                    description = table.Column<string>(nullable: false),
                    image = table.Column<byte[]>(nullable: false),
                    startPrice = table.Column<int>(nullable: false),
                    currentPrice = table.Column<int>(nullable: false),
                    createDate = table.Column<DateTime>(nullable: false),
                    openDate = table.Column<DateTime>(nullable: false),
                    closeDate = table.Column<DateTime>(nullable: false),
                    state = table.Column<string>(nullable: false),
                    winnerId = table.Column<string>(nullable: true),
                    ownerId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auctions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Auctions_AspNetUsers_ownerId",
                        column: x => x.ownerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Auctions_AspNetUsers_winnerId",
                        column: x => x.winnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bids",
                columns: table => new
                {
                    userId = table.Column<string>(nullable: false),
                    auctionId = table.Column<int>(nullable: false),
                    price = table.Column<int>(nullable: false),
                    bidDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bids", x => new { x.userId, x.auctionId });
                    table.ForeignKey(
                        name: "FK_Bids_Auctions_auctionId",
                        column: x => x.auctionId,
                        principalTable: "Auctions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bids_AspNetUsers_userId",
                        column: x => x.userId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "87342dfd-f458-427b-be03-3d77ca4f8a7c", "1c548340-da5c-409b-a84c-6c961c699d56", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "055448d3-0a05-459a-8a88-8a3f6794cb2b", "0b2be5f4-352c-4664-96c2-5650cdde8bbb", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_Auctions_ownerId",
                table: "Auctions",
                column: "ownerId");

            migrationBuilder.CreateIndex(
                name: "IX_Auctions_winnerId",
                table: "Auctions",
                column: "winnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Bids_auctionId",
                table: "Bids",
                column: "auctionId");

            migrationBuilder.AddForeignKey(
                name: "FK_TokenTransactions_BagTokens_bagId",
                table: "TokenTransactions",
                column: "bagId",
                principalTable: "BagTokens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TokenTransactions_AspNetUsers_userId",
                table: "TokenTransactions",
                column: "userId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TokenTransactions_BagTokens_bagId",
                table: "TokenTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_TokenTransactions_AspNetUsers_userId",
                table: "TokenTransactions");

            migrationBuilder.DropTable(
                name: "Bids");

            migrationBuilder.DropTable(
                name: "Auctions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TokenTransactions",
                table: "TokenTransactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BagTokens",
                table: "BagTokens");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "055448d3-0a05-459a-8a88-8a3f6794cb2b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87342dfd-f458-427b-be03-3d77ca4f8a7c");

            migrationBuilder.RenameTable(
                name: "TokenTransactions",
                newName: "TokenTransaction");

            migrationBuilder.RenameTable(
                name: "BagTokens",
                newName: "BagToken");

            migrationBuilder.RenameIndex(
                name: "IX_TokenTransactions_userId",
                table: "TokenTransaction",
                newName: "IX_TokenTransaction_userId");

            migrationBuilder.RenameIndex(
                name: "IX_TokenTransactions_bagId",
                table: "TokenTransaction",
                newName: "IX_TokenTransaction_bagId");

            migrationBuilder.AlterColumn<int>(
                name: "tokens",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "state",
                table: "AspNetUsers",
                type: "nvarchar(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldDefaultValue: "Active");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TokenTransaction",
                table: "TokenTransaction",
                column: "IdTra");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BagToken",
                table: "BagToken",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6c5b964e-edd0-46c0-9c37-abdd82e255c7", "4bb31c30-e815-403a-bd59-a2c590ecb80b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "480e0d5a-e097-4a40-8b05-8030658927c0", "2d0a4b42-6830-4dc7-9098-06087d925cf0", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.AddForeignKey(
                name: "FK_TokenTransaction_BagToken_bagId",
                table: "TokenTransaction",
                column: "bagId",
                principalTable: "BagToken",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TokenTransaction_AspNetUsers_userId",
                table: "TokenTransaction",
                column: "userId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
