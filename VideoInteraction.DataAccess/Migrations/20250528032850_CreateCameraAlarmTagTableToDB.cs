using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VideoInteraction.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CreateCameraAlarmTagTableToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AlarmMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AlarmText = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedTs = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlarmMessages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CameraAlarmTags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTs = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTs = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CameraId = table.Column<int>(type: "int", nullable: false),
                    AlarmMessageId = table.Column<int>(type: "int", nullable: false),
                    ShowStringParamId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CameraAlarmTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CameraAlarmTags_AlarmMessages_AlarmMessageId",
                        column: x => x.AlarmMessageId,
                        principalTable: "AlarmMessages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CameraAlarmTags_Cameras_CameraId",
                        column: x => x.CameraId,
                        principalTable: "Cameras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CameraAlarmTags_ShowStringParams_ShowStringParamId",
                        column: x => x.ShowStringParamId,
                        principalTable: "ShowStringParams",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CameraAlarmTags_AlarmMessageId",
                table: "CameraAlarmTags",
                column: "AlarmMessageId");

            migrationBuilder.CreateIndex(
                name: "IX_CameraAlarmTags_CameraId",
                table: "CameraAlarmTags",
                column: "CameraId");

            migrationBuilder.CreateIndex(
                name: "IX_CameraAlarmTags_ShowStringParamId",
                table: "CameraAlarmTags",
                column: "ShowStringParamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CameraAlarmTags");

            migrationBuilder.DropTable(
                name: "AlarmMessages");
        }
    }
}
