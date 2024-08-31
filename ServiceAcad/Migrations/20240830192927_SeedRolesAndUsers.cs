using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ServiceAcad.Migrations
{
    /// <inheritdoc />
    public partial class SeedRolesAndUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "4d22b22b-ddd7-46b4-983f-3eb0d366097e", null, "Instructor", "INSTRUCTOR" },
                    { "a553105c-e6e3-4082-8b24-9e583d88504c", null, "Admin", "ADMIN" },
                    { "f0b29439-b3fa-4fdd-8961-63d8a6ea35fe", null, "Student", "STUDENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "31ae8f6f-76b3-4f9d-a5d0-502c8ff811f8", 0, "8708a574-7b06-42fa-81d3-3b58909361a0", "admin@lms.com", true, "Admin User", false, null, "ADMIN@LMS.COM", "ADMIN@LMS.COM", "AQAAAAIAAYagAAAAEFAUoStJyKuZwgkuqyuIoQbtSsivJfjN1B90LoC7JOi5OvVgFo1jUvSYTLILh9QQWw==", null, false, "Admin", "4ce1bde8-abbb-4f50-8950-2926d1c0c161", false, "admin@lms.com" },
                    { "b25da1ae-689c-479d-ad01-83409f540794", 0, "bc86891d-81a9-41e3-bfe6-3a7f2e88771d", "instructor@lms.com", true, "Instructor User", false, null, "INSTRUCTOR@LMS.COM", "INSTRUCTOR@LMS.COM", "AQAAAAIAAYagAAAAED1enNrWSPDQk4OF6L+NcYrRlMprDGXzLZROzTq5J0JXtoOrrwwyDjK82sxpmlFlCw==", null, false, "Instructor", "73387998-189b-4a0b-90f6-e1d33d65b6bb", false, "instructor@lms.com" },
                    { "f9db717f-c6c2-49f2-81fd-a0f5b3807b62", 0, "505177d5-9bec-45cd-9000-692321a852de", "student@lms.com", true, "Student User", false, null, "STUDENT@LMS.COM", "STUDENT@LMS.COM", "AQAAAAIAAYagAAAAEP6rdaTFBQh0FoCPuqi2ps1+VHFUIohv7LJaEbpZMFvjGQXwzhpOnhd4ByhalsbVJA==", null, false, "Student", "b8b10aa5-0286-4ee5-9937-696ad89f6e4e", false, "student@lms.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "a553105c-e6e3-4082-8b24-9e583d88504c", "31ae8f6f-76b3-4f9d-a5d0-502c8ff811f8" },
                    { "4d22b22b-ddd7-46b4-983f-3eb0d366097e", "b25da1ae-689c-479d-ad01-83409f540794" },
                    { "f0b29439-b3fa-4fdd-8961-63d8a6ea35fe", "f9db717f-c6c2-49f2-81fd-a0f5b3807b62" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a553105c-e6e3-4082-8b24-9e583d88504c", "31ae8f6f-76b3-4f9d-a5d0-502c8ff811f8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4d22b22b-ddd7-46b4-983f-3eb0d366097e", "b25da1ae-689c-479d-ad01-83409f540794" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f0b29439-b3fa-4fdd-8961-63d8a6ea35fe", "f9db717f-c6c2-49f2-81fd-a0f5b3807b62" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d22b22b-ddd7-46b4-983f-3eb0d366097e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a553105c-e6e3-4082-8b24-9e583d88504c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0b29439-b3fa-4fdd-8961-63d8a6ea35fe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31ae8f6f-76b3-4f9d-a5d0-502c8ff811f8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b25da1ae-689c-479d-ad01-83409f540794");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9db717f-c6c2-49f2-81fd-a0f5b3807b62");

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
    }
}
