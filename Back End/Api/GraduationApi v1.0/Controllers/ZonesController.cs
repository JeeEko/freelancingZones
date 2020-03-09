using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraduationApi_v1._0.Model;
using GraduationApi_v1._0.Model.ViewModels;
using GraduationApi_v1._0.Repo.Classes;
using GraduationApi_v1._0.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduationApi_v1._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZonesController : ControllerBase
    {
        private readonly MainOperation<Zone> zoneRepository;
        private readonly ZoneServise ZoneServises;

        public ZonesController(MainOperation<Zone> zoneRepository, ZoneServise ZoneServises)
        {
            this.zoneRepository = zoneRepository;
            this.ZoneServises = ZoneServises;
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetZones()
        {
            var zones = zoneRepository.GetAll();
            return Ok(zones);
        }


        [HttpGet("{id}")]
        [AllowAnonymous]
        public IActionResult GetZone(int Id)
        {
            var zone = zoneRepository.GetById(Id);
            if (zone == null)
                return NotFound();
            return Ok(zone);

        }
        [HttpDelete("{id}")]
        [AllowAnonymous]
        public IActionResult DeleteZone(int Id)
        {
            var Zone = zoneRepository.GetById(Id);
            if (Zone == null)
                return NotFound();
            zoneRepository.Delete(Id);
            zoneRepository.Save();
            return Ok(Zone);

        }
        [AllowAnonymous]
        [HttpPut("put")]
        public IActionResult PutZone([FromForm]ZoneVM zonevm)
        {
            var Zone = ZoneServises.ZoneEdited(zonevm);
            if (Zone == null)
                return NotFound();
            return Ok(Zone);

        }
        [AllowAnonymous]
        [HttpPost("post")]
        public IActionResult PostZone([FromForm]ZoneVM zonevm)
        {
            var Zone = ZoneServises.ZoneAdded(zonevm);
            if (Zone == null)
                return NotFound();
            return Ok(Zone);

        }


    }
}