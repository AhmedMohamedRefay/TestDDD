using Structure.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Domain.Aggregate.EmployeePositionsAggregate.Lookup
{

    [Table("WorkType", Schema = "Structure")]
    public class WorkType:LookpBase
    {
 
        public string Name {  get;protected set; }
    }
}
