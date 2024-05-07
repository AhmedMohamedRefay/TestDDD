using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Structure.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class adding_somePropertiestoUserCompanyTabled : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFirstLogin",
                schema: "Structure",
                table: "CompaniesEmployeeInformations");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFirstLogin",
                schema: "Structure",
                table: "CompaniesEmployeeInformations",
                type: "boolean",
                nullable: false,
                defaultValue: true);
        }
    }
}
