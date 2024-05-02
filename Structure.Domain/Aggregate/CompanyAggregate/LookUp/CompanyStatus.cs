using Structure.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Domain.Aggregate.CompanyAggregate.LookUp
{
    [Table("CompanyStatus", Schema = "Structure")]
    public class CompanyStatus : LookpBase
    {
        public string? Name { get; protected set; }
    }
}
