using Structure.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Domain.Aggregate.EmployeeAggregate.Lookup
{

    [Table("Religion", Schema = "Structure")]

    public class Religion : LookpBase
    {
        public string Name { get; protected set; }

    }
}
