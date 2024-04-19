using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StackExchange.Redis;
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
        public MailController(IMailService mailService, ICacheService cacheService)
        {
            this.mailService = mailService;
            _cacheService = cacheService;
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
        [HttpPost("SendoTP/{mail}")]

        public async Task<IActionResult> SendOTP(string mail)
        {
            string OTP = GenerateoTP();
            await mailService.SendEmailAsync(new MailRequest
            {
                Body = OTP,
                Subject = "OTP",
                ToEmail = mail
            });
            var expirationTime = DateTimeOffset.Now.AddMinutes(5.0);
            _cacheService.SetData($"OTP", OTP, expirationTime);
            return Ok();

        }



        [HttpPost("VerfiyOTP/{OTP}")]

        public async Task<IActionResult> VerfiyOTP(string OTP)
        {
            var cacheData = _cacheService.GetData<string>("OTP");
            if (cacheData != null)
            {

                //  var prod= MapperConfig.InitializeAutomapper().Map<productDTO>(cacheData);

                if (cacheData == OTP)
                    return Ok("Success");
                else
                    return NotFound("Not Found !");

            }

            
            return NotFound("Invalid");

        }

        private string GenerateoTP()
        {
            Random random = new Random();
            int otp = random.Next(100000, 999999);
            return otp.ToString();
        }
    }

}
