using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Structure.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class deleteCompanyol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Companies_CompanyId",
                schema: "Structure",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Gender_GenderId",
                schema: "Structure",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_CompanyId",
                schema: "Structure",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                schema: "Structure",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "NationalityId",
                schema: "Structure",
                table: "Employee");

            migrationBuilder.AlterColumn<int>(
                name: "GenderId",
                schema: "Structure",
                table: "Employee",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Gender_GenderId",
                schema: "Structure",
                table: "Employee",
                column: "GenderId",
                principalSchema: "Structure",
                principalTable: "Gender",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Gender_GenderId",
                schema: "Structure",
                table: "Employee");

            migrationBuilder.AlterColumn<int>(
                name: "GenderId",
                schema: "Structure",
                table: "Employee",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                schema: "Structure",
                table: "Employee",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NationalityId",
                schema: "Structure",
                table: "Employee",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_CompanyId",
                schema: "Structure",
                table: "Employee",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Companies_CompanyId",
                schema: "Structure",
                table: "Employee",
                column: "CompanyId",
                principalSchema: "Structure",
                principalTable: "Companies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Gender_GenderId",
                schema: "Structure",
                table: "Employee",
                column: "GenderId",
                principalSchema: "Structure",
                principalTable: "Gender",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
