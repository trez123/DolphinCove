using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DolphinCove.Migrations
{
    public partial class addReservationToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Schedule = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AdultParticipant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChildParticipant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InfantParticipant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UndiscountedTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FinalTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SpecialInstruction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoolCruise = table.Column<bool>(type: "bit", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExperienceId = table.Column<int>(type: "int", nullable: true),
                    PromotionCodeId = table.Column<int>(type: "int", nullable: true),
                    AddonId = table.Column<int>(type: "int", nullable: true),
                    CruiseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Addons_AddonId",
                        column: x => x.AddonId,
                        principalTable: "Addons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reservations_Cruises_CruiseId",
                        column: x => x.CruiseId,
                        principalTable: "Cruises",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reservations_Experiences_ExperienceId",
                        column: x => x.ExperienceId,
                        principalTable: "Experiences",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reservations_PromotionCodes_PromotionCodeId",
                        column: x => x.PromotionCodeId,
                        principalTable: "PromotionCodes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_AddonId",
                table: "Reservations",
                column: "AddonId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CruiseId",
                table: "Reservations",
                column: "CruiseId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ExperienceId",
                table: "Reservations",
                column: "ExperienceId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_PromotionCodeId",
                table: "Reservations",
                column: "PromotionCodeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");
        }
    }
}
