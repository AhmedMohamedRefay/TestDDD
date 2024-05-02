using Structure.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Domain.Aggregate.EmployeeAggregate.Models
{

    [Table("WorkHistory", Schema = "Structure")]
    public class WorkHistory : EntityBase
    {
        public string CompanyLogo { get; private set; }

        public string CompanyName { get; private set; }

        public string DepartmentName { get; private set; }

        public string JobPosition { get; private set; }

        public DateTime EmploymentStartDate { get; private set; }

        public DateTime EmploymentEndDate { get; private set; }

        public string Details { get; private set; }

        public Guid EmployeeId { get; private set; }

        public virtual Employee Employee { get; private set; }





    }
}
