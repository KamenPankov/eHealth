using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ChangeIdToPersonVaccineAllergyDisease : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonAllergies_Allergies_AllergyId",
                table: "PersonAllergies");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonAllergies_Persons_PersonId",
                table: "PersonAllergies");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonChronicDiseases_ChronicDiseases_ChronicDiseaseId",
                table: "PersonChronicDiseases");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonChronicDiseases_Persons_PersonId",
                table: "PersonChronicDiseases");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonVaccines_Persons_PersonId",
                table: "PersonVaccines");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonVaccines_Vaccines_VaccineId",
                table: "PersonVaccines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonVaccines",
                table: "PersonVaccines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonChronicDiseases",
                table: "PersonChronicDiseases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonAllergies",
                table: "PersonAllergies");

            migrationBuilder.AlterColumn<string>(
                name: "PersonId",
                table: "PersonVaccines",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PersonVaccines",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "PersonId",
                table: "PersonChronicDiseases",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PersonChronicDiseases",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "PersonAllergies",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonVaccines",
                table: "PersonVaccines",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonChronicDiseases",
                table: "PersonChronicDiseases",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonAllergies",
                table: "PersonAllergies",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonVaccines_PersonId",
                table: "PersonVaccines",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonChronicDiseases_PersonId",
                table: "PersonChronicDiseases",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonAllergies_Allergies_AllergyId",
                table: "PersonAllergies",
                column: "AllergyId",
                principalTable: "Allergies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonAllergies_Persons_PersonId",
                table: "PersonAllergies",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonChronicDiseases_ChronicDiseases_ChronicDiseaseId",
                table: "PersonChronicDiseases",
                column: "ChronicDiseaseId",
                principalTable: "ChronicDiseases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonChronicDiseases_Persons_PersonId",
                table: "PersonChronicDiseases",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonVaccines_Persons_PersonId",
                table: "PersonVaccines",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonVaccines_Vaccines_VaccineId",
                table: "PersonVaccines",
                column: "VaccineId",
                principalTable: "Vaccines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonAllergies_Allergies_AllergyId",
                table: "PersonAllergies");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonAllergies_Persons_PersonId",
                table: "PersonAllergies");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonChronicDiseases_ChronicDiseases_ChronicDiseaseId",
                table: "PersonChronicDiseases");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonChronicDiseases_Persons_PersonId",
                table: "PersonChronicDiseases");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonVaccines_Persons_PersonId",
                table: "PersonVaccines");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonVaccines_Vaccines_VaccineId",
                table: "PersonVaccines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonVaccines",
                table: "PersonVaccines");

            migrationBuilder.DropIndex(
                name: "IX_PersonVaccines_PersonId",
                table: "PersonVaccines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonChronicDiseases",
                table: "PersonChronicDiseases");

            migrationBuilder.DropIndex(
                name: "IX_PersonChronicDiseases_PersonId",
                table: "PersonChronicDiseases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonAllergies",
                table: "PersonAllergies");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PersonVaccines");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PersonChronicDiseases");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PersonAllergies");

            migrationBuilder.AlterColumn<string>(
                name: "PersonId",
                table: "PersonVaccines",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PersonId",
                table: "PersonChronicDiseases",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonVaccines",
                table: "PersonVaccines",
                columns: new[] { "PersonId", "VaccineId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonChronicDiseases",
                table: "PersonChronicDiseases",
                columns: new[] { "PersonId", "ChronicDiseaseId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonAllergies",
                table: "PersonAllergies",
                columns: new[] { "PersonId", "AllergyId" });

            migrationBuilder.AddForeignKey(
                name: "FK_PersonAllergies_Allergies_AllergyId",
                table: "PersonAllergies",
                column: "AllergyId",
                principalTable: "Allergies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonAllergies_Persons_PersonId",
                table: "PersonAllergies",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonChronicDiseases_ChronicDiseases_ChronicDiseaseId",
                table: "PersonChronicDiseases",
                column: "ChronicDiseaseId",
                principalTable: "ChronicDiseases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonChronicDiseases_Persons_PersonId",
                table: "PersonChronicDiseases",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonVaccines_Persons_PersonId",
                table: "PersonVaccines",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonVaccines_Vaccines_VaccineId",
                table: "PersonVaccines",
                column: "VaccineId",
                principalTable: "Vaccines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
