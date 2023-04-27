using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "caB43a6e-f6bb-4444-baaf-labb431cabbf",
                column: "ConcurrencyStamp",
                value: "406ae502-67d3-4edf-b111-2d41180915e0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-ladd431ccbbf",
                column: "ConcurrencyStamp",
                value: "a39dd6c6-058e-4a9f-9657-9d740f455c68");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84df05bf-a29f-49a1-8972-5ceea06e5cdd",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "fd8499db-24f9-4d3f-b14a-892b8e382bd8", true, "ADMIN2@TEST.COM", "AQAAAAEAACcQAAAAEBHPrnwh6tl5sAjYr22etmH60mRrXzRbHEMWAjvnizoZHXZjHgqOfRkuI06j6OTF3w==", "1b3963c2-39e8-403b-af28-9903879bdedf", "admin2@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1307ac6-2428-409d-a83d-7e188048b199",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "88c324ec-0f26-4093-ad11-fc136d8190ee", true, "USER@TEST.COM", "AQAAAAEAACcQAAAAEP0cu9TOpapVYEchG/Nm0B3qx2T0cyJIo8gE2qnRhnH2ucJMT/xQfneH5cNONNxO3g==", "a241ca0c-deb5-4b5b-875a-dc2ad6f6780d", "user@test.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "caB43a6e-f6bb-4444-baaf-labb431cabbf",
                column: "ConcurrencyStamp",
                value: "d5dbd183-81ce-43e0-9dd0-7b6cf556acd5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-ladd431ccbbf",
                column: "ConcurrencyStamp",
                value: "e599c538-009b-44e7-963d-e0cc1d1c0bd5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84df05bf-a29f-49a1-8972-5ceea06e5cdd",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "bf1b0eb1-b3dd-4c24-b2ff-5e1a171a0e12", false, null, "AQAAAAEAACcQAAAAEJC22R/utzuc9Ff29ykL755lH7NyLGuglpLT0n3As3ncvHxhVJJ8j6jFZIkom8EuXw==", "a454202b-8676-42b8-9458-461cf31e1cdc", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1307ac6-2428-409d-a83d-7e188048b199",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "150744e0-07ce-4129-bba3-4904f359d43c", false, null, "AQAAAAEAACcQAAAAEMv6oErtdOPrMAXcquEfuDufGPBzlPRCwnHpVeyzVWixneYCXtymOQoOjlD4gpYnKQ==", "85caba63-7904-41d0-92e0-692130694c30", null });
        }
    }
}
