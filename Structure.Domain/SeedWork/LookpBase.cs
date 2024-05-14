using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Domain.SeedWork
{
    public class LookpBase
    {
        public int Id { get; protected set; }

        public void setId(int id)
        {
            this.Id = id;
        }
    }
}
