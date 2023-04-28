using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class UpdatedRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "caB43a6e-f6bb-4444-baaf-labb431cabbf",
                column: "ConcurrencyStamp",
                value: "42f807cf-3a46-4c15-9bdf-f06b7f7a27d7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-ladd431ccbbf",
                column: "ConcurrencyStamp",
                value: "f08913d1-bfdf-4742-bfca-70147aa323f5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84df05bf-a29f-49a1-8972-5ceea06e5cdd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4caf1f92-5469-4795-82f3-038aa7b2d483", "AQAAAAEAACcQAAAAELDDpXbGWNojBIukClkVN0fPw8F1p49aMsbj/07R7xMDj+1gkR+FX8q7DxXRFpAHWw==", "1ccc6417-bab9-4bfd-a618-ff3e4f2376d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1307ac6-2428-409d-a83d-7e188048b199",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b915e2b-8c2b-4c45-9251-83a9621530b8", "AQAAAAEAACcQAAAAECBH+I5P0o6V1TNOyTHb2fmyFEZTTiTJJKXtHFRLW/ob1VFcBUrDTzYtNpsJSu5WUw==", "f764663d-b2e3-4b5d-802f-665e19987da3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "caB43a6e-f6bb-4444-baaf-labb431cabbf",
                column: "ConcurrencyStamp",
                value: "3b9f50b2-24a3-417f-b278-64f4b8c6eb60");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-ladd431ccbbf",
                column: "ConcurrencyStamp",
                value: "e82c7d51-acfd-4f63-847e-b178881d0c84");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84df05bf-a29f-49a1-8972-5ceea06e5cdd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6aa14076-80e9-4c98-bc80-e13827b20af9", "AQAAAAEAACcQAAAAEDd9u8YxtrnqZfsHH0ZtIbEC+7frFZQCdUoypiRZs3WW4FxsoAM7uaAtRripVTKH6w==", "aacba47c-85a8-4119-9c37-d62c3aeb0116" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1307ac6-2428-409d-a83d-7e188048b199",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a17cfa8-ff4c-4fb7-a486-a37033d0f0ab", "AQAAAAEAACcQAAAAEHH7lbOvxoWHCMAXRuZbzqjgH+2hTZ3VwRYOz5S9p75EIu3s7uxZEWg5sc17cjL1Ag==", "c5cd94f7-7403-4860-9ee9-5482336e740a" });
        }
    }
}
