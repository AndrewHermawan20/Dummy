using System;
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

        public virtual DbSet<Configuration> Configurations { get; set; } = null!;
        public virtual DbSet<Portofolio> Portofolios { get; set; } = null!;
        public virtual DbSet<PortofolioItem> PortofolioItems { get; set; } = null!;
        public virtual DbSet<Stock> Stocks { get; set; } = null!;
        public virtual DbSet<StockSector> StockSectors { get; set; } = null!;
        public virtual DbSet<Summary> Summaries { get; set; } = null!;
        public virtual DbSet<Transaction> Transactions { get; set; } = null!;
        public virtual DbSet<TransactionStatus> TransactionStatuses { get; set; } = null!;
        public virtual DbSet<TransactionType> TransactionTypes { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=Dummy;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Configuration>(entity =>
            {
                entity.ToTable("Configuration");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.Value).HasMaxLength(100);

                entity.Property(e => e.Version).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Portofolio>(entity =>
            {
                entity.ToTable("Portofolio");

                entity.Property(e => e.PortofolioId).ValueGeneratedNever();

                entity.Property(e => e.Cash).HasColumnType("money");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.UserId).ValueGeneratedOnAdd();

                entity.Property(e => e.Value).HasColumnType("money");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Portofolios)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Portofolio_Portofolio");
            });

            modelBuilder.Entity<PortofolioItem>(entity =>
            {
                entity.ToTable("PortofolioItem");

                entity.Property(e => e.AverageValue).HasColumnType("money");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.TotalValue).HasColumnType("money");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.Version).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Portofolio)
                    .WithMany(p => p.PortofolioItems)
                    .HasForeignKey(d => d.PortofolioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortofolioItem_Portofolio");

                entity.HasOne(d => d.Stock)
                    .WithMany(p => p.PortofolioItems)
                    .HasForeignKey(d => d.StockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortofolioItem_PortofolioItem");
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.ToTable("Stock");

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ReleaseDate).HasColumnType("date");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(sysdatetime())");

                entity.HasOne(d => d.StockSector)
                    .WithMany(p => p.Stocks)
                    .HasForeignKey(d => d.StockSectorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Stocks_StockSector");
            });

            modelBuilder.Entity<StockSector>(entity =>
            {
                entity.ToTable("StockSector");

                entity.Property(e => e.Code).HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(sysdatetime())");
            });

            modelBuilder.Entity<Summary>(entity =>
            {
                entity.ToTable("Summary");

                entity.Property(e => e.AdjustmentCurrentCash).HasColumnType("money");

                entity.Property(e => e.CapitalGain).HasColumnType("money");

                entity.Property(e => e.CapitalLoss).HasColumnType("money");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.CurrentCash).HasColumnType("money");

                entity.Property(e => e.Deviden).HasColumnType("money");

                entity.Property(e => e.LoanInterest).HasColumnType("money");

                entity.Property(e => e.MateraiFee).HasColumnType("money");

                entity.Property(e => e.TotalBuyNetAmount).HasColumnType("money");

                entity.Property(e => e.TotalSellNetAmount).HasColumnType("money");

                entity.Property(e => e.Transfer).HasColumnType("money");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.Version).HasDefaultValueSql("((1))");

                entity.Property(e => e.Withdraw).HasColumnType("money");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Summaries)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Summary_Summary");
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.ToTable("Transaction");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.GrossAmount)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.NetAmount).HasColumnType("money");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.TransactionDate).HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.TransactionFee).HasColumnType("money");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.Version).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.BuyTransaction)
                    .WithMany(p => p.InverseBuyTransaction)
                    .HasForeignKey(d => d.BuyTransactionId)
                    .HasConstraintName("FK_BuyTransaction_Transaction");

                entity.HasOne(d => d.SellTransaction)
                    .WithMany(p => p.InverseSellTransaction)
                    .HasForeignKey(d => d.SellTransactionId)
                    .HasConstraintName("FK_SellTransaction_Transaction");

                entity.HasOne(d => d.Stock)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.StockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transaction_Stock");

                entity.HasOne(d => d.TransactionStatus)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.TransactionStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transaction_TransactionStatus");

                entity.HasOne(d => d.TransactionType)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.TransactionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transaction_TransactionType");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transaction_User");
            });

            modelBuilder.Entity<TransactionStatus>(entity =>
            {
                entity.ToTable("TransactionStatus");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Version).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TransactionType>(entity =>
            {
                entity.ToTable("TransactionType");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Version).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Password).HasMaxLength(200);

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.UserName).HasMaxLength(200);

                entity.Property(e => e.Version).HasDefaultValueSql("((1))");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
