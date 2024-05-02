using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure.Domain.Aggregate.CompanyAggregate.Input
{

    public class CompanyInput
    {
        [Required]
        public Guid Id { get; set; }
        [Required]

        public string Name { get; set; }


        public string? Description { get; set; }



        public DateTime? CommercialRegistrationStartDate { get; set; }


        public DateTime? CommercialRegistrationExpireDate { get; set; }


        public string? UnifiedNationalNumber { get; set; }


        public string? InstitutionNumber { get; set; }


        public string? SocialInsuranceSubscriptionNumber { get; set; }



        public string? LogoPath { get; set; }

        public string? Website { get; set; }
        public string? Twitter { get; set; }

        public string? Facebook { get; set; }
        public string? Linkedin { get; set; }

        public Guid? CEO { get; set; }

        public Guid? CFO { get; set; }

        public Guid? CMO { get; set; }

    }
}
