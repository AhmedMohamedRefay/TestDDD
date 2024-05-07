using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Structure.Domain.Aggregate.DepartmentsaAggregate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Infrastructure.DataBase
{
    public class DepartmentConfiguration:IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> modelBuilder)
        {

            modelBuilder
           .HasOne(s => s.department)
           .WithMany(g => g.departments)
           .HasForeignKey(s => new { s.ParentId });



            modelBuilder
           .HasOne(s => s.EmployeeInformations)
           .WithMany()
           .HasForeignKey(s => new { s.CompanyId, s.ManagerId });

            modelBuilder
        .HasIndex(d => d.Name)
        .IsUnique();

         }
    }
}
