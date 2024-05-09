using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Domain.SeedWork
{
    public class EntityBase
    {
        public Guid Id { get; protected set; }
        public DateTime CreatedAt { get; protected set; } = DateTime.UtcNow;
        public Guid? CreatedBy { get; protected set; }
        //public DateTime? EditedAt { get; protected set; }
        //public Guid? EditedBy { get; protected set; }

        public DateTime? UpdatedAt { get; protected set; }
        public Guid? UpdatedBy { get; protected set; }
        public bool IsDeleted { get; protected set; } = false;
    

     
    }
}
