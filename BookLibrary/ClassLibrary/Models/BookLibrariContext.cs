using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ClassLibrary.Models;

public partial class BookLibrariContext : DbContext
{
    public BookLibrariContext()
    {
    }

    public BookLibrariContext(DbContextOptions<BookLibrariContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<History> Histories { get; set; }

    public virtual DbSet<Person> Persons { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
        IConfigurationRoot configuration = builder.Build();
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyDB"));
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.AccountId).HasName("PK__Accounts__349DA5860A5DA36E");

            entity.Property(e => e.AccountId).HasColumnName("AccountID");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.PersonId).HasColumnName("PersonID");

            entity.HasOne(d => d.Person).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.PersonId)
                .HasConstraintName("FK__Accounts__Person__286302EC");
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.BookId).HasName("PK__Books__3DE0C227658A830E");

            entity.Property(e => e.BookId).HasColumnName("BookID");
            entity.Property(e => e.BookName).HasMaxLength(50);
            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.Image).HasMaxLength(50);
        });

        modelBuilder.Entity<History>(entity =>
        {
            entity.HasKey(e => e.HistoryId).HasName("PK__History__4D7B4ADD49A77EF4");

            entity.ToTable("History");

            entity.Property(e => e.HistoryId).HasColumnName("HistoryID");
            entity.Property(e => e.BookId).HasColumnName("BookID");
            entity.Property(e => e.BorrowDate).HasColumnType("datetime");
            entity.Property(e => e.LibrarianId).HasColumnName("LibrarianID");
            entity.Property(e => e.ReturnDeadline).HasColumnType("datetime");
            entity.Property(e => e.ReturnedDate).HasColumnType("datetime");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");

            entity.HasOne(d => d.Book).WithMany(p => p.Histories)
                .HasForeignKey(d => d.BookId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__History__BookID__2D27B809");

            entity.HasOne(d => d.Librarian).WithMany(p => p.HistoryLibrarians)
                .HasForeignKey(d => d.LibrarianId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__History__Librari__2B3F6F97");

            entity.HasOne(d => d.Student).WithMany(p => p.HistoryStudents)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__History__Student__2C3393D0");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.PersonId).HasName("PK__Persons__AA2FFB85133E05DE");

            entity.Property(e => e.PersonId).HasColumnName("PersonID");
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.PersonName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
