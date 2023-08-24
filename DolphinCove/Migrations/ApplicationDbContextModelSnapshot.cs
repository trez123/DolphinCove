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

                    b.Property<string>("ExperienceImage1")
                        .IsRequired()
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

                    b.Property<decimal>("ExperiencePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ParkId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParkId");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("DolphinCove.Models.Park", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ExperienceId1")
                        .HasColumnType("int");

                    b.Property<int?>("ExperienceId2")
                        .HasColumnType("int");

                    b.Property<int?>("ExperienceId3")
                        .HasColumnType("int");

                    b.Property<int?>("ExperienceId4")
                        .HasColumnType("int");

                    b.Property<int?>("ExperienceId5")
                        .HasColumnType("int");

                    b.Property<int?>("ExperienceId6")
                        .HasColumnType("int");

                    b.Property<int?>("ExperienceId7")
                        .HasColumnType("int");

                    b.Property<int?>("ExperienceId8")
                        .HasColumnType("int");

                    b.Property<string>("ParkName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ExperienceId1");

                    b.HasIndex("ExperienceId2");

                    b.HasIndex("ExperienceId3");

                    b.HasIndex("ExperienceId4");

                    b.HasIndex("ExperienceId5");

                    b.HasIndex("ExperienceId6");

                    b.HasIndex("ExperienceId7");

                    b.HasIndex("ExperienceId8");

                    b.ToTable("Parks");
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

            modelBuilder.Entity("DolphinCove.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AddonId")
                        .HasColumnType("int");

                    b.Property<string>("AdultParticipant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("BoolCruise")
                        .HasColumnType("bit");

                    b.Property<string>("ChildParticipant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CruiseId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ExperienceId")
                        .HasColumnType("int");

                    b.Property<decimal?>("FinalTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InfantParticipant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParkId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PromotionCodeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Schedule")
                        .HasColumnType("datetime2");

                    b.Property<string>("SpecialInstruction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("UndiscountedTotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("AddonId");

                    b.HasIndex("CruiseId");

                    b.HasIndex("ExperienceId");

                    b.HasIndex("ParkId");

                    b.HasIndex("PromotionCodeId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("DolphinCove.Models.Experience", b =>
                {
                    b.HasOne("DolphinCove.Models.Park", null)
                        .WithMany("Experiences")
                        .HasForeignKey("ParkId");
                });

            modelBuilder.Entity("DolphinCove.Models.Park", b =>
                {
                    b.HasOne("DolphinCove.Models.Experience", "Experience1")
                        .WithMany()
                        .HasForeignKey("ExperienceId1");

                    b.HasOne("DolphinCove.Models.Experience", "Experience2")
                        .WithMany()
                        .HasForeignKey("ExperienceId2");

                    b.HasOne("DolphinCove.Models.Experience", "Experience3")
                        .WithMany()
                        .HasForeignKey("ExperienceId3");

                    b.HasOne("DolphinCove.Models.Experience", "Experience4")
                        .WithMany()
                        .HasForeignKey("ExperienceId4");

                    b.HasOne("DolphinCove.Models.Experience", "Experience5")
                        .WithMany()
                        .HasForeignKey("ExperienceId5");

                    b.HasOne("DolphinCove.Models.Experience", "Experience6")
                        .WithMany()
                        .HasForeignKey("ExperienceId6");

                    b.HasOne("DolphinCove.Models.Experience", "Experience7")
                        .WithMany()
                        .HasForeignKey("ExperienceId7");

                    b.HasOne("DolphinCove.Models.Experience", "Experience8")
                        .WithMany()
                        .HasForeignKey("ExperienceId8");

                    b.Navigation("Experience1");

                    b.Navigation("Experience2");

                    b.Navigation("Experience3");

                    b.Navigation("Experience4");

                    b.Navigation("Experience5");

                    b.Navigation("Experience6");

                    b.Navigation("Experience7");

                    b.Navigation("Experience8");
                });

            modelBuilder.Entity("DolphinCove.Models.Reservation", b =>
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
                        .HasForeignKey("PromotionCodeId");

                    b.Navigation("Addon");

                    b.Navigation("Cruise");

                    b.Navigation("Experience");

                    b.Navigation("Park");

                    b.Navigation("PromotionCode");
                });

            modelBuilder.Entity("DolphinCove.Models.Park", b =>
                {
                    b.Navigation("Experiences");
                });
#pragma warning restore 612, 618
        }
    }
}
