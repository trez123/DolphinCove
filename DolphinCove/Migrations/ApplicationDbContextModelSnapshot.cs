﻿// <auto-generated />
using System;
using DolphinCove.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DolphinCove.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DolphinCove.Models.Addon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddonImage1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddonName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("AddonPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Addons");
                });

            modelBuilder.Entity("DolphinCove.Models.Cruise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CruiseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cruises");
                });

            modelBuilder.Entity("DolphinCove.Models.Experience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("AdultPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ChildPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ExperienceAddonsId")
                        .HasColumnType("int");

                    b.Property<string>("ExperienceImage1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExperienceImage2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExperienceImage3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExperienceImage4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExperienceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParkId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExperienceAddonsId");

                    b.HasIndex("ParkId");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("DolphinCove.Models.ExperienceAddon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AddonId")
                        .HasColumnType("int");

                    b.Property<int?>("ExperienceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddonId");

                    b.HasIndex("ExperienceId");

                    b.ToTable("ExperienceAddons");
                });

            modelBuilder.Entity("DolphinCove.Models.Guest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MasterReservationId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MasterReservationId");

                    b.ToTable("Guests");
                });

            modelBuilder.Entity("DolphinCove.Models.MasterReservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdultParticipant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("BoolCruise")
                        .HasColumnType("bit");

                    b.Property<string>("ChildParticipant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("FinalTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("GuestId")
                        .HasColumnType("int");

                    b.Property<string>("InfantParticipant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecialInstruction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SubReservationId")
                        .HasColumnType("int");

                    b.Property<decimal?>("SubTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("UndiscountedTotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("GuestId");

                    b.HasIndex("SubReservationId");

                    b.ToTable("MasterReservations");
                });

            modelBuilder.Entity("DolphinCove.Models.Park", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DropdownImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParkName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Parks");
                });

            modelBuilder.Entity("DolphinCove.Models.ParkExperience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ExperienceId")
                        .HasColumnType("int");

                    b.Property<int?>("ParkId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExperienceId");

                    b.HasIndex("ParkId");

                    b.ToTable("ParkExperiences");
                });

            modelBuilder.Entity("DolphinCove.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("GuestId")
                        .HasColumnType("int");

                    b.Property<int>("MasterReservationId")
                        .HasColumnType("int");

                    b.Property<int?>("PromoCodeId")
                        .HasColumnType("int");

                    b.Property<int?>("SubReservationId")
                        .HasColumnType("int");

                    b.Property<decimal>("SubTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("GuestId");

                    b.HasIndex("MasterReservationId");

                    b.HasIndex("PromoCodeId");

                    b.HasIndex("SubReservationId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("DolphinCove.Models.PromotionCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("PromoCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PromoPercent")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("PromotionCodes");
                });

            modelBuilder.Entity("DolphinCove.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AvailableTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("DolphinCove.Models.SubReservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AddonId")
                        .HasColumnType("int");

                    b.Property<int?>("CruiseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ExperienceId")
                        .HasColumnType("int");

                    b.Property<int?>("ParkId")
                        .HasColumnType("int");

                    b.Property<int?>("PromoCodeId")
                        .HasColumnType("int");

                    b.Property<int?>("ScheduleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddonId");

                    b.HasIndex("CruiseId");

                    b.HasIndex("ExperienceId");

                    b.HasIndex("ParkId");

                    b.HasIndex("PromoCodeId");

                    b.HasIndex("ScheduleId");

                    b.ToTable("SubReservations");
                });

            modelBuilder.Entity("DolphinCove.Models.Experience", b =>
                {
                    b.HasOne("DolphinCove.Models.ExperienceAddon", "ExperienceAddons")
                        .WithMany()
                        .HasForeignKey("ExperienceAddonsId");

                    b.HasOne("DolphinCove.Models.Park", "Park")
                        .WithMany()
                        .HasForeignKey("ParkId");

                    b.Navigation("ExperienceAddons");

                    b.Navigation("Park");
                });

            modelBuilder.Entity("DolphinCove.Models.ExperienceAddon", b =>
                {
                    b.HasOne("DolphinCove.Models.Addon", "Addon")
                        .WithMany()
                        .HasForeignKey("AddonId");

                    b.HasOne("DolphinCove.Models.Experience", "Experience")
                        .WithMany()
                        .HasForeignKey("ExperienceId");

                    b.Navigation("Addon");

                    b.Navigation("Experience");
                });

            modelBuilder.Entity("DolphinCove.Models.Guest", b =>
                {
                    b.HasOne("DolphinCove.Models.MasterReservation", "MasterReservation")
                        .WithMany()
                        .HasForeignKey("MasterReservationId");

                    b.Navigation("MasterReservation");
                });

            modelBuilder.Entity("DolphinCove.Models.MasterReservation", b =>
                {
                    b.HasOne("DolphinCove.Models.Guest", "Guest")
                        .WithMany()
                        .HasForeignKey("GuestId");

                    b.HasOne("DolphinCove.Models.SubReservation", "SubReservation")
                        .WithMany()
                        .HasForeignKey("SubReservationId");

                    b.Navigation("Guest");

                    b.Navigation("SubReservation");
                });

            modelBuilder.Entity("DolphinCove.Models.ParkExperience", b =>
                {
                    b.HasOne("DolphinCove.Models.Experience", "Experience")
                        .WithMany()
                        .HasForeignKey("ExperienceId");

                    b.HasOne("DolphinCove.Models.Park", "Park")
                        .WithMany()
                        .HasForeignKey("ParkId");

                    b.Navigation("Experience");

                    b.Navigation("Park");
                });

            modelBuilder.Entity("DolphinCove.Models.Payment", b =>
                {
                    b.HasOne("DolphinCove.Models.Guest", "Guest")
                        .WithMany()
                        .HasForeignKey("GuestId");

                    b.HasOne("DolphinCove.Models.MasterReservation", "MasterReservation")
                        .WithMany()
                        .HasForeignKey("MasterReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DolphinCove.Models.PromotionCode", "PromotionCode")
                        .WithMany()
                        .HasForeignKey("PromoCodeId");

                    b.HasOne("DolphinCove.Models.SubReservation", "SubReservation")
                        .WithMany()
                        .HasForeignKey("SubReservationId");

                    b.Navigation("Guest");

                    b.Navigation("MasterReservation");

                    b.Navigation("PromotionCode");

                    b.Navigation("SubReservation");
                });

            modelBuilder.Entity("DolphinCove.Models.SubReservation", b =>
                {
                    b.HasOne("DolphinCove.Models.Addon", "Addon")
                        .WithMany()
                        .HasForeignKey("AddonId");

                    b.HasOne("DolphinCove.Models.Cruise", "Cruise")
                        .WithMany()
                        .HasForeignKey("CruiseId");

                    b.HasOne("DolphinCove.Models.Experience", "Experience")
                        .WithMany()
                        .HasForeignKey("ExperienceId");

                    b.HasOne("DolphinCove.Models.Park", "Park")
                        .WithMany()
                        .HasForeignKey("ParkId");

                    b.HasOne("DolphinCove.Models.PromotionCode", "PromotionCode")
                        .WithMany()
                        .HasForeignKey("PromoCodeId");

                    b.HasOne("DolphinCove.Models.Schedule", "Schedule")
                        .WithMany()
                        .HasForeignKey("ScheduleId");

                    b.Navigation("Addon");

                    b.Navigation("Cruise");

                    b.Navigation("Experience");

                    b.Navigation("Park");

                    b.Navigation("PromotionCode");

                    b.Navigation("Schedule");
                });
#pragma warning restore 612, 618
        }
    }
}
