using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Structure.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class EditInPolicy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DerpartmentId",
                schema: "Structure",
                table: "CompanyDepartmentPolicies");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "DerpartmentId",
                schema: "Structure",
                table: "CompanyDepartmentPolicies",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
