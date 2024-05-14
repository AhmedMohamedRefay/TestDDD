using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Structure.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class deleteCompanyolx : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Countries_CountryId",
                schema: "Structure",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Gender_GenderId",
                schema: "Structure",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_MaritalStatus_MaritalStatusId",
                schema: "Structure",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Religion_ReligionId",
                schema: "Structure",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_CountryId",
                schema: "Structure",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_GenderId",
                schema: "Structure",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_MaritalStatusId",
                schema: "Structure",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_ReligionId",
                schema: "Structure",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                schema: "Structure",
                table: "Employee",
                newName: "NationalityId");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NationalityId",
                schema: "Structure",
                table: "Employee",
                newName: "CountryId");

            migrationBuilder.AlterColumn<int>(
                name: "GenderId",
                schema: "Structure",
                table: "Employee",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_CountryId",
                schema: "Structure",
                table: "Employee",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_GenderId",
                schema: "Structure",
                table: "Employee",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_MaritalStatusId",
                schema: "Structure",
                table: "Employee",
                column: "MaritalStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_ReligionId",
                schema: "Structure",
                table: "Employee",
                column: "ReligionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Countries_CountryId",
                schema: "Structure",
                table: "Employee",
                column: "CountryId",
                principalSchema: "Structure",
                principalTable: "Countries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Gender_GenderId",
                schema: "Structure",
                table: "Employee",
                column: "GenderId",
                principalSchema: "Structure",
                principalTable: "Gender",
                principalColumn: "Id");

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
    }
}
