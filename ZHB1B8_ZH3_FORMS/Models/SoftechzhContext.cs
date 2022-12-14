using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ZHB1B8_ZH3_FORMS.Models;

public partial class SoftechzhContext : DbContext
{
    public SoftechzhContext()
    {
    }

    public SoftechzhContext(DbContextOptions<SoftechzhContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Autok> Autok { get; set; }

    public virtual DbSet<Rendeles> Rendeles { get; set; }

    public virtual DbSet<Ugyfel> Ugyfel { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=softechzh.database.windows.net;Initial Catalog=softechzh;User ID=zhb1b8;Password=Password123");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Autok>(entity =>
        {
            entity.HasKey(e => e.TermekKod);

            entity.Property(e => e.TermekKod).ValueGeneratedNever();
            entity.Property(e => e.AutoModell).HasMaxLength(50);
            entity.Property(e => e.AutoNev).HasMaxLength(50);
        });

        modelBuilder.Entity<Rendeles>(entity =>
        {
            entity.HasKey(e => new { e.TermekKod, e.Ugyfel });
        });

        modelBuilder.Entity<Ugyfel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Ugyfelű");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Nev).HasMaxLength(50);
            entity.Property(e => e.RegDatum).HasColumnType("date");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
