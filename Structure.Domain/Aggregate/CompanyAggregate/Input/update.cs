using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Domain.Aggregate.CompanyAggregate.Input
{
    public class update
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string CommercialRegisterationNo { get; set; }

    

        public string SocialInsuranceSubscriptionNumber { get; set; }

        public DateTime? CommercialRegistrationStartDate { get; set; }

        public string? UnifiedNationalNumber { get; set; }

        public DateTime? CommercialRegistrationExpireDate { get; set; }
    }
}
