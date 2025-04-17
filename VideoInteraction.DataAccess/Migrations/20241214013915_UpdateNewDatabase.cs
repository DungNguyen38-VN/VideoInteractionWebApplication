using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VideoInteraction.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateNewDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AddColumn<int>(
                name: "L1ControlId",
                table: "Cameras",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ControlWindowTags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTs = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTs = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WindowId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlWindowTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ControlWindowTags_Windows_WindowId",
                        column: x => x.WindowId,
                        principalTable: "Windows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ControlWindowTags_WindowId",
                table: "ControlWindowTags",
                column: "WindowId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ControlWindowTags");

            migrationBuilder.DropColumn(
                name: "L1ControlId",
                table: "Cameras");

            migrationBuilder.InsertData(
                table: "Cameras",
                columns: new[] { "Id", "CameraCode", "CreatedTs", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "code12312001", new DateTime(2024, 12, 11, 8, 45, 36, 466, DateTimeKind.Local).AddTicks(7574), "", "Cam01" },
                    { 2, "code12312002", new DateTime(2024, 12, 11, 8, 45, 36, 466, DateTimeKind.Local).AddTicks(7685), "", "Cam02" },
                    { 3, "code12312003", new DateTime(2024, 12, 11, 8, 45, 36, 466, DateTimeKind.Local).AddTicks(7794), "", "Cam03" },
                    { 4, "code12312004", new DateTime(2024, 12, 11, 8, 45, 36, 466, DateTimeKind.Local).AddTicks(7903), "", "Cam04" }
                });

            migrationBuilder.InsertData(
                table: "CameraControlTags",
                columns: new[] { "Id", "CameraId", "CreatedTs", "Description", "TagName", "UpdatedTs" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 12, 11, 8, 45, 36, 466, DateTimeKind.Local).AddTicks(8452), "tag1", "TDC_Com.TDC1.Tag1", new DateTime(2024, 12, 11, 8, 45, 36, 466, DateTimeKind.Local).AddTicks(8511) },
                    { 2, 2, new DateTime(2024, 12, 11, 8, 45, 36, 466, DateTimeKind.Local).AddTicks(8680), "tag2", "TDC_Com.TDC1.Tag2", new DateTime(2024, 12, 11, 8, 45, 36, 466, DateTimeKind.Local).AddTicks(8734) },
                    { 3, 3, new DateTime(2024, 12, 11, 8, 45, 36, 466, DateTimeKind.Local).AddTicks(8897), "tag3", "TDC_Com.TDC1.Tag3", new DateTime(2024, 12, 11, 8, 45, 36, 466, DateTimeKind.Local).AddTicks(8986) },
                    { 4, 4, new DateTime(2024, 12, 11, 8, 45, 36, 466, DateTimeKind.Local).AddTicks(9152), "tag4", "TDC_Com.TDC1.Tag4", new DateTime(2024, 12, 11, 8, 45, 36, 466, DateTimeKind.Local).AddTicks(9207) }
                });
        }
    }
}
