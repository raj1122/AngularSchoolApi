using System.Collections.Generic;
using Newtonsoft.Json;
using SchoolApi.Models;

namespace SchoolApi.Persistence
{
    public class Seed
    {
        private readonly SchoolAPiDbContext userContext;
        public Seed(SchoolAPiDbContext userContext)
        {
            this.userContext = userContext;
        }

        public void SeedUsers()
        {
            userContext.user.RemoveRange(userContext.user);
            userContext.SaveChanges();

            // seed users
            var userData = System.IO.File.ReadAllText("Persistence/UserSeedData.json");
            var users = JsonConvert.DeserializeObject<List<UserModel>>(userData);
            foreach (var userList in users)
            {
                // create the password hash
                byte[] passwordHash, passwordSalt;
                CreatePasswordHash("password", out passwordHash, out passwordSalt);

                userList.passwordHash = passwordHash;
                userList.passwordSalt = passwordSalt;
                userList.name = userList.name.ToLower();

                userContext.user.Add(userList);
            }


            userContext.SaveChanges();
        }

        public void SeedStudents()
        {
            userContext.detailDB.RemoveRange(userContext.detailDB);
            userContext.SaveChanges();

            // seed users
            var userData = System.IO.File.ReadAllText("Persistence/studentseedData.json");
            var students = JsonConvert.DeserializeObject<List<StudentModel>>(userData);
            foreach (var studentList in students)
            {
                userContext.detailDB.Add(studentList);

            }
            userContext.SaveChanges();

        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
        
    }
}