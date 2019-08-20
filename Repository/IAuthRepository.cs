using System.Threading.Tasks;
using SchoolApi.Models;

namespace SchoolApi.Repository
{
    public interface IAuthRepository
    {
         Task<UserModel> register(UserModel user , string pass);

         Task<UserModel> Login(string username , string pass);

         Task<bool> UserExist(string username);

         
    }
}