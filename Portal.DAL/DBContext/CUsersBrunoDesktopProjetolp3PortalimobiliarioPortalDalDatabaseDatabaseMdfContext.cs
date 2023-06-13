using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Portal.DAL.DBContext;

public partial class CUsersBrunoDesktopProjetolp3PortalimobiliarioPortalDalDatabaseDatabaseMdfContext : DbContext
{
    public CUsersBrunoDesktopProjetolp3PortalimobiliarioPortalDalDatabaseDatabaseMdfContext()
    {
    }

    public CUsersBrunoDesktopProjetolp3PortalimobiliarioPortalDalDatabaseDatabaseMdfContext(DbContextOptions<CUsersBrunoDesktopProjetolp3PortalimobiliarioPortalDalDatabaseDatabaseMdfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Imv> Imvs { get; set; }

    public virtual DbSet<TbCorretor> TbCorretors { get; set; }

    public virtual DbSet<TbEndereco> TbEnderecos { get; set; }

    public virtual DbSet<TbImovel> TbImovels { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\bruno\\Desktop\\ProjetoLP3\\PortalImobiliario\\Portal.DAL\\database\\database.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Imv>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Imv__3214EC0744D2CD85");

            entity.ToTable("Imv");

            entity.Property(e => e.Descricao)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.Local)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("local");
            entity.Property(e => e.Valor).HasColumnName("valor");
        });

        modelBuilder.Entity<TbCorretor>(entity =>
        {
            entity.HasKey(e => e.IdCorretor).HasName("pk_corretor");

            entity.ToTable("tb_corretor");

            entity.Property(e => e.IdCorretor)
                .ValueGeneratedNever()
                .HasColumnName("ID_corretor");
            entity.Property(e => e.Cpf).HasColumnName("cpf");
            entity.Property(e => e.Deputado)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("deputado");
            entity.Property(e => e.DtNascimento)
                .HasColumnType("date")
                .HasColumnName("dt_nascimento");
            entity.Property(e => e.Nome)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Senha)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("senha");
        });

        modelBuilder.Entity<TbEndereco>(entity =>
        {
            entity.HasKey(e => e.IdEndereco).HasName("pk_endereco");

            entity.ToTable("tb_endereco");

            entity.Property(e => e.IdEndereco)
                .ValueGeneratedNever()
                .HasColumnName("ID_endereco");
            entity.Property(e => e.Cep).HasColumnName("cep");
            entity.Property(e => e.Complemento)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("complemento");
            entity.Property(e => e.Logradoro)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("logradoro");
            entity.Property(e => e.Numero).HasColumnName("numero");
        });

        modelBuilder.Entity<TbImovel>(entity =>
        {
            entity.HasKey(e => e.IdImovel).HasName("pk_imovel");

            entity.ToTable("tb_imovel");

            entity.Property(e => e.IdImovel)
                .ValueGeneratedNever()
                .HasColumnName("ID_imovel");
            entity.Property(e => e.Descricao)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.IdCorretor).HasColumnName("ID_corretor");
            entity.Property(e => e.IdEndereco).HasColumnName("ID_endereco");
            entity.Property(e => e.Valor).HasColumnName("valor");

            entity.HasOne(d => d.IdCorretorNavigation).WithMany(p => p.TbImovels)
                .HasForeignKey(d => d.IdCorretor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_imovel_ccorretor");

            entity.HasOne(d => d.IdEnderecoNavigation).WithMany(p => p.TbImovels)
                .HasForeignKey(d => d.IdEndereco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_imovel_endereco");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuario__3214EC0787E3D7A5");

            entity.ToTable("Usuario");

            entity.Property(e => e.Cpf)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("cpf");
            entity.Property(e => e.Deputado)
                .HasMaxLength(19)
                .IsUnicode(false)
                .HasColumnName("deputado");
            entity.Property(e => e.Nome)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Senha)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("senha");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
