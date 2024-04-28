using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Domain.UserAggregation.Input;

namespace Test.Infrastructure.Service
{
    public interface IUserService
    {
        Task<string> Login(string Email,string Password);

        Task Register(UserInput userInput);
    }
}
