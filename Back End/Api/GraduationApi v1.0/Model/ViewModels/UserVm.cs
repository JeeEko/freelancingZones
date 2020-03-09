using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationApi_v1._0.Model.ViewModels
{
    public class UserVm
    {
        public int ID { get; set; }
        public String Email { get; set; }
        public String UserName { get; set; }
        public String PhoneNumber { get; set; }
        public String ImageUrl { get; set; }
        public String Token { get; set; }
        public String Role { get; set; }

        
    }
}
