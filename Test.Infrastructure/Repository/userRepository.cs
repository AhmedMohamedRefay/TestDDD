using Microsoft.AspNetCore.Identity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Domain.Interfaces;
using Test.Domain.UserAggregation;
using Test.Domain.UserAggregation.Input;
using Test.Infrastructure.DataBase;

namespace Test.Infrastructure.Repository
{
    public class userRepository : IUserRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly EcomerceDbContext _context;

        public userRepository(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, EcomerceDbContext context)
        {
            _userManager = userManager;
           _roleManager = roleManager;
            _context = context;
        }

        public async Task<ApplicationUser> CreateUser(UserInput userInput)
        {

            var user = new ApplicationUser(userInput);

            await _userManager.CreateAsync(user);
           
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<ApplicationUser> GetUserById(string email)
        {
            
            var user=await _userManager.FindByEmailAsync(email);
            
          return user;
        }

        
    }
}
