using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test.Application.Dto;
using Test.Application.MidleWare;
using Test.Domain.Interfaces;
using Test.Domain.UserAggregation;
using Test.Domain.UserAggregation.Input;
using Test.Infrastructure.Service;

namespace Test.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserService _userService;
        public UserController(IUnitOfWork  unitOfWork,IUserService userService)
        {
            _unitOfWork = unitOfWork;
            _userService = userService;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(UserInput input)
        {
            var user = new ApplicationUser(input.UserName,input.Password,input.Email);
            await _unitOfWork.UserRepository.AddAsync(user);

            _unitOfWork.save();
             return Ok(user);
            
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(UserLoginDto input)
        {
          
           string token= await _userService.Login(input.Email, input.Password);

            return Ok(token);

        }
    }
}
