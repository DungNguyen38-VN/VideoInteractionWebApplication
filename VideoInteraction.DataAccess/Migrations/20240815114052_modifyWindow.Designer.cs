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
    [Migration("20240815114052_modifyWindow")]
    partial class modifyWindow
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
                            CreatedTs = new DateTime(2024, 8, 15, 18, 40, 51, 918, DateTimeKind.Local).AddTicks(6938),
                            Description = "",
                            Name = "Cam01"
                        },
                        new
                        {
                            Id = 2,
                            CameraCode = "code12312002",
                            CreatedTs = new DateTime(2024, 8, 15, 18, 40, 51, 918, DateTimeKind.Local).AddTicks(6940),
                            Description = "",
                            Name = "Cam02"
                        },
                        new
                        {
                            Id = 3,
                            CameraCode = "code12312003",
                            CreatedTs = new DateTime(2024, 8, 15, 18, 40, 51, 918, DateTimeKind.Local).AddTicks(6941),
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

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("UpdatedTs")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CameraId");

                    b.ToTable("CameraControlTags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CameraId = 1,
                            CreatedTs = new DateTime(2024, 8, 15, 18, 40, 51, 918, DateTimeKind.Local).AddTicks(7015),
                            Description = "tag1",
                            TagName = "TDC_Com.TDC1.Tag1",
                            UpdatedTs = new DateTime(2024, 8, 15, 18, 40, 51, 918, DateTimeKind.Local).AddTicks(7015)
                        },
                        new
                        {
                            Id = 2,
                            CameraId = 2,
                            CreatedTs = new DateTime(2024, 8, 15, 18, 40, 51, 918, DateTimeKind.Local).AddTicks(7017),
                            Description = "tag2",
                            TagName = "TDC_Com.TDC1.Tag2",
                            UpdatedTs = new DateTime(2024, 8, 15, 18, 40, 51, 918, DateTimeKind.Local).AddTicks(7017)
                        },
                        new
                        {
                            Id = 3,
                            CameraId = 3,
                            CreatedTs = new DateTime(2024, 8, 15, 18, 40, 51, 918, DateTimeKind.Local).AddTicks(7019),
                            Description = "tag3",
                            TagName = "TDC_Com.TDC1.Tag3",
                            UpdatedTs = new DateTime(2024, 8, 15, 18, 40, 51, 918, DateTimeKind.Local).AddTicks(7019)
                        },
                        new
                        {
                            Id = 4,
                            CameraId = 4,
                            CreatedTs = new DateTime(2024, 8, 15, 18, 40, 51, 918, DateTimeKind.Local).AddTicks(7021),
                            Description = "tag4",
                            TagName = "TDC_Com.TDC1.Tag4",
                            UpdatedTs = new DateTime(2024, 8, 15, 18, 40, 51, 918, DateTimeKind.Local).AddTicks(7021)
                        });
                });

            modelBuilder.Entity("VideoInteraction.Models.MeasurementPrefix", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedTs")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("measurementPrefixes");
                });

            modelBuilder.Entity("VideoInteraction.Models.MeasurementTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CameraId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedTs")
                        .HasColumnType("datetime2");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("MeasureTagName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("MeasurementPrefixId")
                        .HasColumnType("int");

                    b.Property<int>("MeasurementUnitId")
                        .HasColumnType("int");

                    b.Property<string>("TagDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedTs")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CameraId");

                    b.HasIndex("MeasurementPrefixId");

                    b.HasIndex("MeasurementUnitId");

                    b.ToTable("MeasurementTags");
                });

            modelBuilder.Entity("VideoInteraction.Models.MeasurementUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedTs")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("MeasurementUnits");
                });

            modelBuilder.Entity("VideoInteraction.Models.Window", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedTs")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("UpdatedTs")
                        .HasColumnType("datetime2");

                    b.Property<int>("WndId")
                        .HasColumnType("int");

                    b.Property<string>("WndUrl")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Windows");
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

            modelBuilder.Entity("VideoInteraction.Models.MeasurementTag", b =>
                {
                    b.HasOne("VideoInteraction.Models.Camera", "Camera")
                        .WithMany()
                        .HasForeignKey("CameraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VideoInteraction.Models.MeasurementPrefix", "MeasurementPrefix")
                        .WithMany()
                        .HasForeignKey("MeasurementPrefixId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VideoInteraction.Models.MeasurementUnit", "MeasurementUnit")
                        .WithMany()
                        .HasForeignKey("MeasurementUnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Camera");

                    b.Navigation("MeasurementPrefix");

                    b.Navigation("MeasurementUnit");
                });
#pragma warning restore 612, 618
        }
    }
}
