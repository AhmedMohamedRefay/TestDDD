using Structure.Domain.Aggregate.CompanyEmployeeInfromationAggregate.Lookup;
using Structure.Domain.Interfaces.Repository;
using Structure.Infrastructure.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Infrastructure.Repository.LookupRepository
{
    public class lookupRepository : ILookupRepository
    {
        private readonly StructureContext _context;

        public lookupRepository(StructureContext context)
        {
            _context = context;
        }

        public async Task<Role> addAsync(Role role)
        {
             await _context.Roles.AddAsync(role);
            return role;
        }
    }
}
