using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Structure.Domain.Interfaces.Repository;
using Structure.Infrastructure.Repository;

namespace Structure.API.Controllers.lookupcontroll
{
    [Route("api/[controller]")]
    [ApiController]
    public class LookupController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;

        public LookupController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        
    }
}
