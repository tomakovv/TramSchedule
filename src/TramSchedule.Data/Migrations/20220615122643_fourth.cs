using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TramSchedule.Data.Migrations
{
    public partial class fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TramStops_TramLines_TramLineId",
                table: "TramStops");

            migrationBuilder.DropIndex(
                name: "IX_TramStops_TramLineId",
                table: "TramStops");

            migrationBuilder.DeleteData(
                table: "TramLines",
                keyColumn: "TramLineId",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "TramLineId",
                table: "TramStops");

            migrationBuilder.CreateTable(
                name: "TramLineTramStop",
                columns: table => new
                {
                    LinesTramLineId = table.Column<int>(type: "int", nullable: false),
                    StopsTramStopId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TramLineTramStop", x => new { x.LinesTramLineId, x.StopsTramStopId });
                    table.ForeignKey(
                        name: "FK_TramLineTramStop_TramLines_LinesTramLineId",
                        column: x => x.LinesTramLineId,
                        principalTable: "TramLines",
                        principalColumn: "TramLineId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TramLineTramStop_TramStops_StopsTramStopId",
                        column: x => x.StopsTramStopId,
                        principalTable: "TramStops",
                        principalColumn: "TramStopId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TramLineTramStop_StopsTramStopId",
                table: "TramLineTramStop",
                column: "StopsTramStopId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TramLineTramStop");

            migrationBuilder.AddColumn<int>(
                name: "TramLineId",
                table: "TramStops",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "TramLines",
                columns: new[] { "TramLineId", "Name" },
                values: new object[] { 1, "Trasa 1" });

            migrationBuilder.CreateIndex(
                name: "IX_TramStops_TramLineId",
                table: "TramStops",
                column: "TramLineId");

            migrationBuilder.AddForeignKey(
                name: "FK_TramStops_TramLines_TramLineId",
                table: "TramStops",
                column: "TramLineId",
                principalTable: "TramLines",
                principalColumn: "TramLineId");
        }
    }
}
