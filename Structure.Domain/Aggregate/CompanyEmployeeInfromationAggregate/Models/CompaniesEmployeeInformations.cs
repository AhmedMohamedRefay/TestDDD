using Structure.Domain.Aggregate.CompanyAggregate.Models;
using Structure.Domain.Aggregate.CompanyEmployeeInfromationAggregate.Lookup;
using Structure.Domain.Aggregate.EmployeeAggregate.Models;
using Structure.Domain.Aggregate.EmployeePositionsAggregate.Models;
using Structure.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Domain.Aggregate.CompanyEmployeeInfromationAggregate.Models
{

    [Table("CompaniesEmployeeInformations", Schema = "Structure")]
    public class CompaniesEmployeeInformations : EntityBase
    {
        public Guid CompanyId { get; private set; }

        public Guid EmployeeId { get; private set; }
        public DateTime EmploymentStartDate { get; private set; }= DateTime.UtcNow;

        public int? ProbationaryPeriodInDays { get; private set; }

        public bool? ProbationaryPeriodIsActive { get; private set; }

        public int? EmploymentContractInDays { get; private set; }

        public decimal? Performance { get; private set; }

        public string? ContractDocomentPath { get; private set; }

        public bool? IsTerminated { get; private set; }

        public string? Password {  get; private set; }

        public string Email {  get; private set; }

        public bool? IsFirstLogin { get; private set; } = false;
        public int RoleId { get; private set; } = 1;

        public int StatusId { get; private set; } = 1;

        public virtual Role role { get; private set; }

        public virtual CompanyEmployeeStatus status { get; private set; }

        public virtual Company Company { get; private set; }

        public virtual Employee Employee { get; private set; }

        private readonly List<EmployeePositions> _employeePositions;
        public virtual IReadOnlyCollection<EmployeePositions> employeePositions => _employeePositions;


        private readonly List<InjuryAndDeathRegistration> _injuryAndDeathRegistrations;
        public CompaniesEmployeeInformations()
        {
            _employeePositions=new List<EmployeePositions>();
        }
        public CompaniesEmployeeInformations(Guid companyId, Guid employeeId)
        {
            CompanyId = companyId;
            EmployeeId = employeeId;
            _employeePositions = new List<EmployeePositions>();

        }

        public virtual IReadOnlyCollection<InjuryAndDeathRegistration> injuryAndDeathRegistrations => _injuryAndDeathRegistrations;

        public void ChangeFirstLoginStatus()
        {
            this.IsFirstLogin = false;
        }

        public void setEmail(string email)
        {
            this.Email = email;
        }

        public void setPasword(string password)
        {
            this.Password = password;
        }
    }
}
