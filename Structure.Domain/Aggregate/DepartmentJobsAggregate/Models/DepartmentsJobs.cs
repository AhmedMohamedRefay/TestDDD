﻿using Structure.Domain.Aggregate.DepartmentsaAggregate.Models;
using Structure.Domain.Aggregate.EmployeePositionsAggregate.Models;
using Structure.Domain.Aggregate.JobAggregate.Models;
using Structure.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Domain.Aggregate.DepartmentJobsAggregate.Models
{
    [Table("DepartmentsJobs", Schema = "Structure")]
    public class DepartmentsJobs : EntityBase
    {
        public Guid DerpatmentId { get; private set; }

        public Guid JobId { get; private set; }

        public int NumberOfPosition { get; private set; }

        public virtual Department Department { get; private set; }

        public virtual Job Job { get; private set; }


        private readonly List<EmployeePositions> _employeePositions;
        public virtual IReadOnlyCollection<EmployeePositions> employeePositions => _employeePositions;

    }
}
