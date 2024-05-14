using Structure.Domain.Aggregate.CompanyEmployeeInfromationAggregate.Models;
using Structure.Domain.Aggregate.DepartmentJobsAggregate.Models;
using Structure.Domain.Aggregate.EmployeePositionsAggregate.Lookup;
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
        public EmployeePositions()
        {
            
        }
        public EmployeePositions(Guid companyId, Guid employeeId, Guid departmentId, Guid jobId, bool isActive, int workTypeId)
        {
            CompanyId = companyId;
            EmployeeId = employeeId;
            DepartmentId = departmentId;
            JobId = jobId;
            IsActive = isActive;
            WorkTypeId = workTypeId;
        }

        public virtual WorkType WorkType { get;private set; }
        public Guid CompanyId { get; private set; }

        public Guid EmployeeId { get; private set; }

        public Guid DepartmentId { get; private set; }

        public Guid JobId { get; private set; }

        public bool IsActive { get; private set; }

        public int WorkTypeId {  get; private set; }

        public virtual DepartmentsJobs DepartmentsJobs { get; private set; }

        public virtual CompaniesEmployeeInformations CompaniesEmployeeInformations { get; private set; }



    }
}
