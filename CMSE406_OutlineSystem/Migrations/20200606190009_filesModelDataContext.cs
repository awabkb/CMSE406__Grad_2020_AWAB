using Microsoft.EntityFrameworkCore.Migrations;

namespace CMSE406_OutlineSystem.Migrations
{
    public partial class filesModelDataContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassTime_Courses_CourseCode1",
                table: "ClassTime");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseFiles_FileModel_AssignmentsId",
                table: "CourseFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseFiles_FileModel_BestWorstMedianFinalExamPapersId",
                table: "CourseFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseFiles_FileModel_BestWorstMedianMidterm1PapersId",
                table: "CourseFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseFiles_FileModel_BestWorstMedianMidterm2PapersId",
                table: "CourseFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseFiles_FileModel_CourseEvolutionDocId",
                table: "CourseFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseFiles_FileModel_CourseSyllabusId",
                table: "CourseFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseFiles_FileModel_FinalExamWithSolutionsId",
                table: "CourseFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseFiles_FileModel_HomeworksId",
                table: "CourseFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseFiles_FileModel_LabSheetsId",
                table: "CourseFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseFiles_FileModel_Midterm1WithSolutionsId",
                table: "CourseFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseFiles_FileModel_Midterm2WithSolutionsId",
                table: "CourseFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseFiles_FileModel_ProjectsId",
                table: "CourseFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseFiles_FileModel_QuizWithSolutionsId",
                table: "CourseFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_ClassTime_LabTimeCourseCode",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Prerequisite_Courses_CourseCode",
                table: "Prerequisite");

            migrationBuilder.DropPrimaryKey(
                name: "PK_studentLOs",
                table: "studentLOs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prerequisite",
                table: "Prerequisite");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FileModel",
                table: "FileModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassTime",
                table: "ClassTime");

            migrationBuilder.RenameTable(
                name: "studentLOs",
                newName: "StudentLOs");

            migrationBuilder.RenameTable(
                name: "Prerequisite",
                newName: "Prerequisites");

            migrationBuilder.RenameTable(
                name: "FileModel",
                newName: "FileModels");

            migrationBuilder.RenameTable(
                name: "ClassTime",
                newName: "ClassTimes");

            migrationBuilder.RenameIndex(
                name: "IX_Prerequisite_CourseCode",
                table: "Prerequisites",
                newName: "IX_Prerequisites_CourseCode");

            migrationBuilder.RenameIndex(
                name: "IX_ClassTime_CourseCode1",
                table: "ClassTimes",
                newName: "IX_ClassTimes_CourseCode1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentLOs",
                table: "StudentLOs",
                column: "SloCode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prerequisites",
                table: "Prerequisites",
                column: "PreCourseCode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FileModels",
                table: "FileModels",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassTimes",
                table: "ClassTimes",
                column: "CourseCode");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassTimes_Courses_CourseCode1",
                table: "ClassTimes",
                column: "CourseCode1",
                principalTable: "Courses",
                principalColumn: "CourseCode",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseFiles_FileModels_AssignmentsId",
                table: "CourseFiles",
                column: "AssignmentsId",
                principalTable: "FileModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseFiles_FileModels_BestWorstMedianFinalExamPapersId",
                table: "CourseFiles",
                column: "BestWorstMedianFinalExamPapersId",
                principalTable: "FileModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseFiles_FileModels_BestWorstMedianMidterm1PapersId",
                table: "CourseFiles",
                column: "BestWorstMedianMidterm1PapersId",
                principalTable: "FileModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseFiles_FileModels_BestWorstMedianMidterm2PapersId",
                table: "CourseFiles",
                column: "BestWorstMedianMidterm2PapersId",
                principalTable: "FileModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseFiles_FileModels_CourseEvolutionDocId",
                table: "CourseFiles",
                column: "CourseEvolutionDocId",
                principalTable: "FileModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseFiles_FileModels_CourseSyllabusId",
                table: "CourseFiles",
                column: "CourseSyllabusId",
                principalTable: "FileModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseFiles_FileModels_FinalExamWithSolutionsId",
                table: "CourseFiles",
                column: "FinalExamWithSolutionsId",
                principalTable: "FileModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseFiles_FileModels_HomeworksId",
                table: "CourseFiles",
                column: "HomeworksId",
                principalTable: "FileModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseFiles_FileModels_LabSheetsId",
                table: "CourseFiles",
                column: "LabSheetsId",
                principalTable: "FileModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseFiles_FileModels_Midterm1WithSolutionsId",
                table: "CourseFiles",
                column: "Midterm1WithSolutionsId",
                principalTable: "FileModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseFiles_FileModels_Midterm2WithSolutionsId",
                table: "CourseFiles",
                column: "Midterm2WithSolutionsId",
                principalTable: "FileModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseFiles_FileModels_ProjectsId",
                table: "CourseFiles",
                column: "ProjectsId",
                principalTable: "FileModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseFiles_FileModels_QuizWithSolutionsId",
                table: "CourseFiles",
                column: "QuizWithSolutionsId",
                principalTable: "FileModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_ClassTimes_LabTimeCourseCode",
                table: "Courses",
                column: "LabTimeCourseCode",
                principalTable: "ClassTimes",
                principalColumn: "CourseCode",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prerequisites_Courses_CourseCode",
                table: "Prerequisites",
                column: "CourseCode",
                principalTable: "Courses",
                principalColumn: "CourseCode",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassTimes_Courses_CourseCode1",
                table: "ClassTimes");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseFiles_FileModels_AssignmentsId",
                table: "CourseFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseFiles_FileModels_BestWorstMedianFinalExamPapersId",
                table: "CourseFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseFiles_FileModels_BestWorstMedianMidterm1PapersId",
                table: "CourseFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseFiles_FileModels_BestWorstMedianMidterm2PapersId",
                table: "CourseFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseFiles_FileModels_CourseEvolutionDocId",
                table: "CourseFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseFiles_FileModels_CourseSyllabusId",
                table: "CourseFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseFiles_FileModels_FinalExamWithSolutionsId",
                table: "CourseFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseFiles_FileModels_HomeworksId",
                table: "CourseFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseFiles_FileModels_LabSheetsId",
                table: "CourseFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseFiles_FileModels_Midterm1WithSolutionsId",
                table: "CourseFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseFiles_FileModels_Midterm2WithSolutionsId",
                table: "CourseFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseFiles_FileModels_ProjectsId",
                table: "CourseFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseFiles_FileModels_QuizWithSolutionsId",
                table: "CourseFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_ClassTimes_LabTimeCourseCode",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Prerequisites_Courses_CourseCode",
                table: "Prerequisites");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentLOs",
                table: "StudentLOs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prerequisites",
                table: "Prerequisites");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FileModels",
                table: "FileModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassTimes",
                table: "ClassTimes");

            migrationBuilder.RenameTable(
                name: "StudentLOs",
                newName: "studentLOs");

            migrationBuilder.RenameTable(
                name: "Prerequisites",
                newName: "Prerequisite");

            migrationBuilder.RenameTable(
                name: "FileModels",
                newName: "FileModel");

            migrationBuilder.RenameTable(
                name: "ClassTimes",
                newName: "ClassTime");

            migrationBuilder.RenameIndex(
                name: "IX_Prerequisites_CourseCode",
                table: "Prerequisite",
                newName: "IX_Prerequisite_CourseCode");

            migrationBuilder.RenameIndex(
                name: "IX_ClassTimes_CourseCode1",
                table: "ClassTime",
                newName: "IX_ClassTime_CourseCode1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_studentLOs",
                table: "studentLOs",
                column: "SloCode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prerequisite",
                table: "Prerequisite",
                column: "PreCourseCode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FileModel",
                table: "FileModel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassTime",
                table: "ClassTime",
                column: "CourseCode");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassTime_Courses_CourseCode1",
                table: "ClassTime",
                column: "CourseCode1",
                principalTable: "Courses",
                principalColumn: "CourseCode",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseFiles_FileModel_AssignmentsId",
                table: "CourseFiles",
                column: "AssignmentsId",
                principalTable: "FileModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseFiles_FileModel_BestWorstMedianFinalExamPapersId",
                table: "CourseFiles",
                column: "BestWorstMedianFinalExamPapersId",
                principalTable: "FileModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseFiles_FileModel_BestWorstMedianMidterm1PapersId",
                table: "CourseFiles",
                column: "BestWorstMedianMidterm1PapersId",
                principalTable: "FileModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseFiles_FileModel_BestWorstMedianMidterm2PapersId",
                table: "CourseFiles",
                column: "BestWorstMedianMidterm2PapersId",
                principalTable: "FileModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseFiles_FileModel_CourseEvolutionDocId",
                table: "CourseFiles",
                column: "CourseEvolutionDocId",
                principalTable: "FileModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseFiles_FileModel_CourseSyllabusId",
                table: "CourseFiles",
                column: "CourseSyllabusId",
                principalTable: "FileModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseFiles_FileModel_FinalExamWithSolutionsId",
                table: "CourseFiles",
                column: "FinalExamWithSolutionsId",
                principalTable: "FileModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseFiles_FileModel_HomeworksId",
                table: "CourseFiles",
                column: "HomeworksId",
                principalTable: "FileModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseFiles_FileModel_LabSheetsId",
                table: "CourseFiles",
                column: "LabSheetsId",
                principalTable: "FileModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseFiles_FileModel_Midterm1WithSolutionsId",
                table: "CourseFiles",
                column: "Midterm1WithSolutionsId",
                principalTable: "FileModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseFiles_FileModel_Midterm2WithSolutionsId",
                table: "CourseFiles",
                column: "Midterm2WithSolutionsId",
                principalTable: "FileModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseFiles_FileModel_ProjectsId",
                table: "CourseFiles",
                column: "ProjectsId",
                principalTable: "FileModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseFiles_FileModel_QuizWithSolutionsId",
                table: "CourseFiles",
                column: "QuizWithSolutionsId",
                principalTable: "FileModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_ClassTime_LabTimeCourseCode",
                table: "Courses",
                column: "LabTimeCourseCode",
                principalTable: "ClassTime",
                principalColumn: "CourseCode",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prerequisite_Courses_CourseCode",
                table: "Prerequisite",
                column: "CourseCode",
                principalTable: "Courses",
                principalColumn: "CourseCode",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
