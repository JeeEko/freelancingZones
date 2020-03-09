using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraduationApi_v1._0.Model;
using GraduationApi_v1._0.Repo.Classes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduationApi_v1._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannerImagesController : ControllerBase
    {
        private readonly BannerImageRepository bannerImageRepository;

        public BannerImagesController(BannerImageRepository bannerImageRepository )
        {
            
            this.bannerImageRepository = bannerImageRepository;
        }
        [HttpGet]
        
        public IActionResult GetBannerImages()
        {
            List<string> imgs = new List<string>();
            List<BannerImages> list = bannerImageRepository.GetAll().ToList();
            for(int i = 0;i<list.Count;i++)
            { 
                imgs.Add(list[i].MyProperty);
                    
            }
            return Ok(imgs);

        }
    }
}