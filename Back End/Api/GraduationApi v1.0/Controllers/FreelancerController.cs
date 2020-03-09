using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraduationApi_v1._0.Model;
using GraduationApi_v1._0.Model.ViewModels;
using GraduationApi_v1._0.Repo.Classes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduationApi_v1._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FreelancerController : ControllerBase
    {
        
        private readonly FreeLancerRepository freeLancerRepository;
        private readonly UserRepository userRepository;


        public FreelancerController(FreeLancerRepository freeLancerRepository,UserRepository userRepository)
        {
            this.freeLancerRepository = freeLancerRepository;
            this.userRepository = userRepository;
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetFreelancer()
        {
            var zones = freeLancerRepository.GetAll();
            return Ok(zones);
        }


        [HttpGet("{id}")]
        [AllowAnonymous]
        public IActionResult GetFreelancer(int Id)
        {
            var zone = freeLancerRepository.GetById(Id);
            if (zone == null)
                return NotFound();
            return Ok(zone);
        }
        [HttpGet("getOpinion")]
        [AllowAnonymous]
        public IActionResult getFreelancersWithOpinions() {
            var freelancers = freeLancerRepository.GetForOpinion();
            List<FreeLancerViewModel> freelancersVm = new List<FreeLancerViewModel>();
            foreach (var freelancer in freelancers)
            {
                FreeLancerViewModel freeLancerViewModel = new FreeLancerViewModel();
                var user = userRepository.GetById(freelancer.User_Id);
                freeLancerViewModel.Id = freelancer.Id;
                freeLancerViewModel.JobTitle = freelancer.JobTitle;
                freeLancerViewModel.Name = freelancer.Name;
                freeLancerViewModel.Opinion = freelancer.Opinion;
                freeLancerViewModel.Image = user.ImageUrl;
                freelancersVm.Add(freeLancerViewModel);
            }
            
            return Ok(freelancersVm);
        }

        [HttpGet("getStories")]
        [AllowAnonymous]
        public IActionResult getFreeLancersWithStories() {
            var freelancers = freeLancerRepository.GetForStories();
            List<FreeLancerViewModel> freelancersVm = new List<FreeLancerViewModel>();
            foreach (var freelancer in freelancers)
            {
                FreeLancerViewModel freeLancerViewModel = new FreeLancerViewModel();
                var user = userRepository.GetById(freelancer.User_Id);
                freeLancerViewModel.Id = freelancer.Id;
                freeLancerViewModel.JobTitle = freelancer.JobTitle;
                freeLancerViewModel.Name = freelancer.Name;
                freeLancerViewModel.Brief = freelancer.Brief;
                freeLancerViewModel.Image = user.ImageUrl;
                freelancersVm.Add(freeLancerViewModel);
            }

            return Ok(freelancersVm);
        }
    }
}