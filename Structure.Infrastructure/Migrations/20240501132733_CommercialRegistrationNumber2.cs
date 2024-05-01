using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Structure.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CommercialRegistrationNumber2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_companyStatuses_StatusId",
                schema: "Structure",
                table: "Companies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_companyStatuses",
                table: "companyStatuses");

            migrationBuilder.RenameTable(
                name: "companyStatuses",
                newName: "CompanyStatus",
                newSchema: "Structure");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyStatus",
                schema: "Structure",
                table: "CompanyStatus",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_CompanyStatus_StatusId",
                schema: "Structure",
                table: "Companies",
                column: "StatusId",
                principalSchema: "Structure",
                principalTable: "CompanyStatus",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_CompanyStatus_StatusId",
                schema: "Structure",
                table: "Companies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyStatus",
                schema: "Structure",
                table: "CompanyStatus");

            migrationBuilder.RenameTable(
                name: "CompanyStatus",
                schema: "Structure",
                newName: "companyStatuses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_companyStatuses",
                table: "companyStatuses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_companyStatuses_StatusId",
                schema: "Structure",
                table: "Companies",
                column: "StatusId",
                principalTable: "companyStatuses",
                principalColumn: "Id");
        }
    }
}
