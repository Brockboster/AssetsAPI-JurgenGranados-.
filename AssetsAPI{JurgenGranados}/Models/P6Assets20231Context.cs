using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AssetsAPI_JurgenGranados__.Models
{
    public partial class P6Assets20231Context : DbContext
    {
        public P6Assets20231Context()
        {
        }

        public P6Assets20231Context(DbContextOptions<P6Assets20231Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AssetsInfo> AssetsInfos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("SERVER= DESKTOP-ULMSP3L\\MSSQLSERVER02; DATABASE = P6Assets20231; INTEGRATED SECURITY=TRUE;User Id=; Password=");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AssetsInfo>(entity =>
            {
                entity.HasKey(e => e.Idactivo)
                    .HasName("PK__AssetsIn__4D268044F2D77D59");

                entity.ToTable("AssetsInfo");

                entity.Property(e => e.Idactivo).HasColumnName("IDActivo");

                entity.Property(e => e.CostoActivo).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Descripcion).HasMaxLength(1000);

                entity.Property(e => e.FechaRegistro).HasColumnType("date");

                entity.Property(e => e.NombreActivo).HasMaxLength(255);

                entity.Property(e => e.NumeroSerie).HasMaxLength(255);

                entity.Property(e => e.PorcentajeDepreciacion).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Responsable).HasMaxLength(255);

                entity.Property(e => e.Ubicacion).HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
