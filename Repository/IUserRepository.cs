using System.Collections.Generic;
using System.Threading.Tasks;
using SchoolApi.Models;

namespace SchoolApi.Repository
{
    public interface IUserRepository
    {

         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll();
         Task<UserModel> GetUserById(int id);

         Task<UserModel> GetUserDetailsById(int id);
         Task< IEnumerable<UserModel>> GetAllUserDetails();

         Task< IEnumerable<UserModel>> GetAllUsers();
         
    }
}