using Structure.Domain.Aggregate.EmployeeAggregate.Lookup;
using Structure.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Domain.Aggregate.EmployeeAggregate.Models
{

    [Table("EmployeeDocuments", Schema = "Structure")]
    public class EmployeeDocuments : EntityBase
    {
        public string Name { get; private set; }
        public DateTime IssuingOn { get; private set; }

        public DateTime ExpireDate { get; private set; }
        public string AttachmentPath { get; private set; }

        public Guid EmployeeId { get; private set; }

        public int DocumentTypeId { get; private set; }

        public virtual Employee Employee { get; private set; }

        public virtual DocumentType DocumentType { get; private set; }


    }
}
