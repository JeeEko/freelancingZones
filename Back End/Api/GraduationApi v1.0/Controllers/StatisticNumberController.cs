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
    //[Route("api/[controller]")]
    [ApiController]
    public class StatisticNumberController : ControllerBase
    {
        private readonly StatisticNumberRepo StatisticNumberRepository;
        public StatisticNumberController(StatisticNumberRepo StatisticNumberRepository)
        {
            this.StatisticNumberRepository = StatisticNumberRepository;
        }


        [HttpGet]
        [AllowAnonymous]
        [Route("api/GetStatisticNumber")]
        public IActionResult GetStatisticNumber()
        {
            var Numbers = StatisticNumberRepository.GetAllNumberArranged();
            return Ok(Numbers);
        }
        [HttpGet]
        [AllowAnonymous]
        [Route("api/GetStatisticDescription")]
        public IActionResult GetStatisticDescription()
        {
            var Description = StatisticNumberRepository.GetAllDescriptionArranged();
            return Ok(Description);
        }
        [HttpGet]
        [AllowAnonymous]
        [Route("api/Get")]
        public IActionResult GetStatistic()
        {
            var Description = StatisticNumberRepository.GetAll();
            return Ok(Description);
        }
        [HttpGet]
        [AllowAnonymous]
        [Route("api/Get/{id}")]
        public IActionResult GetStatistic(int id)
        {
            var Description = StatisticNumberRepository.GetById(id);
            return Ok(Description);
        }
        [HttpDelete]
        [AllowAnonymous]
        [Route("api/Delete/{id}")]
        public IActionResult DeleteStatistic(int id)
        {
            StatisticNumberRepository.Delete(id);
            StatisticNumberRepository.Save();
            return Ok();
        }
        [HttpPost]
        [AllowAnonymous]
        [Route("api/Post")]
        public IActionResult PostStatistic(StatisticNumber StatisticNumber)
        {
            StatisticNumberRepository.Insert(StatisticNumber);
            StatisticNumberRepository.Save();
            return Ok();
        }
        [HttpPut]
        [AllowAnonymous]
        [Route("api/Put")]
        public IActionResult PutStatistic(StatisticNumber StatisticNumber)
        {
            StatisticNumberRepository.Update(StatisticNumber);
            StatisticNumberRepository.Save();
            return Ok();
        }

        //[HttpGet("{id}")]
        //[AllowAnonymous]
        //public IActionResult GetStatisticNumber(int Id)
        //{
        //    var zone = StatisticNumberRepository.GetById(Id);
        //    if (zone == null)
        //        return NotFound();
        //    return Ok(zone);

        //}
    }
}