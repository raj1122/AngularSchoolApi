using System.Collections.Generic;
using System.Threading.Tasks;
using SchoolApi.Models;

namespace SchoolApi.Repository
{
    public interface IStudentRepsitory
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll();
         Task<IEnumerable<StudentModel>> GetStudents();
         Task<StudentModel> GetStudentByTeacher(int id);

         Task<StudentModel> GetStudentById(int id);
    }
}