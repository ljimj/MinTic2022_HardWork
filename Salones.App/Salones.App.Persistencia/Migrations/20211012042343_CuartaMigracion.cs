using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Salones.App.Persistencia.Migrations
{
    public partial class CuartaMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Salonid",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaIngreso",
                table: "IngresosSalon",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "sintomas",
                table: "DiagnosticosCovid",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "fechaDiagnostico",
                table: "DiagnosticosCovid",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tipoSintomas",
                table: "DiagnosticosCovid",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Personas_Salonid",
                table: "Personas",
                column: "Salonid");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Salones_Salonid",
                table: "Personas",
                column: "Salonid",
                principalTable: "Salones",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Salones_Salonid",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_Salonid",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Salonid",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "tipoSintomas",
                table: "DiagnosticosCovid");

            migrationBuilder.AlterColumn<string>(
                name: "FechaIngreso",
                table: "IngresosSalon",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "sintomas",
                table: "DiagnosticosCovid",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "fechaDiagnostico",
                table: "DiagnosticosCovid",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
