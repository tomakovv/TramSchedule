using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TramSchedule.Data.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TramLines",
                columns: new[] { "TramLineId", "Name" },
                values: new object[] { 1, "Trasa 1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TramLines",
                keyColumn: "TramLineId",
                keyValue: 1);
        }
    }
}
