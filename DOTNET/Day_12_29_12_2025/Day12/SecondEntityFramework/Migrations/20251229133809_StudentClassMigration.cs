using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecondEntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class StudentClassMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentData",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "varchar(50)", nullable: true),
                    StudentMarks = table.Column<double>(type: "float", nullable: false),
                    StudentAdmissionDate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentData", x => x.StudentID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentData");
        }
    }
}
