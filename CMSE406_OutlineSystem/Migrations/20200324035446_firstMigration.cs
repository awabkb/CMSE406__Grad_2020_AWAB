using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CMSE406_OutlineSystem.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssessmentTypes",
                columns: table => new
                {
                    AssessmentCode = table.Column<string>(nullable: false),
                    AssessmentName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentTypes", x => x.AssessmentCode);
                });

            migrationBuilder.CreateTable(
                name: "CourseLOs",
                columns: table => new
                {
                    CloCode = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseLearningOutcomes = table.Column<string>(nullable: true),
                    CourseCode = table.Column<string>(nullable: true),
                    Rcode = table.Column<int>(nullable: false),
                    YearSemester = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseLOs", x => x.CloCode);
                });

            migrationBuilder.CreateTable(
                name: "CourseSemesterWeeklySchedules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseCode = table.Column<string>(nullable: true),
                    Rcode = table.Column<int>(nullable: false),
                    YearSemester = table.Column<string>(nullable: true),
                    WeekNo = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    LectureTopic = table.Column<string>(nullable: true),
                    LabTopic = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseSemesterWeeklySchedules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "studentLOs",
                columns: table => new
                {
                    SloCode = table.Column<string>(nullable: false),
                    StudentLearningOutcomes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentLOs", x => x.SloCode);
                });

            migrationBuilder.CreateTable(
                name: "StudyPrograms",
                columns: table => new
                {
                    ProgramCode = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgramName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyPrograms", x => x.ProgramCode);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    SurName = table.Column<string>(nullable: true),
                    TypeOfUser = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Office = table.Column<string>(nullable: true),
                    OfficeTel = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CourseAssessments",
                columns: table => new
                {
                    AssessmentCode = table.Column<string>(nullable: false),
                    CourseCode = table.Column<string>(nullable: true),
                    Rcode = table.Column<int>(nullable: false),
                    YearSemester = table.Column<string>(nullable: true),
                    Percentage = table.Column<int>(nullable: false),
                    AssessmentTypeAssessmentCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseAssessments", x => x.AssessmentCode);
                    table.ForeignKey(
                        name: "FK_CourseAssessments_AssessmentTypes_AssessmentTypeAssessmentCode",
                        column: x => x.AssessmentTypeAssessmentCode,
                        principalTable: "AssessmentTypes",
                        principalColumn: "AssessmentCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CourseSemesterDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseCode = table.Column<string>(nullable: true),
                    Rcode = table.Column<int>(nullable: false),
                    YearSemester = table.Column<string>(nullable: true),
                    TextBook = table.Column<string>(nullable: true),
                    IndicativeBasicReadingList = table.Column<string>(nullable: true),
                    MeetingTimePlace = table.Column<string>(nullable: true),
                    InstructorId = table.Column<int>(nullable: false),
                    AssistantId = table.Column<int>(nullable: false),
                    AttendanceGrade = table.Column<int>(nullable: false),
                    MakeupPolicy = table.Column<string>(nullable: true),
                    NgGradePolicy = table.Column<string>(nullable: true),
                    MissedLabPolicy = table.Column<string>(nullable: true),
                    CourseSemesterWeeklyScheduleId = table.Column<int>(nullable: true),
                    CourseAssessmentAssessmentCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseSemesterDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseSemesterDetails_CourseAssessments_CourseAssessmentAssessmentCode",
                        column: x => x.CourseAssessmentAssessmentCode,
                        principalTable: "CourseAssessments",
                        principalColumn: "AssessmentCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseSemesterDetails_CourseSemesterWeeklySchedules_CourseSemesterWeeklyScheduleId",
                        column: x => x.CourseSemesterWeeklyScheduleId,
                        principalTable: "CourseSemesterWeeklySchedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseCode = table.Column<string>(nullable: false),
                    Rcode = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ReqOrElc = table.Column<string>(nullable: true),
                    LectureHour = table.Column<DateTime>(nullable: false),
                    LabHour = table.Column<DateTime>(nullable: false),
                    Credits = table.Column<int>(nullable: false),
                    Ects = table.Column<int>(nullable: false),
                    Semester = table.Column<string>(nullable: true),
                    Department = table.Column<string>(nullable: true),
                    CourseDescription = table.Column<string>(nullable: true),
                    CourseWebpage = table.Column<string>(nullable: true),
                    CourseSemesterDetailsId = table.Column<int>(nullable: true),
                    CourseLOCloCode = table.Column<int>(nullable: true),
                    CourseCode1 = table.Column<string>(nullable: true),
                    StudyProgramProgramCode = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseCode);
                    table.ForeignKey(
                        name: "FK_Courses_Courses_CourseCode1",
                        column: x => x.CourseCode1,
                        principalTable: "Courses",
                        principalColumn: "CourseCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Courses_CourseLOs_CourseLOCloCode",
                        column: x => x.CourseLOCloCode,
                        principalTable: "CourseLOs",
                        principalColumn: "CloCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Courses_CourseSemesterDetails_CourseSemesterDetailsId",
                        column: x => x.CourseSemesterDetailsId,
                        principalTable: "CourseSemesterDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Courses_StudyPrograms_StudyProgramProgramCode",
                        column: x => x.StudyProgramProgramCode,
                        principalTable: "StudyPrograms",
                        principalColumn: "ProgramCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseAssessments_AssessmentTypeAssessmentCode",
                table: "CourseAssessments",
                column: "AssessmentTypeAssessmentCode");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseCode1",
                table: "Courses",
                column: "CourseCode1");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseLOCloCode",
                table: "Courses",
                column: "CourseLOCloCode");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseSemesterDetailsId",
                table: "Courses",
                column: "CourseSemesterDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_StudyProgramProgramCode",
                table: "Courses",
                column: "StudyProgramProgramCode");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSemesterDetails_CourseAssessmentAssessmentCode",
                table: "CourseSemesterDetails",
                column: "CourseAssessmentAssessmentCode");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSemesterDetails_CourseSemesterWeeklyScheduleId",
                table: "CourseSemesterDetails",
                column: "CourseSemesterWeeklyScheduleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "studentLOs");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "CourseLOs");

            migrationBuilder.DropTable(
                name: "CourseSemesterDetails");

            migrationBuilder.DropTable(
                name: "StudyPrograms");

            migrationBuilder.DropTable(
                name: "CourseAssessments");

            migrationBuilder.DropTable(
                name: "CourseSemesterWeeklySchedules");

            migrationBuilder.DropTable(
                name: "AssessmentTypes");
        }
    }
}
