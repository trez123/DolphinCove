using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DolphinCove.Migrations
{
    /// <inheritdoc />
    public partial class EverythingToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddonPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AddonImage1 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cruises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CruiseName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cruises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PromotionCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PromoCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PromoPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromotionCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExperienceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExperiencePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExperienceImage1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExperienceImage2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExperienceImage3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExperienceImage4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParkId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.Id);
                });

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
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExperienceId = table.Column<int>(type: "int", nullable: true),
                    PromotionCodeId = table.Column<int>(type: "int", nullable: true),
                    AddonId = table.Column<int>(type: "int", nullable: true),
                    CruiseId = table.Column<int>(type: "int", nullable: true),
                    ParkId = table.Column<int>(type: "int", nullable: true)
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
                        name: "FK_Reservations_Parks_ParkId",
                        column: x => x.ParkId,
                        principalTable: "Parks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reservations_PromotionCodes_PromotionCodeId",
                        column: x => x.PromotionCodeId,
                        principalTable: "PromotionCodes",
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
                name: "IX_Reservations_ParkId",
                table: "Reservations",
                column: "ParkId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_PromotionCodeId",
                table: "Reservations",
                column: "PromotionCodeId");

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
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Addons");

            migrationBuilder.DropTable(
                name: "Cruises");

            migrationBuilder.DropTable(
                name: "PromotionCodes");

            migrationBuilder.DropTable(
                name: "Parks");

            migrationBuilder.DropTable(
                name: "Experiences");
        }
    }
}
