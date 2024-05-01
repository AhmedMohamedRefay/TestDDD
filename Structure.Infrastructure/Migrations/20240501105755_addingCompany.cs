using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Structure.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addingCompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Structure");

            migrationBuilder.CreateTable(
                name: "companyStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companyStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                schema: "Structure",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CommercialRegistrationStartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CommercialRegistrationExpireDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UnifiedNationalNumber = table.Column<string>(type: "text", nullable: true),
                    InstitutionNumber = table.Column<string>(type: "text", nullable: true),
                    SocialInsuranceSubscriptionNumber = table.Column<string>(type: "text", nullable: true),
                    LogoPath = table.Column<string>(type: "text", nullable: true),
                    Website = table.Column<string>(type: "text", nullable: true),
                    Twitter = table.Column<string>(type: "text", nullable: true),
                    Facebook = table.Column<string>(type: "text", nullable: true),
                    Linkedin = table.Column<string>(type: "text", nullable: true),
                    ParentId = table.Column<Guid>(type: "uuid", nullable: true),
                    OwnerId = table.Column<Guid>(type: "uuid", nullable: false),
                    CEO = table.Column<Guid>(type: "uuid", nullable: true),
                    CFO = table.Column<Guid>(type: "uuid", nullable: true),
                    CMO = table.Column<Guid>(type: "uuid", nullable: true),
                    StatusId = table.Column<int>(type: "integer", nullable: true),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    EditedBy = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EditedAt = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "Structure",
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Companies_companyStatuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "companyStatuses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CompanyId",
                schema: "Structure",
                table: "Companies",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_StatusId",
                schema: "Structure",
                table: "Companies",
                column: "StatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies",
                schema: "Structure");

            migrationBuilder.DropTable(
                name: "companyStatuses");
        }
    }
}
