using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Domain.UserAggregation.Input;
 
namespace Test.Domain.UserAggregation
{
    public  class ApplicationUser:IdentityUser
    {

        

        public ApplicationUser()
        {
            
        }

        public ApplicationUser(UserInput input)
        {
            Validate(input);
            
        }

        private void Validate(UserInput userInput)
        {
            if(userInput.Email != null&&userInput.Password!=null) {
            
                this.Email=userInput.Email;
                this.PasswordHash = userInput.Password;
            }
        }
    }
}
