using Structure.Domain.Aggregate.CompanyEmployeeInfromationAggregate.Models;
using Structure.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Domain.Aggregate.DepartmentsaAggregate.Models
{
    [Table("CompanyDepartmentPoliciesIsReaded", Schema = "Structure")]
    public class CompanyDepartmentPoliciesIsReaded : EntityBase
    {
        public Guid CompanyId { get; private set; }

        public Guid EmployeeId { get; private set; }

        public Guid CompanyDepartmentPoliciesId { get; private set; }

        public virtual CompanyDepartmentPolicies CompanyDepartmentPolicies { get; private set; }

        public virtual CompaniesEmployeeInformations CompaniesEmployeeInformations { get; private set; }
    }
}
