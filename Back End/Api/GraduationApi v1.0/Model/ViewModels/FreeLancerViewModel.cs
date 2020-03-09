using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationApi_v1._0.Model.ViewModels
{
    public class FreeLancerViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }   
        public String JobTitle { get; set; }
        public String Brief { get; set; }
        public String Opinion { get; set; }
        public String Image { get; set; }
    }
}
