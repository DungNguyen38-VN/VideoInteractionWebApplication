﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VideoInteraction.DataAccess.Data;

#nullable disable

namespace VideoInteraction.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240814161351_addCameraToDB")]
    partial class addCameraToDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VideoInteraction.Web.Models.Camera", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CameraCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedTs")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Cameras");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CameraCode = "code12312001",
                            CreatedTs = new DateTime(2024, 8, 14, 23, 13, 50, 565, DateTimeKind.Local).AddTicks(5509),
                            Description = "",
                            Name = "Cam01"
                        },
                        new
                        {
                            Id = 2,
                            CameraCode = "code12312002",
                            CreatedTs = new DateTime(2024, 8, 14, 23, 13, 50, 565, DateTimeKind.Local).AddTicks(5523),
                            Description = "",
                            Name = "Cam02"
                        },
                        new
                        {
                            Id = 3,
                            CameraCode = "code12312003",
                            CreatedTs = new DateTime(2024, 8, 14, 23, 13, 50, 565, DateTimeKind.Local).AddTicks(5524),
                            Description = "",
                            Name = "Cam03"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}