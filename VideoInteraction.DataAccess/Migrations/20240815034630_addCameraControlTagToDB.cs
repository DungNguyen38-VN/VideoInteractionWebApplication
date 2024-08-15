using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VideoInteraction.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addCameraControlTagToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CameraControlTag",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedTs = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CameraId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CameraControlTag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CameraControlTag_Cameras_CameraId",
                        column: x => x.CameraId,
                        principalTable: "Cameras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CameraControlTag",
                columns: new[] { "Id", "CameraId", "CreatedTs", "Description", "IsActive", "TagName" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 8, 15, 10, 46, 28, 964, DateTimeKind.Local).AddTicks(1311), "tag1", true, "TDC_Com.TDC1.Tag1" },
                    { 2, 2, new DateTime(2024, 8, 15, 10, 46, 28, 964, DateTimeKind.Local).AddTicks(1313), "tag2", true, "TDC_Com.TDC1.Tag2" },
                    { 3, 3, new DateTime(2024, 8, 15, 10, 46, 28, 964, DateTimeKind.Local).AddTicks(1314), "tag3", true, "TDC_Com.TDC1.Tag3" },
                    { 4, 4, new DateTime(2024, 8, 15, 10, 46, 28, 964, DateTimeKind.Local).AddTicks(1316), "tag4", true, "TDC_Com.TDC1.Tag4" }
                });

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 15, 10, 46, 28, 962, DateTimeKind.Local).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 15, 10, 46, 28, 962, DateTimeKind.Local).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 15, 10, 46, 28, 962, DateTimeKind.Local).AddTicks(8917));

            migrationBuilder.CreateIndex(
                name: "IX_CameraControlTag_CameraId",
                table: "CameraControlTag",
                column: "CameraId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CameraControlTag");

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 14, 23, 13, 50, 565, DateTimeKind.Local).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 14, 23, 13, 50, 565, DateTimeKind.Local).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 14, 23, 13, 50, 565, DateTimeKind.Local).AddTicks(5524));
        }
    }
}
