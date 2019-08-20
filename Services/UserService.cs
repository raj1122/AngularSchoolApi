using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolApi.Models;
using SchoolApi.Persistence;
using SchoolApi.Repository;

namespace SchoolApi.Services
{
    public class UserService:  IUserRepository
    {

        private readonly SchoolAPiDbContext dbContext;
        public UserService(SchoolAPiDbContext dbContext)
        {
            this.dbContext = dbContext;

        }

        public void Add<T>(T entity) where T : class
        {
            throw new System.NotImplementedException();
        }

        public void Delete<T>(T entity) where T : class
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<UserModel>> GetAllUserDetails()
        {
            return await dbContext.user
                                       .Include(p => p.phoneNumber)
                                       .Include(p => p.Photos)
                                       .Include(p => p.UserDetails)
                                       .ToListAsync();
        }

        public async Task<IEnumerable<UserModel>> GetAllUsers()
        {
            return await dbContext.user.Include(p => p.phoneNumber).ToListAsync();
        }

        public Task<UserModel> GetUserById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<UserModel> GetUserDetailsById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> SaveAll()
        {
            throw new System.NotImplementedException();
        }
    }
}