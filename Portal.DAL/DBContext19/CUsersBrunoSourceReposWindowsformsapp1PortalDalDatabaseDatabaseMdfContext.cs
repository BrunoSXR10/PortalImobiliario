using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Portal.MODEL;

public partial class CUsersBrunoSourceReposWindowsformsapp1PortalDalDatabaseDatabaseMdfContext : DbContext
{
    public CUsersBrunoSourceReposWindowsformsapp1PortalDalDatabaseDatabaseMdfContext()
    {
    }

    public CUsersBrunoSourceReposWindowsformsapp1PortalDalDatabaseDatabaseMdfContext(DbContextOptions<CUsersBrunoSourceReposWindowsformsapp1PortalDalDatabaseDatabaseMdfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Corretor> Corretors { get; set; }

    public virtual DbSet<Imovel> Imovels { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\bruno\\source\\repos\\WindowsFormsApp1\\Portal.DAL\\database\\database.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Corretor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Corretor__3214EC07409A1359");

            entity.ToTable("Corretor");

            entity.Property(e => e.Deputado)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("deputado");
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Telefone)
                .HasMaxLength(13)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Imovel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Imovel__3214EC07AE6CD86D");

            entity.ToTable("Imovel");

            entity.Property(e => e.Descricao)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Localizacao)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
