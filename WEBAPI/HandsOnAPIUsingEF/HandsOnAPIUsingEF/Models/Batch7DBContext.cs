using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HandsOnAPIUsingEF.Models
{
    public partial class Batch7DBContext : DbContext
    {
        public Batch7DBContext()
        {
        }

        public Batch7DBContext(DbContextOptions<Batch7DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<VwEmployee> VwEmployees { get; set; }
        public virtual DbSet<VwEmployeeProject> VwEmployeeProjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=SANTU\\MSSQLSERVER2019;database=Batch7DB;trusted_connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.HasIndex(e => e.Salary, "salary_ncindx");

                entity.Property(e => e.EmployeeId).ValueGeneratedNever();

                entity.Property(e => e.Designation)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Not Assigned')");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JoinDate).HasColumnType("date");

                entity.Property(e => e.ProjectCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.ManagerNavigation)
                    .WithMany(p => p.InverseManagerNavigation)
                    .HasForeignKey(d => d.Manager)
                    .HasConstraintName("FK__Employee__Manage__47DBAE45");

                entity.HasOne(d => d.ProjectCodeNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.ProjectCode)
                    .HasConstraintName("FK__Employee__Projec__3E52440B");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("Person");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fname)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Lname)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.HasIndex(e => e.ProductName, "UQ__Product__DD5A978AA9A5EE8B")
                    .IsUnique();

                entity.Property(e => e.ProductId).ValueGeneratedNever();

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasKey(e => e.ProjectCode)
                    .HasName("PK__Project__2F3A49491D36B5C5");

                entity.ToTable("Project");

                entity.HasIndex(e => e.ProjectName, "UQ__Project__BCBE781C5FF176AE")
                    .IsUnique();

                entity.Property(e => e.ProjectCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PK__Student__CA1E5D78E5FB5C40");

                entity.ToTable("Student");

                entity.Property(e => e.Sid).ValueGeneratedNever();

                entity.Property(e => e.Sname)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_employee");

                entity.Property(e => e.Designation)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JoinDate).HasColumnType("date");
            });

            modelBuilder.Entity<VwEmployeeProject>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_employeeProject");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
