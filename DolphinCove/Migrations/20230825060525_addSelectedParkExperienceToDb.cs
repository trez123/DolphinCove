using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DolphinCove.Migrations
{
    /// <inheritdoc />
    public partial class addSelectedParkExperienceToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_ParkExperiences_ParkExperienceId",
                table: "Reservations");

            migrationBuilder.RenameColumn(
                name: "ParkExperienceId",
                table: "Reservations",
                newName: "SelectedParkExperienceId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_ParkExperienceId",
                table: "Reservations",
                newName: "IX_Reservations_SelectedParkExperienceId");

            migrationBuilder.CreateTable(
                name: "SelectedParkExperiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SelectedParkId = table.Column<int>(type: "int", nullable: false),
                    SelectedExperienceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedParkExperiences", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_SelectedParkExperiences_SelectedParkExperienceId",
                table: "Reservations",
                column: "SelectedParkExperienceId",
                principalTable: "SelectedParkExperiences",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_SelectedParkExperiences_SelectedParkExperienceId",
                table: "Reservations");

            migrationBuilder.DropTable(
                name: "SelectedParkExperiences");

            migrationBuilder.RenameColumn(
                name: "SelectedParkExperienceId",
                table: "Reservations",
                newName: "ParkExperienceId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservations_SelectedParkExperienceId",
                table: "Reservations",
                newName: "IX_Reservations_ParkExperienceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_ParkExperiences_ParkExperienceId",
                table: "Reservations",
                column: "ParkExperienceId",
                principalTable: "ParkExperiences",
                principalColumn: "Id");
        }
    }
}
