using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Structure.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class deleteCompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Companies_CompanyId",
                schema: "Structure",
                table: "Employee");

            migrationBuilder.AlterColumn<Guid>(
                name: "CompanyId",
                schema: "Structure",
                table: "Employee",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Companies_CompanyId",
                schema: "Structure",
                table: "Employee",
                column: "CompanyId",
                principalSchema: "Structure",
                principalTable: "Companies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Companies_CompanyId",
                schema: "Structure",
                table: "Employee");

            migrationBuilder.AlterColumn<Guid>(
                name: "CompanyId",
                schema: "Structure",
                table: "Employee",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Companies_CompanyId",
                schema: "Structure",
                table: "Employee",
                column: "CompanyId",
                principalSchema: "Structure",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
