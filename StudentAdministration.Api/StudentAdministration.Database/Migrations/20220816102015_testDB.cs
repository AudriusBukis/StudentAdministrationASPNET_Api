using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentAdministration.Database.Migrations
{
    public partial class testDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    PersonalNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.PersonalNumber);
                });

            migrationBuilder.CreateTable(
                name: "StudiesPrograms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Credits = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudiesPrograms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentStudieEnrolls",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentPersonalNumber = table.Column<string>(type: "nvarchar(11)", nullable: false),
                    ProgramId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EnrollYear = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentStudieEnrolls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentStudieEnrolls_Student_StudentPersonalNumber",
                        column: x => x.StudentPersonalNumber,
                        principalTable: "Student",
                        principalColumn: "PersonalNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentStudieEnrolls_StudiesPrograms_ProgramId",
                        column: x => x.ProgramId,
                        principalTable: "StudiesPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudiesSubSubject",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Credits = table.Column<int>(type: "int", nullable: false),
                    StudiesProgramId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StudiesSubSubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudiesSubSubject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudiesSubSubject_StudiesPrograms_StudiesProgramId",
                        column: x => x.StudiesProgramId,
                        principalTable: "StudiesPrograms",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudiesSubSubject_StudiesSubSubject_StudiesSubSubjectId",
                        column: x => x.StudiesSubSubjectId,
                        principalTable: "StudiesSubSubject",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StudiesSubject",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Credits = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    StudiesProgramId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StudiesSubSubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudiesSubject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudiesSubject_StudiesPrograms_StudiesProgramId",
                        column: x => x.StudiesProgramId,
                        principalTable: "StudiesPrograms",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudiesSubject_StudiesSubSubject_StudiesSubSubjectId",
                        column: x => x.StudiesSubSubjectId,
                        principalTable: "StudiesSubSubject",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentStudieEnrolls_ProgramId",
                table: "StudentStudieEnrolls",
                column: "ProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentStudieEnrolls_StudentPersonalNumber",
                table: "StudentStudieEnrolls",
                column: "StudentPersonalNumber");

            migrationBuilder.CreateIndex(
                name: "IX_StudiesSubject_StudiesProgramId",
                table: "StudiesSubject",
                column: "StudiesProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_StudiesSubject_StudiesSubSubjectId",
                table: "StudiesSubject",
                column: "StudiesSubSubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_StudiesSubSubject_StudiesProgramId",
                table: "StudiesSubSubject",
                column: "StudiesProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_StudiesSubSubject_StudiesSubSubjectId",
                table: "StudiesSubSubject",
                column: "StudiesSubSubjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentStudieEnrolls");

            migrationBuilder.DropTable(
                name: "StudiesSubject");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "StudiesSubSubject");

            migrationBuilder.DropTable(
                name: "StudiesPrograms");
        }
    }
}
