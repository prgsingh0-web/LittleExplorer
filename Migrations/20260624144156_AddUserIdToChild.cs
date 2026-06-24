using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToddlerActivityPlanner.Migrations
{
    /// <inheritdoc />
    public partial class AddUserIdToChild : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Children",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Children_UserId",
                table: "Children",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Children_AspNetUsers_UserId",
                table: "Children",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Children_AspNetUsers_UserId",
                table: "Children");

            migrationBuilder.DropIndex(
                name: "IX_Children_UserId",
                table: "Children");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Children");
        }
    }
}
