using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Structure.API.Controllers.JobControll.Request;
using Structure.Domain.Aggregate.EmployeePositionsAggregate.Models;
using Structure.Domain.Aggregate.JobAggregate.Models;
using Structure.Domain.Aggregate.OccupationAggregate.Models;
using Structure.Domain.Interfaces.Repository;

namespace Structure.API.Controllers.JobControll
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public JobController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost("Add Ocuppation")]

        public async Task<IActionResult> addOccpation(string Name,string Description)
        {
           var result= await _unitOfWork.JobRepository.addOcupation(new Occupation(Name,Description));
        
            if(result!=null) { return Ok(result); }
            return BadRequest("can not create occupation");
        }

        [HttpPost("Add Job")]
        public async Task<IActionResult> addJob([FromBody] addJobDto job)
        {

            Job j=new Job(job.Name, job.Description,job.OccupationId);
            var result = await _unitOfWork.JobRepository.addJob(j,job.departments,job.NumberOfPosition);
            if (result != null) { return Ok(result); }
            return BadRequest("can not create occupation");
        }

        [HttpPost("Assign Jobs To Employee")]
        public  IActionResult  assignJobToEmployee([FromBody] AssignEmployeePositionDto Dto)
        {

            for (var i = 0; i < Dto.Employees.Count(); i++)
            {
                var result = _unitOfWork.JobRepository.AssignJobToEmployee
                    (new EmployeePositions(Dto.companyId, Dto.Employees[i], Dto.Departments
                                          , Dto.JobId, true, Dto.workTypeId));
               
                if (result != null) { _unitOfWork.SaveChangesAsync(); }
               else return BadRequest("can not assign jobs to employees");
            }
            return Ok("succefully");
         
        }
    }
}
