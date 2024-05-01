using Structure.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Domain.EmployeeAggregate.Lookup
{
    public class CountriesStates : LookpBase
    {
        public string Name { get; protected set; }

        public int CountryId { get; protected set; }

        public virtual Countries Countries { get; protected set; }

    }
}
