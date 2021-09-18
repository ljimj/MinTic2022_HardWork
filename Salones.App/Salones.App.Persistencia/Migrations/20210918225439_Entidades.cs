using Microsoft.EntityFrameworkCore.Migrations;

namespace Salones.App.Persistencia.Migrations
{
    public partial class Entidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiagnosticosCovid",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sintomas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estadoCovid = table.Column<int>(type: "int", nullable: false),
                    fechaDiagnostico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    periodoAislamiento = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiagnosticosCovid", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Sedes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cantidadSalones = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sedes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tipoIdentificacion = table.Column<int>(type: "int", nullable: false),
                    identificación = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    edad = table.Column<int>(type: "int", nullable: false),
                    estadoCovidid = table.Column<int>(type: "int", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sedeid = table.Column<int>(type: "int", nullable: true),
                    unidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    carrera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    semestre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    facultad = table.Column<int>(type: "int", nullable: true),
                    turno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    departamento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    materia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Profesor_facultad = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Personas_DiagnosticosCovid_estadoCovidid",
                        column: x => x.estadoCovidid,
                        principalTable: "DiagnosticosCovid",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_Sedes_Sedeid",
                        column: x => x.Sedeid,
                        principalTable: "Sedes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Salones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    capacidad = table.Column<int>(type: "int", nullable: false),
                    disponibilidad = table.Column<bool>(type: "bit", nullable: false),
                    Sedeid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salones", x => x.id);
                    table.ForeignKey(
                        name: "FK_Salones_Sedes_Sedeid",
                        column: x => x.Sedeid,
                        principalTable: "Sedes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IngresosSalon",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaIngreso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    personaid = table.Column<int>(type: "int", nullable: true),
                    salonid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngresosSalon", x => x.id);
                    table.ForeignKey(
                        name: "FK_IngresosSalon_Personas_personaid",
                        column: x => x.personaid,
                        principalTable: "Personas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IngresosSalon_Salones_salonid",
                        column: x => x.salonid,
                        principalTable: "Salones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngresosSalon_personaid",
                table: "IngresosSalon",
                column: "personaid");

            migrationBuilder.CreateIndex(
                name: "IX_IngresosSalon_salonid",
                table: "IngresosSalon",
                column: "salonid");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_estadoCovidid",
                table: "Personas",
                column: "estadoCovidid");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_Sedeid",
                table: "Personas",
                column: "Sedeid");

            migrationBuilder.CreateIndex(
                name: "IX_Salones_Sedeid",
                table: "Salones",
                column: "Sedeid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngresosSalon");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Salones");

            migrationBuilder.DropTable(
                name: "DiagnosticosCovid");

            migrationBuilder.DropTable(
                name: "Sedes");
        }
    }
}
