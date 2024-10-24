using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Domain.Migrations
{
    /// <inheritdoc />
    public partial class Init8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GymMachines",
                columns: new[] { "Id", "Description", "Name", "UsingSteps" },
                values: new object[] { 6, "The peck deck is a machine designed to isolate and target the chest muscles, specifically the pectoralis major. It mimics the motion of a chest fly, helping to build strength and definition in the chest by bringing the arms together in a controlled motion.", "peck_deck", "[\"Adjust the seat height so that your arms are parallel to the floor when gripping the handles. Position your back flat against the seat pad.\",\"Sit upright, grasp the handles with your elbows slightly bent, and keep your feet flat on the floor.\",\"Bring the handles together in front of your chest in a smooth, controlled motion, focusing on squeezing your chest muscles.\",\"Hold for a brief second when the handles meet, ensuring full contraction of the chest.\",\"Slowly return to the starting position, allowing the arms to open up without overstretching the chest.\",\"Perform the desired number of repetitions, maintaining control and good form throughout.\"]" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GymMachines",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
