using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationApi_v1._0.Model.ViewModels
{
    public class SponsorVM
    {
        public int? ID { get; set; }
        public IFormFile ImageName { get; set; }

    }
}
