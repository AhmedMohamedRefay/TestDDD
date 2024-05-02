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
    [Table("FamilyDocuments", Schema = "Structure")]
    public class FamilyDocuments : EntityBase
    {
        public string Name { get; private set; }
        public DateTime IssuingOn { get; private set; }

        public DateTime ExpireDate { get; private set; }
        public string AttachmentPath { get; private set; }

        public Guid MemeberId { get; private set; }

        public int DocumentTypeId { get; private set; }

        public virtual FamilyInformation FamilyInformation { get; private set; }

        public virtual DocumentType DocumentType { get; private set; }


    }
}
