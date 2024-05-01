using Structure.Domain.Base;
using Structure.Domain.CompanyAggregate.Input;
using Structure.Domain.EmployeeAggregate.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Domain.CompanyAggregate.Models
{
    [Table("Companies", Schema ="Structure")]
    public  class Company: EntityBase
    {
        public Company()
        {
            Status = new CompanyStatus();
        }
        public Company(CompanyInput input)
        {
            Id = input.Id;
            Name = input.Name;
            Description=input.Description;
            CommercialRegistrationStartDate= input.CommercialRegistrationStartDate;
            CommercialRegistrationExpireDate= input.CommercialRegistrationExpireDate;

            UnifiedNationalNumber=input.UnifiedNationalNumber;
            InstitutionNumber=input.InstitutionNumber;
            SocialInsuranceSubscriptionNumber=input.SocialInsuranceSubscriptionNumber;

           

            LogoPath = input.LogoPath;
            Website = input.Website;
            Twitter=input.Twitter;

            Facebook=input.Facebook;

            Linkedin = input.Linkedin; 

            CEO = input.CEO;

            CFO = input.CFO; 

            CMO=input.CMO;
            Status=new CompanyStatus();

    }

        public string Name { get; private set; }
        public string? Description { get; private set; }

        public string? CommercialRegistrationNumber { get;private set; }
        public DateTime? CommercialRegistrationStartDate {  get; private set; }

        
        public DateTime? CommercialRegistrationExpireDate { get; private set; }

        public string? UnifiedNationalNumber { get; private set; }

        public string? InstitutionNumber {  get; private set; }

        public string? SocialInsuranceSubscriptionNumber {  get; private set; }

        public string? LogoPath { get; private set; }
        public string? Website {  get; private set; }

        public string? Twitter { get; private set; }

        public string? Facebook {  get; private set; }
        public string? Linkedin {  get; private set; }

        
        public Guid? ParentId { get; private set; }
        public Guid OwnerId { get; private set;}

        public Guid? CEO {  get; private set; }

        public Guid? CFO { get; private set; }

        public Guid? CMO { get; private set; }


        public int? StatusId { get; private set; } = 1;

        private readonly List<Company> _companies = new List<Company>();
        public virtual CompanyStatus Status { get; private set; } 

     //   public virtual Employee Employee { get; private set; }

     
        public virtual IReadOnlyList<Company> Companies => _companies;

        public void AddSubSidary(Company company)
        {
            _companies.Add(company);
        }

        public void addStatus(int? statusID)
        {
            StatusId = statusID;
        }
      //  private readonly List<Employee> _employees = new List<Employee>();
        

       // public virtual IReadOnlyList<Employee> employees => _employees;
    }
}
