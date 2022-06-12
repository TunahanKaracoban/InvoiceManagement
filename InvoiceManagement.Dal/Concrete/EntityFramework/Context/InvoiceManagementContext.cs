using System;
using InvoiceManagement.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace InvoiceManagement.Dal.Concrete.EntityFramework.Contex
{
    public partial class InvoiceManagementContext : DbContext
    {
        IConfiguration _configuration;
        public InvoiceManagementContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        //public InvoiceManagementContext(DbContextOptions<InvoiceManagementContext> options)
        //    : base(options)
        //{
        //}

        public virtual DbSet<Apartment> Apartments { get; set; }
        public virtual DbSet<Block> Blocks { get; set; }
        public virtual DbSet<Due> Dues { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoiceType> InvoiceTypes { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Month> Months { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoomType> RoomTypes { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_configuration.GetConnectionString("SqlServer"));
                //optionsBuilder.UseSqlServer("Server=DESKTOP-K0CTJKB;Database=InvoiceManagement;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<Apartment>(entity =>
            {
                entity.Property(e => e.ApartmentStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Block)
                    .WithMany(p => p.Apartments)
                    .HasForeignKey(d => d.BlockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Apartments_Blocks");

                entity.HasOne(d => d.RoomType)
                    .WithMany(p => p.Apartments)
                    .HasForeignKey(d => d.RoomTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Apartments_RoomTypes");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Apartments)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Apartments_Users");
            });

            modelBuilder.Entity<Block>(entity =>
            {
                entity.Property(e => e.BlockName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Due>(entity =>
            {
                entity.HasKey(e => e.DuesId);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Apartment)
                    .WithMany(p => p.Dues)
                    .HasForeignKey(d => d.ApartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dues_Apartments");

                entity.HasOne(d => d.Month)
                    .WithMany(p => p.Dues)
                    .HasForeignKey(d => d.MonthId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Dues_Months");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ExpirDate).HasColumnType("datetime");

                entity.HasOne(d => d.Apartment)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.ApartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Invoices_Apartments");

                entity.HasOne(d => d.InvoiceType)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.InvoiceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Invoices_InvoiceTypes");

                entity.HasOne(d => d.Month)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.MonthId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Invoices_Months");
            });

            modelBuilder.Entity<InvoiceType>(entity =>
            {
                entity.Property(e => e.InvoiceName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.Property(e => e.Contents)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Header)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SendingDate).HasColumnType("datetime");

                entity.HasOne(d => d.Receiver)
                    .WithMany(p => p.MessageReceivers)
                    .HasForeignKey(d => d.ReceiverId)
                    .HasConstraintName("FK_Messages_Users1");

                entity.HasOne(d => d.Sender)
                    .WithMany(p => p.MessageSenders)
                    .HasForeignKey(d => d.SenderId)
                    .HasConstraintName("FK_Messages_Users");
            });

            modelBuilder.Entity<Month>(entity =>
            {
                entity.Property(e => e.MonthName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RoomType>(entity =>
            {
                entity.Property(e => e.RoomType1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RoomType");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IdentityNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumberPlate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_Roles");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
