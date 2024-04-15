using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesWebMvc.Migrations
{
    /// <inheritdoc />
    public partial class OnDeleteRestrictToSeller : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecord_Seller_SellerId1",
                table: "SalesRecord");

            migrationBuilder.DropIndex(
                name: "IX_SalesRecord_SellerId1",
                table: "SalesRecord");

            migrationBuilder.DropColumn(
                name: "SellerId1",
                table: "SalesRecord");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SellerId1",
                table: "SalesRecord",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SalesRecord_SellerId1",
                table: "SalesRecord",
                column: "SellerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecord_Seller_SellerId1",
                table: "SalesRecord",
                column: "SellerId1",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
