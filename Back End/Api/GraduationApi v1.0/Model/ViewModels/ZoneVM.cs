using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationApi_v1._0.Model.ViewModels
{
    public class ZoneVM
    {
        public int? ID { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string Place { get; set; }
        public int Available { get; set; }
        public int NumberOfRooms { get; set; }
        public IFormFile ImageUrl { get; set; }
    }
}
