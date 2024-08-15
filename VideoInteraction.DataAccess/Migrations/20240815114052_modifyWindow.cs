using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VideoInteraction.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class modifyWindow : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Windows",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 15, 18, 40, 51, 918, DateTimeKind.Local).AddTicks(7015), new DateTime(2024, 8, 15, 18, 40, 51, 918, DateTimeKind.Local).AddTicks(7015) });

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 15, 18, 40, 51, 918, DateTimeKind.Local).AddTicks(7017), new DateTime(2024, 8, 15, 18, 40, 51, 918, DateTimeKind.Local).AddTicks(7017) });

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 15, 18, 40, 51, 918, DateTimeKind.Local).AddTicks(7019), new DateTime(2024, 8, 15, 18, 40, 51, 918, DateTimeKind.Local).AddTicks(7019) });

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 15, 18, 40, 51, 918, DateTimeKind.Local).AddTicks(7021), new DateTime(2024, 8, 15, 18, 40, 51, 918, DateTimeKind.Local).AddTicks(7021) });

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 15, 18, 40, 51, 918, DateTimeKind.Local).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 15, 18, 40, 51, 918, DateTimeKind.Local).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 15, 18, 40, 51, 918, DateTimeKind.Local).AddTicks(6941));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Windows",
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
                values: new object[] { new DateTime(2024, 8, 15, 18, 30, 23, 758, DateTimeKind.Local).AddTicks(7324), new DateTime(2024, 8, 15, 18, 30, 23, 758, DateTimeKind.Local).AddTicks(7325) });

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 15, 18, 30, 23, 758, DateTimeKind.Local).AddTicks(7326), new DateTime(2024, 8, 15, 18, 30, 23, 758, DateTimeKind.Local).AddTicks(7327) });

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 15, 18, 30, 23, 758, DateTimeKind.Local).AddTicks(7328), new DateTime(2024, 8, 15, 18, 30, 23, 758, DateTimeKind.Local).AddTicks(7329) });

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 15, 18, 30, 23, 758, DateTimeKind.Local).AddTicks(7330), new DateTime(2024, 8, 15, 18, 30, 23, 758, DateTimeKind.Local).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 15, 18, 30, 23, 758, DateTimeKind.Local).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 15, 18, 30, 23, 758, DateTimeKind.Local).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 15, 18, 30, 23, 758, DateTimeKind.Local).AddTicks(7238));
        }
    }
}
