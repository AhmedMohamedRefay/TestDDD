using Structure.Domain.Aggregate.CompanyAggregate.Models;
using Structure.Domain.Aggregate.CompanyEmployeeInfromationAggregate.Lookup;
using Structure.Domain.Aggregate.DepartmentsaAggregate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Structure.Domain.Interfaces.Repository
{
    public interface ICompanyRepository  
    {
        Task<Company> Addcompany(Company company);
        Task<Company> GetCompanyProfile(Guid Id);

        Task<Company> updateCompany( Company company);
        string GetStatusName(int Id);

        Company GetCompany(Guid Id);

        Task<List<Company>> GetCompanies(Guid Id);


        string GetCompanyName(Guid Id);

        List<Company> subCompanies(Guid Id);

        Task<Role> addAsyncRole(Role role);

        Task<CompanyDepartmentPolicies> addPolicyAsync(CompanyDepartmentPolicies policy);
    }
}
