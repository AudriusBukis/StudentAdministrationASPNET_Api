using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentAdministration.Database.Migrations
{
    public partial class testDB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentStudieEnrolls_Student_StudentPersonalNumber",
                table: "StudentStudieEnrolls");

            migrationBuilder.DropIndex(
                name: "IX_StudentStudieEnrolls_StudentPersonalNumber",
                table: "StudentStudieEnrolls");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "StudentPersonalNumber",
                table: "StudentStudieEnrolls");

            migrationBuilder.AddColumn<Guid>(
                name: "StudentId",
                table: "StudentStudieEnrolls",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "PersonalNumber",
                table: "Student",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_StudentStudieEnrolls_StudentId",
                table: "StudentStudieEnrolls",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentStudieEnrolls_Student_StudentId",
                table: "StudentStudieEnrolls",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentStudieEnrolls_Student_StudentId",
                table: "StudentStudieEnrolls");

            migrationBuilder.DropIndex(
                name: "IX_StudentStudieEnrolls_StudentId",
                table: "StudentStudieEnrolls");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "StudentStudieEnrolls");

            migrationBuilder.AddColumn<string>(
                name: "StudentPersonalNumber",
                table: "StudentStudieEnrolls",
                type: "nvarchar(11)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "PersonalNumber",
                table: "Student",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "PersonalNumber");

            migrationBuilder.CreateIndex(
                name: "IX_StudentStudieEnrolls_StudentPersonalNumber",
                table: "StudentStudieEnrolls",
                column: "StudentPersonalNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentStudieEnrolls_Student_StudentPersonalNumber",
                table: "StudentStudieEnrolls",
                column: "StudentPersonalNumber",
                principalTable: "Student",
                principalColumn: "PersonalNumber",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
