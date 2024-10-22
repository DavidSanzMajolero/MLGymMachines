using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Domain.Migrations
{
    /// <inheritdoc />
    public partial class Init5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GymMachines",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "treadmill");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GymMachines",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "tredmill");
        }
    }
}
