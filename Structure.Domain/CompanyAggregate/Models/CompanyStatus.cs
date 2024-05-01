using Structure.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Domain.CompanyAggregate.Models
{
    [Table("CompanyStatus", Schema = "Structure")]
    public class CompanyStatus:LookpBase
    {
        public string? Name { get;protected set; }
    }
}
