using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VideoInteraction.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class modifyCameraControlTagToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "CameraControlTags");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTs",
                table: "CameraControlTags",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 15, 14, 30, 19, 645, DateTimeKind.Local).AddTicks(5610), new DateTime(2024, 8, 15, 14, 30, 19, 645, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 15, 14, 30, 19, 645, DateTimeKind.Local).AddTicks(5612), new DateTime(2024, 8, 15, 14, 30, 19, 645, DateTimeKind.Local).AddTicks(5612) });

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 15, 14, 30, 19, 645, DateTimeKind.Local).AddTicks(5614), new DateTime(2024, 8, 15, 14, 30, 19, 645, DateTimeKind.Local).AddTicks(5614) });

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 15, 14, 30, 19, 645, DateTimeKind.Local).AddTicks(5615), new DateTime(2024, 8, 15, 14, 30, 19, 645, DateTimeKind.Local).AddTicks(5615) });

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 15, 14, 30, 19, 645, DateTimeKind.Local).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 15, 14, 30, 19, 645, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 15, 14, 30, 19, 645, DateTimeKind.Local).AddTicks(5533));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdatedTs",
                table: "CameraControlTags");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "CameraControlTags",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTs", "IsActive" },
                values: new object[] { new DateTime(2024, 8, 15, 14, 25, 11, 970, DateTimeKind.Local).AddTicks(1391), true });

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTs", "IsActive" },
                values: new object[] { new DateTime(2024, 8, 15, 14, 25, 11, 970, DateTimeKind.Local).AddTicks(1393), true });

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTs", "IsActive" },
                values: new object[] { new DateTime(2024, 8, 15, 14, 25, 11, 970, DateTimeKind.Local).AddTicks(1394), true });

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTs", "IsActive" },
                values: new object[] { new DateTime(2024, 8, 15, 14, 25, 11, 970, DateTimeKind.Local).AddTicks(1396), true });

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 15, 14, 25, 11, 970, DateTimeKind.Local).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 15, 14, 25, 11, 970, DateTimeKind.Local).AddTicks(1309));

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 15, 14, 25, 11, 970, DateTimeKind.Local).AddTicks(1310));
        }
    }
}
