using Structure.Domain.Aggregate.CompanyAggregate.Models;
using Structure.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Domain.Aggregate.DepartmentsaAggregate.Models
{

    [Table("CompanyDepartmentPolicies", Schema = "Structure")]
    public class CompanyDepartmentPolicies : EntityBase
    {
        public string Name { get; private set; }

        public string Description { get; private set; }

        public Guid CompanyId { get; private set; }

        public Guid DerpartmentId { get; private set; }

        public virtual Company Company { get; private set; }

        public virtual Department Department { get; private set; }





        private readonly List<CompanyDepartmentPoliciesIsReaded> _CompanyDepartmentPoliciesIsReaded;
        public virtual IReadOnlyCollection<CompanyDepartmentPoliciesIsReaded> CompanyDepartmentPoliciesIsReaded => _CompanyDepartmentPoliciesIsReaded;
    }
}
