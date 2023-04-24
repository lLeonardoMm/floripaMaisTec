using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalaDeAulaS10.Migrations
{
    /// <inheritdoc />
    public partial class Disciplina : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {   
            migrationBuilder.DropColumn(
                name: "DisciplinaId",
                table: "Disciplinas");

            migrationBuilder.RenameColumn(
                name: "EstudanteId",
                table: "Disciplinas",
                newName: "ProfessorId");

            migrationBuilder.AddColumn<string>(
                name: "Materia",
                table: "Disciplinas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Materia",
                table: "Disciplinas");

            migrationBuilder.RenameColumn(
                name: "ProfessorId",
                table: "Disciplinas",
                newName: "EstudanteId");

            migrationBuilder.AddColumn<int>(
                name: "DisciplinaId",
                table: "Disciplinas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
