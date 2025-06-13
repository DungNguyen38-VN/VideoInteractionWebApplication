using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VideoInteraction.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ControlWindowTagTableModify1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsAlarm",
                table: "ControlWindowTags",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsAlarm",
                table: "ControlWindowTags",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");
        }
    }
}
