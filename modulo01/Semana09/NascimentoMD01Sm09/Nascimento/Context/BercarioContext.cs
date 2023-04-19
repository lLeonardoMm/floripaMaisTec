using bercario.Configuration;
using bercario.Models;
using Microsoft.EntityFrameworkCore;

namespace Nascimento.Context
{
    public class BercarioContext : DbContext
    {
        public DbSet<Mae> Maes { get; set; }
        public DbSet<Bebe> Bebes { get; set; }
        public DbSet<Parto> Partos { get; set; }
        public DbSet<Medico> Medicos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-0DDC6L9\\SQLEXPRESS;User ID=sa;Password=321lelele;Database=BercarioS09;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MaeConfiguratio());
            modelBuilder.ApplyConfiguration(new BebeConfiguratio());
            modelBuilder.ApplyConfiguration(new PartoConfiguratio());
            modelBuilder.ApplyConfiguration(new MedicoConfiguratio());
        }
    }
}
