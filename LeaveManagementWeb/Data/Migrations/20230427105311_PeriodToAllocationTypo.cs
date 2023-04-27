using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class PeriodToAllocationTypo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Pediod",
                table: "LeaveAllocations",
                newName: "Period");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "caB43a6e-f6bb-4444-baaf-labb431cabbf",
                column: "ConcurrencyStamp",
                value: "7f1fca5a-9b64-4ace-a113-48615ec9d159");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-ladd431ccbbf",
                column: "ConcurrencyStamp",
                value: "90b94030-6e7f-48df-8307-ef999b867a4b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84df05bf-a29f-49a1-8972-5ceea06e5cdd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47ccce10-6ae0-4d4d-bd05-afff04521130", "AQAAAAEAACcQAAAAEKHQmax2ydTqAcs6OPw5IsogfYauWHJDbBBKlADRwCPadjDaM4d7PN585zOVmV+sWw==", "7566ab79-1141-4397-8790-c64c59f336f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1307ac6-2428-409d-a83d-7e188048b199",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2da9e7a5-da17-4ebe-a250-41c96ee81994", "AQAAAAEAACcQAAAAEE0iSxJLSpmjzffvHV6sEtCOZdGk5JIYor/+IMDV9gXyPm0k2hz9NelexjmLL45mbA==", "beba89f6-e76a-4ec8-ab2a-61211506c6ab" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Period",
                table: "LeaveAllocations",
                newName: "Pediod");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "caB43a6e-f6bb-4444-baaf-labb431cabbf",
                column: "ConcurrencyStamp",
                value: "82445669-d73c-4010-9056-e53934184510");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-ladd431ccbbf",
                column: "ConcurrencyStamp",
                value: "80203611-ae63-4b53-ac17-b5208e90488a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84df05bf-a29f-49a1-8972-5ceea06e5cdd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61c996c6-e29a-449e-b7ee-ad6bea59a8ee", "AQAAAAEAACcQAAAAEEuvsIqCCA2AM+8N5YYQkrqXMuOEI5bueJOMirOpx47XGH6C9WzsNErybryyRdVXzw==", "a1293582-2c78-4933-bc16-015b3594e856" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1307ac6-2428-409d-a83d-7e188048b199",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe84a5b3-9c9d-489e-b004-1b35064340b1", "AQAAAAEAACcQAAAAEOcuqNhfbiPp2bqQeh3Cp4BpAaBHfcTcfcnoG9WoUHWLZomWVu1oMcTbVZzRynpTFQ==", "4a32cfdf-efbc-44de-bce5-16bfdbd118f9" });
        }
    }
}
