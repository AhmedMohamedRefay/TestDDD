using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Infrastructure.Service
{
    public interface ISendOPTService
    {
        Task SendOtpAsync(string mail);
        Task<bool> VerfiyOTP(string mail,string otp);
    }
}
