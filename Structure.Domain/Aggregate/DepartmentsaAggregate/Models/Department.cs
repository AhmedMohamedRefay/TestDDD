using Structure.Domain.Aggregate.CompanyEmployeeInfromationAggregate.Models;
using Structure.Domain.Aggregate.DepartmentJobsAggregate.Models;
using Structure.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Domain.Aggregate.DepartmentsaAggregate.Models
{

    [Table("Department", Schema = "Structure")]
    public class Department : EntityBase
    {
        public string Name { get; private set; }

        public string Description { get; private set; }

        public string Logo { get; private set; }

        public string? OfficePhoneNumber { get; private set; }

        public Guid? ParentId { get; private set; }

        public Guid ManagerId { get; private set; }
        public Guid CompanyId { get; private set; }


        public virtual CompaniesEmployeeInformations EmployeeInformations { get; private set; }
        public virtual Department department { get; private set; }

        private readonly List<DepartmentsJobs> _departmentsJobs;
        public virtual IReadOnlyCollection<DepartmentsJobs> departmentsJobs => _departmentsJobs;


        private readonly List<CompanyDepartmentPolicies> _companyDepartmentsPolicy;
        public virtual IReadOnlyList<CompanyDepartmentPolicies> companyDepartmentsPolicy => _companyDepartmentsPolicy;


    }
}
