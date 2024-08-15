using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VideoInteraction.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class modifyMeasurementTag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TagDescription",
                table: "MeasurementTags",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 15, 16, 57, 25, 188, DateTimeKind.Local).AddTicks(8863), new DateTime(2024, 8, 15, 16, 57, 25, 188, DateTimeKind.Local).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 15, 16, 57, 25, 188, DateTimeKind.Local).AddTicks(8865), new DateTime(2024, 8, 15, 16, 57, 25, 188, DateTimeKind.Local).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 15, 16, 57, 25, 188, DateTimeKind.Local).AddTicks(8867), new DateTime(2024, 8, 15, 16, 57, 25, 188, DateTimeKind.Local).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 15, 16, 57, 25, 188, DateTimeKind.Local).AddTicks(8869), new DateTime(2024, 8, 15, 16, 57, 25, 188, DateTimeKind.Local).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 15, 16, 57, 25, 188, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 15, 16, 57, 25, 188, DateTimeKind.Local).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 15, 16, 57, 25, 188, DateTimeKind.Local).AddTicks(8775));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TagDescription",
                table: "MeasurementTags",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
