using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CMSE406_OutlineSystem.Migrations
{
    public partial class secondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Courses_CourseCode1",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CourseCode1",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseCode1",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "LabHour",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "LectureHour",
                table: "Courses");

            migrationBuilder.AddColumn<string>(
                name: "LabTimeCourseCode",
                table: "Courses",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ClassTime",
                columns: table => new
                {
                    CourseCode = table.Column<string>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    FinishTime = table.Column<DateTime>(nullable: false),
                    CourseCode1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassTime", x => x.CourseCode);
                    table.ForeignKey(
                        name: "FK_ClassTime_Courses_CourseCode1",
                        column: x => x.CourseCode1,
                        principalTable: "Courses",
                        principalColumn: "CourseCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prerequisite",
                columns: table => new
                {
                    PreCourseCode = table.Column<string>(nullable: false),
                    PreCourseName = table.Column<string>(nullable: true),
                    CourseCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prerequisite", x => x.PreCourseCode);
                    table.ForeignKey(
                        name: "FK_Prerequisite_Courses_CourseCode",
                        column: x => x.CourseCode,
                        principalTable: "Courses",
                        principalColumn: "CourseCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_LabTimeCourseCode",
                table: "Courses",
                column: "LabTimeCourseCode");

            migrationBuilder.CreateIndex(
                name: "IX_ClassTime_CourseCode1",
                table: "ClassTime",
                column: "CourseCode1");

            migrationBuilder.CreateIndex(
                name: "IX_Prerequisite_CourseCode",
                table: "Prerequisite",
                column: "CourseCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_ClassTime_LabTimeCourseCode",
                table: "Courses",
                column: "LabTimeCourseCode",
                principalTable: "ClassTime",
                principalColumn: "CourseCode",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_ClassTime_LabTimeCourseCode",
                table: "Courses");

            migrationBuilder.DropTable(
                name: "ClassTime");

            migrationBuilder.DropTable(
                name: "Prerequisite");

            migrationBuilder.DropIndex(
                name: "IX_Courses_LabTimeCourseCode",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "LabTimeCourseCode",
                table: "Courses");

            migrationBuilder.AddColumn<string>(
                name: "CourseCode1",
                table: "Courses",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LabHour",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LectureHour",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseCode1",
                table: "Courses",
                column: "CourseCode1");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Courses_CourseCode1",
                table: "Courses",
                column: "CourseCode1",
                principalTable: "Courses",
                principalColumn: "CourseCode",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
