using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DolphinCove.Migrations
{
    public partial class addImageFieldsForExperienceAndAddonAndAddedAParkRelationshipInReservationToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParkId",
                table: "Reservations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExperienceImage1",
                table: "Experiences",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExperienceImage2",
                table: "Experiences",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExperienceImage3",
                table: "Experiences",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExperienceImage4",
                table: "Experiences",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddonImage1",
                table: "Addons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ParkId",
                table: "Reservations",
                column: "ParkId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Parks_ParkId",
                table: "Reservations",
                column: "ParkId",
                principalTable: "Parks",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Parks_ParkId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_ParkId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "EmailAddress",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "ParkId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "ExperienceImage1",
                table: "Experiences");

            migrationBuilder.DropColumn(
                name: "ExperienceImage2",
                table: "Experiences");

            migrationBuilder.DropColumn(
                name: "ExperienceImage3",
                table: "Experiences");

            migrationBuilder.DropColumn(
                name: "ExperienceImage4",
                table: "Experiences");

            migrationBuilder.DropColumn(
                name: "AddonImage1",
                table: "Addons");
        }
    }
}
