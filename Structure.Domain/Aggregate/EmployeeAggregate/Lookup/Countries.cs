using Structure.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Domain.Aggregate.EmployeeAggregate.Lookup
{
    [Table("Countries", Schema = "Structure")]
    public class Countries : LookpBase
    {
        public string Name { get; protected set; }
        public string Nationality { get; protected set; }

        public string PhoneCodeNumber { get; protected set; }
        public string PhoneNumberLength { get; protected set; }

    }
}
