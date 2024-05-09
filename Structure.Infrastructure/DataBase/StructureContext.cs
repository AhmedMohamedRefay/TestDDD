using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using Structure.Domain.Aggregate.CompanyAggregate.LookUp;
using Structure.Domain.Aggregate.CompanyAggregate.Models;
using Structure.Domain.Aggregate.CompanyEmployeeInfromationAggregate.Lookup;
using Structure.Domain.Aggregate.CompanyEmployeeInfromationAggregate.Models;
using Structure.Domain.Aggregate.DepartmentJobsAggregate.Models;
using Structure.Domain.Aggregate.DepartmentsaAggregate.Models;
using Structure.Domain.Aggregate.EmployeeAggregate.Lookup;
using Structure.Domain.Aggregate.EmployeeAggregate.Models;
using Structure.Domain.Aggregate.EmployeePositionsAggregate.Models;
using Structure.Domain.Aggregate.JobAggregate.Models;
using Structure.Domain.Aggregate.OccupationAggregate.Models;
using Structure.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Structure.Infrastructure.DataBase
{
    public class StructureContext : DbContext
    {
        public StructureContext(DbContextOptions<StructureContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //Configure Primary Key using HasKey method
            modelBuilder.Entity<CompaniesEmployeeInformations>().HasKey(s => new { s.EmployeeId, s.CompanyId });

            modelBuilder.Entity<DepartmentsJobs>().HasKey(s => new { s.JobId, s.DerpatmentId });


            modelBuilder.Entity<EmployeePositions>().HasKey(s => new { s.DepartmentId, s.JobId, s.EmployeeId, s.CompanyId });

             

            modelBuilder.Entity<CompanyDepartmentPoliciesIsReaded>().HasKey(s => new { s.CompanyId, s.EmployeeId, s.CompanyDepartmentPoliciesId });

            modelBuilder.Entity<EmployeePositions>()
           .HasOne(s => s.DepartmentsJobs)
           .WithMany(g => g.employeePositions)
           .HasForeignKey(s => new { s.DepartmentId, s.JobId });

            modelBuilder.Entity<EmployeePositions>()
           .HasOne(s => s.CompaniesEmployeeInformations)
           .WithMany(g => g.employeePositions)
           .HasForeignKey(s => new { s.CompanyId, s.EmployeeId });



        }

        //public override int SaveChanges()
        //{
        //    var entries = ChangeTracker
        //        .Entries()
        //        .Where(e => e.Entity is EntityBase && (
        //                e.State == EntityState.Added
        //                || e.State == EntityState.Modified));

        //    foreach (var entityEntry in entries)
        //    {
        //        // ((EntityBase)entityEntry.Entity).UpdatedAt = DateTime.Now;

        //        ((EntityBase)entityEntry.Entity).setUpdatedAt();

        //        if (entityEntry.State == EntityState.Added)
        //        {
        //            ((EntityBase)entityEntry.Entity).setCreatedAt();
        //          //  ((EntityBase)entityEntry.Entity).CreatedAt = DateTime.Now;
        //        }
        //    }

        //    return base.SaveChanges();
        //}
        public virtual DbSet<Company> companies { get; set; }

        public virtual DbSet<CompanyStatus> companyStatuses { get; set; }

        public virtual DbSet<Department> Departments { get; set; }

        public virtual DbSet<InjuryAndDeathRegistration> InjuryAndDeathRegistrations { get; set; }

        public virtual DbSet<InjuryTypes> InjuryTypes { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }

        public virtual DbSet<Employee> Employees { get; set; }

        public virtual DbSet<CompanyEmployeeStatus> CompanyEmployeeStatuses { get; set; }

        public virtual DbSet<Role> Roles { get; set; }

        public virtual DbSet<TerminationReasons> TerminationReasons { get; set; }

        public virtual DbSet<CompaniesEmployeeInformations> CompaniesEmployeeInformations { get; set; }

        public virtual DbSet<EmployeeServiceTermination> EmployeeServiceTerminations { get; set; }

        public virtual DbSet<DepartmentsJobs> DepartmentsJobs { get; set; }

        public virtual DbSet<CompanyDepartmentPolicies> CompanyDepartmentPolicies { get; set; }

        public virtual DbSet<CompanyDepartmentPoliciesIsReaded> CompanyDepartmentPoliciesIsReadeds { get; set; }

        public virtual DbSet<Countries> Countries { get; set; }

        public virtual DbSet<CountriesStates> CountriesStates { get; set; }

        public virtual DbSet<DocumentType> DocumentTypes { get; set; }

        public virtual DbSet<Gender> Genders { get; set; }

        public virtual DbSet<MaritalStatus> MaritalStatuses { get; set; }

        public virtual DbSet<RelativeRelation> RelativeRelations { get; set; }

        public virtual DbSet<Religion> Religion { get; set; }

        public virtual DbSet<Certificates> Certificates { get; set; }

        public virtual DbSet<EmployeeDocuments> EmployeeDocuments { get; set; }

        public virtual DbSet<FamilyDocuments> FamiliesDocuments { get; set; }

        public virtual DbSet<FamilyInformation> FamiliesInformation { get; set; }

        public virtual DbSet<WorkHistory> WorkHistory { get; set; }

        public virtual DbSet<EmployeePositions> EmployeePositions { get; set; }

        public virtual DbSet<Occupation> Occupations { get; set; }



    }
}
