using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace les_petits_cakes.Migrations
{
    /// <inheritdoc />
    public partial class c5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "OrderItems");

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
    }
}
