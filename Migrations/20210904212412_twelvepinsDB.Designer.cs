﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using twelve_pins.Models;

namespace twelve_pins.Migrations
{
    [DbContext(typeof(TwelvePinsContext))]
    [Migration("20210904212412_twelvepinsDB")]
    partial class twelvepinsDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("ReservedLane", b =>
                {
                    b.Property<int>("ReservedLaneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("LaneId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReserveDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ReservedLaneId");

                    b.HasIndex("LaneId");

                    b.HasIndex("UserId");

                    b.ToTable("ReservedLanes");
                });

            modelBuilder.Entity("twelve_pins.Models.Lane", b =>
                {
                    b.Property<int>("LaneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("BumperRequired")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("LaneNumber")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LaneId");

                    b.HasIndex("UserId");

                    b.ToTable("Lanes");
                });

            modelBuilder.Entity("twelve_pins.Models.League", b =>
                {
                    b.Property<int>("LeagueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LeagueId");

                    b.HasIndex("UserId");

                    b.ToTable("Leagues");
                });

            modelBuilder.Entity("twelve_pins.Models.Party", b =>
                {
                    b.Property<int>("PartyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("BumperRequired")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Comments")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("PartyDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("PartyType")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("PartyId");

                    b.HasIndex("UserId");

                    b.ToTable("Parties");
                });

            modelBuilder.Entity("twelve_pins.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ReservedLane", b =>
                {
                    b.HasOne("twelve_pins.Models.Lane", "Lane")
                        .WithMany()
                        .HasForeignKey("LaneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("twelve_pins.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lane");

                    b.Navigation("User");
                });

            modelBuilder.Entity("twelve_pins.Models.Lane", b =>
                {
                    b.HasOne("twelve_pins.Models.User", null)
                        .WithMany("Lanes")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("twelve_pins.Models.League", b =>
                {
                    b.HasOne("twelve_pins.Models.User", null)
                        .WithMany("Leagues")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("twelve_pins.Models.Party", b =>
                {
                    b.HasOne("twelve_pins.Models.User", null)
                        .WithMany("Parties")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("twelve_pins.Models.User", b =>
                {
                    b.Navigation("Lanes");

                    b.Navigation("Leagues");

                    b.Navigation("Parties");
                });
#pragma warning restore 612, 618
        }
    }
}