using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Structure.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class changeEmployeeProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_MaritalStatus_MaritalStatusId",
                schema: "Structure",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Religion_ReligionId",
                schema: "Structure",
                table: "Employee");

            migrationBuilder.AlterColumn<string>(
                name: "SocialInsuranceSubscriptionNumber",
                schema: "Structure",
                table: "Employee",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "SaudiVisaNumber",
                schema: "Structure",
                table: "Employee",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "ReligionId",
                schema: "Structure",
                table: "Employee",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "NationalityId",
                schema: "Structure",
                table: "Employee",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "NationalIDNumber",
                schema: "Structure",
                table: "Employee",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "MaritalStatusId",
                schema: "Structure",
                table: "Employee",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<Guid>(
                name: "MainCompanyId",
                schema: "Structure",
                table: "Employee",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_MaritalStatus_MaritalStatusId",
                schema: "Structure",
                table: "Employee",
                column: "MaritalStatusId",
                principalSchema: "Structure",
                principalTable: "MaritalStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Religion_ReligionId",
                schema: "Structure",
                table: "Employee",
                column: "ReligionId",
                principalSchema: "Structure",
                principalTable: "Religion",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_MaritalStatus_MaritalStatusId",
                schema: "Structure",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Religion_ReligionId",
                schema: "Structure",
                table: "Employee");

            migrationBuilder.AlterColumn<string>(
                name: "SocialInsuranceSubscriptionNumber",
                schema: "Structure",
                table: "Employee",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SaudiVisaNumber",
                schema: "Structure",
                table: "Employee",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ReligionId",
                schema: "Structure",
                table: "Employee",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NationalityId",
                schema: "Structure",
                table: "Employee",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NationalIDNumber",
                schema: "Structure",
                table: "Employee",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaritalStatusId",
                schema: "Structure",
                table: "Employee",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "MainCompanyId",
                schema: "Structure",
                table: "Employee",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_MaritalStatus_MaritalStatusId",
                schema: "Structure",
                table: "Employee",
                column: "MaritalStatusId",
                principalSchema: "Structure",
                principalTable: "MaritalStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Religion_ReligionId",
                schema: "Structure",
                table: "Employee",
                column: "ReligionId",
                principalSchema: "Structure",
                principalTable: "Religion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
