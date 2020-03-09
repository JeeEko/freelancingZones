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
    public class SponsorController : ControllerBase
    {
        private readonly MainOperation<Sponsor> SponsorRepository;
        private readonly SponsorService SponsorServises;
        public SponsorController(MainOperation<Sponsor> SponsorRepository, SponsorService SponsorServises)
        {
            this.SponsorRepository = SponsorRepository;
            this.SponsorServises = SponsorServises;

        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetSponsor()
        {
            var Sponsor = SponsorRepository.GetAll();
            return Ok(Sponsor);
        }
        
        [AllowAnonymous]
        [HttpPost("post")]
        public IActionResult PostZone([FromForm]SponsorVM Sponsorvm)
        {
            var sponsor = SponsorServises.SponsorAdded(Sponsorvm);
            if (sponsor == null)
                return NotFound();
            return Ok(sponsor);
        }
        [HttpDelete("{id}")]
        [AllowAnonymous]
        public IActionResult DeleteSponsor(int Id)
        {
            var Sponsor= SponsorRepository.GetById(Id);
            if (Sponsor == null)
                return NotFound();
            SponsorRepository.Delete(Id);
            SponsorRepository.Save();
            return Ok(Sponsor);

        }

    }
}