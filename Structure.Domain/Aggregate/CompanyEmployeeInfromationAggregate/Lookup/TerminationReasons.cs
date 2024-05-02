using Structure.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Domain.Aggregate.CompanyEmployeeInfromationAggregate.Lookup
{

    [Table("TerminationReasons", Schema = "Structure")]
    public class TerminationReasons : LookpBase
    {
        public string Name { get; private set; }


    }
}
