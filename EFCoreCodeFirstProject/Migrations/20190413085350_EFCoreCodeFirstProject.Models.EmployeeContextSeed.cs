using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreCodeFirstProject.Migrations
{
    public partial class EFCoreCodeFirstProjectModelsEmployeeContextSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1L, new DateTime(1988, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "uncle.bob@gmail.com", "Sydney", "Hadebe", "078-516-7788" },
                    { 2L, new DateTime(2008, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Simbo.Sbu@gmail.com", "Practice", "Ndlovu", "078-469-9153" }
                });

            migrationBuilder.InsertData(
                table: "Professions",
                columns: new[] { "ProfessionId", "EmployeeId", "Speciality", "Title" },
                values: new object[,]
                {
                    { 1, 1L, "Web Services(Backend)", "Software Developer" },
                    { 2, 2L, "Mobile Services(Backend)", "Web Api Developer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "ProfessionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Professions",
                keyColumn: "ProfessionId",
                keyValue: 2);
        }
    }
}
