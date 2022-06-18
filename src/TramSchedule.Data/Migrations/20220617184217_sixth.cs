using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TramSchedule.Data.Migrations
{
    public partial class sixth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TramDepartures",
                columns: table => new
                {
                    TramDepartureID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TramId = table.Column<int>(type: "int", nullable: false),
                    StopTramStopId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TramDepartures", x => x.TramDepartureID);
                    table.ForeignKey(
                        name: "FK_TramDepartures_Trams_TramId",
                        column: x => x.TramId,
                        principalTable: "Trams",
                        principalColumn: "TramId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TramDepartures_TramStops_StopTramStopId",
                        column: x => x.StopTramStopId,
                        principalTable: "TramStops",
                        principalColumn: "TramStopId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepartureTimes",
                columns: table => new
                {
                    DepartureTimeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TramDeparturesTramDepartureID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartureTimes", x => x.DepartureTimeId);
                    table.ForeignKey(
                        name: "FK_DepartureTimes_TramDepartures_TramDeparturesTramDepartureID",
                        column: x => x.TramDeparturesTramDepartureID,
                        principalTable: "TramDepartures",
                        principalColumn: "TramDepartureID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartureTimes_TramDeparturesTramDepartureID",
                table: "DepartureTimes",
                column: "TramDeparturesTramDepartureID");

            migrationBuilder.CreateIndex(
                name: "IX_TramDepartures_StopTramStopId",
                table: "TramDepartures",
                column: "StopTramStopId");

            migrationBuilder.CreateIndex(
                name: "IX_TramDepartures_TramId",
                table: "TramDepartures",
                column: "TramId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartureTimes");

            migrationBuilder.DropTable(
                name: "TramDepartures");
        }
    }
}
