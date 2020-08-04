using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectIepAuction.Migrations
{
    public partial class TokenTransactionUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TokenTransactions_BagTokens_bagId",
                table: "TokenTransactions");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "055448d3-0a05-459a-8a88-8a3f6794cb2b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87342dfd-f458-427b-be03-3d77ca4f8a7c");

            migrationBuilder.AlterColumn<int>(
                name: "bagId",
                table: "TokenTransactions",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a28dc680-c5f6-4bf6-8c11-507d4cc37c72", "37c3c944-da05-4266-a195-62715dc68119", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "df956c98-82db-4fed-9465-64b4b78f1b2d", "429754f4-77e8-4874-bc56-78c9e0b9ac0f", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.AddForeignKey(
                name: "FK_TokenTransactions_BagTokens_bagId",
                table: "TokenTransactions",
                column: "bagId",
                principalTable: "BagTokens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TokenTransactions_BagTokens_bagId",
                table: "TokenTransactions");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a28dc680-c5f6-4bf6-8c11-507d4cc37c72");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "df956c98-82db-4fed-9465-64b4b78f1b2d");

            migrationBuilder.AlterColumn<int>(
                name: "bagId",
                table: "TokenTransactions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "87342dfd-f458-427b-be03-3d77ca4f8a7c", "1c548340-da5c-409b-a84c-6c961c699d56", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "055448d3-0a05-459a-8a88-8a3f6794cb2b", "0b2be5f4-352c-4664-96c2-5650cdde8bbb", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.AddForeignKey(
                name: "FK_TokenTransactions_BagTokens_bagId",
                table: "TokenTransactions",
                column: "bagId",
                principalTable: "BagTokens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
