using Microsoft.EntityFrameworkCore.Migrations;

namespace CMSE406_OutlineSystem.Migrations
{
    public partial class descIdAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FileModels_Courses_CourseCode",
                table: "FileModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FileModels",
                table: "FileModels");

            migrationBuilder.RenameTable(
                name: "FileModels",
                newName: "Files");

            migrationBuilder.RenameIndex(
                name: "IX_FileModels_CourseCode",
                table: "Files",
                newName: "IX_Files_CourseCode");

            migrationBuilder.AlterColumn<int>(
                name: "Rcode",
                table: "Courses",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "InstructorID",
                table: "Courses",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Ects",
                table: "Courses",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Credits",
                table: "Courses",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "DesId",
                table: "Files",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Files",
                table: "Files",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Courses_CourseCode",
                table: "Files",
                column: "CourseCode",
                principalTable: "Courses",
                principalColumn: "CourseCode",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Files_Courses_CourseCode",
                table: "Files");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Files",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "DesId",
                table: "Files");

            migrationBuilder.RenameTable(
                name: "Files",
                newName: "FileModels");

            migrationBuilder.RenameIndex(
                name: "IX_Files_CourseCode",
                table: "FileModels",
                newName: "IX_FileModels_CourseCode");

            migrationBuilder.AlterColumn<int>(
                name: "Rcode",
                table: "Courses",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InstructorID",
                table: "Courses",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Ects",
                table: "Courses",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Credits",
                table: "Courses",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FileModels",
                table: "FileModels",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FileModels_Courses_CourseCode",
                table: "FileModels",
                column: "CourseCode",
                principalTable: "Courses",
                principalColumn: "CourseCode",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
