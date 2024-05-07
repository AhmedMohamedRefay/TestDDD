using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Structure.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatesomePropertyInDepartmentModelSetLogo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Department_departmentId",
                schema: "Structure",
                table: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Department_departmentId",
                schema: "Structure",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "departmentId",
                schema: "Structure",
                table: "Department");

            migrationBuilder.CreateIndex(
                name: "IX_Department_ParentId",
                schema: "Structure",
                table: "Department",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Department_ParentId",
                schema: "Structure",
                table: "Department",
                column: "ParentId",
                principalSchema: "Structure",
                principalTable: "Department",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Department_ParentId",
                schema: "Structure",
                table: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Department_ParentId",
                schema: "Structure",
                table: "Department");

            migrationBuilder.AddColumn<Guid>(
                name: "departmentId",
                schema: "Structure",
                table: "Department",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Department_departmentId",
                schema: "Structure",
                table: "Department",
                column: "departmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Department_departmentId",
                schema: "Structure",
                table: "Department",
                column: "departmentId",
                principalSchema: "Structure",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
