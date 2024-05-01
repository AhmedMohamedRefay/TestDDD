using Structure.Domain.Base;
using Structure.Domain.CompanyAggregate.Models;
using Structure.Domain.EmployeeAggregate.Lookup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Domain.EmployeeAggregate.Models
{
    public class Employee:EntityBase
    {
        public string Name { get;private set; }
        public string PhotoPath {  get;private set; }
        
        public string NationalIDNumber {  get;private set; }

        public string SaudiVisaNumber { get;private set; }

        public string PassportNumber { get; private set; }

        public DateOnly DateOfBirth { get;private set; }

        public string PrimaryPhoneNumber {  get;private set; }

        public string SecondaryPhonenNumber {  get;private set; }

        public string Email  { get;private set;}

        public string SocialInsuranceSubscriptionNumber {  get;private set; }

        public Guid MainCompanyId { get;private set; }

        public int NationalityId {  get;private set; }

        public int MaritalStatusId {  get;private set; }

        public int ReligionId { get;private set; }

        public string GenderId { get;private set;}

        public virtual Company Company { get;private set; }

        public virtual Countries Country { get;private set; }

        public virtual MaritalStatus MaritalStatus { get;private set; }

        public virtual Religion Religion { get;private set; }

        public virtual Gender Gender { get; private set; }
    }
}
