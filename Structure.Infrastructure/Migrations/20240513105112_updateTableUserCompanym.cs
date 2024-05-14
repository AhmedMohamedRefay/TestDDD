using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Structure.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateTableUserCompanym : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePositions_DepartmentsJobs_DepartmentId_JobId",
                schema: "Structure",
                table: "EmployeePositions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartmentsJobs",
                schema: "Structure",
                table: "DepartmentsJobs");

            migrationBuilder.DropColumn(
                name: "DerpatmentId",
                schema: "Structure",
                table: "DepartmentsJobs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartmentsJobs",
                schema: "Structure",
                table: "DepartmentsJobs",
                columns: new[] { "JobId", "DepartmentId" });

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePositions_DepartmentsJobs_DepartmentId_JobId",
                schema: "Structure",
                table: "EmployeePositions",
                columns: new[] { "DepartmentId", "JobId" },
                principalSchema: "Structure",
                principalTable: "DepartmentsJobs",
                principalColumns: new[] { "JobId", "DepartmentId" },
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePositions_DepartmentsJobs_DepartmentId_JobId",
                schema: "Structure",
                table: "EmployeePositions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartmentsJobs",
                schema: "Structure",
                table: "DepartmentsJobs");

            migrationBuilder.AddColumn<Guid>(
                name: "DerpatmentId",
                schema: "Structure",
                table: "DepartmentsJobs",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartmentsJobs",
                schema: "Structure",
                table: "DepartmentsJobs",
                columns: new[] { "JobId", "DerpatmentId" });

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePositions_DepartmentsJobs_DepartmentId_JobId",
                schema: "Structure",
                table: "EmployeePositions",
                columns: new[] { "DepartmentId", "JobId" },
                principalSchema: "Structure",
                principalTable: "DepartmentsJobs",
                principalColumns: new[] { "JobId", "DerpatmentId" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
