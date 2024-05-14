using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Structure.API.Controllers.EmployeeControll.Request;
using Structure.Domain.Aggregate.EmployeeAggregate.Models;
using Structure.Domain.Interfaces.Repository;
using Structure.Infrastructure.Services;

namespace Structure.API.Controllers.EmployeeControll
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        
        private readonly ICompanyservice _companyService;
        public EmployeeController(IUnitOfWork unitOfWork,ICompanyservice companyservice)
        {
            _unitOfWork = unitOfWork;
            _companyService = companyservice;
        }

        [HttpPost("addEmployee")]
        public async Task<IActionResult> addEmployee([FromForm] addEmployeeDto employee)
        {
            var path = _companyService.GetPath(employee.Logo);
            
            var emp = new Employee(employee.Name,path,employee.PasspostNumber,employee.DateOfBirth,employee.NationalAddress,employee.PrimaryPhoneNumber,
                                   employee.SecondaryPhoneNumber,employee.Email,employee.NationalityId,employee.GenderId);
            var employ =await _unitOfWork.EmployeeRepository.Add(emp);
            
            if(employ == null) { return BadRequest("some error occure");}

            var result=await _unitOfWork.EmployeeRepository.addUserCompany(employee.compnayId,employ.Id);
            if(result==true)
           return Ok(employ);

            return BadRequest("Can not adding in companyUser Table");

        }

        [HttpPost("Reset Password")]
        public async Task<IActionResult> ResetPassword([FromBody] resetPasswordDto dto)
        {
            var result=await _unitOfWork.EmployeeRepository.ResetPassword(dto.companyId,dto.Emplyees,dto.Password);
            if(result==true)
            {
                await _unitOfWork.SaveChangesAsync();
                return Ok("success");

            }
           
            return BadRequest("Failed");
        }
    }
}
