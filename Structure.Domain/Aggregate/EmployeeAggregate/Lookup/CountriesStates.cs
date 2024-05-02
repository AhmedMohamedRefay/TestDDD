using Structure.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Domain.Aggregate.EmployeeAggregate.Lookup
{
    [Table("CountriesStates", Schema = "Structure")]
    public class CountriesStates : LookpBase
    {
        public string Name { get; protected set; }

        public int CountryId { get; protected set; }

        public virtual Countries Countries { get; protected set; }

    }
}
