using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace les_petits_cakes.Migrations
{
    /// <inheritdoc />
    public partial class c3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderModelId",
                table: "OrderItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderModelId",
                table: "OrderItems",
                column: "OrderModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderModelId",
                table: "OrderItems",
                column: "OrderModelId",
                principalTable: "Orders",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderModelId",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_OrderModelId",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "OrderModelId",
                table: "OrderItems");
        }
    }
}
