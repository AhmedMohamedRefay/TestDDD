using Microsoft.EntityFrameworkCore;
using Structure.Domain.CompanyAggregate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Infrastructure.DataBase
{
    public class StructureContext:DbContext
    {
        public StructureContext(DbContextOptions<StructureContext> options):base(options) 
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();
        }
        public virtual  DbSet<Company> companies { get; set; }

        public virtual DbSet<CompanyStatus>  companyStatuses { get; set; }
    }
}
