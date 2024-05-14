using Structure.Domain.Aggregate.EmployeeAggregate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Domain.Interfaces.Repository
{
    public interface IEmployeeRepository
    {
        Task<Employee> Add(Employee employee);

        Task<bool> addUserCompany(Guid companyId,Guid userId);

        Task<bool> ResetPassword(Guid companyId,List<Guid> employees,string password);
    }
}
