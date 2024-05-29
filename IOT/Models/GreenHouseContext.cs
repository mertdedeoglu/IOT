using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace IOT.Models;

public partial class GreenHouseContext : DbContext
{
    public GreenHouseContext()
    {
    }

    public GreenHouseContext(DbContextOptions<GreenHouseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Light> Lights { get; set; }

    public virtual DbSet<LightAction> LightActions { get; set; }

    public virtual DbSet<Moisture> Moistures { get; set; }

    public virtual DbSet<MoistureAction> MoistureActions { get; set; }

    public virtual DbSet<Rain> Rains { get; set; }

    public virtual DbSet<RainAction> RainActions { get; set; }

    public virtual DbSet<Temprature> Tempratures { get; set; }

    public virtual DbSet<TempratureAction> TempratureActions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=77.245.159.10\\MSSQLSERVER2019; Initial Catalog=ehmsera;user=ehmadmindb; password=EhmSera123*;  Connect Timeout=30; Encrypt=False; TrustServerCertificate=False; ApplicationIntent=ReadWrite; MultiSubnetFailover= False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Light>(entity =>
        {
            entity.ToTable("LIGHT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.Value)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VALUE");
        });

        modelBuilder.Entity<LightAction>(entity =>
        {
            entity.ToTable("LIGHT_ACTION");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Action)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACTION");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.Effect)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EFFECT");
        });

        modelBuilder.Entity<Moisture>(entity =>
        {
            entity.ToTable("MOISTURE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.Value)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VALUE");
        });

        modelBuilder.Entity<MoistureAction>(entity =>
        {
            entity.ToTable("MOISTURE_ACTION");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Action)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACTION");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.Effect)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EFFECT");
        });

        modelBuilder.Entity<Rain>(entity =>
        {
            entity.ToTable("RAIN");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.Value)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VALUE");
        });

        modelBuilder.Entity<RainAction>(entity =>
        {
            entity.ToTable("RAIN_ACTION");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Action)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACTION");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.Effect)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EFFECT");
        });

        modelBuilder.Entity<Temprature>(entity =>
        {
            entity.ToTable("TEMPRATURE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.Value)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VALUE");
        });

        modelBuilder.Entity<TempratureAction>(entity =>
        {
            entity.ToTable("TEMPRATURE_ACTION");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Action)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACTION");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.Effect)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EFFECT");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
