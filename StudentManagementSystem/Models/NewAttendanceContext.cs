using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StudentManagementSystem.Models
{
    public partial class NewAttendanceContext : DbContext
    {
        public NewAttendanceContext()
        {
        }

        public NewAttendanceContext(DbContextOptions<NewAttendanceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admins> Admins { get; set; }
        public virtual DbSet<Attends> Attends { get; set; }
        public virtual DbSet<Classes> Classes { get; set; }
        public virtual DbSet<Sections> Sections { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<Subjects> Subjects { get; set; }
        public virtual DbSet<Teachers> Teachers { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        

       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admins>(entity =>
            {
                entity.HasKey(e => e.AdminId);

                entity.Property(e => e.AdminId)
                    .HasColumnName("AdminID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdminEmail).HasMaxLength(50);

                entity.Property(e => e.AdminName)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.AdminPhone).HasMaxLength(50);
            });

            modelBuilder.Entity<Attends>(entity =>
            {
                entity.HasKey(e => e.AttendId);

                entity.Property(e => e.AttendId).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RoomNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                /*
                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Attends)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Attends_Classes");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.Attends)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Attends_Sections");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Attends)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Attends_Students");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Attends)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Attends_Subjects");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.Attends)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Attends_Teachers");
                    */
            });

            modelBuilder.Entity<Classes>(entity =>
            {
                entity.HasKey(e => e.ClassId);

                entity.Property(e => e.ClassId).ValueGeneratedNever();

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Sections>(entity =>
            {
                entity.HasKey(e => e.SectionId);

                entity.Property(e => e.SectionId).ValueGeneratedNever();

                entity.Property(e => e.SectionName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.HasKey(e => e.StudentId);

                entity.Property(e => e.StudentId).ValueGeneratedNever();

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FatherName).HasMaxLength(50);

                entity.Property(e => e.FatherPhone).HasMaxLength(50);

                entity.Property(e => e.MotherName).HasMaxLength(50);

                entity.Property(e => e.MotherPhone).HasMaxLength(50);

                entity.Property(e => e.StudentAddress).HasMaxLength(50);

                entity.Property(e => e.StudentGender).HasMaxLength(50);

                entity.Property(e => e.StudentName).HasMaxLength(50);
            });

            modelBuilder.Entity<Subjects>(entity =>
            {
                entity.HasKey(e => e.SubjectId);

                entity.Property(e => e.SubjectId).ValueGeneratedNever();

                entity.Property(e => e.SubjectName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Subject)
                    .WithOne(p => p.InverseSubject)
                    .HasForeignKey<Subjects>(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Subjects_Subjects");
            });

            modelBuilder.Entity<Teachers>(entity =>
            {
                entity.HasKey(e => e.TeacherId);

                entity.Property(e => e.TeacherId).ValueGeneratedNever();

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.TeacherAddress).HasMaxLength(50);

                entity.Property(e => e.TeacherEmail)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TeacherGender)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TeacherName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TeacherPhone)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserType)
                    .IsRequired()
                    .HasMaxLength(50);
            });
        }

    }
}
