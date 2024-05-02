using Structure.Domain.Aggregate.CompanyEmployeeInfromationAggregate.Lookup;
using Structure.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Domain.Aggregate.CompanyEmployeeInfromationAggregate.Models
{
    [Table("InjuryAndDeathRegistration", Schema = "Structure")]
    public class InjuryAndDeathRegistration : EntityBase
    {
        public DateTime DateTime { get; private set; }

        public string Description { get; private set; }

        public string Location { get; private set; }

        public string AtatachmentPath { get; private set; }

        public Guid CompanyId { get; private set; }

        public Guid EmployeeId { get; private set; }

        public int InjuryTypeId { get; private set; }

        public virtual CompaniesEmployeeInformations CompaniesEmployeeInformations { get; private set; }

        public virtual InjuryTypes InjuryTypes { get; private set; }

    }
}
