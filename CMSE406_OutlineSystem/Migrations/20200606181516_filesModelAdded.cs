using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CMSE406_OutlineSystem.Migrations
{
    public partial class filesModelAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Assignments",
                table: "CourseFiles");

            migrationBuilder.DropColumn(
                name: "BestWorstMedianFinalExamPapers",
                table: "CourseFiles");

            migrationBuilder.DropColumn(
                name: "BestWorstMedianMidterm1Papers",
                table: "CourseFiles");

            migrationBuilder.DropColumn(
                name: "BestWorstMedianMidterm2Papers",
                table: "CourseFiles");

            migrationBuilder.DropColumn(
                name: "CourseEvolutionDoc",
                table: "CourseFiles");

            migrationBuilder.DropColumn(
                name: "CourseSyllabus",
                table: "CourseFiles");

            migrationBuilder.DropColumn(
                name: "FinalExamWithSolutions",
                table: "CourseFiles");

            migrationBuilder.DropColumn(
                name: "Homeworks",
                table: "CourseFiles");

            migrationBuilder.DropColumn(
                name: "LabSheets",
                table: "CourseFiles");

            migrationBuilder.DropColumn(
                name: "Midterm1WithSolutions",
                table: "CourseFiles");

            migrationBuilder.DropColumn(
                name: "Midterm2WithSolutions",
                table: "CourseFiles");

            migrationBuilder.DropColumn(
                name: "Projects",
                table: "CourseFiles");

            migrationBuilder.DropColumn(
                name: "QuizWithSolutions",
                table: "CourseFiles");

            migrationBuilder.AddColumn<int>(
                name: "AssignmentsId",
                table: "CourseFiles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BestWorstMedianFinalExamPapersId",
                table: "CourseFiles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BestWorstMedianMidterm1PapersId",
                table: "CourseFiles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BestWorstMedianMidterm2PapersId",
                table: "CourseFiles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseEvolutionDocId",
                table: "CourseFiles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseSyllabusId",
                table: "CourseFiles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FinalExamWithSolutionsId",
                table: "CourseFiles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HomeworksId",
                table: "CourseFiles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LabSheetsId",
                table: "CourseFiles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Midterm1WithSolutionsId",
                table: "CourseFiles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Midterm2WithSolutionsId",
                table: "CourseFiles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectsId",
                table: "CourseFiles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuizWithSolutionsId",
                table: "CourseFiles",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FileModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    PublicId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileModel", x => x.Id);
                });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropTable(
                name: "FileModel");

            migrationBuilder.DropIndex(
                name: "IX_CourseFiles_AssignmentsId",
                table: "CourseFiles");

            migrationBuilder.DropIndex(
                name: "IX_CourseFiles_BestWorstMedianFinalExamPapersId",
                table: "CourseFiles");

            migrationBuilder.DropIndex(
                name: "IX_CourseFiles_BestWorstMedianMidterm1PapersId",
                table: "CourseFiles");

            migrationBuilder.DropIndex(
                name: "IX_CourseFiles_BestWorstMedianMidterm2PapersId",
                table: "CourseFiles");

            migrationBuilder.DropIndex(
                name: "IX_CourseFiles_CourseEvolutionDocId",
                table: "CourseFiles");

            migrationBuilder.DropIndex(
                name: "IX_CourseFiles_CourseSyllabusId",
                table: "CourseFiles");

            migrationBuilder.DropIndex(
                name: "IX_CourseFiles_FinalExamWithSolutionsId",
                table: "CourseFiles");

            migrationBuilder.DropIndex(
                name: "IX_CourseFiles_HomeworksId",
                table: "CourseFiles");

            migrationBuilder.DropIndex(
                name: "IX_CourseFiles_LabSheetsId",
                table: "CourseFiles");

            migrationBuilder.DropIndex(
                name: "IX_CourseFiles_Midterm1WithSolutionsId",
                table: "CourseFiles");

            migrationBuilder.DropIndex(
                name: "IX_CourseFiles_Midterm2WithSolutionsId",
                table: "CourseFiles");

            migrationBuilder.DropIndex(
                name: "IX_CourseFiles_ProjectsId",
                table: "CourseFiles");

            migrationBuilder.DropIndex(
                name: "IX_CourseFiles_QuizWithSolutionsId",
                table: "CourseFiles");

            migrationBuilder.DropColumn(
                name: "AssignmentsId",
                table: "CourseFiles");

            migrationBuilder.DropColumn(
                name: "BestWorstMedianFinalExamPapersId",
                table: "CourseFiles");

            migrationBuilder.DropColumn(
                name: "BestWorstMedianMidterm1PapersId",
                table: "CourseFiles");

            migrationBuilder.DropColumn(
                name: "BestWorstMedianMidterm2PapersId",
                table: "CourseFiles");

            migrationBuilder.DropColumn(
                name: "CourseEvolutionDocId",
                table: "CourseFiles");

            migrationBuilder.DropColumn(
                name: "CourseSyllabusId",
                table: "CourseFiles");

            migrationBuilder.DropColumn(
                name: "FinalExamWithSolutionsId",
                table: "CourseFiles");

            migrationBuilder.DropColumn(
                name: "HomeworksId",
                table: "CourseFiles");

            migrationBuilder.DropColumn(
                name: "LabSheetsId",
                table: "CourseFiles");

            migrationBuilder.DropColumn(
                name: "Midterm1WithSolutionsId",
                table: "CourseFiles");

            migrationBuilder.DropColumn(
                name: "Midterm2WithSolutionsId",
                table: "CourseFiles");

            migrationBuilder.DropColumn(
                name: "ProjectsId",
                table: "CourseFiles");

            migrationBuilder.DropColumn(
                name: "QuizWithSolutionsId",
                table: "CourseFiles");

            migrationBuilder.AddColumn<string>(
                name: "Assignments",
                table: "CourseFiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BestWorstMedianFinalExamPapers",
                table: "CourseFiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BestWorstMedianMidterm1Papers",
                table: "CourseFiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BestWorstMedianMidterm2Papers",
                table: "CourseFiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CourseEvolutionDoc",
                table: "CourseFiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CourseSyllabus",
                table: "CourseFiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FinalExamWithSolutions",
                table: "CourseFiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Homeworks",
                table: "CourseFiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LabSheets",
                table: "CourseFiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Midterm1WithSolutions",
                table: "CourseFiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Midterm2WithSolutions",
                table: "CourseFiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Projects",
                table: "CourseFiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "QuizWithSolutions",
                table: "CourseFiles",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
