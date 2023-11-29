﻿// <auto-generated />
using System;
using HarryPotterAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HarryPotterAPI.Migrations
{
    [DbContext(typeof(HarryPotterContext))]
    partial class HarryPotterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("HarryPotterAPI.Models.CharacterModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<string>("House")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsWitcher")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("id");

                    b.ToTable("characters");
                });

            modelBuilder.Entity("HarryPotterAPI.Models.WandModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<string>("Core")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<double>("Size")
                        .HasColumnType("double");

                    b.Property<string>("Wood")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("id");

                    b.HasIndex("CharacterId")
                        .IsUnique();

                    b.ToTable("wand");
                });

            modelBuilder.Entity("HarryPotterAPI.Models.WandModel", b =>
                {
                    b.HasOne("HarryPotterAPI.Models.CharacterModel", "Character")
                        .WithOne("Wand")
                        .HasForeignKey("HarryPotterAPI.Models.WandModel", "CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("HarryPotterAPI.Models.CharacterModel", b =>
                {
                    b.Navigation("Wand")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
