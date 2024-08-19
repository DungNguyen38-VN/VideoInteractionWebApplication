using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VideoInteraction.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addRoleToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 17, 52, 89, DateTimeKind.Local).AddTicks(4325), new DateTime(2024, 8, 16, 16, 17, 52, 89, DateTimeKind.Local).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 17, 52, 89, DateTimeKind.Local).AddTicks(4327), new DateTime(2024, 8, 16, 16, 17, 52, 89, DateTimeKind.Local).AddTicks(4327) });

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 17, 52, 89, DateTimeKind.Local).AddTicks(4329), new DateTime(2024, 8, 16, 16, 17, 52, 89, DateTimeKind.Local).AddTicks(4329) });

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 16, 16, 17, 52, 89, DateTimeKind.Local).AddTicks(4331), new DateTime(2024, 8, 16, 16, 17, 52, 89, DateTimeKind.Local).AddTicks(4331) });

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 16, 16, 17, 52, 89, DateTimeKind.Local).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 16, 16, 17, 52, 89, DateTimeKind.Local).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 16, 16, 17, 52, 89, DateTimeKind.Local).AddTicks(4249));
        }
    }
}
