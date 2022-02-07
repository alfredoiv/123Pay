using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _123Pay.Migrations
{
    public partial class InitializeModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClientName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferenceNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Merchant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttachmentFilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcessorId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentRequests_AspNetUsers_ProcessorId",
                        column: x => x.ProcessorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fdbde63e-6a08-4f35-a1ac-fca72f698f59", "6adf74c5-2bef-4a19-a2d5-7140ece44009", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "71fac99f-2553-48da-8bca-4954274053bc", 0, "b39499a0-0101-45a9-8578-66e6ffe9d86f", "alfredoiv.magpantay@yahoo.com", false, false, null, "ALFREDOIV.MAGPANTAY@YAHOO.COM", "ADMINISTRATOR", "AQAAAAEAACcQAAAAEKHaJFeliWYa9aO0g3YxUToQuXMh3cDwpGm90SxXCEuRNora+tC/9cSR0mSwX1Cc6Q==", null, false, "f202683f-bf4a-419b-bf4e-5a1d6c3efc4c", false, "administrator" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fdbde63e-6a08-4f35-a1ac-fca72f698f59", "71fac99f-2553-48da-8bca-4954274053bc" });

            migrationBuilder.InsertData(
                table: "PaymentRequests",
                columns: new[] { "Id", "AccountName", "AccountNo", "Amount", "AttachmentFilePath", "ClientName", "CreateDate", "CustomerName", "Merchant", "OtherDetails", "ProcessorId", "ReferenceNo", "Status" },
                values: new object[,]
                {
                    { 18, "Customer 18", "8011223318", 1800.0, null, "ABC Pay", new DateTime(2022, 2, 6, 7, 22, 49, 536, DateTimeKind.Local).AddTicks(6927), "Wan Talamera", "Amazon", "Other Details 18", "71fac99f-2553-48da-8bca-4954274053bc", "PR2022020100018", "FAILED" },
                    { 17, "Customer 17", "8011223317", 1700.0, null, "ABC Pay", new DateTime(2022, 2, 6, 7, 22, 49, 536, DateTimeKind.Local).AddTicks(6924), "Wan Talamera", "Netflix", "Other Details 17", "71fac99f-2553-48da-8bca-4954274053bc", "PR2022020100017", "PROCESSING" },
                    { 16, "Customer 16", "8011223316", 1600.0, null, "ABC Pay", new DateTime(2022, 2, 6, 7, 22, 49, 536, DateTimeKind.Local).AddTicks(6921), "Wan Talamera", "AT&T", "Other Details 16", "71fac99f-2553-48da-8bca-4954274053bc", "PR2022020100016", "PENDING" },
                    { 15, "Customer 15", "8011223315", 1500.0, null, "ABC Pay", new DateTime(2022, 2, 6, 7, 22, 49, 536, DateTimeKind.Local).AddTicks(6919), "Wan Talamera", "TELEPAY", "Other Details 15", "71fac99f-2553-48da-8bca-4954274053bc", "PR2022020100015", "PENDING" },
                    { 14, "Customer 14", "8011223314", 1400.0, null, "ABC Pay", new DateTime(2022, 2, 6, 7, 22, 49, 536, DateTimeKind.Local).AddTicks(6917), "Wan Talamera", "EBay", "Other Details 14", "71fac99f-2553-48da-8bca-4954274053bc", "PR2022020100014", "DONE" },
                    { 13, "Customer 13", "8011223313", 1300.0, null, "ABC Pay", new DateTime(2022, 2, 6, 7, 22, 49, 536, DateTimeKind.Local).AddTicks(6916), "Wan Talamera", "Amazon", "Other Details 13", "71fac99f-2553-48da-8bca-4954274053bc", "PR2022020100013", "FAILED" },
                    { 12, "Customer 12", "8011223312", 1200.0, null, "ABC Pay", new DateTime(2022, 2, 6, 7, 22, 49, 536, DateTimeKind.Local).AddTicks(6914), "Wan Talamera", "Netflix", "Other Details 12", "71fac99f-2553-48da-8bca-4954274053bc", "PR2022020100012", "PROCESSING" },
                    { 11, "Customer 11", "8011223311", 1100.0, null, "ABC Pay", new DateTime(2022, 2, 6, 7, 22, 49, 536, DateTimeKind.Local).AddTicks(6912), "Wan Talamera", "AT&T", "Other Details 11", "71fac99f-2553-48da-8bca-4954274053bc", "PR2022020100011", "PENDING" },
                    { 19, "Customer 19", "8011223319", 1900.0, null, "ABC Pay", new DateTime(2022, 2, 6, 7, 22, 49, 536, DateTimeKind.Local).AddTicks(6929), "Wan Talamera", "EBay", "Other Details 19", "71fac99f-2553-48da-8bca-4954274053bc", "PR2022020100019", "DONE" },
                    { 10, "Customer 10", "8011223310", 1000.0, null, "ABC Pay", new DateTime(2022, 2, 6, 7, 22, 49, 536, DateTimeKind.Local).AddTicks(6910), "Wan Talamera", "TELEPAY", "Other Details 10", "71fac99f-2553-48da-8bca-4954274053bc", "PR2022020100010", "PENDING" },
                    { 8, "Customer 8", "8011223308", 800.0, null, "ABC Pay", new DateTime(2022, 2, 6, 7, 22, 49, 536, DateTimeKind.Local).AddTicks(6906), "Wan Talamera", "Amazon", "Other Details 8", "71fac99f-2553-48da-8bca-4954274053bc", "PR2022020100008", "FAILED" },
                    { 7, "Customer 7", "8011223307", 700.0, null, "ABC Pay", new DateTime(2022, 2, 6, 7, 22, 49, 536, DateTimeKind.Local).AddTicks(6904), "Wan Talamera", "Netflix", "Other Details 7", "71fac99f-2553-48da-8bca-4954274053bc", "PR2022020100007", "PROCESSING" },
                    { 6, "Customer 6", "8011223306", 600.0, null, "ABC Pay", new DateTime(2022, 2, 6, 7, 22, 49, 536, DateTimeKind.Local).AddTicks(6902), "Wan Talamera", "AT&T", "Other Details 6", "71fac99f-2553-48da-8bca-4954274053bc", "PR2022020100006", "PENDING" },
                    { 5, "Customer 5", "8011223305", 500.0, null, "ABC Pay", new DateTime(2022, 2, 6, 7, 22, 49, 536, DateTimeKind.Local).AddTicks(6898), "Wan Talamera", "TELEPAY", "Other Details 5", "71fac99f-2553-48da-8bca-4954274053bc", "PR2022020100005", "PENDING" },
                    { 4, "Customer 4", "8011223304", 400.0, null, "ABC Pay", new DateTime(2022, 2, 6, 7, 22, 49, 536, DateTimeKind.Local).AddTicks(6896), "Wan Talamera", "EBay", "Other Details 4", "71fac99f-2553-48da-8bca-4954274053bc", "PR2022020100004", "DONE" },
                    { 3, "Customer 3", "8011223303", 300.0, null, "ABC Pay", new DateTime(2022, 2, 6, 7, 22, 49, 536, DateTimeKind.Local).AddTicks(6892), "Wan Talamera", "Amazon", "Other Details 3", "71fac99f-2553-48da-8bca-4954274053bc", "PR2022020100003", "FAILED" },
                    { 2, "Customer 2", "8011223302", 200.0, null, "ABC Pay", new DateTime(2022, 2, 6, 7, 22, 49, 536, DateTimeKind.Local).AddTicks(6756), "Wan Talamera", "Netflix", "Other Details 2", "71fac99f-2553-48da-8bca-4954274053bc", "PR2022020100002", "PROCESSING" },
                    { 1, "Customer 1", "8011223301", 100.0, null, "ABC Pay", new DateTime(2022, 2, 6, 7, 22, 49, 534, DateTimeKind.Local).AddTicks(7645), "Wan Talamera", "AT&T", "Other Details 1", "71fac99f-2553-48da-8bca-4954274053bc", "PR2022020100001", "PENDING" },
                    { 9, "Customer 9", "8011223309", 900.0, null, "ABC Pay", new DateTime(2022, 2, 6, 7, 22, 49, 536, DateTimeKind.Local).AddTicks(6908), "Wan Talamera", "EBay", "Other Details 9", "71fac99f-2553-48da-8bca-4954274053bc", "PR2022020100009", "DONE" },
                    { 20, "Customer 20", "8011223320", 2000.0, null, "ABC Pay", new DateTime(2022, 2, 6, 7, 22, 49, 536, DateTimeKind.Local).AddTicks(6931), "Wan Talamera", "TELEPAY", "Other Details 20", "71fac99f-2553-48da-8bca-4954274053bc", "PR2022020100020", "PENDING" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentRequests_ProcessorId",
                table: "PaymentRequests",
                column: "ProcessorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "PaymentRequests");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
