using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VideoInteraction.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class rebuildDBTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MeasurementTags_measurementPrefixes_MeasurementPrefixId",
                table: "MeasurementTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_measurementPrefixes",
                table: "measurementPrefixes");

            migrationBuilder.RenameTable(
                name: "measurementPrefixes",
                newName: "MeasurementPrefixes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MeasurementPrefixes",
                table: "MeasurementPrefixes",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 19, 10, 5, 40, 953, DateTimeKind.Local).AddTicks(1523), new DateTime(2024, 8, 19, 10, 5, 40, 953, DateTimeKind.Local).AddTicks(1523) });

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 19, 10, 5, 40, 953, DateTimeKind.Local).AddTicks(1525), new DateTime(2024, 8, 19, 10, 5, 40, 953, DateTimeKind.Local).AddTicks(1526) });

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 19, 10, 5, 40, 953, DateTimeKind.Local).AddTicks(1527), new DateTime(2024, 8, 19, 10, 5, 40, 953, DateTimeKind.Local).AddTicks(1528) });

            migrationBuilder.UpdateData(
                table: "CameraControlTags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTs", "UpdatedTs" },
                values: new object[] { new DateTime(2024, 8, 19, 10, 5, 40, 953, DateTimeKind.Local).AddTicks(1529), new DateTime(2024, 8, 19, 10, 5, 40, 953, DateTimeKind.Local).AddTicks(1529) });

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 19, 10, 5, 40, 953, DateTimeKind.Local).AddTicks(1425));

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 19, 10, 5, 40, 953, DateTimeKind.Local).AddTicks(1426));

            migrationBuilder.UpdateData(
                table: "Cameras",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTs",
                value: new DateTime(2024, 8, 19, 10, 5, 40, 953, DateTimeKind.Local).AddTicks(1428));

            migrationBuilder.AddForeignKey(
                name: "FK_MeasurementTags_MeasurementPrefixes_MeasurementPrefixId",
                table: "MeasurementTags",
                column: "MeasurementPrefixId",
                principalTable: "MeasurementPrefixes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MeasurementTags_MeasurementPrefixes_MeasurementPrefixId",
                table: "MeasurementTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MeasurementPrefixes",
                table: "MeasurementPrefixes");

            migrationBuilder.RenameTable(
                name: "MeasurementPrefixes",
                newName: "measurementPrefixes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_measurementPrefixes",
                table: "measurementPrefixes",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_MeasurementTags_measurementPrefixes_MeasurementPrefixId",
                table: "MeasurementTags",
                column: "MeasurementPrefixId",
                principalTable: "measurementPrefixes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
