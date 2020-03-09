using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraduationApi_v1._0.Model;
using GraduationApi_v1._0.Repo.Classes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduationApi_v1._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MentorController : ControllerBase
    {
        private readonly MainOperation<Mentor> MentorRepository;

        public MentorController(MainOperation<Mentor> MentorRepository)
        {
            this.MentorRepository = MentorRepository;
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetMentors()
        {
            var zones = MentorRepository.GetAll();
            return Ok(zones);
        }


        [HttpGet("{id}")]
        [AllowAnonymous]
        public IActionResult GetMentor(int Id)
        {
            var zone = MentorRepository.GetById(Id);
            if (zone == null)
                return NotFound();
            return Ok(zone);

        }
    }
}