using Structure.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Domain.Aggregate.EmployeeAggregate.Models
{

    [Table("Certificates", Schema = "Structure")]
    public class Certificates : EntityBase
    {
        public string Name { get; private set; }
        public string IssuingBody { get; private set; }

        public DateTime IssuingOn { get; private set; }

        public DateTime ExpireDate { get; private set; }

        public string AttachmentPaht { get; private set; }

        public Guid EmployeeId { get; private set; }

        public virtual Employee Employee { get; private set; }

    }
}
