using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraduationApi_v1._0.Model.ViewModels;
using GraduationApi_v1._0.Repo.Classes;
using GraduationApi_v1._0.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduationApi_v1._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserRepository userRepository;
        private readonly IUserService userService;

        public AccountController(UserRepository userRepository, IUserService userService)
        {
            this.userRepository = userRepository;
            this.userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult login(LoginViewModel loginViewModel) {
            loginViewModel.Password = Encrypt.GenerateSha256Hash(loginViewModel.Password);
            var user = userService.Authenticate(loginViewModel.Email, loginViewModel.Password);
            if (user == null) {
                return BadRequest(new { message = "Username or password is incorrect " });
            }
            return Ok(user);
        }
        [AllowAnonymous]
        [HttpPost("register")]
        
        public IActionResult register([FromForm]RegisterViewModel register)
        {
            if (ModelState.IsValid)
            {
                var mailExists = userRepository.GetByMail(register.Email);
                if (mailExists != null) {
                    return BadRequest(new { message="This Mail is already registered"});
                }
                var user = userService.register(register);
                if (user == null)
                {
                    return BadRequest();
                }

                return Ok(user);
            }
            else return BadRequest(ModelState.Values);
        }
    }
}