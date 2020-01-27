using Microsoft.EntityFrameworkCore.Migrations;

namespace Gym.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    Exercise_Name = table.Column<string>(type: "varchar(100)", nullable: false),
                    Exercise_Description = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.Exercise_Name);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    PersonID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    FirstName = table.Column<string>(type: "varchar(100)", nullable: true),
                    Membership_End_Date = table.Column<string>(type: "varchar(100)", nullable: true),
                    Planned_exercise_id = table.Column<string>(type: "varchar(100)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(250)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.PersonID);
                });

            migrationBuilder.CreateTable(
                name: "PlannedWorkouts",
                columns: table => new
                {
                    ExerciseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Exercise_Name = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Planned_Set_Number = table.Column<string>(type: "varchar(100)", nullable: false),
                    Planned_Reps = table.Column<string>(type: "varchar(100)", nullable: false),
                    Planned_Weight = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlannedWorkouts", x => x.ExerciseID);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    StaffID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    FirstName = table.Column<string>(type: "varchar(100)", nullable: true),
                    Occupation = table.Column<string>(type: "varchar(100)", nullable: true),
                    OrganizationName = table.Column<string>(type: "varchar(100)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(250)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.StaffID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "PlannedWorkouts");

            migrationBuilder.DropTable(
                name: "Staffs");
        }
    }
}
