using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ServiceAcad.Migrations
{
    /// <inheritdoc />
    public partial class SecondCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7aa9d934-6852-478c-9538-b8c6ca3fe3f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80111b5a-6bdc-4b67-a5af-1dc99d1fb71d");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "161d58c7-c78c-4860-b45c-711b0f261cb8", "fa6ff6c7-b3eb-48ef-b289-3db22c33355a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "161d58c7-c78c-4860-b45c-711b0f261cb8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa6ff6c7-b3eb-48ef-b289-3db22c33355a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8699bc94-723d-44c7-b28f-7f572f6e0b7a", null, "Instructor", "INSTRUCTOR" },
                    { "e13a10d1-cd4c-407a-818a-d224dd1374f4", null, "Student", "STUDENT" },
                    { "fc0691e4-572c-4e79-b50b-e2ec97a3a30a", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "dd1e73d6-e919-4038-b61f-0974d828b9f6", 0, "473f2bf4-0123-46fe-9464-d44b88971b95", "admin@lms.com", true, "Admin User", false, null, "ADMIN@LMS.COM", "ADMIN@LMS.COM", "AQAAAAIAAYagAAAAEGd/nSLER5le5iHEQfXSPzFijWFKvrXLJcs+HXvToUM556RlsyGZ+nFA4XpFuQfakA==", null, false, "Admin", "69fc2e4d-f949-4891-bcc2-cdd6b0d68270", false, "admin@lms.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fc0691e4-572c-4e79-b50b-e2ec97a3a30a", "dd1e73d6-e919-4038-b61f-0974d828b9f6" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8699bc94-723d-44c7-b28f-7f572f6e0b7a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e13a10d1-cd4c-407a-818a-d224dd1374f4");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fc0691e4-572c-4e79-b50b-e2ec97a3a30a", "dd1e73d6-e919-4038-b61f-0974d828b9f6" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc0691e4-572c-4e79-b50b-e2ec97a3a30a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd1e73d6-e919-4038-b61f-0974d828b9f6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "161d58c7-c78c-4860-b45c-711b0f261cb8", null, "Admin", "ADMIN" },
                    { "7aa9d934-6852-478c-9538-b8c6ca3fe3f3", null, "Instructor", "INSTRUCTOR" },
                    { "80111b5a-6bdc-4b67-a5af-1dc99d1fb71d", null, "Student", "STUDENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "fa6ff6c7-b3eb-48ef-b289-3db22c33355a", 0, "bb5966cc-0586-4e22-a9ab-c8bff964d887", "admin@lms.com", true, "Admin User", false, null, "ADMIN@LMS.COM", "ADMIN@LMS.COM", "AQAAAAIAAYagAAAAEKakHzfIh2d6KClNWqsqN1VoEdJYVWi2JpJWJq4bIlf8lM62eBitstR+rMb26Ym/Zg==", null, false, "Admin", "fca752ea-a2fe-4243-ab2f-e8518e2feb92", false, "admin@lms.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "161d58c7-c78c-4860-b45c-711b0f261cb8", "fa6ff6c7-b3eb-48ef-b289-3db22c33355a" });
        }
    }
}
