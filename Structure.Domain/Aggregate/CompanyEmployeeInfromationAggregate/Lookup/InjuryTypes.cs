using Structure.Domain.Aggregate.CompanyEmployeeInfromationAggregate.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Structure.Domain.SeedWork;

namespace Structure.Domain.Aggregate.CompanyEmployeeInfromationAggregate.Lookup
{
    [Table("InjuryTypes", Schema = "Structure")]
    public class InjuryTypes : LookpBase
    {
        public string Name { get; private set; }
    }
}
