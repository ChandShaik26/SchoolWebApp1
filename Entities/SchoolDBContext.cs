using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace OnlineStudentEnrollmentSystem.Entities;

public partial class SchoolDBContext : DbContext
{
    public SchoolDBContext()
    {
    }

    public SchoolDBContext(DbContextOptions<SchoolDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-T30GOEIK\\MSSQLSERVER01;Initial Catalog=SchoolDB;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Class>(entity =>
        {
            entity.HasKey(e => e.ClassId).HasName("PK__Class__B09705373A1FE09D");

            entity.ToTable("Class");

            entity.Property(e => e.ClassId).HasColumnName("Class_Id");
            entity.Property(e => e.Block)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ClassName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Standard)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__Student__A2F4E98CFE72B4BF");

            entity.ToTable("Student");

            entity.Property(e => e.StudentId).HasColumnName("Student_Id");
            entity.Property(e => e.ClassId).HasColumnName("Class_Id");
            entity.Property(e => e.ClassName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Class_Name");
            entity.Property(e => e.EmailId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Email_Id");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Phone_No");
            entity.Property(e => e.TeacherId).HasColumnName("Teacher_Id");
            entity.Property(e => e.TeacherName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Teacher_Name");

            entity.HasOne(d => d.Class).WithMany(p => p.Students)
                .HasForeignKey(d => d.ClassId)
                .HasConstraintName("FK_Student_Class");

            entity.HasOne(d => d.Teacher).WithMany(p => p.Students)
                .HasForeignKey(d => d.TeacherId)
                .HasConstraintName("FK_Student_Teacher");
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.HasKey(e => e.TeacherId).HasName("PK__Teacher__92FF4CEB95989575");

            entity.ToTable("Teacher");

            entity.Property(e => e.TeacherId).HasColumnName("Teacher_Id");
            entity.Property(e => e.EmailId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Email_Id");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Phone_No");
            entity.Property(e => e.Qualification)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__User__1788CC4C40E0A1F8");

            entity.ToTable("User");

            entity.Property(e => e.EmailId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
