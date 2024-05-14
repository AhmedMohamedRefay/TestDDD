using Structure.Domain.Aggregate.CompanyEmployeeInfromationAggregate.Lookup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Domain.Interfaces.Repository
{
    public interface ILookupRepository
    {
        Task<Role> addAsync(Role role);
    }
}
