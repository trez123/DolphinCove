using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DolphinCove.Migrations
{
    /// <inheritdoc />
    public partial class addParkExperienceToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParkExperience_Experiences_ExperienceId",
                table: "ParkExperience");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkExperience_Parks_ParkId",
                table: "ParkExperience");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_ParkExperience_ParkExperienceId",
                table: "Reservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ParkExperience",
                table: "ParkExperience");

            migrationBuilder.RenameTable(
                name: "ParkExperience",
                newName: "ParkExperiences");

            migrationBuilder.RenameIndex(
                name: "IX_ParkExperience_ParkId",
                table: "ParkExperiences",
                newName: "IX_ParkExperiences_ParkId");

            migrationBuilder.RenameIndex(
                name: "IX_ParkExperience_ExperienceId",
                table: "ParkExperiences",
                newName: "IX_ParkExperiences_ExperienceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParkExperiences",
                table: "ParkExperiences",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ParkExperiences_Experiences_ExperienceId",
                table: "ParkExperiences",
                column: "ExperienceId",
                principalTable: "Experiences",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ParkExperiences_Parks_ParkId",
                table: "ParkExperiences",
                column: "ParkId",
                principalTable: "Parks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_ParkExperiences_ParkExperienceId",
                table: "Reservations",
                column: "ParkExperienceId",
                principalTable: "ParkExperiences",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParkExperiences_Experiences_ExperienceId",
                table: "ParkExperiences");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkExperiences_Parks_ParkId",
                table: "ParkExperiences");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_ParkExperiences_ParkExperienceId",
                table: "Reservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ParkExperiences",
                table: "ParkExperiences");

            migrationBuilder.RenameTable(
                name: "ParkExperiences",
                newName: "ParkExperience");

            migrationBuilder.RenameIndex(
                name: "IX_ParkExperiences_ParkId",
                table: "ParkExperience",
                newName: "IX_ParkExperience_ParkId");

            migrationBuilder.RenameIndex(
                name: "IX_ParkExperiences_ExperienceId",
                table: "ParkExperience",
                newName: "IX_ParkExperience_ExperienceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParkExperience",
                table: "ParkExperience",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ParkExperience_Experiences_ExperienceId",
                table: "ParkExperience",
                column: "ExperienceId",
                principalTable: "Experiences",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ParkExperience_Parks_ParkId",
                table: "ParkExperience",
                column: "ParkId",
                principalTable: "Parks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_ParkExperience_ParkExperienceId",
                table: "Reservations",
                column: "ParkExperienceId",
                principalTable: "ParkExperience",
                principalColumn: "Id");
        }
    }
}
