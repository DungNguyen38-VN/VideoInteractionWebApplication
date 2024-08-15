using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VideoInteraction.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addMeasurementRelatedTableToDBNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "measurementPrefixes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedTs = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_measurementPrefixes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MeasurementUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedTs = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeasurementUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MeasurementTags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    MeasureTagName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TagDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTs = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTs = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CameraId = table.Column<int>(type: "int", nullable: false),
                    MeasurementUnitId = table.Column<int>(type: "int", nullable: false),
                    MeasurementPrefixId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeasurementTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MeasurementTags_Cameras_CameraId",
                        column: x => x.CameraId,
                        principalTable: "Cameras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MeasurementTags_MeasurementUnits_MeasurementUnitId",
                        column: x => x.MeasurementUnitId,
                        principalTable: "MeasurementUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MeasurementTags_measurementPrefixes_MeasurementPrefixId",
                        column: x => x.MeasurementPrefixId,
                        principalTable: "measurementPrefixes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 15, 15, 46, 40, 332, DateTimeKind.Local).AddTicks(3806), new DateTime(2024, 8, 15, 15, 46, 40, 332, DateTimeKind.Local).AddTicks(3806) });

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 15, 15, 46, 40, 332, DateTimeKind.Local).AddTicks(3809), new DateTime(2024, 8, 15, 15, 46, 40, 332, DateTimeKind.Local).AddTicks(3809) });

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 15, 15, 46, 40, 332, DateTimeKind.Local).AddTicks(3811), new DateTime(2024, 8, 15, 15, 46, 40, 332, DateTimeKind.Local).AddTicks(3811) });

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 15, 15, 46, 40, 332, DateTimeKind.Local).AddTicks(3814), new DateTime(2024, 8, 15, 15, 46, 40, 332, DateTimeKind.Local).AddTicks(3814) });

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 15, 15, 46, 40, 332, DateTimeKind.Local).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 15, 15, 46, 40, 332, DateTimeKind.Local).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 15, 15, 46, 40, 332, DateTimeKind.Local).AddTicks(3713));

            migrationBuilder.CreateIndex(
                name: "IX_MeasurementTags_CameraId",
                table: "MeasurementTags",
                column: "CameraId");

            migrationBuilder.CreateIndex(
                name: "IX_MeasurementTags_MeasurementPrefixId",
                table: "MeasurementTags",
                column: "MeasurementPrefixId");

            migrationBuilder.CreateIndex(
                name: "IX_MeasurementTags_MeasurementUnitId",
                table: "MeasurementTags",
                column: "MeasurementUnitId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MeasurementTags");

            migrationBuilder.DropTable(
                name: "MeasurementUnits");

            migrationBuilder.DropTable(
                name: "measurementPrefixes");

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 15, 15, 45, 35, 511, DateTimeKind.Local).AddTicks(2527), new DateTime(2024, 8, 15, 15, 45, 35, 511, DateTimeKind.Local).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 15, 15, 45, 35, 511, DateTimeKind.Local).AddTicks(2529), new DateTime(2024, 8, 15, 15, 45, 35, 511, DateTimeKind.Local).AddTicks(2529) });

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 15, 15, 45, 35, 511, DateTimeKind.Local).AddTicks(2531), new DateTime(2024, 8, 15, 15, 45, 35, 511, DateTimeKind.Local).AddTicks(2531) });

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 15, 15, 45, 35, 511, DateTimeKind.Local).AddTicks(2533), new DateTime(2024, 8, 15, 15, 45, 35, 511, DateTimeKind.Local).AddTicks(2533) });

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 15, 15, 45, 35, 511, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 15, 15, 45, 35, 511, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 15, 15, 45, 35, 511, DateTimeKind.Local).AddTicks(2439));
        }
    }
}
