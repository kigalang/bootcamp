using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace formDemo.Models
{
    public partial class FORMDBContext : DbContext
    {
        public FORMDBContext()
        {
        }

        public FORMDBContext(DbContextOptions<FORMDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Lists> Lists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=FORMDB;User Id=sa;Password=Docker123**;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lists>(entity =>
            {
                entity.HasKey(e => e.ListId)
                    .HasName("PK__Lists__E383286557A5CC4D");

                entity.Property(e => e.ListId).HasColumnName("ListID");

                entity.Property(e => e.ListData)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ListTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
