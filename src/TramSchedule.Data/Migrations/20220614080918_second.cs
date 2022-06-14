using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TramSchedule.Data.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Trams",
                columns: new[] { "TramId", "Description", "Name", "Number" },
                values: new object[] { 1, "modern tram", "tramicus", 110 });

            migrationBuilder.InsertData(
                table: "Trams",
                columns: new[] { "TramId", "Description", "Name", "Number" },
                values: new object[] { 2, "modern tram", "kiosk", 110 });

            migrationBuilder.InsertData(
                table: "Trams",
                columns: new[] { "TramId", "Description", "Name", "Number" },
                values: new object[] { 3, "modern tram", "delfin", 110 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trams",
                keyColumn: "TramId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trams",
                keyColumn: "TramId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trams",
                keyColumn: "TramId",
                keyValue: 3);
        }
    }
}
