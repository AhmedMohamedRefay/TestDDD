using Structure.Domain.Aggregate.CompanyAggregate.Models;
using Structure.Domain.Aggregate.CompanyEmployeeInfromationAggregate.Models;
using Structure.Domain.Aggregate.EmployeeAggregate.Lookup;
using Structure.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Domain.Aggregate.EmployeeAggregate.Models
{

    [Table("Employee", Schema = "Structure")]
    public class Employee : EntityBase
    {
        public string Name { get; private set; }
        public string PhotoPath { get; private set; }

        public string NationalIDNumber { get; private set; }

        public string SaudiVisaNumber { get; private set; }

        public string PassportNumber { get; private set; }

        public DateOnly DateOfBirth { get; private set; }

        public string Address { get; private set; }
        public string PrimaryPhoneNumber { get; private set; }

        public string SecondaryPhonenNumber { get; private set; }

        public string Email { get; private set; }

        public string SocialInsuranceSubscriptionNumber { get; private set; }

        public Guid MainCompanyId { get; private set; }

        public int NationalityId { get; private set; }

        public int MaritalStatusId { get; private set; }

        public int ReligionId { get; private set; }

        public int GenderId { get; private set; }

        #region NavigationProprty
        public virtual Company Company { get; private set; }

        public virtual Countries Country { get; private set; }

        public virtual MaritalStatus MaritalStatus { get; private set; }

        public virtual Religion Religion { get; private set; }

        public virtual Gender Gender { get; private set; }

        #endregion


        private readonly List<EmployeeDocuments> _employeeDocuments;

        public virtual IReadOnlyCollection<EmployeeDocuments> employeeDocuments => _employeeDocuments;

        private readonly List<Certificates> _certificates;

        public virtual IReadOnlyCollection<Certificates> certificates => _certificates;


        private readonly List<FamilyInformation> _familyInformation;

        public virtual IReadOnlyCollection<FamilyInformation> familyInformation => _familyInformation;


        private readonly List<WorkHistory> _workHistories;

        public virtual IReadOnlyCollection<WorkHistory> workHistories => _workHistories;

        private readonly List<CompaniesEmployeeInformations> _companiesEmployeeInformations;
        public virtual IReadOnlyCollection<CompaniesEmployeeInformations> CompaniesEmployeeInformations => _companiesEmployeeInformations;
    }
}
