using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Domain.UserAggregation.Input;
 
namespace Test.Domain.UserAggregation
{
    public  class ApplicationUser
    {
        public Guid Id { get; set; }
        public string UserName { get;private  set; }
        public string Password { get; private set; }
        public string Email { get; private set; }

        

        public ApplicationUser()
        {
            
        }

        public ApplicationUser(string userName, string password, string email)
        {
            UserName = userName;
            Password = password;
            Email = email;
        }
         
    }
}
