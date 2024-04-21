using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Domain.ProductAggregation;
using Test.Domain.UserAggregation;
using Test.Domain.UserAggregation.Input;

namespace Test.Domain.Interfaces
{
    public interface IUserRepository : IGenericRepository<ApplicationUser>
    {
 
    }
}
