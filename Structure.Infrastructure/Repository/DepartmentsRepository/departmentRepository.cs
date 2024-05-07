using Microsoft.EntityFrameworkCore;
using Structure.Domain.Aggregate.DepartmentsaAggregate.Models;
using Structure.Domain.Interfaces.Repository;
using Structure.Infrastructure.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Infrastructure.Repository.DepartmentsRepository
{
    public class departmentRepository : IDepartmentRepository
    {
        private readonly StructureContext _context;

        public departmentRepository(StructureContext context)
        {
            _context = context;
        }

        public async Task<Department> AddDepartment(Department department)
        {
           await _context.AddAsync(department);
            var higherman = new Department();
           higherman = getHigherManagementDepartment(department.CompanyId, "Higher Managment");
            higherman.addSubDepartment(department);
            await _context.SaveChangesAsync();
            return department;
            
        }

        public async Task<Department> getDepartmentAsync(Guid companyId, Guid id)
        {
           var department=await _context.Departments.Where(d=>d.CompanyId==companyId&&d.Id==id).FirstOrDefaultAsync();

            return department;
                
                
        }

       

        private Department getHigherManagementDepartment(Guid companyId, string name)
        {

            var result=_context.Departments.Where(depart=> depart.CompanyId==companyId&& depart.Name==name).FirstOrDefault();

            return result;
        }
    }
}
