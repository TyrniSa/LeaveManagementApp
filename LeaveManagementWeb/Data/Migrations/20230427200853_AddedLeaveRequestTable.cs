using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
