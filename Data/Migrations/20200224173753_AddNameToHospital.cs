using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AddNameToHospital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "PersonVaccines");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "PersonChronicDiseases");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "PersonAllergies");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Hospitals",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Hospitals");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "PersonVaccines",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "PersonChronicDiseases",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "PersonAllergies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
