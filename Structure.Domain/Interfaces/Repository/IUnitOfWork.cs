using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Domain.Interfaces.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        public ICompanyRepository CompanyRepository { get; }

        public IDepartmentRepository DepartmentRepository { get; }

        public IEmployeeRepository EmployeeRepository { get; }


        public IJobRepository JobRepository { get; }
        
        public Task SaveChangesAsync();
    }
}
