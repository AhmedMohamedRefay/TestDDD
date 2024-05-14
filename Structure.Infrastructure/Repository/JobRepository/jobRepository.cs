using Microsoft.EntityFrameworkCore;
using Structure.Domain.Aggregate.DepartmentJobsAggregate.Models;
using Structure.Domain.Aggregate.EmployeePositionsAggregate.Models;
using Structure.Domain.Aggregate.JobAggregate.Models;
using Structure.Domain.Aggregate.OccupationAggregate.Models;
using Structure.Domain.Interfaces.Repository;
using Structure.Infrastructure.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Infrastructure.Repository.JobRepository
{
    public class jobRepository : IJobRepository
    {

        private readonly StructureContext _context;

        public jobRepository(StructureContext context)
        {
            _context = context;
        }


        public async Task<Occupation> addOcupation(Occupation occupation)
        {
            await _context.Occupations.AddAsync(occupation);
            await _context.SaveChangesAsync();
            return occupation;

        }

        public async Task<Job> addJob(Job job, List<Guid> departments, int numberOposition)
        {
            var occupation = await _context.Occupations.FindAsync(job.OccupationId);

            if (occupation != null)
            {
                await _context.Jobs.AddAsync(job);


                for (int i = 0; i < departments.Count(); i++)
                {
                    var dep = await _context.Departments.FindAsync(departments[i]);
                    if (dep != null)
                    {
                        var depJob = new DepartmentsJobs(departments[i], job.Id, numberOposition);
                        await _context.DepartmentsJobs.AddAsync(depJob);
                        await _context.SaveChangesAsync();
                    }
                }

                //await _context.SaveChangesAsync();
                return job;
            }
            return null;
        }

        public EmployeePositions  AssignJobToEmployee(EmployeePositions employeePositions)
        {
           var company=  _context.companies.Find(employeePositions.CompanyId);
            if(company != null)
            {
                var employee=_context.Employees.Find(employeePositions.EmployeeId);
                if (employee!=null)
                {

                    var companyEmployee =  _context.CompaniesEmployeeInformations
                                           .Where(ep => ep.CompanyId == company.Id && ep.EmployeeId == employee.Id)
                                           .FirstOrDefault();
                    if (companyEmployee != null)
                    {
                        var department = _context.Departments.Find(employeePositions.DepartmentId);
                        if (department != null)
                        {
                            var job =   _context.Jobs.Find(employeePositions.JobId);

                            if(job != null)
                            {
                                var departjob =  _context.DepartmentsJobs
                                          .Where(ep => ep.DepartmentId == department.Id && ep.JobId == job.Id)
                                          .FirstOrDefault();
                                if (departjob!=null)
                                {
                                      _context.EmployeePositions
                                        .Add(
                                      new EmployeePositions(employeePositions.CompanyId,
                                                           employeePositions.EmployeeId,
                                                          employeePositions.DepartmentId,
                                                          employeePositions.JobId, true, employeePositions.WorkTypeId));

                                    _context.SaveChanges();
                                    return employeePositions;

                                }
                              
                            }

                        }

                    }
                }
                
            }
            throw new ArgumentException("some error happend");
        }
    }
}
