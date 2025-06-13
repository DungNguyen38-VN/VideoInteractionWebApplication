using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VideoInteraction.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ControlWindowTagTableAddColIsAlarm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAlarm",
                table: "ControlWindowTags",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAlarm",
                table: "ControlWindowTags");
        }
    }
}
