using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Pediod",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pediod",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd8499db-24f9-4d3f-b14a-892b8e382bd8", "AQAAAAEAACcQAAAAEBHPrnwh6tl5sAjYr22etmH60mRrXzRbHEMWAjvnizoZHXZjHgqOfRkuI06j6OTF3w==", "1b3963c2-39e8-403b-af28-9903879bdedf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1307ac6-2428-409d-a83d-7e188048b199",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88c324ec-0f26-4093-ad11-fc136d8190ee", "AQAAAAEAACcQAAAAEP0cu9TOpapVYEchG/Nm0B3qx2T0cyJIo8gE2qnRhnH2ucJMT/xQfneH5cNONNxO3g==", "a241ca0c-deb5-4b5b-875a-dc2ad6f6780d" });
        }
    }
}
