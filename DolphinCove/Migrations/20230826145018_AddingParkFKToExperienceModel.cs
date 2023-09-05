using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DolphinCove.Migrations
{
    /// <inheritdoc />
    public partial class AddingParkFKToExperienceModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParkId",
                table: "Experiences",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_ParkId",
                table: "Experiences",
                column: "ParkId");

            migrationBuilder.AddForeignKey(
                name: "FK_Experiences_Parks_ParkId",
                table: "Experiences",
                column: "ParkId",
                principalTable: "Parks",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Experiences_Parks_ParkId",
                table: "Experiences");

            migrationBuilder.DropIndex(
                name: "IX_Experiences_ParkId",
                table: "Experiences");

            migrationBuilder.DropColumn(
                name: "ParkId",
                table: "Experiences");
        }
    }
}
