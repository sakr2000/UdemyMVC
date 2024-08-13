using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UdemyMVC.Migrations
{
    /// <inheritdoc />
    public partial class v11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Topics",
                table: "chapters");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Topics",
                table: "chapters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
