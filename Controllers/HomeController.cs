using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolApi.Controllers.Resources;
using SchoolApi.Dtos;
using SchoolApi.Models;
using SchoolApi.Persistence;
using SchoolApi.Repository;

namespace SchoolApi.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        private readonly SchoolAPiDbContext dbContext;
        private readonly IMapper mapper;
        private readonly IUserRepository userRepository;

        public HomeController(IUserRepository userRepository, SchoolAPiDbContext dbContext, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
            this.dbContext = dbContext;


        }

        [HttpGet("usersAllDetails")]
        public async Task<IActionResult> GetAllUsersDetails()
        {
            // var user = await dbContext.user.Include(m => m.phoneNumber).ToListAsync();
            var userDetailsListReturn = await userRepository.GetAllUserDetails();
            
            var userDetailsReturn = mapper.Map< IEnumerable<UserAllDetailDto>>(userDetailsListReturn);

            return Ok(userDetailsReturn);

        }



    }


}