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
                values: new object[] { 66, false, new DateTime(2022, 4, 2, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 65, false, new DateTime(2022, 4, 1, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 64, false, new DateTime(2022, 4, 1, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 63, false, new DateTime(2022, 4, 1, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 62, false, new DateTime(2022, 4, 1, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 61, false, new DateTime(2022, 4, 1, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 60, false, new DateTime(2022, 4, 1, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 59, false, new DateTime(2022, 4, 1, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 58, false, new DateTime(2022, 4, 1, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 56, false, new DateTime(2022, 4, 1, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 67, false, new DateTime(2022, 4, 2, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 55, false, new DateTime(2022, 4, 1, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 54, false, new DateTime(2022, 4, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 53, false, new DateTime(2022, 4, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 52, false, new DateTime(2022, 3, 31, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 51, false, new DateTime(2022, 3, 31, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 50, false, new DateTime(2022, 3, 31, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 49, false, new DateTime(2022, 3, 31, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 48, false, new DateTime(2022, 3, 31, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 57, false, new DateTime(2022, 4, 1, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 68, false, new DateTime(2022, 4, 2, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 69, false, new DateTime(2022, 4, 2, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 70, false, new DateTime(2022, 4, 2, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 89, true, new DateTime(2022, 4, 3, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 88, true, new DateTime(2022, 4, 3, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 87, true, new DateTime(2022, 4, 3, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 86, true, new DateTime(2022, 4, 3, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 85, true, new DateTime(2022, 4, 3, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 84, true, new DateTime(2022, 4, 3, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 83, true, new DateTime(2022, 4, 3, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 82, true, new DateTime(2022, 4, 3, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 81, true, new DateTime(2022, 4, 3, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 80, true, new DateTime(2022, 4, 3, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 79, true, new DateTime(2022, 4, 3, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 78, false, new DateTime(2022, 4, 2, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 77, false, new DateTime(2022, 4, 2, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 76, false, new DateTime(2022, 4, 2, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 75, false, new DateTime(2022, 4, 2, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 74, false, new DateTime(2022, 4, 2, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 73, false, new DateTime(2022, 4, 2, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 72, false, new DateTime(2022, 4, 2, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 71, false, new DateTime(2022, 4, 2, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 47, false, new DateTime(2022, 3, 31, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 46, false, new DateTime(2022, 3, 31, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 44, false, new DateTime(2022, 3, 31, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 90, true, new DateTime(2022, 4, 3, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 19, false, new DateTime(2022, 3, 29, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 18, false, new DateTime(2022, 3, 29, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 17, false, new DateTime(2022, 3, 29, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 16, false, new DateTime(2022, 3, 29, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 15, false, new DateTime(2022, 3, 29, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 14, false, new DateTime(2022, 3, 29, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 13, false, new DateTime(2022, 3, 28, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 12, false, new DateTime(2022, 3, 28, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 11, false, new DateTime(2022, 3, 28, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 10, false, new DateTime(2022, 3, 28, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 9, false, new DateTime(2022, 3, 28, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 8, false, new DateTime(2022, 3, 28, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 7, false, new DateTime(2022, 3, 28, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 6, false, new DateTime(2022, 3, 28, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 5, false, new DateTime(2022, 3, 28, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 4, false, new DateTime(2022, 3, 28, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 3, false, new DateTime(2022, 3, 28, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 2, false, new DateTime(2022, 3, 28, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 1, false, new DateTime(2022, 3, 28, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 20, false, new DateTime(2022, 3, 29, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 21, false, new DateTime(2022, 3, 29, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 22, false, new DateTime(2022, 3, 29, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 23, false, new DateTime(2022, 3, 29, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 43, false, new DateTime(2022, 3, 31, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 42, false, new DateTime(2022, 3, 31, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 41, false, new DateTime(2022, 3, 31, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 40, false, new DateTime(2022, 3, 31, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 39, false, new DateTime(2022, 3, 30, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 38, false, new DateTime(2022, 3, 30, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 37, false, new DateTime(2022, 3, 30, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 36, false, new DateTime(2022, 3, 30, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 35, false, new DateTime(2022, 3, 30, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 45, false, new DateTime(2022, 3, 31, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 34, false, new DateTime(2022, 3, 30, 15, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 32, false, new DateTime(2022, 3, 30, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 31, false, new DateTime(2022, 3, 30, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 30, false, new DateTime(2022, 3, 30, 11, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 29, false, new DateTime(2022, 3, 30, 10, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 28, false, new DateTime(2022, 3, 30, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 27, false, new DateTime(2022, 3, 30, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 26, false, new DateTime(2022, 3, 29, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 25, false, new DateTime(2022, 3, 29, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 24, false, new DateTime(2022, 3, 29, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 33, false, new DateTime(2022, 3, 30, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Times",
                columns: new[] { "TimeID", "SlotFilled", "TimeDescription" },
                values: new object[] { 91, true, new DateTime(2022, 4, 3, 20, 0, 0, 0, DateTimeKind.Unspecified) });
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
