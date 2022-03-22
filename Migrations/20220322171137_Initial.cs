using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LaytonTemple.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppointmentID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: false),
                    Size = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    AppointmentTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AppointmentID);
                });

            migrationBuilder.CreateTable(
                name: "Times",
                columns: table => new
                {
                    TimeID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TimeDescription = table.Column<DateTime>(nullable: false),
                    SlotFilled = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Times", x => x.TimeID);
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "AppointmentTime", "Email", "Name", "Phone", "Size" },
                values: new object[] { 1, new DateTime(2022, 3, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), "Johnson@johnson.com", "Johnson", "1231234567", 3 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "AppointmentTime", "Email", "Name", "Phone", "Size" },
                values: new object[] { 2, new DateTime(2022, 3, 28, 10, 0, 0, 0, DateTimeKind.Unspecified), "Davidson@davidson.com", "Davidson", "9879876543", 4 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "AppointmentTime", "Email", "Name", "Phone", "Size" },
                values: new object[] { 3, new DateTime(2022, 3, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), "Jackson@jackson.com", "Jackson", "5555555555", 2 });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 1, false, new DateTime(2022, 3, 28, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 2, false, new DateTime(2022, 3, 28, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 3, false, new DateTime(2022, 3, 28, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 4, false, new DateTime(2022, 3, 28, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 5, false, new DateTime(2022, 3, 28, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 6, false, new DateTime(2022, 3, 28, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 7, false, new DateTime(2022, 3, 28, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 8, false, new DateTime(2022, 3, 28, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 9, false, new DateTime(2022, 3, 28, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 10, false, new DateTime(2022, 3, 28, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 11, false, new DateTime(2022, 3, 28, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 12, false, new DateTime(2022, 3, 28, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 13, false, new DateTime(2022, 3, 28, 20, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Times");
        }
    }
}
