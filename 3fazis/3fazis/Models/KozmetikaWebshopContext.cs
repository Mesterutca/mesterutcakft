
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace _3fazis.Models;

public partial class KozmetikaWebshopContext : DbContext
{
    public KozmetikaWebshopContext()
    {
    }

    public KozmetikaWebshopContext(DbContextOptions<KozmetikaWebshopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Akció> Akciós { get; set; }

    public virtual DbSet<AkciósTermékek> AkciósTermékeks { get; set; }

    public virtual DbSet<Eladasok> Eladasoks { get; set; }

    public virtual DbSet<TermékAkció> TermékAkciós { get; set; }

    public virtual DbSet<Termékek> Termékeks { get; set; }

    public virtual DbSet<Vevok> Vevoks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=kozmetika_webshop;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Akció>(entity =>
        {
            entity.HasKey(e => e.AkcióId).HasName("PK__akcio__F5D3FE42E4191989");

            entity.ToTable("Akció");

            entity.Property(e => e.AkcióId)
                .ValueGeneratedNever()
                .HasColumnName("AkcióID");
        });

        modelBuilder.Entity<AkciósTermékek>(entity =>
        {
            entity.HasKey(e => e.TermékId).HasName("PK__akcios_t__244EC36577C69538");

            entity.ToTable("Akciós Termékek");

            entity.Property(e => e.TermékId)
                .ValueGeneratedNever()
                .HasColumnName("TermékID");
            entity.Property(e => e.EredetiAr).HasColumnName("eredeti_ar");
        });

        modelBuilder.Entity<Eladasok>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__eladasok__3213E83FA164CA51");

            entity.ToTable("eladasok");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Datum)
                .HasColumnType("date")
                .HasColumnName("datum");
            entity.Property(e => e.Mennyiseg).HasColumnName("mennyiseg");
            entity.Property(e => e.TermekekId).HasColumnName("termekek_id");
            entity.Property(e => e.VevokId).HasColumnName("vevok_id");

            entity.HasOne(d => d.Termekek).WithMany(p => p.Eladasoks)
                .HasForeignKey(d => d.TermekekId)
                .HasConstraintName("FK__eladasok__termek__4D94879B");

            entity.HasOne(d => d.Vevok).WithMany(p => p.Eladasoks)
                .HasForeignKey(d => d.VevokId)
                .HasConstraintName("FK__eladasok__vevok___4E88ABD4");
        });

        modelBuilder.Entity<TermékAkció>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__termek_a__3213E83F5C21C0D7");

            entity.ToTable("Termék Akció");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AkcióId).HasColumnName("AkcióID");
            entity.Property(e => e.TermékId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TermékID");
            entity.Property(e => e.ÚjÁr).HasColumnName("új_ár");
        });

        modelBuilder.Entity<Termékek>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__termekek__3213E83F54C8DCDA");

            entity.ToTable("Termékek");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Ar).HasColumnName("ar");
            entity.Property(e => e.Keszlet).HasColumnName("keszlet");
            entity.Property(e => e.Nev)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nev");
        });

        modelBuilder.Entity<Vevok>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__vevok__3213E83F60BF7BE6");

            entity.ToTable("vevok");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Nev)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nev");
            entity.Property(e => e.Telefon)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefon");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
