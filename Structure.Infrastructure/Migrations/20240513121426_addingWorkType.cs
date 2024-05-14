using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Structure.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addingWorkType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WorkTypeId",
                schema: "Structure",
                table: "EmployeePositions",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "WorkTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePositions_WorkTypeId",
                schema: "Structure",
                table: "EmployeePositions",
                column: "WorkTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePositions_WorkTypes_WorkTypeId",
                schema: "Structure",
                table: "EmployeePositions",
                column: "WorkTypeId",
                principalTable: "WorkTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePositions_WorkTypes_WorkTypeId",
                schema: "Structure",
                table: "EmployeePositions");

            migrationBuilder.DropTable(
                name: "WorkTypes");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePositions_WorkTypeId",
                schema: "Structure",
                table: "EmployeePositions");

            migrationBuilder.DropColumn(
                name: "WorkTypeId",
                schema: "Structure",
                table: "EmployeePositions");
        }
    }
}
