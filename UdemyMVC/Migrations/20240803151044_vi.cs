using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UdemyMVC.Migrations
{
    /// <inheritdoc />
    public partial class vi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Categories_CategoryID",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CategoryID",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Courses");

            migrationBuilder.CreateTable(
                name: "CategoryCourses",
                columns: table => new
                {
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryCourses", x => new { x.CourseID, x.CategoryID });
                    table.ForeignKey(
                        name: "FK_CategoryCourses_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryCourses_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "chapters",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Topic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chapters", x => x.ID);
                    table.ForeignKey(
                        name: "FK_chapters_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryCourses_CategoryID",
                table: "CategoryCourses",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_chapters_CourseId",
                table: "chapters",
                column: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryCourses");

            migrationBuilder.DropTable(
                name: "chapters");

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CategoryID",
                table: "Courses",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Categories_CategoryID",
                table: "Courses",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
