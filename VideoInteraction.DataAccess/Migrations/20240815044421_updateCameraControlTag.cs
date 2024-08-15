using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VideoInteraction.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updateCameraControlTag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CameraControlTag_Cameras_CameraId",
                table: "CameraControlTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CameraControlTag",
                table: "CameraControlTag");

            migrationBuilder.RenameTable(
                name: "CameraControlTag",
                newName: "CameraControlTags");

            migrationBuilder.RenameIndex(
                name: "IX_CameraControlTag_CameraId",
                table: "CameraControlTags",
                newName: "IX_CameraControlTags_CameraId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CameraControlTags",
                table: "CameraControlTags",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 15, 11, 44, 20, 567, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 15, 11, 44, 20, 567, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 15, 11, 44, 20, 567, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 15, 11, 44, 20, 567, DateTimeKind.Local).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 15, 11, 44, 20, 567, DateTimeKind.Local).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 15, 11, 44, 20, 567, DateTimeKind.Local).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 15, 11, 44, 20, 567, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.AddForeignKey(
                name: "FK_CameraControlTags_Cameras_CameraId",
                table: "CameraControlTags",
                column: "CameraId",
                principalTable: "Cameras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CameraControlTags_Cameras_CameraId",
                table: "CameraControlTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CameraControlTags",
                table: "CameraControlTags");

            migrationBuilder.RenameTable(
                name: "CameraControlTags",
                newName: "CameraControlTag");

            migrationBuilder.RenameIndex(
                name: "IX_CameraControlTags_CameraId",
                table: "CameraControlTag",
                newName: "IX_CameraControlTag_CameraId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CameraControlTag",
                table: "CameraControlTag",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "CameraControlTag",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 15, 10, 46, 28, 964, DateTimeKind.Local).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "CameraControlTag",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 15, 10, 46, 28, 964, DateTimeKind.Local).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "CameraControlTag",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 15, 10, 46, 28, 964, DateTimeKind.Local).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "CameraControlTag",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 15, 10, 46, 28, 964, DateTimeKind.Local).AddTicks(1316));

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

            migrationBuilder.AddForeignKey(
                name: "FK_CameraControlTag_Cameras_CameraId",
                table: "CameraControlTag",
                column: "CameraId",
                principalTable: "Cameras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
