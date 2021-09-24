using Microsoft.EntityFrameworkCore.Migrations;

namespace Salones.App.Persistencia.Migrations
{
    public partial class Segunda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "identificación",
                table: "Personas",
                newName: "identificacion");

            migrationBuilder.AlterColumn<int>(
                name: "periodoAislamiento",
                table: "DiagnosticosCovid",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "estadoCovid",
                table: "DiagnosticosCovid",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "identificacion",
                table: "Personas",
                newName: "identificación");

            migrationBuilder.AlterColumn<string>(
                name: "periodoAislamiento",
                table: "DiagnosticosCovid",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "estadoCovid",
                table: "DiagnosticosCovid",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }
    }
}
