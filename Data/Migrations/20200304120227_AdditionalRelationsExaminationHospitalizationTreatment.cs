using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AdditionalRelationsExaminationHospitalizationTreatment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "HospitalizationId",
                table: "Treatments",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "ExaminationId",
                table: "Treatments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HospitalizationId",
                table: "Examinations",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_ExaminationId",
                table: "Treatments",
                column: "ExaminationId");

            migrationBuilder.CreateIndex(
                name: "IX_Examinations_HospitalizationId",
                table: "Examinations",
                column: "HospitalizationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Examinations_Hospitalizations_HospitalizationId",
                table: "Examinations",
                column: "HospitalizationId",
                principalTable: "Hospitalizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Treatments_Examinations_ExaminationId",
                table: "Treatments",
                column: "ExaminationId",
                principalTable: "Examinations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Examinations_Hospitalizations_HospitalizationId",
                table: "Examinations");

            migrationBuilder.DropForeignKey(
                name: "FK_Treatments_Examinations_ExaminationId",
                table: "Treatments");

            migrationBuilder.DropIndex(
                name: "IX_Treatments_ExaminationId",
                table: "Treatments");

            migrationBuilder.DropIndex(
                name: "IX_Examinations_HospitalizationId",
                table: "Examinations");

            migrationBuilder.DropColumn(
                name: "ExaminationId",
                table: "Treatments");

            migrationBuilder.DropColumn(
                name: "HospitalizationId",
                table: "Examinations");

            migrationBuilder.AlterColumn<string>(
                name: "HospitalizationId",
                table: "Treatments",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
