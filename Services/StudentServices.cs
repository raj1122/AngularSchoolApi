using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolApi.Models;
using SchoolApi.Persistence;
using SchoolApi.Repository;

namespace SchoolApi.Services
{
    public class StudentServices : IStudentRepsitory
    {
        private readonly SchoolAPiDbContext dbContext;
        public StudentServices(SchoolAPiDbContext dbContext)
        {
            this.dbContext = dbContext;

        }
        public void Add<T>(T entity) where T : class
        {
            dbContext.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            dbContext.Remove(entity);
        }

        public async Task<StudentModel> GetStudentByTeacher(int id)
        {
            var student = await dbContext.detailDB.FirstOrDefaultAsync(u => u.Id == id);
            return student;
        }

        public async Task<IEnumerable<StudentModel>> GetStudents()
        {
            return await dbContext.detailDB.ToListAsync();
            
        }

        public async Task<StudentModel> GetStudentById(int id)
        {
            return await dbContext.detailDB.FindAsync(id);
            
        }

        public async Task<bool> SaveAll()
        {
            return await dbContext.SaveChangesAsync() >0 ;
        }
    }
}