using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ControlInventario.Models;

public partial class InventarioContext : DbContext
{
    public InventarioContext()
    {
    }

    public InventarioContext(DbContextOptions<InventarioContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Taccione> Tacciones { get; set; }

    public virtual DbSet<Tarticulo> Tarticulos { get; set; }

    public virtual DbSet<Tborrado> Tborrados { get; set; }

    public virtual DbSet<Tperfile> Tperfiles { get; set; }

    public virtual DbSet<Tproveedore> Tproveedores { get; set; }

    public virtual DbSet<Tregistro> Tregistros { get; set; }

    public virtual DbSet<Tusuario> Tusuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-U5J3L6H\\SQLEXPRESS; Database=Inventario; Trusted_Connection=True; Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Taccione>(entity =>
        {
            entity.HasKey(e => e.AccId).HasName("PK__TAccione__91CBC37861354CB7");

            entity.ToTable("TAcciones");

            entity.Property(e => e.Anombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ANombre");
        });

        modelBuilder.Entity<Tarticulo>(entity =>
        {
            entity.HasKey(e => e.Aid).HasName("PK__TArticul__C6900628515E4F03");

            entity.ToTable("TArticulos");

            entity.Property(e => e.Aid).HasColumnName("AId");
            entity.Property(e => e.Acantidad).HasColumnName("ACantidad");
            entity.Property(e => e.AcreatedBy).HasColumnName("ACreatedBy");
            entity.Property(e => e.Adescripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADescripcion");
            entity.Property(e => e.Anombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANombre");
            entity.Property(e => e.Apid).HasColumnName("APId");
            entity.Property(e => e.Avalor)
                .HasColumnType("money")
                .HasColumnName("AValor");

            entity.HasOne(d => d.AcreatedByNavigation).WithMany(p => p.Tarticulos)
                .HasForeignKey(d => d.AcreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACREATEDBY");

            entity.HasOne(d => d.Ap).WithMany(p => p.Tarticulos)
                .HasForeignKey(d => d.Apid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_APROVID");
        });

        modelBuilder.Entity<Tborrado>(entity =>
        {
            entity.HasKey(e => e.Bid).HasName("PK__TBorrado__C6DE0CC1E2D19636");

            entity.ToTable("TBorrados");

            entity.Property(e => e.Bid).HasColumnName("BId");
            entity.Property(e => e.Badescripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BADescripcion");
            entity.Property(e => e.Banombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BANombre");
            entity.Property(e => e.Bcantidad).HasColumnName("BCantidad");
            entity.Property(e => e.BdeletedBy).HasColumnName("BDeletedBy");
            entity.Property(e => e.Bfecha)
                .HasColumnType("datetime")
                .HasColumnName("BFecha");

            entity.HasOne(d => d.BdeletedByNavigation).WithMany(p => p.Tborrados)
                .HasForeignKey(d => d.BdeletedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DELETEDBY");
        });

        modelBuilder.Entity<Tperfile>(entity =>
        {
            entity.HasKey(e => e.PerId).HasName("PK__TPerfile__496D3DD093803017");

            entity.ToTable("TPerfiles");

            entity.Property(e => e.Pnombre)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PNombre");
            entity.Property(e => e.Ppermisos)
                .IsUnicode(false)
                .HasColumnName("PPermisos");
        });

        modelBuilder.Entity<Tproveedore>(entity =>
        {
            entity.HasKey(e => e.ProvId).HasName("PK__TProveed__13196A5280C0122D");

            entity.ToTable("TProveedores");

            entity.Property(e => e.ProvFin).HasColumnType("datetime");
            entity.Property(e => e.ProvIni).HasColumnType("datetime");
            entity.Property(e => e.ProvName)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Tregistro>(entity =>
        {
            entity.HasKey(e => e.Rid).HasName("PK__TRegistr__CAFF40D26B9FDBE0");

            entity.ToTable("TRegistros");

            entity.Property(e => e.Rid).HasColumnName("RId");
            entity.Property(e => e.RaccionId).HasColumnName("RAccionId");
            entity.Property(e => e.Rfecha)
                .HasColumnType("datetime")
                .HasColumnName("RFecha");
            entity.Property(e => e.RmodifiedBy).HasColumnName("RModifiedBy");

            entity.HasOne(d => d.Raccion).WithMany(p => p.Tregistros)
                .HasForeignKey(d => d.RaccionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RACCION");

            entity.HasOne(d => d.RmodifiedByNavigation).WithMany(p => p.Tregistros)
                .HasForeignKey(d => d.RmodifiedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RMODIFIEDBY");
        });

        modelBuilder.Entity<Tusuario>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__TUsuario__1788CC4CA6CF0AD2");

            entity.ToTable("TUsuario");

            entity.Property(e => e.Ucreated)
                .HasColumnType("datetime")
                .HasColumnName("UCreated");
            entity.Property(e => e.Uhpass).HasColumnName("UHPass");
            entity.Property(e => e.UlastLogin)
                .HasColumnType("datetime")
                .HasColumnName("ULastLogin");
            entity.Property(e => e.UprivId)
                .HasDefaultValue(1)
                .HasColumnName("UPrivId");
            entity.Property(e => e.Ustatus).HasColumnName("UStatus");

            entity.HasOne(d => d.Upriv).WithMany(p => p.Tusuarios)
                .HasForeignKey(d => d.UprivId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UPERFIL");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
