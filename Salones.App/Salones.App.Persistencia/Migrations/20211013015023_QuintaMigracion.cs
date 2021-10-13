using Microsoft.EntityFrameworkCore.Migrations;

namespace Salones.App.Persistencia.Migrations
{
    public partial class QuintaMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngresosSalon_Personas_personaid",
                table: "IngresosSalon");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Salones_Salonid",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_IngresosSalon_personaid",
                table: "IngresosSalon");

            migrationBuilder.DropColumn(
                name: "personaid",
                table: "IngresosSalon");

            migrationBuilder.RenameColumn(
                name: "Salonid",
                table: "Personas",
                newName: "Ingresoid");

            migrationBuilder.RenameIndex(
                name: "IX_Personas_Salonid",
                table: "Personas",
                newName: "IX_Personas_Ingresoid");

            migrationBuilder.AddColumn<string>(
                name: "nombreSalon",
                table: "Salones",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_IngresosSalon_Ingresoid",
                table: "Personas",
                column: "Ingresoid",
                principalTable: "IngresosSalon",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_IngresosSalon_Ingresoid",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "nombreSalon",
                table: "Salones");

            migrationBuilder.RenameColumn(
                name: "Ingresoid",
                table: "Personas",
                newName: "Salonid");

            migrationBuilder.RenameIndex(
                name: "IX_Personas_Ingresoid",
                table: "Personas",
                newName: "IX_Personas_Salonid");

            migrationBuilder.AddColumn<int>(
                name: "personaid",
                table: "IngresosSalon",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_IngresosSalon_personaid",
                table: "IngresosSalon",
                column: "personaid");

            migrationBuilder.AddForeignKey(
                name: "FK_IngresosSalon_Personas_personaid",
                table: "IngresosSalon",
                column: "personaid",
                principalTable: "Personas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Salones_Salonid",
                table: "Personas",
                column: "Salonid",
                principalTable: "Salones",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
