using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bercario.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mae",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DataDeNascimento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mae", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CRM = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Especialidade = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Celular = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Partos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataDoParto = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HorarioDoParto = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdDoMedico = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parto_Medico",
                        column: x => x.IdDoMedico,
                        principalTable: "Medico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bebe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataDeNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PesoDeNascimento = table.Column<decimal>(type: "decimal(4,3)", precision: 4, scale: 3, nullable: false),
                    Altura = table.Column<int>(type: "int", nullable: false),
                    IdDeMae = table.Column<int>(type: "int", nullable: false),
                    IdDoParto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bebe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bebe_Mae",
                        column: x => x.IdDeMae,
                        principalTable: "Mae",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bebe_Parto",
                        column: x => x.IdDoParto,
                        principalTable: "Partos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bebe_IdDeMae",
                table: "Bebe",
                column: "IdDeMae");

            migrationBuilder.CreateIndex(
                name: "IX_Bebe_IdDoParto",
                table: "Bebe",
                column: "IdDoParto");

            migrationBuilder.CreateIndex(
                name: "IX_Partos_IdDoMedico",
                table: "Partos",
                column: "IdDoMedico");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bebe");

            migrationBuilder.DropTable(
                name: "Mae");

            migrationBuilder.DropTable(
                name: "Partos");

            migrationBuilder.DropTable(
                name: "Medico");
        }
    }
}
