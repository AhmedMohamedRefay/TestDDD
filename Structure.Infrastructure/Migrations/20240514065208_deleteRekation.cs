using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Structure.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class deleteRekation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePositions_CompaniesEmployeeInformations_CompanyId_E~",
                schema: "Structure",
                table: "EmployeePositions");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePositions_DepartmentsJobs_DepartmentId_JobId",
                schema: "Structure",
                table: "EmployeePositions");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePositions_CompanyId_EmployeeId",
                schema: "Structure",
                table: "EmployeePositions");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePositions_EmployeeId_CompanyId",
                schema: "Structure",
                table: "EmployeePositions",
                columns: new[] { "EmployeeId", "CompanyId" });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePositions_JobId_DepartmentId",
                schema: "Structure",
                table: "EmployeePositions",
                columns: new[] { "JobId", "DepartmentId" });

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePositions_CompaniesEmployeeInformations_EmployeeId_~",
                schema: "Structure",
                table: "EmployeePositions",
                columns: new[] { "EmployeeId", "CompanyId" },
                principalSchema: "Structure",
                principalTable: "CompaniesEmployeeInformations",
                principalColumns: new[] { "EmployeeId", "CompanyId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePositions_DepartmentsJobs_JobId_DepartmentId",
                schema: "Structure",
                table: "EmployeePositions",
                columns: new[] { "JobId", "DepartmentId" },
                principalSchema: "Structure",
                principalTable: "DepartmentsJobs",
                principalColumns: new[] { "JobId", "DepartmentId" },
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePositions_CompaniesEmployeeInformations_EmployeeId_~",
                schema: "Structure",
                table: "EmployeePositions");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePositions_DepartmentsJobs_JobId_DepartmentId",
                schema: "Structure",
                table: "EmployeePositions");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePositions_EmployeeId_CompanyId",
                schema: "Structure",
                table: "EmployeePositions");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePositions_JobId_DepartmentId",
                schema: "Structure",
                table: "EmployeePositions");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePositions_CompanyId_EmployeeId",
                schema: "Structure",
                table: "EmployeePositions",
                columns: new[] { "CompanyId", "EmployeeId" });

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePositions_CompaniesEmployeeInformations_CompanyId_E~",
                schema: "Structure",
                table: "EmployeePositions",
                columns: new[] { "CompanyId", "EmployeeId" },
                principalSchema: "Structure",
                principalTable: "CompaniesEmployeeInformations",
                principalColumns: new[] { "EmployeeId", "CompanyId" },
                onDelete: ReferentialAction.Cascade);

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
    }
}
