using Castle.Components.DictionaryAdapter.Xml;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Structure.API.Controllers.Mapping;
using Structure.API.Controllers.Request;
using Structure.API.Controllers.Response;
using Structure.Domain.CompanyAggregate.Input;
using Structure.Domain.CompanyAggregate.Models;
using Structure.Domain.Interfaces.Repository;
using Structure.Infrastructure.Services;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;

namespace Structure.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyRepository _companyRepository;

        private readonly ICompanyservice _companyservice;
        public CompanyController(ICompanyRepository companyRepository,ICompanyservice companyservice)
        {
            _companyRepository = companyRepository;
            _companyservice = companyservice;
        }

        [HttpPost("AddCompnay")]
        public async Task<IActionResult> AddCompany([FromForm]addCompany company)
        {

           var path= _companyservice.GetPath(company.Logo);


            var input = CompanyInputMapping.Mapp(company);
            input.LogoPath = path;
            var comp =new Company(input);
            
            var resut = await _companyRepository.Addcompany(comp);
           
            return Ok(resut);
        }

        [HttpGet("companyProfile/{Id}")]
        public async Task<IActionResult>getCompanyProfile(Guid Id)
        {

            var company=_companyRepository.GetCompanyProfile(Id);
            var x = company.Result.Name;
           
            
            if(company!=null)
            {
                var companyProfile = new companyProfileDTO();


                companyProfile.CommercialRegistrationNumber = company.Result.CommercialRegistrationNumber;
                companyProfile.CompanyName = company.Result.Name;
                companyProfile.Description = company.Result.Description;
                companyProfile.SocialInsuranceSubscriptionNumber = company.Result.SocialInsuranceSubscriptionNumber;
                companyProfile.UnifiedNationalNumber = company.Result.UnifiedNationalNumber;
                companyProfile.statusName = ;
                companyProfile.CompanyType = company.Result.ParentId == null ? "Main" : "sub";


             

            return Ok(companyProfile);



            }
            return NotFound("Item not found!");
            
        }
    }
}
