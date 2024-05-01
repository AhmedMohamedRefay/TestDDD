namespace Structure.API.Controllers.Response
{
    public class companyProfileDTO
    {

        public string CommercialRegistrationNumber {  get; set; }

        public string CompanyType {  get; set; }

        public string UnifiedNationalNumber { get; set;}

        public string CompanyName { get; set;}
        public string SocialInsuranceSubscriptionNumber  { get; set;}
         
        public string Description {  get; set;}

        public string statusName {  get; set;}

        public List<string> Employees { get; set;}

        public List<string> Department { set; get; }

        public List<string> HeadOfCompany { set; get; }

    }
}
