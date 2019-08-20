using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolApi.Controllers.Resources;
using SchoolApi.Models;
using SchoolApi.Persistence;

namespace SchoolApi.Controllers
{
    [Route("api/attendance")]
    public class AttendanceController : Controller
    {
        private readonly SchoolAPiDbContext dbContext;
        private readonly IMapper mapper;
        public AttendanceController(SchoolAPiDbContext dbContext, IMapper mapper)
        {
            this.mapper = mapper;
            this.dbContext = dbContext;


        }

        [HttpGet]
        public async Task<IEnumerable<AttendaceResource>> GetAttendance()
        {
            var resultAttendace = await dbContext.attendanceDB.ToListAsync();           

            return mapper.Map<List<StudentAttendanceModel>, List<AttendaceResource> >(resultAttendace);
        }

        
    }
}