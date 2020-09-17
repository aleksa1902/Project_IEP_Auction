using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectIepAuction.Migrations
{
    public partial class FixBids : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bids_AspNetUsers_userId",
                table: "Bids");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bids",
                table: "Bids");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a28dc680-c5f6-4bf6-8c11-507d4cc37c72");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "df956c98-82db-4fed-9465-64b4b78f1b2d");

            migrationBuilder.AlterColumn<string>(
                name: "userId",
                table: "Bids",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Bids",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bids",
                table: "Bids",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1a06dff5-af40-426a-be55-b3af83b4f93d", "2a92dd85-9731-412d-a429-9a312a138e45", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e012f0f4-75f4-44e3-afae-d05ec5809b27", "6cf9e9f0-a1f7-40f4-a03a-0f4759f507b3", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_Bids_userId",
                table: "Bids",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bids_AspNetUsers_userId",
                table: "Bids",
                column: "userId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bids_AspNetUsers_userId",
                table: "Bids");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bids",
                table: "Bids");

            migrationBuilder.DropIndex(
                name: "IX_Bids_userId",
                table: "Bids");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a06dff5-af40-426a-be55-b3af83b4f93d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e012f0f4-75f4-44e3-afae-d05ec5809b27");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Bids");

            migrationBuilder.AlterColumn<string>(
                name: "userId",
                table: "Bids",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bids",
                table: "Bids",
                columns: new[] { "userId", "auctionId" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a28dc680-c5f6-4bf6-8c11-507d4cc37c72", "37c3c944-da05-4266-a195-62715dc68119", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "df956c98-82db-4fed-9465-64b4b78f1b2d", "429754f4-77e8-4874-bc56-78c9e0b9ac0f", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.AddForeignKey(
                name: "FK_Bids_AspNetUsers_userId",
                table: "Bids",
                column: "userId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
