using Microsoft.EntityFrameworkCore;
using Structure.Domain.Aggregate.CompanyEmployeeInfromationAggregate.Models;
using Structure.Domain.Aggregate.EmployeeAggregate.Models;
using Structure.Domain.Interfaces.Repository;
using Structure.Infrastructure.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Infrastructure.Repository.EmployeeRepository
{
    public class employeeRepository : IEmployeeRepository
    {
        private readonly StructureContext _context;

        public employeeRepository(StructureContext context)
        {
            _context = context;
        }

        public async Task<Employee> Add(Employee employee)
        {
           var egnder= await _context.Genders.FindAsync(employee.GenderId);
            var nationality = await _context.Countries.FindAsync(employee.NationalityId);
            if (egnder != null && nationality != null)
            {
                await _context.Employees.AddAsync(employee);
                await _context.SaveChangesAsync();
                return employee;
            }
            else
                return null;   
                
        }

        public async Task<bool> addUserCompany(Guid companyId,Guid employeeId)
        {
            var company=await _context.companies.FindAsync(companyId);
            var employee=await _context.Employees.FindAsync(employeeId);
            if(company!=null&&employee!=null)
            {
                var companyUser=new CompaniesEmployeeInformations(companyId, employeeId);
                companyUser.setEmail(employee.Email);
                companyUser.setPasword(CreatePassword(15));
                await _context.CompaniesEmployeeInformations.AddAsync(companyUser);
                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }

        private static string CreatePassword(int length)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder result = new StringBuilder();
            Random random = new Random();

            while (length-- > 0)
            {
                result.Append(validChars[random.Next(validChars.Length)]);
            }


            return result.ToString();
        }

        public async Task<bool> ResetPassword(Guid companyId,List<Guid> employees, string password)
        {
            for(int i=0;i<employees.Count();i++ )
            {
                var result=await _context.CompaniesEmployeeInformations
                    .Where(emp => emp.CompanyId == companyId && emp.EmployeeId == employees[i])
                    .FirstOrDefaultAsync();

                if (result != null)
                {
                    result.setPasword(password);
                }
                else
                    return false;
                   // throw new Exception($"Employee with id {employees[i]} and company with Id {companyId} not exists");
            }
            return true;

        }
    }
}
