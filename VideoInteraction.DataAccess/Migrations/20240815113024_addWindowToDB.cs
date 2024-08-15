using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VideoInteraction.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addWindowToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Windows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    WndId = table.Column<int>(type: "int", nullable: false),
                    WndUrl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTs = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTs = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Windows", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Windows");

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
    }
}
