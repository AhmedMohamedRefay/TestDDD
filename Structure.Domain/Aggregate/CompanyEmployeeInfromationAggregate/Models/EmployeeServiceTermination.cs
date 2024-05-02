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
    [Table("EmployeeServiceTermination", Schema = "Structure")]
    public class EmployeeServiceTermination : EntityBase
    {
        public DateTime EfeectiveDate { get; private set; }

        public string CertificatePath { get; private set; }

        public int ReasonId { get; private set; }
        public Guid CompanyId { get; private set; }

        public Guid EmployeeId { get; private set; }

        public virtual TerminationReasons TerminationReasons { get; private set; }

        public virtual CompaniesEmployeeInformations CompaniesEmployeeInformations { get; private set; }




    }
}
