using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VideoInteraction.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addCameraToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cameras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CameraCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTs = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cameras", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cameras",
                columns: new[] { "Id", "CameraCode", "CreatedTs", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "code12312001", new DateTime(2024, 8, 14, 23, 13, 50, 565, DateTimeKind.Local).AddTicks(5509), "", "Cam01" },
                    { 2, "code12312002", new DateTime(2024, 8, 14, 23, 13, 50, 565, DateTimeKind.Local).AddTicks(5523), "", "Cam02" },
                    { 3, "code12312003", new DateTime(2024, 8, 14, 23, 13, 50, 565, DateTimeKind.Local).AddTicks(5524), "", "Cam03" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cameras");
        }
    }
}
