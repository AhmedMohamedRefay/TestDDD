using Structure.Domain.Aggregate.JobAggregate.Models;
using Structure.Domain.Aggregate.DepartmentJobsAggregate.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structure.Domain.SeedWork;

namespace Structure.Domain.Aggregate.OccupationAggregate.Models
{

    [Table("Occupation", Schema = "Structure")]
    public class Occupation : EntityBase
    {
        public string Name { get; private set; }

        public string Description { get; private set; }

        private readonly List<Job> _Job;

        public Occupation()
        {
            _Job = new List<Job>();
        }
        public Occupation(string name, string description)
        {
            Name = name;
            Description = description;
            _Job = new List<Job>();
        }

        public virtual IReadOnlyCollection<Job> Job => _Job;


        public void addJob(Job job)
        {
            _Job.Add(job);
        }
    }

}
