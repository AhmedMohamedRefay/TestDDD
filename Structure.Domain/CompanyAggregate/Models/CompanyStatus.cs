using Structure.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Domain.CompanyAggregate.Models
{
    public class CompanyStatus:LookpBase
    {
        public string Name { get;protected set; }
    }
}
