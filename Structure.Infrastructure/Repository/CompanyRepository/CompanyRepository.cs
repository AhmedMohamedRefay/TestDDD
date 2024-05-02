using Microsoft.EntityFrameworkCore;
using Structure.Domain.Aggregate.CompanyAggregate.Models;
using Structure.Domain.Interfaces.Repository;
using Structure.Infrastructure.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Infrastructure.Repository.CompanyRepository
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly StructureContext _context;

        public CompanyRepository(StructureContext context)
        {
            _context = context;
        }

        public async Task<Company> Addcompany(Company company)
        {
            await _context.AddAsync(company);
            if(company.StatusId==null)
            {
                company.addStatus(1);
            }
            if(company.SocialInsuranceSubscriptionNumber!=null)
            {
                company.setInsuranceNumber(company.SocialInsuranceSubscriptionNumber);
            }
            await _context.SaveChangesAsync();
            return company;
        }

        public async Task<Company> GetCompanyProfile(Guid Id)
        {
            var company_profile = await _context.companies.Include(e=>e.Status).FirstAsync(x=>x.Id==Id);

            return company_profile;
        }

        public string GetStatusName(int Id)
        {
            return _context.companyStatuses.Where(s => s.Id == Id).Select(s => s.Name).FirstOrDefault();
        }
    }
}
