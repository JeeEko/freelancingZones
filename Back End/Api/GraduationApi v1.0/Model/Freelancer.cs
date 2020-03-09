using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationApi_v1._0.Model
{
    public class Freelancer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfJob { get; set; }
        public double Rate { get; set; }
        public String JobTitle { get; set; }
        public String Brief { get; set; }
        public String Opinion { get; set; }
        [ForeignKey("User")]
        public int User_Id { get; set; }
        public User User { get; set; }

    }
}
