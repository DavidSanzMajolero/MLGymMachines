using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalProject.Domain.Migrations
{
    /// <inheritdoc />
    public partial class Init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GymMachines",
                columns: new[] { "Id", "Description", "Name", "UsingSteps" },
                values: new object[,]
                {
                    { 1, "The bench press is a classic strength training exercise that primarily targets the chest muscles, but it also engages the triceps and shoulders. It is performed lying on a flat bench while lifting a weighted barbell upward from the chest. It is essential for developing strength and muscle mass in the upper body.", "Bench Press", "[\"Adjust the bench and load the bar. Make sure the weight plates are secured.\",\"Lie on the bench, feet on the floor, back slightly arched. Grip the bar with your hands slightly wider than shoulder-width apart.\",\"Lift the bar from the rack and position it directly above your chest, arms extended.\",\"Slowly lower the bar until it lightly touches your chest, controlling the movement.\",\"Push the bar back up, extending your arms without locking your elbows.\",\"Repeat the movement, and once finished, place the bar back on the rack.\"]" },
                    { 2, "The elliptical machine is a low-impact cardiovascular exercise machine that simulates walking, running, or climbing stairs. It provides a full-body workout by engaging both the upper body (with movable handles) and the lower body (with foot pedals). The elliptical offers an effective way to improve cardiovascular endurance, burn calories, and strengthen muscles without putting excessive strain on the joints.", "Elliptical", "[\"Adjust the resistance and incline (if available) to your fitness level. Ensure the machine is properly set up for your height.\",\"Step onto the foot pedals, holding the handles for support. Start with one foot and then the other, making sure you\\u0027re balanced.\",\"Begin pedaling by moving your feet in an elliptical (circular) motion. Keep your posture upright and your core engaged.\",\"Grip the handles and move them in sync with your legs, pulling and pushing as you pedal to engage your arms and upper body.\",\"Maintain a steady pace, adjusting the resistance or incline as needed for more intensity.\",\"After finishing your workout, reduce the resistance and slow down your pace for a couple of minutes before stepping off the machine.\"]" },
                    { 3, "A treadmill is a cardio machine used for walking, jogging, or running on a moving belt. It helps improve endurance, burn calories, and strengthen the lower body.", "Tredmill", "[\"Adjust speed and incline. Start slow.\",\"Stand on the side rails, press start, then step onto the belt at a low speed.\",\"Gradually increase speed or incline as you feel comfortable.\",\"Stay upright with a relaxed posture, avoiding leaning on the handrails.\",\"Slow down the speed to walk before stopping.\",\"Press stop, wait for the belt to stop, then step off.\"]" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GymMachines",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GymMachines",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GymMachines",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
