using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorTemplate.Migrations
{
    public partial class UpdateDone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDone",
                table: "Tasks",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDone",
                table: "Tasks");
        }
    }
}
