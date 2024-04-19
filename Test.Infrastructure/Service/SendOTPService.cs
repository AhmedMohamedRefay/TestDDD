using MailKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Infrastructure.Service
{
    public class SendOTPService:ISendOPTService
    {
        private readonly IMailService mailService;
        private readonly ICacheService _cacheService;

        public SendOTPService(IMailService mailService, ICacheService cacheService)
        {
            this.mailService = mailService;
            _cacheService = cacheService;
        }

        public async Task SendOtpAsync(string mail)
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
        }

        public async Task<bool> VerfiyOTP(string OTP)
        {
            var cacheData = _cacheService.GetData<string>("OTP");
            if (cacheData != null)
            {

                //  var prod= MapperConfig.InitializeAutomapper().Map<productDTO>(cacheData);

                if (cacheData == OTP)
                    return true;
                else
                    return false;

            }


            return false;

        }
        private string GenerateoTP()
        {
            Random random = new Random();
            int otp = random.Next(100000, 999999);
            return otp.ToString();
        }
    }
}
