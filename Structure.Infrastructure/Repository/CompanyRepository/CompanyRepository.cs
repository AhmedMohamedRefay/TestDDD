 using Microsoft.EntityFrameworkCore;
using Structure.Domain.Aggregate.CompanyAggregate.Models;
using Structure.Domain.Aggregate.CompanyEmployeeInfromationAggregate.Lookup;
using Structure.Domain.Aggregate.DepartmentsaAggregate.Models;
using Structure.Domain.Interfaces.Repository;
using Structure.Infrastructure.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Infrastructure.Repository.CompanyRepository
{
    public class companyRepository : ICompanyRepository
    {
        private readonly StructureContext _context;

        public companyRepository(StructureContext context)
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
            if(company.ParentId!=null)
            {
               var c= _context.companies.Find(company.ParentId);
                c.AddSubSidary(company);
            }
            
            Department department = new Department();
            department.setHigherManagerName();
            department.setCompany(company);
          //  company.setCreatedAt();
            await _context.Departments.AddAsync(department);
            await _context.SaveChangesAsync();
           // company.setCreatedAt();
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

        public async Task<Company> updateCompany( Company company)
        {
   
            if(company!=null)
            {
                
                 
               await _context.SaveChangesAsync();
                return company;
            }
            throw new Exception("Not Found");

            
        }

        public Company GetCompany(Guid Id)
        {
            return _context.companies.Find(Id);
        }

        public async Task<List<Company>> GetCompanies(Guid Id)
        {
           var companies = await _context.companies.Where(c=>c.Id==Id).Include(y=>y.Companies).AsNoTracking().ToListAsync();
           return companies;
        }

        public string GetCompanyName(Guid Id)
        {
            return _context.companies.Where(e=>e.Id==Id).Select(e => e.Name).FirstOrDefault();
        }

        public List<Company> subCompanies(Guid parentId)
        {
           return _context.companies.Where(e => e.ParentId == parentId).ToList();
        }

        public async Task<Role> addAsyncRole(Role role)
        {
           await _context.Roles.AddAsync(role);
            await _context.SaveChangesAsync();
        
            return role;
                      
        }

        public async Task<CompanyDepartmentPolicies> addPolicyAsync(CompanyDepartmentPolicies policy)
        {
            await _context.CompanyDepartmentPolicies.AddAsync(policy);
            return policy;
        }
    }
}
