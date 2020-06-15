using Microsoft.EntityFrameworkCore.Migrations;

namespace CMSE406_OutlineSystem.Migrations
{
    public partial class checklistAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseFilesid",
                table: "Courses",
                nullable: true);

  

            migrationBuilder.CreateTable(
                name: "CourseFiles",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseSyllabus = table.Column<string>(nullable: true),
                    Homeworks = table.Column<string>(nullable: true),
                    QuizWithSolutions = table.Column<string>(nullable: true),
                    Midterm1WithSolutions = table.Column<string>(nullable: true),
                    Midterm2WithSolutions = table.Column<string>(nullable: true),
                    FinalExamWithSolutions = table.Column<string>(nullable: true),
                    Projects = table.Column<string>(nullable: true),
                    Assignments = table.Column<string>(nullable: true),
                    LabSheets = table.Column<string>(nullable: true),
                    BestWorstMedianMidterm1Papers = table.Column<string>(nullable: true),
                    BestWorstMedianMidterm2Papers = table.Column<string>(nullable: true),
                    BestWorstMedianFinalExamPapers = table.Column<string>(nullable: true),
                    CourseEvolutionDoc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseFiles", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseFilesid",
                table: "Courses",
                column: "CourseFilesid");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CourseFiles_CourseFilesid",
                table: "Courses",
                column: "CourseFilesid",
                principalTable: "CourseFiles",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CourseFiles_CourseFilesid",
                table: "Courses");

            migrationBuilder.DropTable(
                name: "CourseFiles");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CourseFilesid",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseFilesid",
                table: "Courses");

           
        }
    }
}
