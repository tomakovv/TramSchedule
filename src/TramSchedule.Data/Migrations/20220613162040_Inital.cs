using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TramSchedule.Data.Migrations
{
    public partial class Inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TramLines",
                columns: table => new
                {
                    TramLineId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TramLines", x => x.TramLineId);
                });

            migrationBuilder.CreateTable(
                name: "Trams",
                columns: table => new
                {
                    TramId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trams", x => x.TramId);
                });

            migrationBuilder.CreateTable(
                name: "TramStops",
                columns: table => new
                {
                    TramStopId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TramLineId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TramStops", x => x.TramStopId);
                    table.ForeignKey(
                        name: "FK_TramStops_TramLines_TramLineId",
                        column: x => x.TramLineId,
                        principalTable: "TramLines",
                        principalColumn: "TramLineId");
                });

            migrationBuilder.CreateTable(
                name: "TramStopsComments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TramStopId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TramStopsComments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_TramStopsComments_TramStops_TramStopId",
                        column: x => x.TramStopId,
                        principalTable: "TramStops",
                        principalColumn: "TramStopId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TramStops_TramLineId",
                table: "TramStops",
                column: "TramLineId");

            migrationBuilder.CreateIndex(
                name: "IX_TramStopsComments_TramStopId",
                table: "TramStopsComments",
                column: "TramStopId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trams");

            migrationBuilder.DropTable(
                name: "TramStopsComments");

            migrationBuilder.DropTable(
                name: "TramStops");

            migrationBuilder.DropTable(
                name: "TramLines");
        }
    }
}
