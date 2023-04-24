using System.IO;
using Microsoft.EntityFrameworkCore;
using SalaDeAulaS10.Models;

namespace SalaDeAulaS10.Contexto
{
    public class SalaDeAulaContext : DbContext
    {

        public SalaDeAulaContext (DbContextOptions<SalaDeAulaContext> options) : base(options)
        {

        }


        public DbSet<DisciplinaModel> Disciplinas     { get; set; }  
        public DbSet<Estudante> Estudantes { get; set; }
        public DbSet<Estudante_Disciplina> Estudante_Disciplinas { get; set; }
        public DbSet<Pergunta> Perguntas { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Prova> Provas { get; set; }
        public DbSet<Resposta> Respostas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-0DDC6L9\\SQLEXPRESS;User ID=sa;Password=321lelele;Database=SalaDeAula;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}
