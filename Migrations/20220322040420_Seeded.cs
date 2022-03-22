using Microsoft.EntityFrameworkCore.Migrations;

namespace LaytonTemple.Migrations
{
    public partial class Seeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AppointmentTime",
                table: "Appointments",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "AppointmentTime", "Email", "Name", "Phone", "Size" },
                values: new object[] { 1, "1:00 PM", "Johnson@johnson.com", "Johnson", "1231234567", 3 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "AppointmentTime", "Email", "Name", "Phone", "Size" },
                values: new object[] { 2, "11:00 AM", "Davidson@davidson.com", "Davidson", "9879876543", 4 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentID", "AppointmentTime", "Email", "Name", "Phone", "Size" },
                values: new object[] { 3, "5:00 PM", "Jackson@jackson.com", "Jackson", "5555555555", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentID",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "AppointmentTime",
                table: "Appointments");
        }
    }
}
