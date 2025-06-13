using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VideoInteraction.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addColumnShowStringParamIdToMeasurementTagTB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShowStringParamId",
                table: "MeasurementTags",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MeasurementTags_ShowStringParamId",
                table: "MeasurementTags",
                column: "ShowStringParamId");

            migrationBuilder.AddForeignKey(
                name: "FK_MeasurementTags_ShowStringParams_ShowStringParamId",
                table: "MeasurementTags",
                column: "ShowStringParamId",
                principalTable: "ShowStringParams",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MeasurementTags_ShowStringParams_ShowStringParamId",
                table: "MeasurementTags");

            migrationBuilder.DropIndex(
                name: "IX_MeasurementTags_ShowStringParamId",
                table: "MeasurementTags");

            migrationBuilder.DropColumn(
                name: "ShowStringParamId",
                table: "MeasurementTags");
        }
    }
}
