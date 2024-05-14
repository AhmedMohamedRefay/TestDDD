using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Structure.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class deleteCompanyo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Countries_CountryId",
                schema: "Structure",
                table: "Employee");

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                schema: "Structure",
                table: "Employee",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Countries_CountryId",
                schema: "Structure",
                table: "Employee",
                column: "CountryId",
                principalSchema: "Structure",
                principalTable: "Countries",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Countries_CountryId",
                schema: "Structure",
                table: "Employee");

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                schema: "Structure",
                table: "Employee",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Countries_CountryId",
                schema: "Structure",
                table: "Employee",
                column: "CountryId",
                principalSchema: "Structure",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
