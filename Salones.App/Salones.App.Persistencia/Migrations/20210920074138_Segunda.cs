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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "identificacion",
                table: "Personas",
                newName: "identificación");
        }
    }
}
