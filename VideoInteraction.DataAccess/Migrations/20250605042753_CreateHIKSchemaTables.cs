using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VideoInteraction.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CreateHIKSchemaTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "hik");

            migrationBuilder.CreateTable(
                name: "TvWall",
                schema: "hik",
                columns: table => new
                {
                    TvWallId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TvWallName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IndexCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TvWall", x => x.TvWallId);
                });

            migrationBuilder.CreateTable(
                name: "Dlp",
                schema: "hik",
                columns: table => new
                {
                    DlpId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DlpName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IndexCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Row = table.Column<int>(type: "int", nullable: false),
                    Col = table.Column<int>(type: "int", nullable: false),
                    BelongTvwallIndexcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DlpType = table.Column<int>(type: "int", nullable: false),
                    DecoderId = table.Column<int>(type: "int", nullable: false),
                    AttachedDeviceNum = table.Column<int>(type: "int", nullable: false),
                    CurSceneId = table.Column<int>(type: "int", nullable: false),
                    CurSceneName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LayoutModified = table.Column<bool>(type: "bit", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    VirtualSplitRow = table.Column<int>(type: "int", nullable: false),
                    VirtualSplitCol = table.Column<int>(type: "int", nullable: false),
                    VirtualSplitType = table.Column<int>(type: "int", nullable: false),
                    Expection = table.Column<bool>(type: "bit", nullable: false),
                    TvWallId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dlp", x => x.DlpId);
                    table.ForeignKey(
                        name: "FK_Dlp_TvWall_TvWallId",
                        column: x => x.TvWallId,
                        principalSchema: "hik",
                        principalTable: "TvWall",
                        principalColumn: "TvWallId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FloatWnd",
                schema: "hik",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Left = table.Column<int>(type: "int", nullable: false),
                    Top = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Layer = table.Column<int>(type: "int", nullable: false),
                    DevId = table.Column<int>(type: "int", nullable: false),
                    SubwndNum = table.Column<int>(type: "int", nullable: false),
                    DecoderId = table.Column<int>(type: "int", nullable: false),
                    Wndpos = table.Column<int>(type: "int", nullable: false),
                    WndId = table.Column<int>(type: "int", nullable: false),
                    Uri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttachedUri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Enlarged = table.Column<bool>(type: "bit", nullable: false),
                    FullLarged = table.Column<bool>(type: "bit", nullable: false),
                    OpenwndMode = table.Column<int>(type: "int", nullable: false),
                    DlpRow = table.Column<int>(type: "int", nullable: false),
                    DlpCol = table.Column<int>(type: "int", nullable: false),
                    IsJoint = table.Column<bool>(type: "bit", nullable: false),
                    DeviceWallNo = table.Column<int>(type: "int", nullable: false),
                    LedWndIndexcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LockStatus = table.Column<int>(type: "int", nullable: false),
                    DlpId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FloatWnd", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FloatWnd_Dlp_DlpId",
                        column: x => x.DlpId,
                        principalSchema: "hik",
                        principalTable: "Dlp",
                        principalColumn: "DlpId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Group",
                schema: "hik",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BelongDlpId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.GroupId);
                    table.ForeignKey(
                        name: "FK_Group_Dlp_BelongDlpId",
                        column: x => x.BelongDlpId,
                        principalSchema: "hik",
                        principalTable: "Dlp",
                        principalColumn: "DlpId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Monitor",
                schema: "hik",
                columns: table => new
                {
                    OutputId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Index = table.Column<int>(type: "int", nullable: false),
                    Pos = table.Column<int>(type: "int", nullable: false),
                    MonitorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Joint = table.Column<bool>(type: "bit", nullable: false),
                    DlpRow = table.Column<int>(type: "int", nullable: false),
                    DlpCol = table.Column<int>(type: "int", nullable: false),
                    DlpId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monitor", x => x.OutputId);
                    table.ForeignKey(
                        name: "FK_Monitor_Dlp_DlpId",
                        column: x => x.DlpId,
                        principalSchema: "hik",
                        principalTable: "Dlp",
                        principalColumn: "DlpId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wnd",
                schema: "hik",
                columns: table => new
                {
                    WndId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WndUri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DecodeChannel = table.Column<int>(type: "int", nullable: false),
                    VirtualId = table.Column<int>(type: "int", nullable: false),
                    Uri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zoom = table.Column<bool>(type: "bit", nullable: false),
                    NetZone = table.Column<int>(type: "int", nullable: false),
                    ShowLogo = table.Column<bool>(type: "bit", nullable: false),
                    Audio = table.Column<bool>(type: "bit", nullable: false),
                    EnableSmartRule = table.Column<int>(type: "int", nullable: false),
                    RotateDegree = table.Column<int>(type: "int", nullable: false),
                    FloatWndId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wnd", x => x.WndId);
                    table.ForeignKey(
                        name: "FK_Wnd_FloatWnd_FloatWndId",
                        column: x => x.FloatWndId,
                        principalSchema: "hik",
                        principalTable: "FloatWnd",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dlp_TvWallId",
                schema: "hik",
                table: "Dlp",
                column: "TvWallId");

            migrationBuilder.CreateIndex(
                name: "IX_FloatWnd_DlpId",
                schema: "hik",
                table: "FloatWnd",
                column: "DlpId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_BelongDlpId",
                schema: "hik",
                table: "Group",
                column: "BelongDlpId");

            migrationBuilder.CreateIndex(
                name: "IX_Monitor_DlpId",
                schema: "hik",
                table: "Monitor",
                column: "DlpId");

            migrationBuilder.CreateIndex(
                name: "IX_Wnd_FloatWndId",
                schema: "hik",
                table: "Wnd",
                column: "FloatWndId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Group",
                schema: "hik");

            migrationBuilder.DropTable(
                name: "Monitor",
                schema: "hik");

            migrationBuilder.DropTable(
                name: "Wnd",
                schema: "hik");

            migrationBuilder.DropTable(
                name: "FloatWnd",
                schema: "hik");

            migrationBuilder.DropTable(
                name: "Dlp",
                schema: "hik");

            migrationBuilder.DropTable(
                name: "TvWall",
                schema: "hik");
        }
    }
}
