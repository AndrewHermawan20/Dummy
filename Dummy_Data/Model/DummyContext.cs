﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Dummy_Data.Model
{
    public partial class DummyContext : DbContext
    {
        public DummyContext()
        {
        }

        public DummyContext(DbContextOptions<DummyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Stock> Stocks { get; set; } = null!;
        public virtual DbSet<StockSector> StockSectors { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=localhost;user=sa;password=p455w0rd;database=Dummy");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stock>(entity =>
            {
                entity.ToTable("Stock");

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysdatetime())");

                entity.HasOne(d => d.StockSector)
                    .WithMany(p => p.Stocks)
                    .HasForeignKey(d => d.StockSectorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stocks_StockSector");
            });

            modelBuilder.Entity<StockSector>(entity =>
            {
                entity.ToTable("StockSector");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
