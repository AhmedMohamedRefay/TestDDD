
using IdentityModel.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Domain.UserAggregation;
using Test.Domain.UserAggregation.Input;
using Test.Infrastructure.DataBase;

namespace Test.Infrastructure.Service
{
    public class UserService : IUserService
    {
        private readonly EcomerceDbContext _context;
        private readonly ISendOPTService _sendOPT;
        public UserService(EcomerceDbContext context)
        {
            _context = context;
        }

        public async Task<string> Login(string Email, string Password)
        {
             var user=_context.ApplicationUsers.FirstOrDefault(x => x.Email == Email);
            if(user!=null)
            {

                if(user.Password == Password)
                {
                
                string token=await GenerateToken();
                   return token;
                }
            }
            return "User Not Found";
        }

        public async Task Register(UserInput input)
        {
            var user = new ApplicationUser(input.UserName, input.Password, input.Email);
            await _sendOPT.SendOtpAsync(input.Email);  

            //await _unitOfWork.UserRepository.AddAsync(user);

            //_unitOfWork.save();
             
        }

        private  async Task<string> GenerateToken()
        {
            var client = new HttpClient();
            var disco = await client.GetDiscoveryDocumentAsync("https://localhost:7029");
            var tokenResponse = await client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
            {
                Address = disco.TokenEndpoint,

                ClientId = "clinet_mobile",
                ClientSecret = "secret",
                Scope = "myApi.read"
            });

            return tokenResponse.AccessToken;
        }
    }
}
