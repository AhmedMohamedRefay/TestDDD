using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Structure.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addingWorkTypec : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePositions_WorkTypes_WorkTypeId",
                schema: "Structure",
                table: "EmployeePositions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkTypes",
                table: "WorkTypes");

            migrationBuilder.RenameTable(
                name: "WorkTypes",
                newName: "WorkType",
                newSchema: "Structure");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkType",
                schema: "Structure",
                table: "WorkType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePositions_WorkType_WorkTypeId",
                schema: "Structure",
                table: "EmployeePositions",
                column: "WorkTypeId",
                principalSchema: "Structure",
                principalTable: "WorkType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePositions_WorkType_WorkTypeId",
                schema: "Structure",
                table: "EmployeePositions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkType",
                schema: "Structure",
                table: "WorkType");

            migrationBuilder.RenameTable(
                name: "WorkType",
                schema: "Structure",
                newName: "WorkTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkTypes",
                table: "WorkTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePositions_WorkTypes_WorkTypeId",
                schema: "Structure",
                table: "EmployeePositions",
                column: "WorkTypeId",
                principalTable: "WorkTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
