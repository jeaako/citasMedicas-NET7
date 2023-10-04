using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace citasMedicas_net7.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DIAGNOSTICOS",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValoracionEspecialista = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Enfermedad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIAGNOSTICOS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "USUARIOS",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Clave = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIOS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MEDICOS",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    NumColegiado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MEDICOS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MEDICOS_USUARIOS_Id",
                        column: x => x.Id,
                        principalTable: "USUARIOS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PACIENTES",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    NSS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumTarjeta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PACIENTES", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PACIENTES_USUARIOS_Id",
                        column: x => x.Id,
                        principalTable: "USUARIOS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CITAS",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MotivoCita = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiagnosticoId = table.Column<long>(type: "bigint", nullable: false),
                    MedicoId = table.Column<long>(type: "bigint", nullable: true),
                    PacienteId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CITAS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CITAS_DIAGNOSTICOS_DiagnosticoId",
                        column: x => x.DiagnosticoId,
                        principalTable: "DIAGNOSTICOS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CITAS_MEDICOS_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "MEDICOS",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CITAS_PACIENTES_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "PACIENTES",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MedicoPaciente",
                columns: table => new
                {
                    MedicosId = table.Column<long>(type: "bigint", nullable: false),
                    PacientesId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicoPaciente", x => new { x.MedicosId, x.PacientesId });
                    table.ForeignKey(
                        name: "FK_MedicoPaciente_MEDICOS_MedicosId",
                        column: x => x.MedicosId,
                        principalTable: "MEDICOS",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MedicoPaciente_PACIENTES_PacientesId",
                        column: x => x.PacientesId,
                        principalTable: "PACIENTES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CITAS_DiagnosticoId",
                table: "CITAS",
                column: "DiagnosticoId");

            migrationBuilder.CreateIndex(
                name: "IX_CITAS_MedicoId",
                table: "CITAS",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_CITAS_PacienteId",
                table: "CITAS",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicoPaciente_PacientesId",
                table: "MedicoPaciente",
                column: "PacientesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CITAS");

            migrationBuilder.DropTable(
                name: "MedicoPaciente");

            migrationBuilder.DropTable(
                name: "DIAGNOSTICOS");

            migrationBuilder.DropTable(
                name: "MEDICOS");

            migrationBuilder.DropTable(
                name: "PACIENTES");

            migrationBuilder.DropTable(
                name: "USUARIOS");
        }
    }
}
