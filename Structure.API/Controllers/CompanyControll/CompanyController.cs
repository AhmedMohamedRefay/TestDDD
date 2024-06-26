﻿using Castle.Components.DictionaryAdapter.Xml;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Structure.API.Controllers.CompanyControll.Mapping;
using Structure.API.Controllers.CompanyControll.Request;
using Structure.API.Controllers.CompanyControll.Response;
 
using Structure.Domain.Aggregate.CompanyAggregate.Models;
using Structure.Domain.Aggregate.CompanyEmployeeInfromationAggregate.Lookup;
using Structure.Domain.Interfaces.Repository;
using Structure.Infrastructure.Services;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;

namespace Structure.API.Controllers.CompanyControll
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly ICompanyservice _companyservice;
        public CompanyController(IUnitOfWork unitOfWork, ICompanyservice companyservice)
        {
            _unitOfWork = unitOfWork;
            _companyservice = companyservice;
        }

        [HttpPost("AddCompnay")]
        public async Task<IActionResult> AddCompany([FromForm] addCompany company)
        {

            var path = _companyservice.GetPath(company.Logo);


            var input = CompanyInputMapping.Mapp(company);
            input.LogoPath = path;
            var comp = new Company(input);

            var resut = await _unitOfWork.CompanyRepository.Addcompany(comp);

            return Ok(resut);
        }

        [HttpGet("companyProfile/{Id}")]
        public async Task<IActionResult> getCompanyProfile(Guid Id)
        {

            var company = _unitOfWork.CompanyRepository.GetCompanyProfile(Id);
            //    var x = company.Result.Name;


            if (company != null)
            {
                var companyProfile = new companyProfileDTO();


                companyProfile.CommercialRegistrationNumber = company.Result.CommercialRegistrationNumber;
                companyProfile.CompanyName = company.Result.Name;
                companyProfile.Description = company.Result.Description;
                companyProfile.SocialInsuranceSubscriptionNumber = company.Result.SocialInsuranceSubscriptionNumber;
                companyProfile.UnifiedNationalNumber = company.Result.UnifiedNationalNumber;
                companyProfile.statusName = _unitOfWork.CompanyRepository.GetStatusName(company.Result.StatusId);
                companyProfile.CompanyType = company.Result.ParentId == null ? "Main" : "sub";




                return Ok(companyProfile);



            }
            return NotFound("Item not found!");

        }

        [HttpPatch("UpdateCompanyProfile/{id}")]
        public async Task<IActionResult> updateCompany(Guid id, [FromBody] updateCompanyDto companyDto)
        {

            var company = _unitOfWork.CompanyRepository.GetCompany(id);
            company.updateCompany(companyDto.Name, companyDto.Description, companyDto.CommercialRegisterationNo,
                                  companyDto.SocialInsuranceSubscriptionNumber, companyDto.CommercialRegistrationStartDate,
                                  companyDto.UnifiedNationalNumber, companyDto.CommercialRegistrationExpireDate);

            var result = await _unitOfWork.CompanyRepository.updateCompany(company);

            return Ok(result);
        }

        [HttpGet("GetsubSidairy/{id}")]
        public async Task<IActionResult> GetCompanysub(Guid id)
        {

            var companyName = _unitOfWork.CompanyRepository.GetCompany(id).Name;
            var subCompnay = _unitOfWork.CompanyRepository.subCompanies(id).Select(com => new { com.Id, com.Name });
            if (companyName != null)
            {
                var Dto = new companyListDto();
                Dto.Name = companyName;

                Dto.companies = new List<companyDto>();
                foreach (var com in subCompnay)
                {

                    Dto.companies.Add(new companyDto { Id = com.Id, Name = com.Name });
                }

                return Ok(Dto);
            }
            return BadRequest("Not company exists");


        }

        [HttpPost("addRole")]
        public async Task<IActionResult> AddRole(string role)
        {

            Role r = new Role(role);
            var result = await _unitOfWork.CompanyRepository.addAsyncRole(r);

            if (result != null)
                return Ok(result);
            return BadRequest("Can not create Role");
        }
    }
}
