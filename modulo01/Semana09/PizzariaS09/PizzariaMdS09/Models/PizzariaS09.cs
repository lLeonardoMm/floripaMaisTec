using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PizzariaMdS09.Models;

public partial class PizzariaS09 : DbContext
{
    public PizzariaS09()
    {
    }

    public PizzariaS09(DbContextOptions<PizzariaS09> options)
        : base(options)
    {
    }

    public virtual DbSet<Bordum> Borda { get; set; }

    public virtual DbSet<Massa> Massas { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<Pizza> Pizzas { get; set; }

    public virtual DbSet<PizzaSabore> PizzaSabores { get; set; }

    public virtual DbSet<Sabore> Sabores { get; set; }

    public virtual DbSet<StatusDaPizza> StatusDaPizzas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-0DDC6L9\\SQLEXPRESS;Database=PizzariaS09;User ID=sa;Password=321lelele;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bordum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Borda__3214EC0789A660D3");

            entity.Property(e => e.Nome)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Massa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Massa__3214EC0727AB6942");

            entity.ToTable("Massa");

            entity.Property(e => e.Nome)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pedidos__3214EC070A829194");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IdPizzas).HasColumnName("Id_Pizzas");
            entity.Property(e => e.IdStatus).HasColumnName("Id_Status");

            entity.HasOne(d => d.IdPizzasNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.IdPizzas)
                .HasConstraintName("Fk_Pizza_Pedidos");

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.IdStatus)
                .HasConstraintName("Fk_Status_Pedidos");
        });

        modelBuilder.Entity<Pizza>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pizza__3214EC07D10145B7");

            entity.ToTable("Pizza");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IdBordas).HasColumnName("Id_Bordas");
            entity.Property(e => e.IdMassas).HasColumnName("Id_Massas");

            entity.HasOne(d => d.IdBordasNavigation).WithMany(p => p.Pizzas)
                .HasForeignKey(d => d.IdBordas)
                .HasConstraintName("Fk_Borda_Pizza");

            entity.HasOne(d => d.IdMassasNavigation).WithMany(p => p.Pizzas)
                .HasForeignKey(d => d.IdMassas)
                .HasConstraintName("Fk_Massas_Pizza");
        });

        modelBuilder.Entity<PizzaSabore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pizza_Sa__3214EC07E649BF96");

            entity.ToTable("Pizza_Sabores");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IdPizzas).HasColumnName("Id_pizzas");
            entity.Property(e => e.IdSabores).HasColumnName("Id_sabores");

            entity.HasOne(d => d.IdPizzasNavigation).WithMany(p => p.PizzaSabores)
                .HasForeignKey(d => d.IdPizzas)
                .HasConstraintName("Fk_Pizza_Pizza_Sabores");

            entity.HasOne(d => d.IdSaboresNavigation).WithMany(p => p.PizzaSabores)
                .HasForeignKey(d => d.IdSabores)
                .HasConstraintName("Fk_Sabores_Pizza_Sabores");
        });

        modelBuilder.Entity<Sabore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Sabores__3214EC07A8726B0D");

            entity.Property(e => e.Sabor)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StatusDaPizza>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__StatusDa__3214EC078A470522");

            entity.ToTable("StatusDaPizza");

            entity.Property(e => e.Nome)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
