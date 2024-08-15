using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VideoInteraction.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addMeasurementRelatedTableToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 15, 14, 43, 2, 169, DateTimeKind.Local).AddTicks(9026), new DateTime(2024, 8, 15, 14, 43, 2, 169, DateTimeKind.Local).AddTicks(9027) });

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 15, 14, 43, 2, 169, DateTimeKind.Local).AddTicks(9029), new DateTime(2024, 8, 15, 14, 43, 2, 169, DateTimeKind.Local).AddTicks(9029) });

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 15, 14, 43, 2, 169, DateTimeKind.Local).AddTicks(9031), new DateTime(2024, 8, 15, 14, 43, 2, 169, DateTimeKind.Local).AddTicks(9031) });

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 15, 14, 43, 2, 169, DateTimeKind.Local).AddTicks(9033), new DateTime(2024, 8, 15, 14, 43, 2, 169, DateTimeKind.Local).AddTicks(9033) });

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 15, 14, 43, 2, 169, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 15, 14, 43, 2, 169, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 15, 14, 43, 2, 169, DateTimeKind.Local).AddTicks(8947));
        }
    }
}
