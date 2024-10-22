using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Domain.Migrations
{
    /// <inheritdoc />
    public partial class Init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GymMachines",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "bench_press");

            migrationBuilder.UpdateData(
                table: "GymMachines",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "elliptical");

            migrationBuilder.UpdateData(
                table: "GymMachines",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "tredmill");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GymMachines",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Bench Press");

            migrationBuilder.UpdateData(
                table: "GymMachines",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Elliptical");

            migrationBuilder.UpdateData(
                table: "GymMachines",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Tredmill");
        }
    }
}
