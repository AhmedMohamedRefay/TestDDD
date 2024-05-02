using Structure.Domain.Aggregate.CompanyEmployeeInfromationAggregate.Models;
using Structure.Domain.Aggregate.DepartmentJobsAggregate.Models;
using Structure.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Domain.Aggregate.EmployeePositionsAggregate.Models
{

    [Table("EmployeePositions", Schema = "Structure")]
    public class EmployeePositions : EntityBase
    {
        public Guid CompanyId { get; private set; }

        public Guid EmployeeId { get; private set; }

        public Guid DepartmentId { get; private set; }

        public Guid JobId { get; private set; }

        public bool IsActive { get; private set; }

        public virtual DepartmentsJobs DepartmentsJobs { get; private set; }

        public virtual CompaniesEmployeeInformations CompaniesEmployeeInformations { get; private set; }



    }
}
