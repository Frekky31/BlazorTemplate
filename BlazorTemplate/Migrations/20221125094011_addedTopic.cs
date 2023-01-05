using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorTemplate.Migrations
{
    public partial class addedTopic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsDone",
                table: "Tasks",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TopicId",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TopicId",
                table: "Tasks",
                column: "TopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Topics_TopicId",
                table: "Tasks",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Topics_TopicId",
                table: "Tasks");

            migrationBuilder.DropTable(
                name: "Topics");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_TopicId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "TopicId",
                table: "Tasks");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDone",
                table: "Tasks",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");
        }
    }
}
