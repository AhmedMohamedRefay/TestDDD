using Microsoft.AspNetCore.Identity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Domain.Interfaces;
using Test.Domain.ProductAggregation;
using Test.Domain.UserAggregation;
using Test.Domain.UserAggregation.Input;
using Test.Infrastructure.DataBase;

namespace Test.Infrastructure.Repository
{
    public class userRepository : GnericRepository<ApplicationUser>, IUserRepository
    {
        public userRepository(EcomerceDbContext dbContext) : base(dbContext)
        {

        }

        //public Task AddAsync(ApplicationUser entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<ApplicationUser> CreateUser(UserInput userInput)
        //{

        //    var user = new ApplicationUser(userInput);

        //    await _userManager.CreateAsync(user);

        //    await _context.SaveChangesAsync();
        //    return user;
        //}

        //public void Delete(ApplicationUser entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<ICollection<ApplicationUser>> GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<ApplicationUser> GetByIdAsync(Guid id)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<ApplicationUser> GetUserById(string email)
        //{

        //    var user=await _userManager.FindByEmailAsync(email);

        //  return user;
        //}

        //public void UpdateAsync(ApplicationUser entity)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
