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
        public DateTime? EditedBy { get; protected set; }
        public Guid? EditedAt { get; protected set; }
        public bool IsDeleted { get; protected set; } = false;
    }
}
