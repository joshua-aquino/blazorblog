using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace blazorblog.Migrations
{
    public partial class AddImageToPost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Introducttion",
                table: "Posts",
                newName: "Introduction");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Posts",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "Introduction",
                table: "Posts",
                newName: "Introducttion");
        }
    }
}
