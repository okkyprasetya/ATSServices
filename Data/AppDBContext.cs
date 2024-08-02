using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using testCRUD.Models;

namespace testCRUD.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AchievementRecord> AchievementRecords { get; set; }

    public virtual DbSet<ApplicantDatum> ApplicantData { get; set; }

    public virtual DbSet<ApplicationDatum> ApplicationData { get; set; }

    public virtual DbSet<Certification> Certifications { get; set; }

    public virtual DbSet<CityDatum> CityData { get; set; }

    public virtual DbSet<EducationalRecord> EducationalRecords { get; set; }

    public virtual DbSet<Hcdatum> Hcdata { get; set; }

    public virtual DbSet<HumanCapital> HumanCapitals { get; set; }

    public virtual DbSet<OrganizationalExperience> OrganizationalExperiences { get; set; }

    public virtual DbSet<ProvinceDatum> ProvinceData { get; set; }

    public virtual DbSet<ResetPassQuestion> ResetPassQuestions { get; set; }

    public virtual DbSet<UserDatum> UserData { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    public virtual DbSet<Vacancy> Vacancies { get; set; }

    public virtual DbSet<WorkExperience> WorkExperiences { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost,1433;Database=ATSDev;User Id=SA;Password=reallyStrongPwd123;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AchievementRecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Achievem__3214EC073AF0B8F9");

            entity.HasIndex(e => e.Id, "UQ__Achievem__3214EC06F93C366D").IsUnique();

            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.Document).HasMaxLength(255);
            entity.Property(e => e.Period).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(150);
        });

        modelBuilder.Entity<ApplicantDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Applican__3214EC071E35F4EB");

            entity.HasIndex(e => e.Id, "UQ__Applican__3214EC06FC3137EB").IsUnique();

            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(550);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.MiddleName).HasMaxLength(255);

            entity.HasOne(d => d.AchievementRecord).WithMany(p => p.ApplicantData)
                .HasForeignKey(d => d.AchievementRecordId)
                .HasConstraintName("ApplicantData_fk14");

            entity.HasOne(d => d.Certification).WithMany(p => p.ApplicantData)
                .HasForeignKey(d => d.CertificationId)
                .HasConstraintName("ApplicantData_fk11");

            entity.HasOne(d => d.City).WithMany(p => p.ApplicantData)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ApplicantData_fk7");

            entity.HasOne(d => d.EducationalRecord).WithMany(p => p.ApplicantData)
                .HasForeignKey(d => d.EducationalRecordId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ApplicantData_fk10");

            entity.HasOne(d => d.OrganizationalExperience).WithMany(p => p.ApplicantData)
                .HasForeignKey(d => d.OrganizationalExperienceId)
                .HasConstraintName("ApplicantData_fk13");

            entity.HasOne(d => d.Province).WithMany(p => p.ApplicantData)
                .HasForeignKey(d => d.ProvinceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ApplicantData_fk8");

            entity.HasOne(d => d.User).WithMany(p => p.ApplicantData)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ApplicantData_fk9");

            entity.HasOne(d => d.WorkExperience).WithMany(p => p.ApplicantData)
                .HasForeignKey(d => d.WorkExperienceId)
                .HasConstraintName("ApplicantData_fk12");
        });

        modelBuilder.Entity<ApplicationDatum>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ReviewedBy).HasMaxLength(50);

            entity.HasOne(d => d.ApplicantData).WithMany()
                .HasForeignKey(d => d.ApplicantDataId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApplicationData_ApplicantData");

            entity.HasOne(d => d.Vacancy).WithMany()
                .HasForeignKey(d => d.VacancyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApplicationData_Vacancy");
        });

        modelBuilder.Entity<Certification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Certific__3214EC074C979AAC");

            entity.ToTable("Certification");

            entity.HasIndex(e => e.Id, "UQ__Certific__3214EC069A53760E").IsUnique();

            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Document).HasMaxLength(255);
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<CityDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CityData__3214EC0796AE9E0B");

            entity.HasIndex(e => e.Id, "UQ__CityData__3214EC0619CE461C").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<EducationalRecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Educatio__3214EC07E8F1B850");

            entity.HasIndex(e => e.Id, "UQ__Educatio__3214EC06F14C2F1C").IsUnique();

            entity.Property(e => e.Document).HasMaxLength(255);
            entity.Property(e => e.Gpa)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("GPA");
            entity.Property(e => e.Major).HasMaxLength(150);
            entity.Property(e => e.Title).HasMaxLength(5);
            entity.Property(e => e.University).HasMaxLength(255);
        });

        modelBuilder.Entity<Hcdatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HCData");

            entity.Property(e => e.Name).HasMaxLength(255);

            entity.HasOne(d => d.UserData).WithMany()
                .HasForeignKey(d => d.UserDataId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HCData_UserData");
        });

        modelBuilder.Entity<HumanCapital>(entity =>
        {
            entity.ToTable("HumanCapital");

            entity.Property(e => e.Id)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<OrganizationalExperience>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Organiza__3214EC0748FA3088");

            entity.ToTable("OrganizationalExperience");

            entity.HasIndex(e => e.Id, "UQ__Organiza__3214EC06863CAC30").IsUnique();

            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<ProvinceDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Province__3214EC0751E9D4AD");

            entity.HasIndex(e => e.Id, "UQ__Province__3214EC060B7EB2F2").IsUnique();

            entity.HasIndex(e => e.Name, "UQ__Province__737584F65B266CA8").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<ResetPassQuestion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ResetPas__3214EC0709FA4336");

            entity.ToTable("ResetPassQuestion");

            entity.HasIndex(e => e.Id, "UQ__ResetPas__3214EC066E9E7BD6").IsUnique();

            entity.HasIndex(e => e.Question, "UQ__ResetPas__9AA2C3BE5336FAB7").IsUnique();

            entity.Property(e => e.Question)
                .HasMaxLength(255)
                .HasColumnName("question");
        });

        modelBuilder.Entity<UserDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserData__3214EC07E901F467");

            entity.HasIndex(e => e.Id, "UQ__UserData__3214EC0627A5C4C3").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__UserData__AB6E6164AF6E3ACC").IsUnique();

            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.ResetPassAnswer)
                .HasMaxLength(50)
                .HasColumnName("resetPassAnswer");
            entity.Property(e => e.ResetPassQuestionId).HasColumnName("resetPassQuestionID");
            entity.Property(e => e.RoleId).HasColumnName("roleID");

            entity.HasOne(d => d.ResetPassQuestion).WithMany(p => p.UserData)
                .HasForeignKey(d => d.ResetPassQuestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("UserData_fk3");

            entity.HasOne(d => d.Role).WithMany(p => p.UserData)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("UserData_fk5");
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserRole__3214EC07BDF06735");

            entity.ToTable("UserRole");

            entity.HasIndex(e => e.Id, "UQ__UserRole__3214EC0663D34CA1").IsUnique();

            entity.HasIndex(e => e.RoleName, "UQ__UserRole__B1947861A83BFF17").IsUnique();

            entity.Property(e => e.RoleName)
                .HasMaxLength(50)
                .HasColumnName("roleName");
        });

        modelBuilder.Entity<Vacancy>(entity =>
        {
            entity.ToTable("Vacancy");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Requirements).HasMaxLength(500);
            entity.Property(e => e.Salary).HasMaxLength(50);
            entity.Property(e => e.Title)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<WorkExperience>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WorkExpe__3214EC07D820E04F");

            entity.ToTable("WorkExperience");

            entity.HasIndex(e => e.Id, "UQ__WorkExpe__3214EC06331B83C3").IsUnique();

            entity.Property(e => e.CompanyName).HasMaxLength(150);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Position).HasMaxLength(150);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
