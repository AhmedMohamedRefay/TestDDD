using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StackExchange.Redis;
using System.Drawing.Printing;
using Test.Application.Dto;
using Test.Infrastructure.Service;

namespace Test.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        private readonly IMailService mailService;
        private readonly ICacheService _cacheService;

        private readonly ISendOPTService _sendOPTService;
        public MailController(IMailService mailService, ICacheService cacheService,ISendOPTService sendOPTService)
        {
            this.mailService = mailService;
            _cacheService = cacheService;
            _sendOPTService = sendOPTService;
        }

        [HttpPost("Send")]
        public async Task<IActionResult> Send([FromForm] MailRequest request)
        {
            try
            {
                await mailService.SendEmailAsync(request);
                return Ok();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        [HttpPost("SendOTP/{mail}")]

        public async Task<IActionResult> SendOTP(string mail)
        {


           await _sendOPTService.SendOtpAsync(mail);
            return Ok();

        }



        [HttpPost("VerfiyOTP/{OTP}")]

        public async Task<IActionResult> VerfiyOTP(string mail,string OTP)
        {
            bool verify =await _sendOPTService.VerfiyOTP(mail,OTP);
            if (verify)
         
                return Ok("Success");
            
            return NotFound("Invalid");

        }

      
    }

}
