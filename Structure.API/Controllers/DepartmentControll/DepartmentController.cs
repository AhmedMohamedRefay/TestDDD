using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Structure.API.Controllers.DepartmentControll.Request;
using Structure.API.Controllers.DepartmentControll.Response;
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
                Name = result.Name,
                Description = result.Description,
                NumberOfSubDepartment = result.departments.Count(),
            };
            return Ok(dep);
        }
    }

    class GlobalExecption :Exception
    {

    }
   
   
}
