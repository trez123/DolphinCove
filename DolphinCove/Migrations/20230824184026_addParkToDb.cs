using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DolphinCove.Migrations
{
    /// <inheritdoc />
    public partial class addParkToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParkId",
                table: "Experiences",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParkName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExperienceId1 = table.Column<int>(type: "int", nullable: true),
                    ExperienceId2 = table.Column<int>(type: "int", nullable: true),
                    ExperienceId3 = table.Column<int>(type: "int", nullable: true),
                    ExperienceId4 = table.Column<int>(type: "int", nullable: true),
                    ExperienceId5 = table.Column<int>(type: "int", nullable: true),
                    ExperienceId6 = table.Column<int>(type: "int", nullable: true),
                    ExperienceId7 = table.Column<int>(type: "int", nullable: true),
                    ExperienceId8 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parks_Experiences_ExperienceId1",
                        column: x => x.ExperienceId1,
                        principalTable: "Experiences",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Parks_Experiences_ExperienceId2",
                        column: x => x.ExperienceId2,
                        principalTable: "Experiences",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Parks_Experiences_ExperienceId3",
                        column: x => x.ExperienceId3,
                        principalTable: "Experiences",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Parks_Experiences_ExperienceId4",
                        column: x => x.ExperienceId4,
                        principalTable: "Experiences",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Parks_Experiences_ExperienceId5",
                        column: x => x.ExperienceId5,
                        principalTable: "Experiences",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Parks_Experiences_ExperienceId6",
                        column: x => x.ExperienceId6,
                        principalTable: "Experiences",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Parks_Experiences_ExperienceId7",
                        column: x => x.ExperienceId7,
                        principalTable: "Experiences",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Parks_Experiences_ExperienceId8",
                        column: x => x.ExperienceId8,
                        principalTable: "Experiences",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_ParkId",
                table: "Experiences",
                column: "ParkId");

            migrationBuilder.CreateIndex(
                name: "IX_Parks_ExperienceId1",
                table: "Parks",
                column: "ExperienceId1");

            migrationBuilder.CreateIndex(
                name: "IX_Parks_ExperienceId2",
                table: "Parks",
                column: "ExperienceId2");

            migrationBuilder.CreateIndex(
                name: "IX_Parks_ExperienceId3",
                table: "Parks",
                column: "ExperienceId3");

            migrationBuilder.CreateIndex(
                name: "IX_Parks_ExperienceId4",
                table: "Parks",
                column: "ExperienceId4");

            migrationBuilder.CreateIndex(
                name: "IX_Parks_ExperienceId5",
                table: "Parks",
                column: "ExperienceId5");

            migrationBuilder.CreateIndex(
                name: "IX_Parks_ExperienceId6",
                table: "Parks",
                column: "ExperienceId6");

            migrationBuilder.CreateIndex(
                name: "IX_Parks_ExperienceId7",
                table: "Parks",
                column: "ExperienceId7");

            migrationBuilder.CreateIndex(
                name: "IX_Parks_ExperienceId8",
                table: "Parks",
                column: "ExperienceId8");

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

            migrationBuilder.DropTable(
                name: "Parks");

            migrationBuilder.DropIndex(
                name: "IX_Experiences_ParkId",
                table: "Experiences");

            migrationBuilder.DropColumn(
                name: "ParkId",
                table: "Experiences");
        }
    }
}
