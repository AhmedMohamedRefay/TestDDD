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

    [Table("FamilyInformation", Schema = "Structure")]
    public class FamilyInformation : EntityBase
    {
        public string FirstName { get; private set; }

        public string FatherName { get; private set; }

        public string FamilyName { get; private set; }

        public DateTime DateOfBirth { get; private set; }

        public string IdNumber { get; private set; }

        public Guid EmployeeId { get; private set; }

        public int RelativeRelationId { get; private set; }

        public int MaritalStatusId { get; private set; }

        public int GenderId { get; private set; }

        //private readonly List<FamilyDocuments> _familyDocuments=new List<FamilyDocuments>();

        private readonly List<FamilyDocuments> _familyDocuments;

        public virtual IReadOnlyCollection<FamilyDocuments> familyDocuments => _familyDocuments;

        public virtual Employee Employee { get; private set; }

        public virtual RelativeRelation RelativeRelation { get; private set; }

        public virtual MaritalStatus MaritalStatus { get; private set; }


        public virtual Gender Gender { get; private set; }


    }
}
