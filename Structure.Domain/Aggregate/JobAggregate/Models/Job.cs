using Structure.Domain.Aggregate.DepartmentJobsAggregate.Models;
using Structure.Domain.Aggregate.OccupationAggregate.Models;
using Structure.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Domain.Aggregate.JobAggregate.Models
{

    [Table("Job", Schema = "Structure")]
    public class Job : EntityBase
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        public Guid OccupationId { get; private set; }

        public virtual Occupation occupation { get; private set; }


        public Job()
        {
            _departmentsJobs = new List<DepartmentsJobs>();
        }
        public Job(string name, string description, Guid occupationId)
        {
            Name = name;
            Description = description;
            OccupationId = occupationId;
            _departmentsJobs = new List<DepartmentsJobs>();
        }

        public virtual IReadOnlyCollection<DepartmentsJobs> departmentsJobs => _departmentsJobs;

        private readonly List<DepartmentsJobs> _departmentsJobs;
    }
}
