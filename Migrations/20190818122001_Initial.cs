using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student_Attendance_All",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AttendanceDate = table.Column<DateTime>(nullable: false),
                    studentName = table.Column<string>(maxLength: 255, nullable: false),
                    studentRoll = table.Column<int>(nullable: false),
                    createdTime = table.Column<DateTime>(nullable: false),
                    updatedBy = table.Column<string>(nullable: true),
                    updatedTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_Attendance_All", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 255, nullable: false),
                    email = table.Column<string>(maxLength: 255, nullable: false),
                    passwordHash = table.Column<byte[]>(maxLength: 255, nullable: false),
                    passwordSalt = table.Column<byte[]>(nullable: true),
                    Designation = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    LastActive = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Url = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    isMain = table.Column<bool>(nullable: false),
                    UserModelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_Users_UserModelId",
                        column: x => x.UserModelId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserModelId = table.Column<int>(nullable: false),
                    studentName = table.Column<string>(maxLength: 255, nullable: false),
                    studentRoll = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    StudentUrl = table.Column<string>(nullable: true),
                    createdTime = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    updatedBy = table.Column<string>(nullable: true),
                    updatedTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student_Users_UserModelId",
                        column: x => x.UserModelId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    FatherName = table.Column<string>(nullable: true),
                    MotherName = table.Column<string>(nullable: true),
                    Createdat = table.Column<DateTime>(nullable: false),
                    UserModelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDetails_Users_UserModelId",
                        column: x => x.UserModelId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users_Phone_Number",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    userPhoneAll = table.Column<long>(nullable: false),
                    UserModelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users_Phone_Number", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Phone_Number_Users_UserModelId",
                        column: x => x.UserModelId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentAttendance",
                columns: table => new
                {
                    StudentDetailsModelId = table.Column<int>(nullable: false),
                    StudentAttendanceModelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAttendance", x => new { x.StudentDetailsModelId, x.StudentAttendanceModelId });
                    table.ForeignKey(
                        name: "FK_StudentAttendance_Student_Attendance_All_StudentAttendanceModelId",
                        column: x => x.StudentAttendanceModelId,
                        principalTable: "Student_Attendance_All",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentAttendance_Student_StudentDetailsModelId",
                        column: x => x.StudentDetailsModelId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photos_UserModelId",
                table: "Photos",
                column: "UserModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_UserModelId",
                table: "Student",
                column: "UserModelId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAttendance_StudentAttendanceModelId",
                table: "StudentAttendance",
                column: "StudentAttendanceModelId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetails_UserModelId",
                table: "UserDetails",
                column: "UserModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Phone_Number_UserModelId",
                table: "Users_Phone_Number",
                column: "UserModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "StudentAttendance");

            migrationBuilder.DropTable(
                name: "UserDetails");

            migrationBuilder.DropTable(
                name: "Users_Phone_Number");

            migrationBuilder.DropTable(
                name: "Student_Attendance_All");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
