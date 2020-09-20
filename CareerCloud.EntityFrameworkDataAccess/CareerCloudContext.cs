using CareerCloud.Pocos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Text;

namespace CareerCloud.EntityFrameworkDataAccess
{
    public class CareerCloudContext : DbContext
    {
        protected readonly string _connStr = string.Empty;
        public virtual DbSet<ApplicantEducationPoco> ApplicantEducations   { get; set; }
        public virtual DbSet<ApplicantJobApplicationPoco> ApplicantJobApplications { get; set; }
        public virtual DbSet<ApplicantProfilePoco> ApplicantProfiles { get; set; }
        public virtual DbSet<ApplicantResumePoco> ApplicantResumes { get; set; }
        public virtual DbSet<ApplicantSkillPoco> ApplicantSkills { get; set; }
        public virtual DbSet<ApplicantWorkHistoryPoco> ApplicantWorkHistories { get; set; }
        public virtual DbSet<CompanyDescriptionPoco> CompanyDescriptions { get; set; }
        public virtual DbSet<CompanyJobDescriptionPoco> CompanyJobDescriptions { get; set; }
        public virtual DbSet<CompanyJobEducationPoco> CompanyJobEducations { get; set; }
        public virtual DbSet<CompanyJobPoco> CompanyJobs { get; set; }
        public virtual DbSet<CompanyJobSkillPoco> CompanyJobSkills { get; set; }
        public virtual DbSet<CompanyLocationPoco> CompanyLocations { get; set; }
        public virtual DbSet<CompanyProfilePoco> CompanyProfiles { get; set; }
        public virtual DbSet<SecurityLoginPoco> SecurityLogins { get; set; }
        public virtual DbSet<SecurityLoginsLogPoco> SecurityLoginsLogs { get; set; }
        public virtual DbSet<SecurityLoginsRolePoco> SecurityLoginsRoles { get; set; }
        public virtual DbSet<SecurityRolePoco> SecurityRoles { get; set; }
        public virtual DbSet<SystemCountryCodePoco> SystemCountryCodes { get; set; }
        public virtual DbSet<SystemLanguageCodePoco> SystemLanguageCodePocos { get; set; }

        public CareerCloudContext(){
            var config = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            config.AddJsonFile(path, false);
            var root = config.Build();
            _connStr = root.GetSection("ConnectionString").GetSection("DataConnection").Value;
            }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connStr);
     
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // for ApplicantEducationPoco
           modelBuilder.Entity<ApplicantEducationPoco>()
                        .HasOne<ApplicantProfilePoco>(s => s.ApplicantProfiles)
                        .WithMany(g => g.ApplicantEducations)
                        .HasForeignKey(s => s.Applicant);


            // for ApplicantJobApplications
            modelBuilder.Entity<ApplicantJobApplicationPoco>(entity =>
            {
                entity
               .HasOne<ApplicantProfilePoco>(s => s.ApplicantProfiles)
               .WithMany(g => g.ApplicantJobApplications)
               .HasForeignKey(s => s.Applicant);

                entity
               .HasOne<CompanyJobPoco>(s => s.CompanyJobs)
               .WithMany(g => g.ApplicantJobApplications)
               .HasForeignKey(s => s.Job);
            });

            // for ApplicantProfilePoco
            modelBuilder.Entity<ApplicantProfilePoco>(entity =>
            {
                entity
               .HasOne<SecurityLoginPoco>(s => s.SecurityLogins)
               .WithMany(g => g.ApplicantProfiles)
               .HasForeignKey(s => s.Login);

                entity
               .HasOne<SystemCountryCodePoco>(s => s.SystemCountryCodes)
               .WithMany(g => g.ApplicantProfiles)
               .HasForeignKey(s => s.Country);
            });

            //for ApplicantResumepoco
            modelBuilder.Entity<ApplicantResumePoco>()
                        .HasOne<ApplicantProfilePoco>(s => s.ApplicantProfiles)
                        .WithMany(g => g.ApplicantResumes)
                        .HasForeignKey(s => s.Applicant);

            //for ApplicantSkillpoco
            modelBuilder.Entity<ApplicantSkillPoco>()
            .HasOne<ApplicantProfilePoco>(s => s.ApplicantProfiles)
            .WithMany(g => g.ApplicantSkills)
            .HasForeignKey(s => s.Applicant);

            //for ApplicantWorkhistoryPoco
            modelBuilder.Entity<ApplicantWorkHistoryPoco>(entity =>
            {
                entity
               .HasOne<ApplicantProfilePoco>(s => s.ApplicantProfiles)
               .WithMany(g => g.ApplicantWorkHistory)
               .HasForeignKey(s => s.Applicant);

                entity
               .HasOne<SystemCountryCodePoco>(s => s.SystemCountryCodes)
               .WithMany(g => g.ApplicantWorkHistory)
               .HasForeignKey(s => s.CountryCode);
            });

            //for CompanyDescriptionPoco
            modelBuilder.Entity<CompanyDescriptionPoco>(entity =>
            {
                entity
               .HasOne<CompanyProfilePoco>(s => s.CompanyProfiles)
               .WithMany(g => g.CompanyDescriptions)
               .HasForeignKey(s => s.Company);

                entity
               .HasOne<SystemLanguageCodePoco>(s => s.SystemLanguageCodes)
               .WithMany(g => g.CompanyDescriptions)
               .HasForeignKey(s => s.LanguageId);
            });

            //for CompanyJobDescriptionPoco
            modelBuilder.Entity<CompanyJobDescriptionPoco>()
            .HasOne<CompanyJobPoco>(s => s.CompanyJobs)
            .WithMany(g => g.CompanyJobsDescriptions)
            .HasForeignKey(s => s.Job);

            //for CompanyJobEducationPoco
            modelBuilder.Entity<CompanyJobEducationPoco>()
            .HasOne<CompanyJobPoco>(s => s.CompanyJobs)
            .WithMany(g => g.CompanyJobEducations)
            .HasForeignKey(s => s.Job);

            //for CompanyJobsPoco
            modelBuilder.Entity<CompanyJobPoco>()
           .HasOne<CompanyProfilePoco>(s => s.CompanyProfiles)
           .WithMany(g => g.CompanyJobs)
           .HasForeignKey(s => s.Company);

            //for CompanyJobSkillPoco
            modelBuilder.Entity<CompanyJobSkillPoco>()
           .HasOne<CompanyJobPoco>(s => s.CompanyJobs)
           .WithMany(g => g.CompanyJobSkills)
           .HasForeignKey(s => s.Job);

            //for CompanyLocationPoco
            modelBuilder.Entity<CompanyLocationPoco>()
           .HasOne<CompanyProfilePoco>(s => s.CompanyProfiles)
           .WithMany(g => g.CompanyLocations)
           .HasForeignKey(s => s.Company);

            //for SecurityLoginLogPoco
            modelBuilder.Entity<SecurityLoginsLogPoco>()
           .HasOne<SecurityLoginPoco>(s => s.SecurityLogins)
           .WithMany(g => g.SecurityLoginsLogs)
           .HasForeignKey(s => s.Login);

            //for SecurityLoginRolePoco
            modelBuilder.Entity<SecurityLoginsRolePoco>(entity =>
            {
                entity
               .HasOne<SecurityLoginPoco>(s => s.SecurityLogins)
               .WithMany(g => g.SecurityLoginsRoles)
               .HasForeignKey(s => s.Login);

                entity
               .HasOne<SecurityRolePoco>(s => s.SecurityRoles)
               .WithMany(g => g.SecurityLoginsRoles)
               .HasForeignKey(s => s.Role);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
