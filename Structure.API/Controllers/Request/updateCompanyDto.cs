namespace Structure.API.Controllers.Request
{
    public class updateCompanyDto
    {
       
        public string Name { get; set; }
        public string Description { get; set; }

        public string CommercialRegisterationNo{get;set;}

  

        public string SocialInsuranceSubscriptionNumber {  get;set;}

        public DateTime? CommercialRegistrationStartDate { get;  set; }

        public string? UnifiedNationalNumber { get;  set; }

        public DateTime? CommercialRegistrationExpireDate { get;  set; }

    }
}
