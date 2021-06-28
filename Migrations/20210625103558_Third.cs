using Microsoft.EntityFrameworkCore.Migrations;

namespace DBSAPI.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DExecutive",
                table: "BookingDetails",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DExecutive",
                table: "BookingDetails");
        }
    }
}
