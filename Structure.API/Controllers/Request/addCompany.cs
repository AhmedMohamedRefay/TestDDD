using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Structure.API.Controllers.Request
{
    public class addCompany
    {
        
        public string Name { get;  set; }


        public string? Description { get; set; }


        public DateTime? CommercialRegistrationStartDate { get; set; }


        public DateTime? CommercialRegistrationExpireDate { get; set; }


        public string? UnifiedNationalNumber { get; set; }


        public string? InstitutionNumber { get; set; }

       

        [RegularExpression(@"^(\d{3}-\d{3}-\d{3})|(\d{9})$")]
        public string? SocialInsuranceSubscriptionNumber { get; set; }

        //[FileExtensions(Extensions = "jpg,jpeg,png")]
        public IFormFile? Logo { get; set; }
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
