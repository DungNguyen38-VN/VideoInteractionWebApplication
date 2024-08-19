using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VideoInteraction.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addRoleToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 19, 9, 57, 2, 795, DateTimeKind.Local).AddTicks(6112), new DateTime(2024, 8, 19, 9, 57, 2, 795, DateTimeKind.Local).AddTicks(6113) });

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 19, 9, 57, 2, 795, DateTimeKind.Local).AddTicks(6115), new DateTime(2024, 8, 19, 9, 57, 2, 795, DateTimeKind.Local).AddTicks(6115) });

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 19, 9, 57, 2, 795, DateTimeKind.Local).AddTicks(6117), new DateTime(2024, 8, 19, 9, 57, 2, 795, DateTimeKind.Local).AddTicks(6117) });

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 19, 9, 57, 2, 795, DateTimeKind.Local).AddTicks(6119), new DateTime(2024, 8, 19, 9, 57, 2, 795, DateTimeKind.Local).AddTicks(6119) });

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 19, 9, 57, 2, 795, DateTimeKind.Local).AddTicks(6006));

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 19, 9, 57, 2, 795, DateTimeKind.Local).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 19, 9, 57, 2, 795, DateTimeKind.Local).AddTicks(6009));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 19, 9, 46, 37, 773, DateTimeKind.Local).AddTicks(2169), new DateTime(2024, 8, 19, 9, 46, 37, 773, DateTimeKind.Local).AddTicks(2170) });

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 19, 9, 46, 37, 773, DateTimeKind.Local).AddTicks(2171), new DateTime(2024, 8, 19, 9, 46, 37, 773, DateTimeKind.Local).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 19, 9, 46, 37, 773, DateTimeKind.Local).AddTicks(2173), new DateTime(2024, 8, 19, 9, 46, 37, 773, DateTimeKind.Local).AddTicks(2174) });

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 19, 9, 46, 37, 773, DateTimeKind.Local).AddTicks(2175), new DateTime(2024, 8, 19, 9, 46, 37, 773, DateTimeKind.Local).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 19, 9, 46, 37, 773, DateTimeKind.Local).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 19, 9, 46, 37, 773, DateTimeKind.Local).AddTicks(2058));

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 19, 9, 46, 37, 773, DateTimeKind.Local).AddTicks(2059));
        }
    }
}
