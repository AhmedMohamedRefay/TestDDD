using Structure.Domain.Aggregate.CompanyAggregate.Models;
using Structure.Domain.Aggregate.DepartmentsaAggregate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Domain.Interfaces.Repository
{
    public interface IDepartmentRepository
    {
        Task<Department> AddDepartment(Department department);

        Task<Department> getDepartmentAsync(Guid companyId,Guid id);

        Task<ICollection< Department>> getDepartmentByCompanyId(Guid companyId);

        Task<Department> updateDepartment(Department department);
        Task<ICollection<Department>> getSubDepartments(Guid companyId,Guid DepId);
       // Department getHigherManagementDepartment(Guid companyId,string name);
    }
}
