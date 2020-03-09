using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationApi_v1._0.Model
{
    public class Mentor
    {
        [Key]
        public int ID { get; set; }
        public double Salary { get; set; }
        [ForeignKey("User")]
        public int User_Id { get; set; }
        public User User { get; set; }

    }
}
