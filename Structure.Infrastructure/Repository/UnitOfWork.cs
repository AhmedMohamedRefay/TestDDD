using Structure.Domain.Interfaces.Repository;
using Structure.Infrastructure.DataBase;
using Structure.Infrastructure.Repository.CompanyRepository;
using Structure.Infrastructure.Repository.DepartmentsRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        private ICompanyRepository _companyRepository;
        private IDepartmentRepository _departmentRepository;

        private readonly StructureContext _dbContext;
        private bool disposed = false;
         
        public UnitOfWork(StructureContext dbContext)
        {
            this._dbContext = dbContext;
        }

        
        public ICompanyRepository CompanyRepository => _companyRepository ??= new companyRepository(_dbContext);

        public IDepartmentRepository DepartmentRepository => _departmentRepository ??= new departmentRepository(_dbContext);
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
                if (disposing)
                    _dbContext.Dispose();
            disposed = true;
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        
    }
}
