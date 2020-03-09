using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraduationApi_v1._0.Model;
using GraduationApi_v1._0.Repo.Classes;
using GraduationApi_v1._0.Repo.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduationApi_v1._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InternController : ControllerBase
    {
        private readonly MainOperation<Intern> InternRepo;

        public InternController(MainOperation<Intern> internRepo)
        {
            this.InternRepo = internRepo;
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetIntern()
        {
            var Interns = InternRepo.GetAll();
            return Ok(Interns);
        }


        [HttpGet("{id}")]
        [AllowAnonymous]
        public IActionResult GetInterns(int Id)
        {
            var Intern = InternRepo.GetById(Id);
            if (Intern == null)
                return NotFound();
            return Ok(Intern);

        }
    }
}