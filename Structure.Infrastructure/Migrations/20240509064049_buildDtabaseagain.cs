using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Structure.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class buildDtabaseagain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Structure");

            migrationBuilder.CreateTable(
                name: "CompanyEmployeeStatus",
                schema: "Structure",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyEmployeeStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyStatus",
                schema: "Structure",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                schema: "Structure",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Nationality = table.Column<string>(type: "text", nullable: false),
                    PhoneCodeNumber = table.Column<string>(type: "text", nullable: false),
                    PhoneNumberLength = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentType",
                schema: "Structure",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                schema: "Structure",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InjuryTypes",
                schema: "Structure",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InjuryTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaritalStatus",
                schema: "Structure",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaritalStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Occupation",
                schema: "Structure",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occupation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RelativeRelation",
                schema: "Structure",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelativeRelation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Religion",
                schema: "Structure",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Religion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                schema: "Structure",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TerminationReasons",
                schema: "Structure",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TerminationReasons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                schema: "Structure",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CommercialRegistrationNumber = table.Column<string>(type: "text", nullable: true),
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
                    StatusId = table.Column<int>(type: "integer", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true),
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
                        name: "FK_Companies_CompanyStatus_StatusId",
                        column: x => x.StatusId,
                        principalSchema: "Structure",
                        principalTable: "CompanyStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CountriesStates",
                schema: "Structure",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CountryId = table.Column<int>(type: "integer", nullable: false),
                    CountriesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountriesStates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CountriesStates_Countries_CountriesId",
                        column: x => x.CountriesId,
                        principalSchema: "Structure",
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Job",
                schema: "Structure",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    OccupationId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Job_Occupation_OccupationId",
                        column: x => x.OccupationId,
                        principalSchema: "Structure",
                        principalTable: "Occupation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                schema: "Structure",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    PhotoPath = table.Column<string>(type: "text", nullable: false),
                    NationalIDNumber = table.Column<string>(type: "text", nullable: false),
                    SaudiVisaNumber = table.Column<string>(type: "text", nullable: false),
                    PassportNumber = table.Column<string>(type: "text", nullable: false),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    PrimaryPhoneNumber = table.Column<string>(type: "text", nullable: false),
                    SecondaryPhonenNumber = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    SocialInsuranceSubscriptionNumber = table.Column<string>(type: "text", nullable: false),
                    MainCompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    NationalityId = table.Column<int>(type: "integer", nullable: false),
                    MaritalStatusId = table.Column<int>(type: "integer", nullable: false),
                    ReligionId = table.Column<int>(type: "integer", nullable: false),
                    GenderId = table.Column<int>(type: "integer", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    CountryId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "Structure",
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_Countries_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "Structure",
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_Gender_GenderId",
                        column: x => x.GenderId,
                        principalSchema: "Structure",
                        principalTable: "Gender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_MaritalStatus_MaritalStatusId",
                        column: x => x.MaritalStatusId,
                        principalSchema: "Structure",
                        principalTable: "MaritalStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_Religion_ReligionId",
                        column: x => x.ReligionId,
                        principalSchema: "Structure",
                        principalTable: "Religion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Certificates",
                schema: "Structure",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    IssuingBody = table.Column<string>(type: "text", nullable: false),
                    IssuingOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    AttachmentPaht = table.Column<string>(type: "text", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Certificates_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalSchema: "Structure",
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompaniesEmployeeInformations",
                schema: "Structure",
                columns: table => new
                {
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uuid", nullable: false),
                    EmploymentStartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ProbationaryPeriodInDays = table.Column<int>(type: "integer", nullable: false),
                    ProbationaryPeriodIsActive = table.Column<bool>(type: "boolean", nullable: false),
                    EmploymentContractInDays = table.Column<int>(type: "integer", nullable: false),
                    Performance = table.Column<decimal>(type: "numeric", nullable: false),
                    ContractDocomentPath = table.Column<string>(type: "text", nullable: false),
                    IsTerminated = table.Column<bool>(type: "boolean", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    IsFirstLogin = table.Column<bool>(type: "boolean", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    StatusId = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompaniesEmployeeInformations", x => new { x.EmployeeId, x.CompanyId });
                    table.ForeignKey(
                        name: "FK_CompaniesEmployeeInformations_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "Structure",
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompaniesEmployeeInformations_CompanyEmployeeStatus_StatusId",
                        column: x => x.StatusId,
                        principalSchema: "Structure",
                        principalTable: "CompanyEmployeeStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompaniesEmployeeInformations_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalSchema: "Structure",
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompaniesEmployeeInformations_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Structure",
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeDocuments",
                schema: "Structure",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    IssuingOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    AttachmentPath = table.Column<string>(type: "text", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uuid", nullable: false),
                    DocumentTypeId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeDocuments_DocumentType_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalSchema: "Structure",
                        principalTable: "DocumentType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeDocuments_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalSchema: "Structure",
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FamilyInformation",
                schema: "Structure",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    FatherName = table.Column<string>(type: "text", nullable: false),
                    FamilyName = table.Column<string>(type: "text", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IdNumber = table.Column<string>(type: "text", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uuid", nullable: false),
                    RelativeRelationId = table.Column<int>(type: "integer", nullable: false),
                    MaritalStatusId = table.Column<int>(type: "integer", nullable: false),
                    GenderId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilyInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FamilyInformation_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalSchema: "Structure",
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FamilyInformation_Gender_GenderId",
                        column: x => x.GenderId,
                        principalSchema: "Structure",
                        principalTable: "Gender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FamilyInformation_MaritalStatus_MaritalStatusId",
                        column: x => x.MaritalStatusId,
                        principalSchema: "Structure",
                        principalTable: "MaritalStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FamilyInformation_RelativeRelation_RelativeRelationId",
                        column: x => x.RelativeRelationId,
                        principalSchema: "Structure",
                        principalTable: "RelativeRelation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkHistory",
                schema: "Structure",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyLogo = table.Column<string>(type: "text", nullable: false),
                    CompanyName = table.Column<string>(type: "text", nullable: false),
                    DepartmentName = table.Column<string>(type: "text", nullable: false),
                    JobPosition = table.Column<string>(type: "text", nullable: false),
                    EmploymentStartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EmploymentEndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Details = table.Column<string>(type: "text", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkHistory_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalSchema: "Structure",
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                schema: "Structure",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Logo = table.Column<string>(type: "text", nullable: true),
                    OfficePhoneNumber = table.Column<string>(type: "text", nullable: true),
                    ParentId = table.Column<Guid>(type: "uuid", nullable: true),
                    ManagerId = table.Column<Guid>(type: "uuid", nullable: true),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Department_CompaniesEmployeeInformations_CompanyId_ManagerId",
                        columns: x => new { x.CompanyId, x.ManagerId },
                        principalSchema: "Structure",
                        principalTable: "CompaniesEmployeeInformations",
                        principalColumns: new[] { "EmployeeId", "CompanyId" });
                    table.ForeignKey(
                        name: "FK_Department_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "Structure",
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Department_Department_ParentId",
                        column: x => x.ParentId,
                        principalSchema: "Structure",
                        principalTable: "Department",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeServiceTermination",
                schema: "Structure",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    EfeectiveDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CertificatePath = table.Column<string>(type: "text", nullable: false),
                    ReasonId = table.Column<int>(type: "integer", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uuid", nullable: false),
                    TerminationReasonsId = table.Column<int>(type: "integer", nullable: false),
                    CompaniesEmployeeInformationsEmployeeId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompaniesEmployeeInformationsCompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeServiceTermination", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeServiceTermination_CompaniesEmployeeInformations_Co~",
                        columns: x => new { x.CompaniesEmployeeInformationsEmployeeId, x.CompaniesEmployeeInformationsCompanyId },
                        principalSchema: "Structure",
                        principalTable: "CompaniesEmployeeInformations",
                        principalColumns: new[] { "EmployeeId", "CompanyId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeServiceTermination_TerminationReasons_TerminationRe~",
                        column: x => x.TerminationReasonsId,
                        principalSchema: "Structure",
                        principalTable: "TerminationReasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InjuryAndDeathRegistration",
                schema: "Structure",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Location = table.Column<string>(type: "text", nullable: false),
                    AtatachmentPath = table.Column<string>(type: "text", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uuid", nullable: false),
                    InjuryTypeId = table.Column<int>(type: "integer", nullable: false),
                    CompaniesEmployeeInformationsEmployeeId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompaniesEmployeeInformationsCompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    InjuryTypesId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InjuryAndDeathRegistration", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InjuryAndDeathRegistration_CompaniesEmployeeInformations_Co~",
                        columns: x => new { x.CompaniesEmployeeInformationsEmployeeId, x.CompaniesEmployeeInformationsCompanyId },
                        principalSchema: "Structure",
                        principalTable: "CompaniesEmployeeInformations",
                        principalColumns: new[] { "EmployeeId", "CompanyId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InjuryAndDeathRegistration_InjuryTypes_InjuryTypesId",
                        column: x => x.InjuryTypesId,
                        principalSchema: "Structure",
                        principalTable: "InjuryTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FamilyDocuments",
                schema: "Structure",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    IssuingOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    AttachmentPath = table.Column<string>(type: "text", nullable: false),
                    MemeberId = table.Column<Guid>(type: "uuid", nullable: false),
                    DocumentTypeId = table.Column<int>(type: "integer", nullable: false),
                    FamilyInformationId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilyDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FamilyDocuments_DocumentType_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalSchema: "Structure",
                        principalTable: "DocumentType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FamilyDocuments_FamilyInformation_FamilyInformationId",
                        column: x => x.FamilyInformationId,
                        principalSchema: "Structure",
                        principalTable: "FamilyInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyDepartmentPolicies",
                schema: "Structure",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    DerpartmentId = table.Column<Guid>(type: "uuid", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyDepartmentPolicies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyDepartmentPolicies_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "Structure",
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyDepartmentPolicies_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalSchema: "Structure",
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentsJobs",
                schema: "Structure",
                columns: table => new
                {
                    DerpatmentId = table.Column<Guid>(type: "uuid", nullable: false),
                    JobId = table.Column<Guid>(type: "uuid", nullable: false),
                    NumberOfPosition = table.Column<int>(type: "integer", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentsJobs", x => new { x.JobId, x.DerpatmentId });
                    table.ForeignKey(
                        name: "FK_DepartmentsJobs_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalSchema: "Structure",
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentsJobs_Job_JobId",
                        column: x => x.JobId,
                        principalSchema: "Structure",
                        principalTable: "Job",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyDepartmentPoliciesIsReaded",
                schema: "Structure",
                columns: table => new
                {
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyDepartmentPoliciesId = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyDepartmentPoliciesIsReaded", x => new { x.CompanyId, x.EmployeeId, x.CompanyDepartmentPoliciesId });
                    table.ForeignKey(
                        name: "FK_CompanyDepartmentPoliciesIsReaded_CompaniesEmployeeInformat~",
                        columns: x => new { x.EmployeeId, x.CompanyId },
                        principalSchema: "Structure",
                        principalTable: "CompaniesEmployeeInformations",
                        principalColumns: new[] { "EmployeeId", "CompanyId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyDepartmentPoliciesIsReaded_CompanyDepartmentPolicies~",
                        column: x => x.CompanyDepartmentPoliciesId,
                        principalSchema: "Structure",
                        principalTable: "CompanyDepartmentPolicies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeePositions",
                schema: "Structure",
                columns: table => new
                {
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uuid", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uuid", nullable: false),
                    JobId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeePositions", x => new { x.DepartmentId, x.JobId, x.EmployeeId, x.CompanyId });
                    table.ForeignKey(
                        name: "FK_EmployeePositions_CompaniesEmployeeInformations_CompanyId_E~",
                        columns: x => new { x.CompanyId, x.EmployeeId },
                        principalSchema: "Structure",
                        principalTable: "CompaniesEmployeeInformations",
                        principalColumns: new[] { "EmployeeId", "CompanyId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeePositions_DepartmentsJobs_DepartmentId_JobId",
                        columns: x => new { x.DepartmentId, x.JobId },
                        principalSchema: "Structure",
                        principalTable: "DepartmentsJobs",
                        principalColumns: new[] { "JobId", "DerpatmentId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Certificates_EmployeeId",
                schema: "Structure",
                table: "Certificates",
                column: "EmployeeId");

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

            migrationBuilder.CreateIndex(
                name: "IX_CompaniesEmployeeInformations_CompanyId",
                schema: "Structure",
                table: "CompaniesEmployeeInformations",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompaniesEmployeeInformations_RoleId",
                schema: "Structure",
                table: "CompaniesEmployeeInformations",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_CompaniesEmployeeInformations_StatusId",
                schema: "Structure",
                table: "CompaniesEmployeeInformations",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyDepartmentPolicies_CompanyId",
                schema: "Structure",
                table: "CompanyDepartmentPolicies",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyDepartmentPolicies_DepartmentId",
                schema: "Structure",
                table: "CompanyDepartmentPolicies",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyDepartmentPoliciesIsReaded_CompanyDepartmentPolicies~",
                schema: "Structure",
                table: "CompanyDepartmentPoliciesIsReaded",
                column: "CompanyDepartmentPoliciesId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyDepartmentPoliciesIsReaded_EmployeeId_CompanyId",
                schema: "Structure",
                table: "CompanyDepartmentPoliciesIsReaded",
                columns: new[] { "EmployeeId", "CompanyId" });

            migrationBuilder.CreateIndex(
                name: "IX_CountriesStates_CountriesId",
                schema: "Structure",
                table: "CountriesStates",
                column: "CountriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Department_CompanyId_ManagerId",
                schema: "Structure",
                table: "Department",
                columns: new[] { "CompanyId", "ManagerId" });

            migrationBuilder.CreateIndex(
                name: "IX_Department_Name_CompanyId",
                schema: "Structure",
                table: "Department",
                columns: new[] { "Name", "CompanyId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Department_ParentId",
                schema: "Structure",
                table: "Department",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentsJobs_DepartmentId",
                schema: "Structure",
                table: "DepartmentsJobs",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_CompanyId",
                schema: "Structure",
                table: "Employee",
                column: "CompanyId");

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

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDocuments_DocumentTypeId",
                schema: "Structure",
                table: "EmployeeDocuments",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDocuments_EmployeeId",
                schema: "Structure",
                table: "EmployeeDocuments",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePositions_CompanyId_EmployeeId",
                schema: "Structure",
                table: "EmployeePositions",
                columns: new[] { "CompanyId", "EmployeeId" });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeServiceTermination_CompaniesEmployeeInformationsEmp~",
                schema: "Structure",
                table: "EmployeeServiceTermination",
                columns: new[] { "CompaniesEmployeeInformationsEmployeeId", "CompaniesEmployeeInformationsCompanyId" });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeServiceTermination_TerminationReasonsId",
                schema: "Structure",
                table: "EmployeeServiceTermination",
                column: "TerminationReasonsId");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyDocuments_DocumentTypeId",
                schema: "Structure",
                table: "FamilyDocuments",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyDocuments_FamilyInformationId",
                schema: "Structure",
                table: "FamilyDocuments",
                column: "FamilyInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyInformation_EmployeeId",
                schema: "Structure",
                table: "FamilyInformation",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyInformation_GenderId",
                schema: "Structure",
                table: "FamilyInformation",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyInformation_MaritalStatusId",
                schema: "Structure",
                table: "FamilyInformation",
                column: "MaritalStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyInformation_RelativeRelationId",
                schema: "Structure",
                table: "FamilyInformation",
                column: "RelativeRelationId");

            migrationBuilder.CreateIndex(
                name: "IX_InjuryAndDeathRegistration_CompaniesEmployeeInformationsEmp~",
                schema: "Structure",
                table: "InjuryAndDeathRegistration",
                columns: new[] { "CompaniesEmployeeInformationsEmployeeId", "CompaniesEmployeeInformationsCompanyId" });

            migrationBuilder.CreateIndex(
                name: "IX_InjuryAndDeathRegistration_InjuryTypesId",
                schema: "Structure",
                table: "InjuryAndDeathRegistration",
                column: "InjuryTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_Job_OccupationId",
                schema: "Structure",
                table: "Job",
                column: "OccupationId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkHistory_EmployeeId",
                schema: "Structure",
                table: "WorkHistory",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Certificates",
                schema: "Structure");

            migrationBuilder.DropTable(
                name: "CompanyDepartmentPoliciesIsReaded",
                schema: "Structure");

            migrationBuilder.DropTable(
                name: "CountriesStates",
                schema: "Structure");

            migrationBuilder.DropTable(
                name: "EmployeeDocuments",
                schema: "Structure");

            migrationBuilder.DropTable(
                name: "EmployeePositions",
                schema: "Structure");

            migrationBuilder.DropTable(
                name: "EmployeeServiceTermination",
                schema: "Structure");

            migrationBuilder.DropTable(
                name: "FamilyDocuments",
                schema: "Structure");

            migrationBuilder.DropTable(
                name: "InjuryAndDeathRegistration",
                schema: "Structure");

            migrationBuilder.DropTable(
                name: "WorkHistory",
                schema: "Structure");

            migrationBuilder.DropTable(
                name: "CompanyDepartmentPolicies",
                schema: "Structure");

            migrationBuilder.DropTable(
                name: "DepartmentsJobs",
                schema: "Structure");

            migrationBuilder.DropTable(
                name: "TerminationReasons",
                schema: "Structure");

            migrationBuilder.DropTable(
                name: "DocumentType",
                schema: "Structure");

            migrationBuilder.DropTable(
                name: "FamilyInformation",
                schema: "Structure");

            migrationBuilder.DropTable(
                name: "InjuryTypes",
                schema: "Structure");

            migrationBuilder.DropTable(
                name: "Department",
                schema: "Structure");

            migrationBuilder.DropTable(
                name: "Job",
                schema: "Structure");

            migrationBuilder.DropTable(
                name: "RelativeRelation",
                schema: "Structure");

            migrationBuilder.DropTable(
                name: "CompaniesEmployeeInformations",
                schema: "Structure");

            migrationBuilder.DropTable(
                name: "Occupation",
                schema: "Structure");

            migrationBuilder.DropTable(
                name: "CompanyEmployeeStatus",
                schema: "Structure");

            migrationBuilder.DropTable(
                name: "Employee",
                schema: "Structure");

            migrationBuilder.DropTable(
                name: "Role",
                schema: "Structure");

            migrationBuilder.DropTable(
                name: "Companies",
                schema: "Structure");

            migrationBuilder.DropTable(
                name: "Countries",
                schema: "Structure");

            migrationBuilder.DropTable(
                name: "Gender",
                schema: "Structure");

            migrationBuilder.DropTable(
                name: "MaritalStatus",
                schema: "Structure");

            migrationBuilder.DropTable(
                name: "Religion",
                schema: "Structure");

            migrationBuilder.DropTable(
                name: "CompanyStatus",
                schema: "Structure");
        }
    }
}
