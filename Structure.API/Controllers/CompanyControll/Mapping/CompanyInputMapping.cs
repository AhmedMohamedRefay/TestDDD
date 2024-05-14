using Structure.API.Controllers.CompanyControll.Request;
using Structure.Domain.Aggregate.CompanyAggregate.Input;
using Structure.Domain.Aggregate.CompanyAggregate.Models;

namespace Structure.API.Controllers.CompanyControll.Mapping
{
    public class CompanyInputMapping
    {

        public static CompanyInput Mapp(addCompany company)
        {

            var input = new CompanyInput
            {

                Id = Guid.NewGuid(),
                Name = company.Name,

                Description = company.Description,


                CommercialRegistrationStartDate = company.CommercialRegistrationStartDate,


                CommercialRegistrationExpireDate = company.CommercialRegistrationExpireDate,


                UnifiedNationalNumber = company.UnifiedNationalNumber,


                InstitutionNumber = company.InstitutionNumber,

                SocialInsuranceSubscriptionNumber = company.SocialInsuranceSubscriptionNumber,

                Website = company.Website,
                Twitter = company.Twitter,

                Facebook = company.Facebook,
                Linkedin = company.Linkedin,

                CEO = company.CEO,

                CFO = company.CFO,

                CMO = company.CMO,
                ParentId = company.ParentId,

            };

            return input;
        }


    }
}
