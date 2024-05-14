using Structure.Domain.Aggregate.EmployeePositionsAggregate.Models;
using Structure.Domain.Aggregate.JobAggregate.Models;
using Structure.Domain.Aggregate.OccupationAggregate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Domain.Interfaces.Repository
{
    public interface IJobRepository
    {
        Task<Occupation> addOcupation(Occupation occupation);

        Task<Job> addJob(Job job,List<Guid> departments, int numberOposition);

       EmployeePositions AssignJobToEmployee(EmployeePositions employeePositions);
    }
}
