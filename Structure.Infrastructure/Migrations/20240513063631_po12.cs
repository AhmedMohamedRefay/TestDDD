using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Structure.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class po12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaritalStatusId",
                schema: "Structure",
                table: "Employee",
                type: "integer",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaritalStatusId",
                schema: "Structure",
                table: "Employee");
        }
    }
}
