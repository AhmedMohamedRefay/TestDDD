using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Structure.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatesomePropertyInDepartmentModeles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_CompaniesEmployeeInformations_EmployeeInformatio~",
                schema: "Structure",
                table: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Department_CompanyId",
                schema: "Structure",
                table: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Department_EmployeeInformationsEmployeeId_EmployeeInformati~",
                schema: "Structure",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "EmployeeInformationsCompanyId",
                schema: "Structure",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "EmployeeInformationsEmployeeId",
                schema: "Structure",
                table: "Department");

            migrationBuilder.CreateIndex(
                name: "IX_Department_CompanyId_ManagerId",
                schema: "Structure",
                table: "Department",
                columns: new[] { "CompanyId", "ManagerId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Department_CompaniesEmployeeInformations_CompanyId_ManagerId",
                schema: "Structure",
                table: "Department",
                columns: new[] { "CompanyId", "ManagerId" },
                principalSchema: "Structure",
                principalTable: "CompaniesEmployeeInformations",
                principalColumns: new[] { "EmployeeId", "CompanyId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_CompaniesEmployeeInformations_CompanyId_ManagerId",
                schema: "Structure",
                table: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Department_CompanyId_ManagerId",
                schema: "Structure",
                table: "Department");

            migrationBuilder.AddColumn<Guid>(
                name: "EmployeeInformationsCompanyId",
                schema: "Structure",
                table: "Department",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "EmployeeInformationsEmployeeId",
                schema: "Structure",
                table: "Department",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Department_CompanyId",
                schema: "Structure",
                table: "Department",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Department_EmployeeInformationsEmployeeId_EmployeeInformati~",
                schema: "Structure",
                table: "Department",
                columns: new[] { "EmployeeInformationsEmployeeId", "EmployeeInformationsCompanyId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Department_CompaniesEmployeeInformations_EmployeeInformatio~",
                schema: "Structure",
                table: "Department",
                columns: new[] { "EmployeeInformationsEmployeeId", "EmployeeInformationsCompanyId" },
                principalSchema: "Structure",
                principalTable: "CompaniesEmployeeInformations",
                principalColumns: new[] { "EmployeeId", "CompanyId" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
