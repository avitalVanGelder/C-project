using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.Models
{
    public partial class dbcontext : DbContext
    {
        public dbcontext()
        {
        }

        public dbcontext(DbContextOptions<dbcontext> options)
            : base(options)
        {
        }

        public virtual DbSet<Costomer> Costomers { get; set; } = null!;
        public virtual DbSet<Dish> Dishes { get; set; } = null!;
        public virtual DbSet<Menu> Menus { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='C:\\Users\\326022910\\Desktop\\פרויקט שלב א\\Database\\DAL\\Catering.mdf';Integrated Security=True;Connect Timeout=30");
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='F:\\אביטל\\שנה ב\\C#\\פרויקט שלב א\\Database\\DAL\\Catering.mdf';Integrated Security=True;Connect Timeout=30");
                //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="F:\אביטל\שנה ב\C#\פרויקט שלב א\Database\DAL\Catering.mdf";Integrated Security=True;Connect Timeout=30
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Costomer>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.City)
                    .HasMaxLength(10)
                    .HasColumnName("city")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.FullName)
                    .HasMaxLength(10)
                    .HasColumnName("fullName")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PhonNumber)
                    .HasMaxLength(10)
                    .HasColumnName("phonNumber")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<Dish>(entity =>
            {
                entity.ToTable("dishes");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.NameOfdish)
                    .HasMaxLength(10)
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Picture)
                    .HasColumnType("image")
                    .HasColumnName("picture");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Typeofmeno)
                    .HasMaxLength(10)
                    .HasColumnName("typeofmeno")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Typeofmenu).HasColumnName("typeofmenu");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Adress)
                    .HasMaxLength(10)
                    .HasColumnName("adress")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Finalprice).HasColumnName("finalprice");

                entity.Property(e => e.NameOfCustomer)
                    .HasMaxLength(10)
                    .HasColumnName("nameOfCustomer")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(10)
                    .HasColumnName("phoneNumber")
                    .IsFixedLength()
                    .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
