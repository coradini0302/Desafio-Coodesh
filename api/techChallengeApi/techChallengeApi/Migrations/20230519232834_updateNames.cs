using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace techChallengeApi.Migrations
{
    /// <inheritdoc />
    public partial class updateNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GeneralSales_Products_ProductsId",
                table: "GeneralSales");

            migrationBuilder.RenameColumn(
                name: "ProductsId",
                table: "GeneralSales",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_GeneralSales_ProductsId",
                table: "GeneralSales",
                newName: "IX_GeneralSales_ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_GeneralSales_Products_ProductId",
                table: "GeneralSales",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GeneralSales_Products_ProductId",
                table: "GeneralSales");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "GeneralSales",
                newName: "ProductsId");

            migrationBuilder.RenameIndex(
                name: "IX_GeneralSales_ProductId",
                table: "GeneralSales",
                newName: "IX_GeneralSales_ProductsId");

            migrationBuilder.AddForeignKey(
                name: "FK_GeneralSales_Products_ProductsId",
                table: "GeneralSales",
                column: "ProductsId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
