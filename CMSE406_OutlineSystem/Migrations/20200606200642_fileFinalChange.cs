using Microsoft.EntityFrameworkCore.Migrations;

namespace CMSE406_OutlineSystem.Migrations
{
    public partial class fileFinalChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "CourseCode",
                table: "FileModels",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FileModels_CourseCode",
                table: "FileModels",
                column: "CourseCode");

            migrationBuilder.AddForeignKey(
                name: "FK_FileModels_Courses_CourseCode",
                table: "FileModels",
                column: "CourseCode",
                principalTable: "Courses",
                principalColumn: "CourseCode",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FileModels_Courses_CourseCode",
                table: "FileModels");

            migrationBuilder.DropIndex(
                name: "IX_FileModels_CourseCode",
                table: "FileModels");

            migrationBuilder.DropColumn(
                name: "CourseCode",
                table: "FileModels");

            migrationBuilder.AddColumn<int>(
                name: "CourseFilesid",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CourseFiles",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssignmentsId = table.Column<int>(type: "int", nullable: true),
                    BestWorstMedianFinalExamPapersId = table.Column<int>(type: "int", nullable: true),
                    BestWorstMedianMidterm1PapersId = table.Column<int>(type: "int", nullable: true),
                    BestWorstMedianMidterm2PapersId = table.Column<int>(type: "int", nullable: true),
                    CourseEvolutionDocId = table.Column<int>(type: "int", nullable: true),
                    CourseSyllabusId = table.Column<int>(type: "int", nullable: true),
                    FinalExamWithSolutionsId = table.Column<int>(type: "int", nullable: true),
                    HomeworksId = table.Column<int>(type: "int", nullable: true),
                    LabSheetsId = table.Column<int>(type: "int", nullable: true),
                    Midterm1WithSolutionsId = table.Column<int>(type: "int", nullable: true),
                    Midterm2WithSolutionsId = table.Column<int>(type: "int", nullable: true),
                    ProjectsId = table.Column<int>(type: "int", nullable: true),
                    QuizWithSolutionsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseFiles", x => x.id);
                    table.ForeignKey(
                        name: "FK_CourseFiles_FileModels_AssignmentsId",
                        column: x => x.AssignmentsId,
                        principalTable: "FileModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseFiles_FileModels_BestWorstMedianFinalExamPapersId",
                        column: x => x.BestWorstMedianFinalExamPapersId,
                        principalTable: "FileModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseFiles_FileModels_BestWorstMedianMidterm1PapersId",
                        column: x => x.BestWorstMedianMidterm1PapersId,
                        principalTable: "FileModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseFiles_FileModels_BestWorstMedianMidterm2PapersId",
                        column: x => x.BestWorstMedianMidterm2PapersId,
                        principalTable: "FileModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseFiles_FileModels_CourseEvolutionDocId",
                        column: x => x.CourseEvolutionDocId,
                        principalTable: "FileModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseFiles_FileModels_CourseSyllabusId",
                        column: x => x.CourseSyllabusId,
                        principalTable: "FileModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseFiles_FileModels_FinalExamWithSolutionsId",
                        column: x => x.FinalExamWithSolutionsId,
                        principalTable: "FileModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseFiles_FileModels_HomeworksId",
                        column: x => x.HomeworksId,
                        principalTable: "FileModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseFiles_FileModels_LabSheetsId",
                        column: x => x.LabSheetsId,
                        principalTable: "FileModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseFiles_FileModels_Midterm1WithSolutionsId",
                        column: x => x.Midterm1WithSolutionsId,
                        principalTable: "FileModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseFiles_FileModels_Midterm2WithSolutionsId",
                        column: x => x.Midterm2WithSolutionsId,
                        principalTable: "FileModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseFiles_FileModels_ProjectsId",
                        column: x => x.ProjectsId,
                        principalTable: "FileModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseFiles_FileModels_QuizWithSolutionsId",
                        column: x => x.QuizWithSolutionsId,
                        principalTable: "FileModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseFilesid",
                table: "Courses",
                column: "CourseFilesid");

            migrationBuilder.CreateIndex(
                name: "IX_CourseFiles_AssignmentsId",
                table: "CourseFiles",
                column: "AssignmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseFiles_BestWorstMedianFinalExamPapersId",
                table: "CourseFiles",
                column: "BestWorstMedianFinalExamPapersId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseFiles_BestWorstMedianMidterm1PapersId",
                table: "CourseFiles",
                column: "BestWorstMedianMidterm1PapersId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseFiles_BestWorstMedianMidterm2PapersId",
                table: "CourseFiles",
                column: "BestWorstMedianMidterm2PapersId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseFiles_CourseEvolutionDocId",
                table: "CourseFiles",
                column: "CourseEvolutionDocId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseFiles_CourseSyllabusId",
                table: "CourseFiles",
                column: "CourseSyllabusId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseFiles_FinalExamWithSolutionsId",
                table: "CourseFiles",
                column: "FinalExamWithSolutionsId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseFiles_HomeworksId",
                table: "CourseFiles",
                column: "HomeworksId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseFiles_LabSheetsId",
                table: "CourseFiles",
                column: "LabSheetsId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseFiles_Midterm1WithSolutionsId",
                table: "CourseFiles",
                column: "Midterm1WithSolutionsId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseFiles_Midterm2WithSolutionsId",
                table: "CourseFiles",
                column: "Midterm2WithSolutionsId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseFiles_ProjectsId",
                table: "CourseFiles",
                column: "ProjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseFiles_QuizWithSolutionsId",
                table: "CourseFiles",
                column: "QuizWithSolutionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CourseFiles_CourseFilesid",
                table: "Courses",
                column: "CourseFilesid",
                principalTable: "CourseFiles",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
