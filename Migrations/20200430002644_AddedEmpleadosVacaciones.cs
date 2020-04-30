using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ihc.Migrations
{
    public partial class AddedEmpleadosVacaciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroEmpleado = table.Column<int>(nullable: false),
                    Cedula = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Apellido = table.Column<string>(nullable: true),
                    Departamento = table.Column<string>(nullable: true),
                    Puesto = table.Column<string>(nullable: true),
                    Salario = table.Column<int>(nullable: false),
                    FechaInicio = table.Column<DateTime>(nullable: false),
                    FechaFinContrato = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SolicitudVacaciones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreSolicitante = table.Column<string>(nullable: true),
                    ApellidoSolicitante = table.Column<string>(nullable: true),
                    EmpleadoId = table.Column<int>(nullable: true),
                    NumeroEmpleado = table.Column<int>(nullable: false),
                    FechaInicio = table.Column<DateTime>(nullable: false),
                    FechaFin = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolicitudVacaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolicitudVacaciones_Empleado_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SolicitudVacaciones_EmpleadoId",
                table: "SolicitudVacaciones",
                column: "EmpleadoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SolicitudVacaciones");

            migrationBuilder.DropTable(
                name: "Empleado");
        }
    }
}
