using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Domain.Migrations
{
    /// <inheritdoc />
    public partial class Init7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GymMachines",
                columns: new[] { "Id", "Description", "Name", "UsingSteps" },
                values: new object[] { 5, "The lat pulldown is a strength exercise that targets the muscles of the upper back, primarily the latissimus dorsi. It involves pulling a bar down towards your chest while seated, simulating a pull-up motion. This exercise helps improve upper body strength and posture.", "pulldown", "[\"Adjust the knee pad to secure your legs. Grip the bar slightly wider than shoulder-width.\",\"Sit upright with your arms fully extended, core tight, and shoulders slightly back.\",\"Pull the bar down towards your upper chest, leading with your elbows and keeping your back straight.\",\"Hold briefly when the bar reaches your chest, squeezing your shoulder blades together.\",\"Slowly extend your arms, letting the bar rise back to the starting position in a controlled motion.\",\"Complete the desired number of repetitions while maintaining good form.\"]" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GymMachines",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
