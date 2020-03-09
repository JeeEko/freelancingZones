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
    public class ZoneManagerController : ControllerBase
    {
        private readonly MainOperation<ZoneManager> ZoneManagerRepository;

        public ZoneManagerController(MainOperation<ZoneManager> ZoneManagerRepository)
        {
            this.ZoneManagerRepository = ZoneManagerRepository;
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetFreelancer()
        {
            var zones = ZoneManagerRepository.GetAll();
            return Ok(zones);
        }


        [HttpGet("{id}")]
        [AllowAnonymous]
        public IActionResult GetFreelancer(int Id)
        {
            var zone = ZoneManagerRepository.GetById(Id);
            if (zone == null)
                return NotFound();
            return Ok(zone);

        }
    }
}