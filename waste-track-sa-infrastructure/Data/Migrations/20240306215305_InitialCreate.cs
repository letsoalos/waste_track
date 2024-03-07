using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace waste_track_sa_infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "APIs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APIs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CardPrintWastePickers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RegistrationNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardPrintWastePickers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cooperatives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    YearEstablish = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsRegistered = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cooperatives", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ErrorLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Method = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ErrorMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErrorLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GetEmailContents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Attachment = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ToAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CCAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BCAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    Attempts = table.Column<int>(type: "int", nullable: false),
                    ErrorMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetEmailContents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IncomeMethods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomeMethods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MasterCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OfficialTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficialTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrganizationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Race",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Race", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SortingAreas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SortingAreas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LogDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LogAction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecordId = table.Column<int>(type: "int", nullable: false),
                    Group = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SystemSettingName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SystemSettingValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValueDataType = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ThirdPartySystems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SystemName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SystemURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SystemDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganizationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganizationWebsite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountStatus = table.Column<int>(type: "int", nullable: false),
                    ReferenceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountActivationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountActivationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    APIKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThirdPartySystems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ToBeUpdatedWastePickers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WastePickerNo = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToBeUpdatedWastePickers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserSessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoginTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LogoutTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoginStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoutStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSessions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WastePickerStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WastePickerStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Worksites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worksites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MasterCodeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocumentTypes_MasterCodes_MasterCodeId",
                        column: x => x.MasterCodeId,
                        principalTable: "MasterCodes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Contacts = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Districts_Provinces_ProviceId",
                        column: x => x.ProviceId,
                        principalTable: "Provinces",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "APIAccesses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThirdPartySystemId = table.Column<int>(type: "int", nullable: false),
                    APIId = table.Column<int>(type: "int", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APIAccesses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_APIAccesses_APIs_APIId",
                        column: x => x.APIId,
                        principalTable: "APIs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_APIAccesses_ThirdPartySystems_ThirdPartySystemId",
                        column: x => x.ThirdPartySystemId,
                        principalTable: "ThirdPartySystems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThirdPartySystemLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThirdPartySystemId = table.Column<int>(type: "int", nullable: false),
                    APIId = table.Column<int>(type: "int", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceIP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThirdPartySystemLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ThirdPartySystemLogs_APIs_APIId",
                        column: x => x.APIId,
                        principalTable: "APIs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ThirdPartySystemLogs_ThirdPartySystems_ThirdPartySystemId",
                        column: x => x.ThirdPartySystemId,
                        principalTable: "ThirdPartySystems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserTypeId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationNo = table.Column<int>(type: "int", nullable: false),
                    ActivationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailVerified = table.Column<bool>(type: "bit", nullable: false),
                    EmailVerifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastPasswordChangedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_UserTypes_UserTypeId",
                        column: x => x.UserTypeId,
                        principalTable: "UserTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WastePickerActivityLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WastePickerStatusId = table.Column<int>(type: "int", nullable: false),
                    LogCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActivityDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActivityStatusId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WastePickerActivityLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WastePickerActivityLogs_WastePickerStatuses_WastePickerStatusId",
                        column: x => x.WastePickerStatusId,
                        principalTable: "WastePickerStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WastePickers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DOB = table.Column<DateOnly>(type: "date", nullable: false),
                    IdentityNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherIdentityNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    CellphoneNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AltCellphoneNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Potrait = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentTypeId = table.Column<int>(type: "int", nullable: false),
                    WastePickerNo = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Consent = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegistrationLocation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    WastePickerStatusId = table.Column<int>(type: "int", nullable: false),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    RaceId = table.Column<int>(type: "int", nullable: false),
                    IsMemberCooperative = table.Column<bool>(type: "bit", nullable: false),
                    CooperativeId = table.Column<int>(type: "int", nullable: false),
                    ActivityStatusId = table.Column<int>(type: "int", nullable: false),
                    LastActivityDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PrintCount = table.Column<int>(type: "int", nullable: false),
                    ManualPrintCount = table.Column<int>(type: "int", nullable: false),
                    AutoPrintCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WastePickers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WastePickers_Cooperatives_CooperativeId",
                        column: x => x.CooperativeId,
                        principalTable: "Cooperatives",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WastePickers_DocumentTypes_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalTable: "DocumentTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WastePickers_Gender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WastePickers_Race_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Race",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WastePickers_WastePickerStatuses_WastePickerStatusId",
                        column: x => x.WastePickerStatusId,
                        principalTable: "WastePickerStatuses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Municipalities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Contacts = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    DistrictId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipalities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Municipalities_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserTypeId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoles_UserTypes_UserTypeId",
                        column: x => x.UserTypeId,
                        principalTable: "UserTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CooperativeInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WastePickerId = table.Column<int>(type: "int", nullable: false),
                    CooperativeId = table.Column<int>(type: "int", nullable: false),
                    WastePickerStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WorksiteId = table.Column<int>(type: "int", nullable: false),
                    Consent = table.Column<int>(type: "int", nullable: false),
                    YearJoined = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CooperativeInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CooperativeInfo_Cooperatives_CooperativeId",
                        column: x => x.CooperativeId,
                        principalTable: "Cooperatives",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CooperativeInfo_WastePickers_WastePickerId",
                        column: x => x.WastePickerId,
                        principalTable: "WastePickers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CooperativeInfo_Worksites_WorksiteId",
                        column: x => x.WorksiteId,
                        principalTable: "Worksites",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GetWastePickerStatusAudits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WastePickerId = table.Column<int>(type: "int", nullable: false),
                    WastePickerStatusId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GetWastePickerStatusAudits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GetWastePickerStatusAudits_WastePickerStatuses_WastePickerStatusId",
                        column: x => x.WastePickerStatusId,
                        principalTable: "WastePickerStatuses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GetWastePickerStatusAudits_WastePickers_WastePickerId",
                        column: x => x.WastePickerId,
                        principalTable: "WastePickers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WastePickerDocuments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WastePickerId = table.Column<int>(type: "int", nullable: false),
                    DocumentTypeId = table.Column<int>(type: "int", nullable: false),
                    MasterCodeId = table.Column<int>(type: "int", nullable: false),
                    Potrait = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WastePickerDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WastePickerDocuments_DocumentTypes_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalTable: "DocumentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WastePickerDocuments_MasterCodes_MasterCodeId",
                        column: x => x.MasterCodeId,
                        principalTable: "MasterCodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WastePickerDocuments_WastePickers_WastePickerId",
                        column: x => x.WastePickerId,
                        principalTable: "WastePickers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizationTypeId = table.Column<int>(type: "int", nullable: false),
                    MunicipalityId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Contacts = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organizations_Municipalities_MunicipalityId",
                        column: x => x.MunicipalityId,
                        principalTable: "Municipalities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Organizations_OrganizationTypes_OrganizationTypeId",
                        column: x => x.OrganizationTypeId,
                        principalTable: "OrganizationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReclaimingInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WastePickerId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorksiteId = table.Column<int>(type: "int", nullable: false),
                    MunicipalityId = table.Column<int>(type: "int", nullable: false),
                    IncomeMethodId = table.Column<int>(type: "int", nullable: false),
                    SortingAreaId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReclaimingInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReclaimingInfo_IncomeMethods_IncomeMethodId",
                        column: x => x.IncomeMethodId,
                        principalTable: "IncomeMethods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReclaimingInfo_Municipalities_MunicipalityId",
                        column: x => x.MunicipalityId,
                        principalTable: "Municipalities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReclaimingInfo_SortingAreas_SortingAreaId",
                        column: x => x.SortingAreaId,
                        principalTable: "SortingAreas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReclaimingInfo_WastePickers_WastePickerId",
                        column: x => x.WastePickerId,
                        principalTable: "WastePickers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReclaimingInfo_Worksites_WorksiteId",
                        column: x => x.WorksiteId,
                        principalTable: "Worksites",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MunicipalityId = table.Column<int>(type: "int", nullable: false),
                    OrganizationId = table.Column<int>(type: "int", nullable: false),
                    Consent = table.Column<int>(type: "int", nullable: false),
                    OfficialTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserInfo_Municipalities_MunicipalityId",
                        column: x => x.MunicipalityId,
                        principalTable: "Municipalities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserInfo_OfficialTypes_OfficialTypeId",
                        column: x => x.OfficialTypeId,
                        principalTable: "OfficialTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserInfo_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserInfo_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_APIAccesses_APIId",
                table: "APIAccesses",
                column: "APIId");

            migrationBuilder.CreateIndex(
                name: "IX_APIAccesses_ThirdPartySystemId",
                table: "APIAccesses",
                column: "ThirdPartySystemId");

            migrationBuilder.CreateIndex(
                name: "IX_CooperativeInfo_CooperativeId",
                table: "CooperativeInfo",
                column: "CooperativeId");

            migrationBuilder.CreateIndex(
                name: "IX_CooperativeInfo_WastePickerId",
                table: "CooperativeInfo",
                column: "WastePickerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CooperativeInfo_WorksiteId",
                table: "CooperativeInfo",
                column: "WorksiteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Districts_ProviceId",
                table: "Districts",
                column: "ProviceId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentTypes_MasterCodeId",
                table: "DocumentTypes",
                column: "MasterCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_GetWastePickerStatusAudits_WastePickerId",
                table: "GetWastePickerStatusAudits",
                column: "WastePickerId");

            migrationBuilder.CreateIndex(
                name: "IX_GetWastePickerStatusAudits_WastePickerStatusId",
                table: "GetWastePickerStatusAudits",
                column: "WastePickerStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Municipalities_DistrictId",
                table: "Municipalities",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_MunicipalityId",
                table: "Organizations",
                column: "MunicipalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_OrganizationTypeId",
                table: "Organizations",
                column: "OrganizationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ReclaimingInfo_IncomeMethodId",
                table: "ReclaimingInfo",
                column: "IncomeMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_ReclaimingInfo_MunicipalityId",
                table: "ReclaimingInfo",
                column: "MunicipalityId");

            migrationBuilder.CreateIndex(
                name: "IX_ReclaimingInfo_SortingAreaId",
                table: "ReclaimingInfo",
                column: "SortingAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_ReclaimingInfo_WastePickerId",
                table: "ReclaimingInfo",
                column: "WastePickerId");

            migrationBuilder.CreateIndex(
                name: "IX_ReclaimingInfo_WorksiteId",
                table: "ReclaimingInfo",
                column: "WorksiteId");

            migrationBuilder.CreateIndex(
                name: "IX_ThirdPartySystemLogs_APIId",
                table: "ThirdPartySystemLogs",
                column: "APIId");

            migrationBuilder.CreateIndex(
                name: "IX_ThirdPartySystemLogs_ThirdPartySystemId",
                table: "ThirdPartySystemLogs",
                column: "ThirdPartySystemId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInfo_MunicipalityId",
                table: "UserInfo",
                column: "MunicipalityId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInfo_OfficialTypeId",
                table: "UserInfo",
                column: "OfficialTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInfo_OrganizationId",
                table: "UserInfo",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInfo_UserId",
                table: "UserInfo",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserTypeId",
                table: "UserRoles",
                column: "UserTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserTypeId",
                table: "Users",
                column: "UserTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WastePickerActivityLogs_WastePickerStatusId",
                table: "WastePickerActivityLogs",
                column: "WastePickerStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_WastePickerDocuments_DocumentTypeId",
                table: "WastePickerDocuments",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WastePickerDocuments_MasterCodeId",
                table: "WastePickerDocuments",
                column: "MasterCodeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WastePickerDocuments_WastePickerId",
                table: "WastePickerDocuments",
                column: "WastePickerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WastePickers_CooperativeId",
                table: "WastePickers",
                column: "CooperativeId");

            migrationBuilder.CreateIndex(
                name: "IX_WastePickers_DocumentTypeId",
                table: "WastePickers",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WastePickers_GenderId",
                table: "WastePickers",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_WastePickers_RaceId",
                table: "WastePickers",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_WastePickers_WastePickerStatusId",
                table: "WastePickers",
                column: "WastePickerStatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "APIAccesses");

            migrationBuilder.DropTable(
                name: "CardPrintWastePickers");

            migrationBuilder.DropTable(
                name: "CooperativeInfo");

            migrationBuilder.DropTable(
                name: "ErrorLogs");

            migrationBuilder.DropTable(
                name: "GetEmailContents");

            migrationBuilder.DropTable(
                name: "GetWastePickerStatusAudits");

            migrationBuilder.DropTable(
                name: "ReclaimingInfo");

            migrationBuilder.DropTable(
                name: "SystemLogs");

            migrationBuilder.DropTable(
                name: "SystemSettings");

            migrationBuilder.DropTable(
                name: "ThirdPartySystemLogs");

            migrationBuilder.DropTable(
                name: "ToBeUpdatedWastePickers");

            migrationBuilder.DropTable(
                name: "UserInfo");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserSessions");

            migrationBuilder.DropTable(
                name: "WastePickerActivityLogs");

            migrationBuilder.DropTable(
                name: "WastePickerDocuments");

            migrationBuilder.DropTable(
                name: "IncomeMethods");

            migrationBuilder.DropTable(
                name: "SortingAreas");

            migrationBuilder.DropTable(
                name: "Worksites");

            migrationBuilder.DropTable(
                name: "APIs");

            migrationBuilder.DropTable(
                name: "ThirdPartySystems");

            migrationBuilder.DropTable(
                name: "OfficialTypes");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "WastePickers");

            migrationBuilder.DropTable(
                name: "Municipalities");

            migrationBuilder.DropTable(
                name: "OrganizationTypes");

            migrationBuilder.DropTable(
                name: "UserTypes");

            migrationBuilder.DropTable(
                name: "Cooperatives");

            migrationBuilder.DropTable(
                name: "DocumentTypes");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "Race");

            migrationBuilder.DropTable(
                name: "WastePickerStatuses");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "MasterCodes");

            migrationBuilder.DropTable(
                name: "Provinces");
        }
    }
}
