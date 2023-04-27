using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "caB43a6e-f6bb-4444-baaf-labb431cabbf", "d5dbd183-81ce-43e0-9dd0-7b6cf556acd5", "User", "USER" },
                    { "cac43a6e-f7bb-4448-baaf-ladd431ccbbf", "e599c538-009b-44e7-963d-e0cc1d1c0bd5", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "84df05bf-a29f-49a1-8972-5ceea06e5cdd", 0, "bf1b0eb1-b3dd-4c24-b2ff-5e1a171a0e12", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin2@test.com", false, "Admin", "Test", false, null, "ADMIN2@TEST.COM", null, "AQAAAAEAACcQAAAAEJC22R/utzuc9Ff29ykL755lH7NyLGuglpLT0n3As3ncvHxhVJJ8j6jFZIkom8EuXw==", null, false, "a454202b-8676-42b8-9458-461cf31e1cdc", null, false, null },
                    { "b1307ac6-2428-409d-a83d-7e188048b199", 0, "150744e0-07ce-4129-bba3-4904f359d43c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@test.com", false, "System", "User", false, null, "USER@TEST.COM", null, "AQAAAAEAACcQAAAAEMv6oErtdOPrMAXcquEfuDufGPBzlPRCwnHpVeyzVWixneYCXtymOQoOjlD4gpYnKQ==", null, false, "85caba63-7904-41d0-92e0-692130694c30", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a6e-f7bb-4448-baaf-ladd431ccbbf", "84df05bf-a29f-49a1-8972-5ceea06e5cdd" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "caB43a6e-f6bb-4444-baaf-labb431cabbf", "b1307ac6-2428-409d-a83d-7e188048b199" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a6e-f7bb-4448-baaf-ladd431ccbbf", "84df05bf-a29f-49a1-8972-5ceea06e5cdd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "caB43a6e-f6bb-4444-baaf-labb431cabbf", "b1307ac6-2428-409d-a83d-7e188048b199" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "caB43a6e-f6bb-4444-baaf-labb431cabbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-ladd431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84df05bf-a29f-49a1-8972-5ceea06e5cdd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1307ac6-2428-409d-a83d-7e188048b199");
        }
    }
}
