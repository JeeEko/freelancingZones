using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationApi_v1._0.Model
{
    public class Sponsor
    {
        [Key]
        public int ID { get; set; }
        public string ImageName { get; set; }
    }
}
