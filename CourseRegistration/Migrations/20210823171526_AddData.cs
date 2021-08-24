using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseRegistration.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "C_Name", "C_Number", "Description" },
                values: new object[] { 1001, "Math", 1, "Geometry" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "C_Name", "C_Number", "Description" },
                values: new object[] { 1002, "Science", 2, "Biology" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "C_Name", "C_Number", "Description" },
                values: new object[] { 1003, "Computer Science", 3, "Web Development" });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "I_Id", "CourseId", "EmailAddress", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 101, 1001, "markjohnson@gmail.com", "Mark", "Johnson" },
                    { 102, 1002, "lucysmith@gmail.com", "Lucy", "Smith" },
                    { 103, 1003, "trecybrown@gmail.com", "Trecy", "Brown" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "CourseId", "EmailAddress", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, 1001, "danialpara@gmail.com", "Danial", "Para", "5879207077" },
                    { 5, 1001, "samueljohnson@gmail.com", "Samuel", "Johnson", "6785644560" },
                    { 2, 1002, "parkerjames@gmail.com", "Parker", "James", "7809304545" },
                    { 6, 1002, "tommylee@gmail.com", "Tommy", "Lee", "4785684564" },
                    { 3, 1003, "robinsmith@gmail.com", "Robin", "Smith", "6785674564" },
                    { 4, 1003, "suratandan@gmail.com", "Sura", "Tandan", "2785674504" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "I_Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "I_Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "I_Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1003);
        }
    }
}
