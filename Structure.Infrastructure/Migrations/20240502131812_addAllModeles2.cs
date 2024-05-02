using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Structure.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addAllModeles2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompaniesEmployeeInformations_CompanyEmployeeStatuses_Statu~",
                schema: "Structure",
                table: "CompaniesEmployeeInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_CompaniesEmployeeInformations_Roles_RoleId",
                schema: "Structure",
                table: "CompaniesEmployeeInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_InjuryAndDeathRegistrations_CompaniesEmployeeInformations_C~",
                table: "InjuryAndDeathRegistrations");

            migrationBuilder.DropForeignKey(
                name: "FK_InjuryAndDeathRegistrations_InjuryTypes_InjuryTypesId",
                table: "InjuryAndDeathRegistrations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InjuryAndDeathRegistrations",
                table: "InjuryAndDeathRegistrations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyEmployeeStatuses",
                table: "CompanyEmployeeStatuses");

            migrationBuilder.RenameTable(
                name: "TerminationReasons",
                newName: "TerminationReasons",
                newSchema: "Structure");

            migrationBuilder.RenameTable(
                name: "InjuryTypes",
                newName: "InjuryTypes",
                newSchema: "Structure");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "Role",
                newSchema: "Structure");

            migrationBuilder.RenameTable(
                name: "InjuryAndDeathRegistrations",
                newName: "InjuryAndDeathRegistration",
                newSchema: "Structure");

            migrationBuilder.RenameTable(
                name: "CompanyEmployeeStatuses",
                newName: "CompanyEmployeeStatus",
                newSchema: "Structure");

            migrationBuilder.RenameIndex(
                name: "IX_InjuryAndDeathRegistrations_InjuryTypesId",
                schema: "Structure",
                table: "InjuryAndDeathRegistration",
                newName: "IX_InjuryAndDeathRegistration_InjuryTypesId");

            migrationBuilder.RenameIndex(
                name: "IX_InjuryAndDeathRegistrations_CompaniesEmployeeInformationsEm~",
                schema: "Structure",
                table: "InjuryAndDeathRegistration",
                newName: "IX_InjuryAndDeathRegistration_CompaniesEmployeeInformationsEmp~");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Role",
                schema: "Structure",
                table: "Role",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InjuryAndDeathRegistration",
                schema: "Structure",
                table: "InjuryAndDeathRegistration",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyEmployeeStatus",
                schema: "Structure",
                table: "CompanyEmployeeStatus",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CompaniesEmployeeInformations_CompanyEmployeeStatus_StatusId",
                schema: "Structure",
                table: "CompaniesEmployeeInformations",
                column: "StatusId",
                principalSchema: "Structure",
                principalTable: "CompanyEmployeeStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompaniesEmployeeInformations_Role_RoleId",
                schema: "Structure",
                table: "CompaniesEmployeeInformations",
                column: "RoleId",
                principalSchema: "Structure",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InjuryAndDeathRegistration_CompaniesEmployeeInformations_Co~",
                schema: "Structure",
                table: "InjuryAndDeathRegistration",
                columns: new[] { "CompaniesEmployeeInformationsEmployeeId", "CompaniesEmployeeInformationsCompanyId" },
                principalSchema: "Structure",
                principalTable: "CompaniesEmployeeInformations",
                principalColumns: new[] { "EmployeeId", "CompanyId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InjuryAndDeathRegistration_InjuryTypes_InjuryTypesId",
                schema: "Structure",
                table: "InjuryAndDeathRegistration",
                column: "InjuryTypesId",
                principalSchema: "Structure",
                principalTable: "InjuryTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompaniesEmployeeInformations_CompanyEmployeeStatus_StatusId",
                schema: "Structure",
                table: "CompaniesEmployeeInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_CompaniesEmployeeInformations_Role_RoleId",
                schema: "Structure",
                table: "CompaniesEmployeeInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_InjuryAndDeathRegistration_CompaniesEmployeeInformations_Co~",
                schema: "Structure",
                table: "InjuryAndDeathRegistration");

            migrationBuilder.DropForeignKey(
                name: "FK_InjuryAndDeathRegistration_InjuryTypes_InjuryTypesId",
                schema: "Structure",
                table: "InjuryAndDeathRegistration");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Role",
                schema: "Structure",
                table: "Role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InjuryAndDeathRegistration",
                schema: "Structure",
                table: "InjuryAndDeathRegistration");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyEmployeeStatus",
                schema: "Structure",
                table: "CompanyEmployeeStatus");

            migrationBuilder.RenameTable(
                name: "TerminationReasons",
                schema: "Structure",
                newName: "TerminationReasons");

            migrationBuilder.RenameTable(
                name: "InjuryTypes",
                schema: "Structure",
                newName: "InjuryTypes");

            migrationBuilder.RenameTable(
                name: "Role",
                schema: "Structure",
                newName: "Roles");

            migrationBuilder.RenameTable(
                name: "InjuryAndDeathRegistration",
                schema: "Structure",
                newName: "InjuryAndDeathRegistrations");

            migrationBuilder.RenameTable(
                name: "CompanyEmployeeStatus",
                schema: "Structure",
                newName: "CompanyEmployeeStatuses");

            migrationBuilder.RenameIndex(
                name: "IX_InjuryAndDeathRegistration_InjuryTypesId",
                table: "InjuryAndDeathRegistrations",
                newName: "IX_InjuryAndDeathRegistrations_InjuryTypesId");

            migrationBuilder.RenameIndex(
                name: "IX_InjuryAndDeathRegistration_CompaniesEmployeeInformationsEmp~",
                table: "InjuryAndDeathRegistrations",
                newName: "IX_InjuryAndDeathRegistrations_CompaniesEmployeeInformationsEm~");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InjuryAndDeathRegistrations",
                table: "InjuryAndDeathRegistrations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyEmployeeStatuses",
                table: "CompanyEmployeeStatuses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CompaniesEmployeeInformations_CompanyEmployeeStatuses_Statu~",
                schema: "Structure",
                table: "CompaniesEmployeeInformations",
                column: "StatusId",
                principalTable: "CompanyEmployeeStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompaniesEmployeeInformations_Roles_RoleId",
                schema: "Structure",
                table: "CompaniesEmployeeInformations",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InjuryAndDeathRegistrations_CompaniesEmployeeInformations_C~",
                table: "InjuryAndDeathRegistrations",
                columns: new[] { "CompaniesEmployeeInformationsEmployeeId", "CompaniesEmployeeInformationsCompanyId" },
                principalSchema: "Structure",
                principalTable: "CompaniesEmployeeInformations",
                principalColumns: new[] { "EmployeeId", "CompanyId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InjuryAndDeathRegistrations_InjuryTypes_InjuryTypesId",
                table: "InjuryAndDeathRegistrations",
                column: "InjuryTypesId",
                principalTable: "InjuryTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
