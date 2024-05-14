using Structure.Domain.Aggregate.JobAggregate.Models;

namespace Structure.API.Controllers.JobControll.Request
{
    public class AssignEmployeePositionDto
    {
        public  List<Guid>  Employees { get; set; }
        public Guid Departments { get; set; }

        public Guid companyId { get; set; }
        public Guid  JobId { get; set; }

        public int workTypeId { get; set; }


    }
}
