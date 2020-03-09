using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationApi_v1._0.Model
{
    public class Zone
    {
        //props
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string Place { get; set; }
        public int Available { get; set; }
        public int NumberOfRooms { get; set; }
        public string ImageUrl { get; set; }


    }
}
