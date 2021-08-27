using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseRegistration.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Courses_CourseId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_CourseId",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "CoursesCourseId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_CoursesCourseId",
                table: "Students",
                column: "CoursesCourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_CoursesCourseId",
                table: "Students",
                column: "CoursesCourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Courses_CoursesCourseId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_CoursesCourseId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CoursesCourseId",
                table: "Students");

            migrationBuilder.CreateIndex(
                name: "IX_Students_CourseId",
                table: "Students",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_CourseId",
                table: "Students",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
