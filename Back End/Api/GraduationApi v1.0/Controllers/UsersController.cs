using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraduationApi_v1._0.Model;
using GraduationApi_v1._0.Repo.Classes;
using GraduationApi_v1._0.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduationApi_v1._0.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {



        private readonly UserRepository userRepository;
        private readonly IUserService userService;

        public UsersController(UserRepository userRepository, IUserService userService)
        {
            this.userRepository = userRepository;
            this.userService = userService;
        }
        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]User userParam)
        {
            var user = userService.Authenticate(userParam.Email, userParam.Password);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(user);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = userRepository.GetAll();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = userRepository.GetById(id);

            if (user == null)
            {
                return NotFound();
            }

            // only allow admins to access other user records
            var currentUserId = int.Parse(User.Identity.Name);
            if (id != currentUserId && !User.IsInRole("Admin"))
            {
                return Forbid();
            }

            return Ok(user);
        }


    }
}