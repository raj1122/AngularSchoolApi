using System.Net;
using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolApi.Controllers.Resources;
using SchoolApi.Models;
using SchoolApi.Persistence;
using SchoolApi.Repository;
using Microsoft.AspNetCore.Authorization;
using SchoolApi.Dtos;
using System.Collections.Generic;

namespace SchoolApi.Controllers
{
    // [Authorize]
    [Route("/api/[controller]")]
    public class StudentController : Controller
    {
        private readonly IMapper mapper;
        private readonly SchoolAPiDbContext dbContext;
        private readonly IStudentRepsitory studentRepsitory;
        public StudentController(IMapper mapper, SchoolAPiDbContext dbContext, IStudentRepsitory studentRepsitory)
        {
            this.studentRepsitory = studentRepsitory;
            this.dbContext = dbContext;

            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            var students = await studentRepsitory.GetStudents();


            var StudentToReturn = mapper.Map<IEnumerable<StudentForListDto>>(students);
            return Ok(StudentToReturn);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudentById(int id)
        {
            var students = await studentRepsitory.GetStudentById(id);

            var StudentToReturnDto = mapper.Map<StudentForListDto>(students);

            return Ok(StudentToReturnDto);

        }

        [HttpPost("create")]
        public async Task<IActionResult> createStudent([FromBody] DetailResource studentResource)
        {
            var student = mapper.Map<DetailResource, StudentModel>(studentResource);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var model = await dbContext.user.FindAsync(student.UserModelId);
            if (model == null)
            {
                ModelState.AddModelError("Error", "UserID is incorrect");
                return BadRequest(ModelState);
            }


            student.updatedBy = "rajat";
            student.updatedTime = DateTime.Now;

            dbContext.detailDB.Add(student);
            await dbContext.SaveChangesAsync();

            // var resultStudent = mapper.Map<StudentDetailsModel, DetailResource>(student);
            return Ok();

        }


        [HttpPut("/update{id}")]
        public async Task<IActionResult> updateStudent(int id, [FromBody] DetailResource studentResource)
        {


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var studentUpdate = await dbContext.detailDB.FindAsync(id);

            var studentResult = mapper.Map<DetailResource, StudentModel>(studentResource, studentUpdate);


            studentResult.updatedBy = "rajat";
            studentResult.updatedTime = DateTime.Now;


            await dbContext.SaveChangesAsync();

            var resultStudent = mapper.Map<StudentModel, DetailResource>(studentResult);
            return Ok(resultStudent);

        }

    }
}