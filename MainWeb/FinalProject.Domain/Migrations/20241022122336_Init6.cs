using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Domain.Migrations
{
    /// <inheritdoc />
    public partial class Init6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GymMachines",
                columns: new[] { "Id", "Description", "Name", "UsingSteps" },
                values: new object[] { 4, "The deadlift is a fundamental strength exercise that targets multiple muscle groups, primarily the lower back, glutes, hamstrings, and core. It involves lifting a weighted barbell from the ground to hip level by hinging at the hips and engaging the legs and back.", "deadlift", "[\"Stand with feet shoulder-width apart, barbell over the middle of your feet. Bend down, grip the bar slightly outside your knees.\",\"Keep your back straight, chest up, and shoulders over the bar. Hinge at the hips and slightly bend your knees.\",\"Push through your heels, extend your hips, and lift the barbell up, keeping it close to your body.\",\"Stand fully upright with the barbell at hip height, shoulders back, and core tight.\",\"Reverse the motion by hinging at the hips and bending your knees to lower the bar back to the ground.\",\"Complete the desired number of repetitions, maintaining proper form.\"]" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GymMachines",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
