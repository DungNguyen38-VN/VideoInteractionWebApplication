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
    [Migration("20240815072512_changeCameraControlTag")]
    partial class changeCameraControlTag
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VideoInteraction.Models.Camera", b =>
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
                            CreatedTs = new DateTime(2024, 8, 15, 14, 25, 11, 970, DateTimeKind.Local).AddTicks(1307),
                            Description = "",
                            Name = "Cam01"
                        },
                        new
                        {
                            Id = 2,
                            CameraCode = "code12312002",
                            CreatedTs = new DateTime(2024, 8, 15, 14, 25, 11, 970, DateTimeKind.Local).AddTicks(1309),
                            Description = "",
                            Name = "Cam02"
                        },
                        new
                        {
                            Id = 3,
                            CameraCode = "code12312003",
                            CreatedTs = new DateTime(2024, 8, 15, 14, 25, 11, 970, DateTimeKind.Local).AddTicks(1310),
                            Description = "",
                            Name = "Cam03"
                        });
                });

            modelBuilder.Entity("VideoInteraction.Models.CameraControlTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CameraId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedTs")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CameraId");

                    b.ToTable("CameraControlTags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CameraId = 1,
                            CreatedTs = new DateTime(2024, 8, 15, 14, 25, 11, 970, DateTimeKind.Local).AddTicks(1391),
                            Description = "tag1",
                            IsActive = true,
                            TagName = "TDC_Com.TDC1.Tag1"
                        },
                        new
                        {
                            Id = 2,
                            CameraId = 2,
                            CreatedTs = new DateTime(2024, 8, 15, 14, 25, 11, 970, DateTimeKind.Local).AddTicks(1393),
                            Description = "tag2",
                            IsActive = true,
                            TagName = "TDC_Com.TDC1.Tag2"
                        },
                        new
                        {
                            Id = 3,
                            CameraId = 3,
                            CreatedTs = new DateTime(2024, 8, 15, 14, 25, 11, 970, DateTimeKind.Local).AddTicks(1394),
                            Description = "tag3",
                            IsActive = true,
                            TagName = "TDC_Com.TDC1.Tag3"
                        },
                        new
                        {
                            Id = 4,
                            CameraId = 4,
                            CreatedTs = new DateTime(2024, 8, 15, 14, 25, 11, 970, DateTimeKind.Local).AddTicks(1396),
                            Description = "tag4",
                            IsActive = true,
                            TagName = "TDC_Com.TDC1.Tag4"
                        });
                });

            modelBuilder.Entity("VideoInteraction.Models.CameraControlTag", b =>
                {
                    b.HasOne("VideoInteraction.Models.Camera", "Camera")
                        .WithMany()
                        .HasForeignKey("CameraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Camera");
                });
#pragma warning restore 612, 618
        }
    }
}