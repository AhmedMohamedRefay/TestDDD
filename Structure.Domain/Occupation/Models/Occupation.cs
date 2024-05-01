using Structure.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Domain.Occupation.Models
{
    public class Occupation:EntityBase
    {
        public string Name { get;private set; }

        public string Description { get;private set; }

       
    }
}
