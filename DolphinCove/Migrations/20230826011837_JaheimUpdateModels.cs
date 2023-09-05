using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DolphinCove.Migrations
{
    /// <inheritdoc />
    public partial class JaheimUpdateModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "SelectedParkExperiences");

            migrationBuilder.RenameColumn(
                name: "ExperiencePrice",
                table: "Experiences",
                newName: "ChildPrice");

            migrationBuilder.AddColumn<decimal>(
                name: "AdultPrice",
                table: "Experiences",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "ExperienceAddonsId",
                table: "Experiences",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ExperienceAddons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExperienceId = table.Column<int>(type: "int", nullable: true),
                    AddonId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperienceAddons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExperienceAddons_Addons_AddonId",
                        column: x => x.AddonId,
                        principalTable: "Addons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ExperienceAddons_Experiences_ExperienceId",
                        column: x => x.ExperienceId,
                        principalTable: "Experiences",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AvailableTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubReservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ParkId = table.Column<int>(type: "int", nullable: true),
                    ExperienceId = table.Column<int>(type: "int", nullable: true),
                    ScheduleId = table.Column<int>(type: "int", nullable: true),
                    AddonId = table.Column<int>(type: "int", nullable: true),
                    CruiseId = table.Column<int>(type: "int", nullable: true),
                    PromoCodeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubReservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubReservations_Addons_AddonId",
                        column: x => x.AddonId,
                        principalTable: "Addons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SubReservations_Cruises_CruiseId",
                        column: x => x.CruiseId,
                        principalTable: "Cruises",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SubReservations_Experiences_ExperienceId",
                        column: x => x.ExperienceId,
                        principalTable: "Experiences",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SubReservations_Parks_ParkId",
                        column: x => x.ParkId,
                        principalTable: "Parks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SubReservations_PromotionCodes_PromoCodeId",
                        column: x => x.PromoCodeId,
                        principalTable: "PromotionCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SubReservations_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterReservationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MasterReservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdultParticipant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChildParticipant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InfantParticipant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    UndiscountedTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FinalTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SpecialInstruction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoolCruise = table.Column<bool>(type: "bit", nullable: true),
                    GuestId = table.Column<int>(type: "int", nullable: true),
                    SubReservationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterReservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MasterReservations_Guests_GuestId",
                        column: x => x.GuestId,
                        principalTable: "Guests",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MasterReservations_SubReservations_SubReservationId",
                        column: x => x.SubReservationId,
                        principalTable: "SubReservations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GuestId = table.Column<int>(type: "int", nullable: true),
                    MasterReservationId = table.Column<int>(type: "int", nullable: false),
                    SubReservationId = table.Column<int>(type: "int", nullable: true),
                    PromoCodeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Guests_GuestId",
                        column: x => x.GuestId,
                        principalTable: "Guests",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Payments_MasterReservations_MasterReservationId",
                        column: x => x.MasterReservationId,
                        principalTable: "MasterReservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_PromotionCodes_PromoCodeId",
                        column: x => x.PromoCodeId,
                        principalTable: "PromotionCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Payments_SubReservations_SubReservationId",
                        column: x => x.SubReservationId,
                        principalTable: "SubReservations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_ExperienceAddonsId",
                table: "Experiences",
                column: "ExperienceAddonsId");

            migrationBuilder.CreateIndex(
                name: "IX_ExperienceAddons_AddonId",
                table: "ExperienceAddons",
                column: "AddonId");

            migrationBuilder.CreateIndex(
                name: "IX_ExperienceAddons_ExperienceId",
                table: "ExperienceAddons",
                column: "ExperienceId");

            migrationBuilder.CreateIndex(
                name: "IX_Guests_MasterReservationId",
                table: "Guests",
                column: "MasterReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_MasterReservations_GuestId",
                table: "MasterReservations",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_MasterReservations_SubReservationId",
                table: "MasterReservations",
                column: "SubReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_GuestId",
                table: "Payments",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_MasterReservationId",
                table: "Payments",
                column: "MasterReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PromoCodeId",
                table: "Payments",
                column: "PromoCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_SubReservationId",
                table: "Payments",
                column: "SubReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_SubReservations_AddonId",
                table: "SubReservations",
                column: "AddonId");

            migrationBuilder.CreateIndex(
                name: "IX_SubReservations_CruiseId",
                table: "SubReservations",
                column: "CruiseId");

            migrationBuilder.CreateIndex(
                name: "IX_SubReservations_ExperienceId",
                table: "SubReservations",
                column: "ExperienceId");

            migrationBuilder.CreateIndex(
                name: "IX_SubReservations_ParkId",
                table: "SubReservations",
                column: "ParkId");

            migrationBuilder.CreateIndex(
                name: "IX_SubReservations_PromoCodeId",
                table: "SubReservations",
                column: "PromoCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_SubReservations_ScheduleId",
                table: "SubReservations",
                column: "ScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Experiences_ExperienceAddons_ExperienceAddonsId",
                table: "Experiences",
                column: "ExperienceAddonsId",
                principalTable: "ExperienceAddons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Guests_MasterReservations_MasterReservationId",
                table: "Guests",
                column: "MasterReservationId",
                principalTable: "MasterReservations",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Experiences_ExperienceAddons_ExperienceAddonsId",
                table: "Experiences");

            migrationBuilder.DropForeignKey(
                name: "FK_Guests_MasterReservations_MasterReservationId",
                table: "Guests");

            migrationBuilder.DropTable(
                name: "ExperienceAddons");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "MasterReservations");

            migrationBuilder.DropTable(
                name: "Guests");

            migrationBuilder.DropTable(
                name: "SubReservations");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Experiences_ExperienceAddonsId",
                table: "Experiences");

            migrationBuilder.DropColumn(
                name: "AdultPrice",
                table: "Experiences");

            migrationBuilder.DropColumn(
                name: "ExperienceAddonsId",
                table: "Experiences");

            migrationBuilder.RenameColumn(
                name: "ChildPrice",
                table: "Experiences",
                newName: "ExperiencePrice");

            migrationBuilder.CreateTable(
                name: "SelectedParkExperiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SelectedExperienceId = table.Column<int>(type: "int", nullable: false),
                    SelectedParkId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedParkExperiences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddonId = table.Column<int>(type: "int", nullable: true),
                    CruiseId = table.Column<int>(type: "int", nullable: true),
                    PromotionCodeId = table.Column<int>(type: "int", nullable: true),
                    SelectedParkExperienceId = table.Column<int>(type: "int", nullable: true),
                    AdultParticipant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoolCruise = table.Column<bool>(type: "bit", nullable: true),
                    ChildParticipant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FinalTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InfantParticipant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Schedule = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SpecialInstruction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UndiscountedTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
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
                        name: "FK_Reservations_PromotionCodes_PromotionCodeId",
                        column: x => x.PromotionCodeId,
                        principalTable: "PromotionCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reservations_SelectedParkExperiences_SelectedParkExperienceId",
                        column: x => x.SelectedParkExperienceId,
                        principalTable: "SelectedParkExperiences",
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
                name: "IX_Reservations_PromotionCodeId",
                table: "Reservations",
                column: "PromotionCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_SelectedParkExperienceId",
                table: "Reservations",
                column: "SelectedParkExperienceId");
        }
    }
}
