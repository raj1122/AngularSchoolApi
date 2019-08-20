using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolApi.Dtos;
using SchoolApi.Models;
using SchoolApi.Persistence;

namespace SchoolApi.Repository
{
    public class AuthServices : IAuthRepository
    {
        private readonly SchoolAPiDbContext dbContext;
        public AuthServices(SchoolAPiDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<UserModel> Login(string username, string pass)
        {
            var user = await dbContext.user.FirstOrDefaultAsync( x=> x.email == username );

            if(user == null)
            {
                return null;
            }

            if(  ! verifyPasswordHash( pass , user.passwordHash , user.passwordSalt))
            {
                return null;
            }

            return user;



        }



        public async Task<UserModel> register(UserModel user, string pass)
        {
            byte[] passwordHash,passwordSalt;
            createPassword(pass , out passwordHash , out passwordSalt);

            user.passwordHash = passwordHash;
            user.passwordSalt = passwordSalt;

            await dbContext.user.AddAsync(user);
            await dbContext.SaveChangesAsync();

            return user;
        }

        public async Task<bool> UserExist(string username)
        {
            if( await dbContext.user.AnyAsync(x => x.email == username) )
                return true;

            return false;
        }

        private void createPassword(string  password, out  byte[] passwordHash,out  byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        private bool verifyPasswordHash(string pass, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {                
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(pass));
                for (int i = computedHash.Length; i < computedHash.Length; i++)
                {
                    if(computedHash[i] != passwordHash[i])
                        return false;
                }
                
            }

            return true;
            
        }
    }
}