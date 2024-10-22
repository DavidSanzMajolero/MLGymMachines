using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Domain.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "GymMachines");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "GymMachines",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
