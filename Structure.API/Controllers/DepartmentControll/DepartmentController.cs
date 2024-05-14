using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Structure.API.Controllers.DepartmentControll.Request;
using Structure.API.Controllers.DepartmentControll.Response;
using Structure.Domain.Aggregate.CompanyAggregate.Models;
using Structure.Domain.Aggregate.DepartmentsaAggregate.Models;
using Structure.Domain.Interfaces.Repository;
using System.Text;
using Utility;
using Utility.GlobalException;

namespace Structure.API.Controllers.DepartmentControll
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public DepartmentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost("addDepartment")]
        public async Task<IActionResult> AddDepartment([FromForm] addDepartmentDto departmentDto)
        {
             
            if(ModelState.IsValid)
            {
                 Department department = new Department(departmentDto.Name, departmentDto.Description, departmentDto.companyId);

                var result = await _unitOfWork.DepartmentRepository.AddDepartment(department);
                return Ok(result);

            }
                
            else
                return BadRequest("some error occured");
               
            
             
             
          
        }

        [HttpGet("GetDepartment/{companyId}/{id}")]
        public async Task<IActionResult> getDepartment(Guid companyId,Guid id)
        {
           
            var result=await _unitOfWork.DepartmentRepository.getDepartmentAsync(companyId,id);
            var dep = new departmentDetails
            {
                Id=result.Id,
                Name = result.Name,
                Description = result.Description,
                NumberOfSubDepartment = result.departments.Count(),
            };
            return Ok(dep);
        }

        [HttpPut("updateDepartment/{companyId}/{departmentId}")]
        public async Task<IActionResult> updateDepartment(Guid companyId,Guid departmentId, [FromBody] updateDepartment department)
        {
            var depart = await _unitOfWork.DepartmentRepository.getDepartmentAsync(companyId, departmentId);
            if (depart == null) return BadRequest("this department not found");
            depart.updateDepartment(department.Name,department.Description);

            var result = await _unitOfWork.DepartmentRepository.updateDepartment(depart);
            return Ok(result);
        }

        [HttpGet("GetDepartments/{companyid}")]
        public async Task<IActionResult>getDepartments(Guid companyid)
        {
            var result= _unitOfWork.DepartmentRepository.getDepartmentByCompanyId(companyid).Result.Select(e=>new {e.Id, e.Name }).OrderBy(e=>e.Name);

            if (result == null) return BadRequest("this company not contain any departments");

            return Ok(result);
        }

        [HttpGet("GetSubDepartmets/{companyId}/{departmentId}")]
        public async Task<IActionResult> getSubDepartments(Guid companyId,Guid departmentId)
        {
            var result = await _unitOfWork.DepartmentRepository.getSubDepartments(companyId, departmentId);
                

            return Ok(result.Select(e=>new {e.Id,e.Name}));
        }
    }

   
    
   
   
}
