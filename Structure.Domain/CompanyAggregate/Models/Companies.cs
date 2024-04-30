using Structure.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Domain.CompanyAggregate.Models
{
    public  class Companies: EntityBase
    {
         
        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime CommercialRegistrationStartDate {  get; private set; }

        
        public DateTime CommercialRegistrationExpireDate { get; private set; }

        public string UnifiedNationalNumber { get; private set; }

        public string InstitutionNumber {  get; private set; }

        public string SocialInsuranceSubscriptionNumber {  get; private set; }

        public string LogoPath { get; private set; }
        public string Website {  get; private set; }

        public string Twitter { get; private set; }

        public string Facebook {  get; private set; }
        public string Linkedin {  get; private set; }

        
        public Guid? ParentId { get; private set; }
        public Guid OwnerId { get; private set;}


        public int StatusId {  get; private set; }

        public virtual CompanyStatus Status { get; private set; }
        ng

    }
}
