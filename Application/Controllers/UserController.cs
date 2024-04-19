using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test.Application.MidleWare;
using Test.Domain.Interfaces;
using Test.Domain.UserAggregation.Input;

namespace Test.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(UserInput input)
        {
            var us = await _userRepository.GetUserById(input.Email);
            if (us != null)
                throw new BadRequestException("user already exists !");
            else
            {
                var user = await _userRepository.CreateUser(input);
                return Ok(user);
            }
        }
    }
}
